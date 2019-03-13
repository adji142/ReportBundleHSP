Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPTSAP_300_Piutang
    Private Class Transaksi
        Property Kode As String
        Property Transaksi As String
    End Class

    Private Sub FillCombo()
        Dim _Transaksi As New List(Of Transaksi)

        _Transaksi.Add(New Transaksi With {.Kode = "", .Transaksi = "<SEMUA TRANSAKSI>"})
        _Transaksi.Add(New Transaksi With {.Kode = "100", .Transaksi = "PENJUALAN LOKAL"})
        _Transaksi.Add(New Transaksi With {.Kode = "102", .Transaksi = "PENJUALAN EKSPOR"})

        cboTransaksi.ComboBox.DataSource = _Transaksi
        cboTransaksi.ComboBox.DisplayMember = "Transaksi"
        cboTransaksi.ComboBox.ValueMember = "Kode"

        cboTransaksi.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub FillComboCustomer()
        Dim DaftarCustomer As New SAPDaftarCustomer()
        Dim DS As New DataSet

        DS = DaftarCustomer.Read("%", cboTransaksi.ComboBox.SelectedValue)
        cboCustomer.ComboBox.DataSource = DS.Tables("View")
        cboCustomer.ComboBox.DisplayMember = "Customer"
        cboCustomer.ComboBox.ValueMember = "Kode"

        Dim DRow As DataRow = DS.Tables("View").Rows.Add
        DRow("Kode") = ""
        DRow("Customer") = "<SELURUH CUSTOMER>"

        cboCustomer.ComboBox.SelectedIndex = cboCustomer.ComboBox.Items.Count - 1
    End Sub

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        FillCombo()
        FillComboCustomer()

        cboLaporan.SelectedIndex = 0

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
        Select Case cboLaporan.SelectedIndex + 1
            Case 1
                RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\LapPiutangUsaha.RPT")
        End Select

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("Transaksi").CurrentValues.AddValue(cboTransaksi.ComboBox.SelectedIndex)
        RPTObject.ParameterFields("MataUang").CurrentValues.AddValue("ALL")
        RPTObject.ParameterFields("KodeCustomer").CurrentValues.AddValue(cboCustomer.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PER :  " + Now.ToString("dd-MM-yyyy HH:mm:ss") + "'"
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

    Private Sub Data_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                                                                        cboTransaksi.SelectedIndexChanged

        Try
            FillComboCustomer()
        Catch
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim DaftarSAPCustomer As IDataLookup = New SAPDaftarCustomer()
        Dim Parameter() As String = {cboTransaksi.ComboBox.SelectedValue}

        Dim Form As New frmLookup(DaftarSAPCustomer, Parameter)
        Form.Text = "Lookup Daftar Customer"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboCustomer.ComboBox.SelectedValue = Form.IDLookup
            cboCustomer.Focus()
        End If
    End Sub
End Class
