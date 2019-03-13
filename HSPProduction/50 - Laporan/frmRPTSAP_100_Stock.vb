Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPTSAP_100_Stock

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        FillCombo()
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        Dim DS As DataSet

        'Lokasi Produksi
        '----------------------------------------------------------------------------
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%")
        cboKodeLokasi.ComboBox.DataSource = DS.Tables("View")
        cboKodeLokasi.ComboBox.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ComboBox.ValueMember = "Kode"

        'Kelompok Item
        '----------------------------------------------------------------------------
        Dim DaftarSAPKelompokItem As New DaftarSAPKelompokItem()
        DS = New DataSet
        DS = DaftarSAPKelompokItem.Read("%")
        cboKodeKelompok.ComboBox.DataSource = DS.Tables("View")
        cboKodeKelompok.ComboBox.DisplayMember = "Kelompok"
        cboKodeKelompok.ComboBox.ValueMember = "Kode"

        Dim Drow As DataRow = DS.Tables("View").Rows.Add
        Drow("Kode") = ""
        Drow("Kelompok") = "-"

        cboKodeKelompok.ComboBox.SelectedIndex = cboKodeKelompok.Items.Count - 1
    End Sub

    Private Sub FillComboItem()
        Dim DS As DataSet

        'Item
        '----------------------------------------------------------------------------
        Dim DaftarSAPItemBarang As New DaftarSAPItemBarang()
        DS = New DataSet
        DS = DaftarSAPItemBarang.Read(cboKodeKelompok.ComboBox.SelectedValue)
        cboItemAwal.ComboBox.DataSource = DS.Tables("View")
        cboItemAwal.ComboBox.DisplayMember = "Nama Item"
        cboItemAwal.ComboBox.ValueMember = "Kode"

        DS = New DataSet
        DS = DaftarSAPItemBarang.Read(cboKodeKelompok.ComboBox.SelectedValue)
        cboItemAkhir.ComboBox.DataSource = DS.Tables("View")
        cboItemAkhir.ComboBox.DisplayMember = "Nama Item"
        cboItemAkhir.ComboBox.ValueMember = "Kode"

        cboItemAwal.SelectedIndex = -1
        cboItemAkhir.SelectedIndex = -1
    End Sub

    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                            cboKodeKelompok.SelectedIndexChanged

        Try
            FillComboItem()
        Catch
        End Try
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
        RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\LapSaldoStock.RPT")

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("Tanggal").CurrentValues.AddValue(Now.Date)
        RPTObject.ParameterFields("Lokasi").CurrentValues.AddValue(cboKodeLokasi.ComboBox.SelectedValue)
        If cboKodeKelompok.ComboBox.SelectedIndex = cboKodeKelompok.ComboBox.Items.Count - 1 Then
            RPTObject.ParameterFields("KodeKelompok").CurrentValues.AddValue(0)
        Else
            RPTObject.ParameterFields("KodeKelompok").CurrentValues.AddValue(cboKodeKelompok.ComboBox.SelectedValue)
        End If
        RPTObject.ParameterFields("KodeItemAwal").CurrentValues.AddValue(cboItemAwal.ComboBox.SelectedValue)
        RPTObject.ParameterFields("KodeItemAkhir").CurrentValues.AddValue(cboItemAkhir.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + Now.ToString("dd-MM-yyyy HH:mm:ss") + "'"

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

    Private Sub btLookupKodeKelompok_Click(sender As Object, e As EventArgs) Handles btLookupKodeKelompok.Click
        Dim DaftarSAPKelompokItem As IDataLookup = New DaftarSAPKelompokItem
        Dim Parameter() As String = {"%"}

        Dim Form As New frmLookup(DaftarSAPKelompokItem, Parameter)
        Form.Text = "Lookup Daftar Kelompok Item"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboKodeKelompok.ComboBox.SelectedValue = Form.IDLookup
            cboKodeKelompok.Focus()
        End If
    End Sub

    Private Sub btLookupItemAwal_Click(sender As Object, e As EventArgs) Handles btLookupItemAwal.Click
        Dim DaftarSAPItemBarang As IDataLookup = New DaftarSAPItemBarang
        Dim Parameter() As String = {cboKodeKelompok.ComboBox.SelectedValue}

        Dim Form As New frmLookup(DaftarSAPItemBarang, Parameter)
        Form.Text = "Lookup Daftar Item Barang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboItemAwal.ComboBox.SelectedValue = Form.IDLookup
            cboItemAwal.Focus()
        End If
    End Sub

    Private Sub btLookupItemAkhir_Click(sender As Object, e As EventArgs) Handles btLookupItemAkhir.Click
        Dim DaftarSAPItemBarang As IDataLookup = New DaftarSAPItemBarang
        Dim Parameter() As String = {cboKodeKelompok.ComboBox.SelectedValue}

        Dim Form As New frmLookup(DaftarSAPItemBarang, Parameter)
        Form.Text = "Lookup Daftar Item Barang"
        Form.ShowDialog()
        If Form.IDLookup <> "" Then
            cboItemAkhir.ComboBox.SelectedValue = Form.IDLookup
            cboItemAkhir.Focus()
        End If
    End Sub
End Class
