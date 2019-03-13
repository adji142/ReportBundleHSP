Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPTSAP_LaporanKartuStock
    Private WithEvents txtTglAwal As New DateTimePicker
    Private WithEvents txtTglAkhir As New DateTimePicker

    Private Sub FillCombo()
        Dim DaftarSAPKelompokItem As New DaftarSAPKelompokItem()
        Dim DS As New DataSet

        DS = DaftarSAPKelompokItem.Read("%")
        cboKelompok.ComboBox.DataSource = DS.Tables("View")
        cboKelompok.ComboBox.DisplayMember = "Kelompok"
        cboKelompok.ComboBox.ValueMember = "Kode"

        Dim DRow As DataRow = DS.Tables("View").Rows.Add
        DRow("Kode") = ""
        DRow("Kelompok") = "ALL"

        cboKelompok.ComboBox.SelectedIndex = cboKelompok.Items.Count - 1

    End Sub
    Private Sub FillComboItem()
        Dim DS As DataSet

        'Item
        '----------------------------------------------------------------------------
        Dim DaftarSAPItemBarang As New DaftarSAPItemBarang()
        DS = New DataSet
        DS = DaftarSAPItemBarang.Read(cboKelompok.ComboBox.SelectedValue)
        cboItem1.ComboBox.DataSource = DS.Tables("View")
        cboItem1.ComboBox.DisplayMember = "Nama Item"
        cboItem1.ComboBox.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarSAPItemBarang.Read(cboKelompok.ComboBox.SelectedValue)
        cboItem2.ComboBox.DataSource = DS.Tables("View")
        cboItem2.ComboBox.DisplayMember = "Nama Item"
        cboItem2.ComboBox.ValueMember = "Kode"

        cboItem1.SelectedIndex = -1
        cboItem2.SelectedIndex = -1
    End Sub

    Private Sub FillComboLokasi()
        Dim SAPLokasi As New SAPLokasi()
        Dim DS As New DataSet

        DS = SAPLokasi.Read("%")
        cboLokasi.ComboBox.DataSource = DS.Tables("View")
        cboLokasi.ComboBox.DisplayMember = "Lokasi"
        cboLokasi.ComboBox.ValueMember = "Kode"

        Dim DRow As DataRow = DS.Tables("View").Rows.Add
        DRow("Kode") = "ALL"
        DRow("Lokasi") = "ALL"

        cboLokasi.ComboBox.SelectedIndex = cboLokasi.ComboBox.Items.Count - 1
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
        FillComboItem()
        FillComboLokasi()

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
        RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\LapKartuStock.rpt")

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("DATEFROM").CurrentValues.AddValue(txtTglAwal.Value.Date)
        RPTObject.ParameterFields("DATETO").CurrentValues.AddValue(txtTglAkhir.Value.Date)
        RPTObject.ParameterFields("GROUPBARANG").CurrentValues.AddValue(cboKelompok.ComboBox.Text)
        RPTObject.ParameterFields("KODEITEM1").CurrentValues.AddValue(cboItem1.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KODEITEM2").CurrentValues.AddValue(cboItem2.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KODELOKASI").CurrentValues.AddValue(cboLokasi.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        If txtTglAwal.Value.ToString("dd/MM/yy") = txtTglAkhir.Value.ToString("dd/MM/yy") Then
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + txtTglAkhir.Value.ToString("dd-MM-yyyy") + "'"
        Else
            RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PERIODE :  " + txtTglAwal.Value.ToString("dd-MM-yy") + " S/D " + txtTglAkhir.Value.ToString("dd-MM-yy") + "'"
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

    Private Sub btnKelompok_Click(sender As Object, e As EventArgs) Handles btnKelompok.Click
        Dim DaftarSAPKelompokItem As IDataLookup = New DaftarSAPKelompokItem()

        Dim Form As New frmLookup(DaftarSAPKelompokItem)
        Form.Text = "Lookup Daftar Kelompok Item"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKelompok.ComboBox.SelectedValue = Form.IDLookup
            cboKelompok.Focus()
        End If
    End Sub

    Private Sub btnLokasi_Click(sender As Object, e As EventArgs) Handles btnLokasi.Click
        Dim SAPLokasi As IDataLookup = New SAPLokasi()

        Dim Form As New frmLookup(SAPLokasi)
        Form.Text = "Lookup Daftar Lokasi"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboLokasi.ComboBox.SelectedValue = Form.IDLookup
            cboLokasi.Focus()
        End If
    End Sub

    Private Sub btnItem1_Click(sender As Object, e As EventArgs) Handles btnItem1.Click
        Dim DaftarSAPItemBarang As IDataLookup = New DaftarSAPItemBarang()
        Dim Parameter() As String = {cboKelompok.ComboBox.SelectedValue}

        Dim Form As New frmLookup(DaftarSAPItemBarang, Parameter)
        Form.Text = "Lookup Daftar Item Barang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboItem1.ComboBox.SelectedValue = Form.IDLookup
            cboItem1.Focus()
        End If
    End Sub

    Private Sub btnItem2_Click(sender As Object, e As EventArgs) Handles btnItem2.Click
        Dim DaftarSAPItemBarang As IDataLookup = New DaftarSAPItemBarang()
        Dim Parameter() As String = {cboKelompok.ComboBox.SelectedValue}

        Dim Form As New frmLookup(DaftarSAPItemBarang, Parameter)
        Form.Text = "Lookup Daftar Item Barang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboItem2.ComboBox.SelectedValue = Form.IDLookup
            cboItem2.Focus()
        End If
    End Sub

    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            cboKelompok.SelectedIndexChanged

        Try
            FillComboItem()
        Catch
        End Try
    End Sub

End Class
