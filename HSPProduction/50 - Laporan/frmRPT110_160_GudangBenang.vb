Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT110_160_GudangBenang
    Private _DBConnection As New DBConnection

    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker
    Private ID As String

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        txtTglAwal.Format = DateTimePickerFormat.Custom
        txtTglAwal.CustomFormat = "dd/MM/yyyy"
        txtTglAwal.Width = 95

        Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        txtTglAkhir.Format = DateTimePickerFormat.Custom
        txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        txtTglAkhir.Width = 95

        FillCombo()

        cboKodeItem.ComboBox.SelectedIndex = -1
        cboKodeStatus.ComboBox.SelectedIndex = -1
        cboLaporan.ComboBox.SelectedIndex = 0

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Grup Produksi
        Dim DaftarItemBenang As New DaftarItemBenang(ActiveSession)

        DS = DaftarItemBenang.ReadItem("%")
        cboKodeItem.ComboBox.DataSource = DS.Tables("View")
        cboKodeItem.ComboBox.DisplayMember = "Nama Item"
        cboKodeItem.ComboBox.ValueMember = "Kode"
    End Sub

    Private Function GenerateReportMesin() As Boolean
        Dim SAKG1 As Double = 0
        Dim SABB1 As Double = 0
        Dim SAKG2 As Double = 0
        Dim SABB2 As Double = 0
        Dim SAKGLL As Double = 0
        Dim SABBLL As Double = 0

        Dim DaftarMutasiBenang As New DaftarMutasiBenang(ActiveSession)
        Dim TempMutasiBenang As New TempMutasiBenang()

        GenerateReportMesin = True

        'Saldo Awal
        Using DBX As IDbConnection = _DBConnection.Connection

            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("sp_SaldoAwalBenangMesin", DBX)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("Tanggal", txtTglAwal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("Item", cboKodeItem.ComboBox.SelectedValue)
            CMD.Parameters.AddWithValue("KodeStatus", cboKodeStatus.ComboBox.SelectedIndex + 1)

            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader

            Do While DR.Read()
                If DR("KodeMesin") = "1001" Then
                    SAKG1 = DR("SAKG1")
                    SABB1 = DR("SABB1")
                ElseIf DR("KodeMesin") = "1002" Then
                    SAKG2 = DR("SAKG2")
                    SABB2 = DR("SABB2")
                ElseIf DR("KodeMesin") = "LAIN-LAIN" Then
                    SAKGLL = DR("SAKGL")
                    SABBLL = DR("SABBL")
                End If
            Loop

            DR.Close()
        End Using

        'Mutasi
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("sp_MutasiBenangMesin", DBX)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("TglAwal", txtTglAwal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("TglAkhir", txtTglAkhir.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("Item", cboKodeItem.ComboBox.SelectedValue)
            CMD.Parameters.AddWithValue("KodeStatus", cboKodeStatus.ComboBox.SelectedIndex + 1)

            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader

            Do While DR.Read()
                TempMutasiBenang.ID = ID
                TempMutasiBenang.Tanggal = DR("Tanggal")
                TempMutasiBenang.KodeShift = DR("KodeShift")
                TempMutasiBenang.KodeGrup = DR("KodeGrup")
                TempMutasiBenang.KodeMesin = DR("KodeMesin")
                TempMutasiBenang.KodeItem = cboKodeItem.ComboBox.SelectedValue
                TempMutasiBenang.NamaItem = cboKodeItem.Text
                TempMutasiBenang.KodeStatusQC = cboKodeStatus.ComboBox.SelectedIndex + 1
                TempMutasiBenang.NamaStatusQC = If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 1, "OK", _
                                                If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 2, "NON OK", _
                                                If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 3, "OVER", _
                                                If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 4, "UNDER", ""))))

                If (DR("KodeMesin") = "1001") Then
                    TempMutasiBenang.SaldoAwalKG = SAKG1
                    TempMutasiBenang.SaldoAwalBB = SABB1
                ElseIf (DR("KodeMesin") = "1002") Then
                    TempMutasiBenang.SaldoAwalKG = SAKG2
                    TempMutasiBenang.SaldoAwalBB = SABB2
                ElseIf (DR("KodeMesin") = "LAIN-LAIN") Then
                    TempMutasiBenang.SaldoAwalKG = SAKGLL
                    TempMutasiBenang.SaldoAwalBB = SABBLL
                End If

                TempMutasiBenang.HasilKG = DR("HASIL_KG")
                TempMutasiBenang.HasilBB = DR("HASIL_BB")
                TempMutasiBenang.ReturKG = DR("RETUR_KG")
                TempMutasiBenang.ReturBB = DR("RETUR_BB")
                TempMutasiBenang.SaldoKG = TempMutasiBenang.SaldoAwalKG + TempMutasiBenang.HasilKG + TempMutasiBenang.ReturKG
                TempMutasiBenang.SaldoBB = TempMutasiBenang.SaldoAwalBB + TempMutasiBenang.HasilBB + TempMutasiBenang.ReturBB
                TempMutasiBenang.KeluarCLKG = DR("KELUAR_CL_KG")
                TempMutasiBenang.KeluarCLBB = DR("KELUAR_CL_BB")
                TempMutasiBenang.KeluarLLKG = DR("KELUAR_LL_KG")
                TempMutasiBenang.KeluarLLBB = DR("KELUAR_LL_BB")
                TempMutasiBenang.TotalKeluarKG = TempMutasiBenang.KeluarCLKG + TempMutasiBenang.KeluarLLKG
                TempMutasiBenang.TotalKeluarBB = TempMutasiBenang.KeluarCLBB + TempMutasiBenang.KeluarLLBB
                TempMutasiBenang.SaldoAkhirKG = TempMutasiBenang.SaldoKG - TempMutasiBenang.TotalKeluarKG
                TempMutasiBenang.SaldoAkhirBB = TempMutasiBenang.SaldoBB - TempMutasiBenang.TotalKeluarBB

                If (DR("KodeMesin") = "1001") Then
                    SAKG1 = TempMutasiBenang.SaldoAkhirKG
                    SABB1 = TempMutasiBenang.SaldoAkhirBB
                ElseIf (DR("KodeMesin") = "1002") Then
                    SAKG2 = TempMutasiBenang.SaldoAkhirKG
                    SABB2 = TempMutasiBenang.SaldoAkhirBB
                ElseIf (DR("KodeMesin") = "LAIN-LAIN") Then
                    SAKGLL = TempMutasiBenang.SaldoAkhirKG
                    SABBLL = TempMutasiBenang.SaldoAkhirBB
                End If

                DaftarMutasiBenang.Add(TempMutasiBenang)
            Loop
        End Using
    End Function

    Private Function GenerateReportItem() As Boolean
        Dim SAKG As Double = 0
        Dim SABB As Double = 0

        Dim DaftarMutasiBenang As New DaftarMutasiBenang(ActiveSession)
        Dim TempMutasiBenang As New TempMutasiBenang()

        GenerateReportItem = True

        'Saldo Awal
        Using DBX As IDbConnection = _DBConnection.Connection

            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("sp_SaldoAwalBenangItem", DBX)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("Tanggal", txtTglAwal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("Item", cboKodeItem.ComboBox.SelectedValue)
            CMD.Parameters.AddWithValue("KodeStatus", cboKodeStatus.ComboBox.SelectedIndex + 1)

            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader
            DR.Read()

            SAKG = DR("SAKG")
            SABB = DR("SABB")

            DR.Close()
        End Using

        'Mutasi
        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("sp_MutasiBenangItem", DBX)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("TglAwal", txtTglAwal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("TglAkhir", txtTglAkhir.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("Item", cboKodeItem.ComboBox.SelectedValue)
            CMD.Parameters.AddWithValue("KodeStatus", cboKodeStatus.ComboBox.SelectedIndex + 1)

            Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader

            Do While DR.Read()
                TempMutasiBenang.ID = ID
                TempMutasiBenang.Tanggal = DR("Tanggal")
                TempMutasiBenang.KodeShift = ""
                TempMutasiBenang.KodeGrup = ""
                TempMutasiBenang.KodeMesin = ""
                TempMutasiBenang.KodeItem = cboKodeItem.ComboBox.SelectedValue
                TempMutasiBenang.NamaItem = cboKodeItem.Text
                TempMutasiBenang.KodeStatusQC = cboKodeStatus.ComboBox.SelectedIndex + 1
                TempMutasiBenang.NamaStatusQC = If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 1, "OK", _
                                                If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 2, "NON OK", _
                                                If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 3, "OVER", _
                                                If(cboKodeStatus.ComboBox.SelectedIndex + 1 = 4, "UNDER", ""))))

                TempMutasiBenang.SaldoAwalKG = SAKG
                TempMutasiBenang.SaldoAwalBB = SABB

                TempMutasiBenang.HasilKG = DR("HASIL_KG")
                TempMutasiBenang.HasilBB = DR("HASIL_BB")
                TempMutasiBenang.ReturKG = DR("RETUR_KG")
                TempMutasiBenang.ReturBB = DR("RETUR_BB")
                TempMutasiBenang.SaldoKG = TempMutasiBenang.SaldoAwalKG + TempMutasiBenang.HasilKG + TempMutasiBenang.ReturKG
                TempMutasiBenang.SaldoBB = TempMutasiBenang.SaldoAwalBB + TempMutasiBenang.HasilBB + TempMutasiBenang.ReturBB
                TempMutasiBenang.KeluarCLKG = DR("KELUAR_CL_KG")
                TempMutasiBenang.KeluarCLBB = DR("KELUAR_CL_BB")
                TempMutasiBenang.KeluarLLKG = DR("KELUAR_LL_KG")
                TempMutasiBenang.KeluarLLBB = DR("KELUAR_LL_BB")
                TempMutasiBenang.TotalKeluarKG = TempMutasiBenang.KeluarCLKG + TempMutasiBenang.KeluarLLKG
                TempMutasiBenang.TotalKeluarBB = TempMutasiBenang.KeluarCLBB + TempMutasiBenang.KeluarLLBB
                TempMutasiBenang.SaldoAkhirKG = TempMutasiBenang.SaldoKG - TempMutasiBenang.TotalKeluarKG
                TempMutasiBenang.SaldoAkhirBB = TempMutasiBenang.SaldoBB - TempMutasiBenang.TotalKeluarBB

                SAKG = TempMutasiBenang.SaldoAkhirKG
                SABB = TempMutasiBenang.SaldoAkhirBB

                DaftarMutasiBenang.Add(TempMutasiBenang)
            Loop
        End Using
    End Function

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
        ID = Now.ToString("yyyyMMddHHmmss") & ActiveSession.KodeUser

        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                If Not GenerateReportMesin() Then
                    GoTo Jump
                End If
            Case 2
                If Not GenerateReportItem() Then
                    GoTo Jump
                End If
        End Select

        Dim Server As New ConnectionInfo
        Dim DataTable As Table

        Me.Cursor = Cursors.WaitCursor
        '-----------------------------------------------------------------------------------------   

        '-----------------------------------------------------------------------------------------   
        Dim DBX As Object = New DBConnection(ActiveSession).ConnectionSetting()

        'Setting Koneksi Database
        With Server
            .ServerName = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=" + DBX.Server + "; PORT = " + DBX.Port.ToString + "; "
            .DatabaseName = DBX.Database
            .UserID = DBX.UserID
            .Password = DBX.Password
        End With
        '-----------------------------------------------------------------------------------------

        Dim RPTObject As New ReportDocument

        'Report
        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt110161_GudangBenang.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt110162_GudangBenang.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("ID").CurrentValues.AddValue(ID)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        If txtTglAwal.Value.ToString("dd/MM/yy") = txtTglAkhir.Value.ToString("dd/MM/yy") Then
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL : " + txtTglAkhir.Value.ToString("dd-MM-yyyy") + "'"
        Else
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PERIODE : " + txtTglAwal.Value.ToString("dd-MM-yy") + " S/D " + txtTglAkhir.Value.ToString("dd-MM-yy") + "'"
        End If

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

Jump:
        Me.Cursor = Cursors.Default

        Dim DaftarMutasiBenang As New DaftarMutasiBenang(ActiveSession)
        DaftarMutasiBenang.Delete(ID)

    End Sub

    Private Sub HideTabControl(ByVal RPT As Object)
        For Each control As Control In RPT.Controls
            If TypeOf control Is CrystalDecisions.Windows.Forms.PageView Then
                Dim tab As TabControl = DirectCast(DirectCast(control, CrystalDecisions.Windows.Forms.PageView).Controls(0), TabControl)
                tab.ItemSize = New Size(0, 1)
                tab.SizeMode = TabSizeMode.Fixed
                tab.Appearance = TabAppearance.Buttons
            End If
        Next
    End Sub

End Class
