Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT210_130_GudangRoll

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        FillCombo()

        cboLaporan.SelectedIndex = 0

    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet
        Dim Drow As DataRow

        'Shift Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)

        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnitPeruntukan.ComboBox.DataSource = DS.Tables("View")
        cboKodeUnitPeruntukan.ComboBox.DisplayMember = "Unit Produksi"
        cboKodeUnitPeruntukan.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Unit Produksi") = "-"

        cboKodeUnitPeruntukan.SelectedIndex = cboKodeUnitPeruntukan.Items.Count - 1

        Dim DaftarLokasi As New DaftarLokasi(ActiveSession)

        DS = DaftarLokasi.Read("%")
        cboKodeLokasi.ComboBox.DataSource = DS.Tables("View")
        cboKodeLokasi.ComboBox.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Lokasi") = "-"

        cboKodeLokasi.SelectedIndex = cboKodeLokasi.Items.Count - 1

        Dim DaftarKelompokProduksi As New DaftarKelompokProduksi(ActiveSession)

        DS = DaftarKelompokProduksi.Read("%", 30)
        cboKodeKelompok.ComboBox.DataSource = DS.Tables("View")
        cboKodeKelompok.ComboBox.DisplayMember = "Nama Kelompok"
        cboKodeKelompok.ComboBox.ValueMember = "Kode"

        Drow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Nama Kelompok") = "-"

        cboKodeKelompok.SelectedIndex = cboKodeKelompok.Items.Count - 1
    End Sub

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
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
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210131_GudangRoll.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210132_GudangRoll.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("UnitPeruntukan").CurrentValues.AddValue(cboKodeUnitPeruntukan.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodeLokasi").CurrentValues.AddValue(cboKodeLokasi.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodeKelompok").CurrentValues.AddValue(cboKodeKelompok.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PER " + Now.ToString("dd-MM-yyyy hh:mm:ss") + "'"
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + UCase(ActiveSession.KodeUser) + "'"

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

        Me.Cursor = Cursors.Default

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
