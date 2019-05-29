Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT200_160b_CircularLoom

    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Private ID As String

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet

        'Unit Produksi
        Dim DaftarUnitProduksi As New DaftarUnitProduksi(ActiveSession)

        DS = DaftarUnitProduksi.Read("%")
        cboKodeUnit.ComboBox.DataSource = DS.Tables("View")
        cboKodeUnit.ComboBox.DisplayMember = "Unit Produksi"
        cboKodeUnit.ComboBox.ValueMember = "Kode"

        cboKodeUnit.ComboBox.SelectedIndex = cboKodeUnit.Items.Count - 1
    End Sub

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

        RPT.ShowGroupTreeButton = False

        FillCombo()

        cboKodeUnit.ComboBox.SelectedValue = GetSetting(enumFormID.frmCircularLoom, enumSetting.settingKodeUnit)
        cboKodeUnit.ComboBox.Enabled = False

        ID = ActiveSession.KodeUser & Now.ToString("ddMMyyyyHHmmss") & cboKodeUnit.ComboBox.SelectedValue

        cboLaporan.SelectedIndex = 0

    End Sub

    Private Sub AmbilDataWO()
        Dim SAP As New SAPWorkOrder()
        Dim DS As DataSet

        DS = SAP.ReadWOPlanQty(New DaftarUnitProduksi(ActiveSession).Find(cboKodeUnit.ComboBox.SelectedValue).KodeUnitSAP)

        Dim DaftarRptPlanWO As New DaftarRptPlanWO(ActiveSession)
        Dim RptPlanWO As New RptPlanWO

        DaftarRptPlanWO.Truncate()

        Dim Record As Integer = DS.Tables("View").Rows.Count
        ProgressBar.Visible = True
        ProgressBar.Value = 0
        ProgressBar.Maximum = Record

        For Each DR As DataRow In DS.Tables("View").Rows
            RptPlanWO.ID = ID
            RptPlanWO.NomorWO = DR("NomorWO")
            RptPlanWO.TglMulai = DR("TglMulai")
            RptPlanWO.TglSelesai = DR("TglSelesai")
            RptPlanWO.KodeItem = DR("KodeItem")
            RptPlanWO.NamaItem = DR("NamaItem")
            RptPlanWO.QtyPlan = DR("QtyPlan")
            RptPlanWO.Satuan = DR("Satuan")
            RptPlanWO.Unit = DR("Unit")
            RptPlanWO.StatusWO = DR("StatusWO")

            DaftarRptPlanWO.Add(RptPlanWO)

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

        'Ambil Data Work Order Dari SAP
        AmbilDataWO()

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
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt200161b_PenyelesaianWO_Loom.RPT")
            Case 2
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rpt200162b_PenyelesaianWO_Loom.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("TglAwal").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("TglAkhir").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("IDData").CurrentValues.AddValue(ID)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        If txtTglAwal.Value.ToString("dd/MM/yy") = txtTglAkhir.Value.ToString("dd/MM/yy") Then
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL : " + txtTglAkhir.Value.ToString("dd-MM-yyyy") + "'"
        Else
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PERIODE : " + txtTglAwal.Value.ToString("dd-MM-yy") + " S/D " + txtTglAkhir.Value.ToString("dd-MM-yy") + "'"
        End If
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + UCase(ActiveSession.KodeUser) + "'"

        RPT.ReportSource = RPTObject
        HideTabControl(RPT)

        RPT.Refresh()

        Dim DaftarRptPlanWO As New DaftarRptPlanWO(ActiveSession)

        'Hapus Temporary
        'DaftarRptPlanWO.Delete(ID)

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
