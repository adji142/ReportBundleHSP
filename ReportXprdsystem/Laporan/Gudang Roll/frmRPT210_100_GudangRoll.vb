Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports ReportXprdsystem.HSP.Data

Public Class frmRPT210_100_GudangRoll

    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        txtTglAwal.Format = DateTimePickerFormat.Custom
        txtTglAwal.CustomFormat = "dd/MM/yyyy"
        txtTglAwal.Width = 95
        txtTglAwal.Value = DateSerial(Year(Now), Month(Now), 1)

        Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        txtTglAkhir.Format = DateTimePickerFormat.Custom
        txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        txtTglAkhir.Width = 95
        txtTglAkhir.Value = Now.Date

        cboLaporan.SelectedIndex = 0

    End Sub

    Private Sub AmbilData()
        Dim SAP As New SAPInventory()
        Dim DS As DataSet

        DS = SAP.ReadItemRoll("CLOOM")

        Dim DaftarTSO As New DaftarTmpItemRoll(ActiveSession)
        Dim TSO As New TmpItemRoll

        DaftarTSO.DeleteAll()

        Dim Record As Integer = DS.Tables("View").Rows.Count
        ProgressBar.Visible = True
        ProgressBar.Value = 0
        ProgressBar.Maximum = Record

        For Each DR As DataRow In DS.Tables("View").Rows

            TSO.KodeItem = DR("KodeItem")
            TSO.NamaItem = DR("NamaItem")
            TSO.BeratStandart = DR("BeratStandart")

            DaftarTSO.Add(TSO)

            ProgressBar.Value += 1
        Next

        If ProgressBar.Value = Record Then
            ProgressBar.Visible = False
        End If
    End Sub

    'Tampilkan Laporan
    Private Sub btRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRefresh.Click
        Dim Server As New ConnectionInfo
        Dim DataTable As Table

        Me.Cursor = Cursors.WaitCursor
        '-----------------------------------------------------------------------------------------   
        Select Case cboLaporan.SelectedIndex + 1
            Case 6
                AmbilData()
        End Select
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
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210101_GudangRoll.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210102_GudangRoll.RPT")
            Case 3
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210103_GudangRoll.RPT")
            Case 4
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210104_GudangRoll.RPT")
            Case 5
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210105_GudangRoll.RPT")
            Case 6
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\RPT210106_GudangRoll.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("KodeUnit").CurrentValues.AddValue(GetSetting(enumFormID.frmGudang, enumSetting.settingKodeUnit))
        RPTObject.ParameterFields("KodeLokasi").CurrentValues.AddValue(GetSetting(enumFormID.frmGudang, enumSetting.settingKodeLokasi))

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        If txtTglAwal.Value.ToString("dd/MM/yy") = txtTglAkhir.Value.ToString("dd/MM/yy") Then
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + txtTglAkhir.Value.ToString("dd-MM-yyyy") + "'"
        Else
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'" + txtTglAwal.Value.ToString("dd-MM-yy") + " S/D " + txtTglAkhir.Value.ToString("dd-MM-yy") + "'"
        End If
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
