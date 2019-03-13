Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPTSAP_800_MonitoringOrderPenjualan
    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Private Class Status
        Property Kode As String
        Property Status As String
    End Class

    Private Sub FillCombo()
        Dim _Status As New List(Of Status)

        _Status.Add(New Status With {.Kode = "ALL", .Status = "<SEMUA STATUS>"})
        _Status.Add(New Status With {.Kode = "O", .Status = "OPEN"})
        _Status.Add(New Status With {.Kode = "C", .Status = "CLOSE"})

        cboStatus.ComboBox.DataSource = _Status
        cboStatus.ComboBox.DisplayMember = "Status"
        cboStatus.ComboBox.ValueMember = "Kode"

        cboStatus.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub FillComboCustomer()
        Dim DaftarCustomerSO As New SAPDaftarCustomerSO()
        Dim DS As New DataSet

        DS = DaftarCustomerSO.Read("%")
        cboCustomer.ComboBox.DataSource = DS.Tables("View")
        cboCustomer.ComboBox.DisplayMember = "Customer"
        cboCustomer.ComboBox.ValueMember = "Kode"

        Dim DRow As DataRow = DS.Tables("View").Rows.Add
        DRow("Kode") = "ALL"
        DRow("Customer") = "<SELURUH CUSTOMER>"

        cboCustomer.ComboBox.SelectedIndex = cboCustomer.ComboBox.Items.Count - 1
    End Sub

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        Toolbar.Items.Insert(1, New ToolStripControlHost(txtTglAwal))
        txtTglAwal.Format = DateTimePickerFormat.Custom
        txtTglAwal.CustomFormat = "dd/MM/yyyy"
        txtTglAwal.Width = 95
        txtTglAwal.Value = Now.Date

        Toolbar.Items.Insert(3, New ToolStripControlHost(txtTglAkhir))
        txtTglAkhir.Format = DateTimePickerFormat.Custom
        txtTglAkhir.CustomFormat = "dd/MM/yyyy"
        txtTglAkhir.Width = 95
        txtTglAkhir.Value = Now.Date

        FillCombo()
        FillComboCustomer()

        txtNomor.Text = ""

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
            .ServerName = "192.168.1.222:30015"
            .DatabaseName = "HARDO_LIVE"
            .UserID = "SYSTEM"
            .Password = "sys825050SYS"
        End With
        '-----------------------------------------------------------------------------------------

        Dim RPTObject As New ReportDocument

        'Report
        RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rptMonitoringOrderPenjualan.rpt")

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("TGLAWAL").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("TGLAKHIR").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("STATUS").CurrentValues.AddValue(cboStatus.ComboBox.SelectedValue)
        RPTObject.ParameterFields("NOORDER").CurrentValues.AddValue(txtNomor.TextBox.Text)
        RPTObject.ParameterFields("KodeCustomer").CurrentValues.AddValue(cboCustomer.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        'RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        'RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PER :  " + Now.ToString("dd-MM-yyyy HH:mm:ss") + "'"
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

    'Private Sub Data_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    '                                                                                    cboStatus.SelectedIndexChanged
    '    Try
    '        FillComboCustomer()
    '    Catch
    '    End Try
    'End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim DaftarSAPCustomerSO As IDataLookup = New SAPDaftarCustomerSO()

        Dim Form As New frmLookup(DaftarSAPCustomerSO)
        Form.Text = "Lookup Daftar Customer"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboCustomer.ComboBox.SelectedValue = Form.IDLookup
            cboCustomer.Focus()
        End If
    End Sub
End Class
