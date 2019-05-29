Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports ReportXprdsystem.HSP.Data

Public Class frmRPTPro_SaldoStockBahan

    Private Sub frmRPTJurnal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        FillCombo()
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        'Lokasi Produksi
        '----------------------------------------------------------------------------
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet
        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%", 1)
        cboKodeLokasi.ComboBox.DataSource = DS.Tables("View")
        cboKodeLokasi.ComboBox.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ComboBox.ValueMember = "Kode"
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
        RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rptPro_SaldoStockBahan.RPT")

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Parameter
        RPTObject.ParameterFields("KODELOKASI").CurrentValues.AddValue(cboKodeLokasi.ComboBox.SelectedValue)

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'TANGGAL :  " + Now.ToString("dd-MM-yyyy") + "'"
        RPTObject.DataDefinition.FormulaFields("LokasiStock").Text = "'LOKASI : " + New DaftarLokasi(ActiveSession).Find(cboKodeLokasi.ComboBox.SelectedValue).NamaLokasi.ToUpper + "'"

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
