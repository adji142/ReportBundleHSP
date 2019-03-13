Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports HSPProduction.HSP.Data

Public Class frmRPT900_110_StockBatch

    Private Sub frmRPTJurnal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        RPT.ShowGroupTreeButton = False

        FillCombo()

        cboKelompok.SelectedIndex = 0
    End Sub

    'Fill Combo
    Private Sub FillCombo()
        'Lokasi Produksi
        '----------------------------------------------------------------------------
        Dim DaftarLokasiProduksi As New DaftarLokasi(ActiveSession)
        Dim DS As DataSet
        DS = New DataSet
        DS = DaftarLokasiProduksi.Read("%")
        cboKodeLokasi.ComboBox.DataSource = DS.Tables("View")
        cboKodeLokasi.ComboBox.DisplayMember = "Nama Lokasi"
        cboKodeLokasi.ComboBox.ValueMember = "Kode"
    End Sub

    Private Sub AmbilDataStockSap()
        Dim SAP As New SAPInventory()
        Dim DS As DataSet

        If cboKelompok.ComboBox.SelectedIndex + 1 = 1 Then
            DS = SAP.ReadStockBatchRoll(cboKodeLokasi.ComboBox.SelectedValue)
        End If
        If cboKelompok.ComboBox.SelectedIndex + 1 = 2 Then
            DS = SAP.ReadStockBatchPacking(cboKodeLokasi.ComboBox.SelectedValue)
        End If
        If cboKelompok.ComboBox.SelectedIndex + 1 = 3 Then
            DS = SAP.ReadStockBatchBmf(cboKodeLokasi.ComboBox.SelectedValue)
        End If

        Dim DaftarStockBacth As New DaftarTempStockBatch(ActiveSession)
        Dim TempStockBatch As New TempStockBatch

        Dim Record As Integer = DS.Tables("View").Rows.Count
        ProgressBar.Visible = True
        ProgressBar.Value = 0
        ProgressBar.Maximum = Record

        For Each DR As DataRow In DS.Tables("View").Rows
            TempStockBatch.KodeItem = DR("KodeItem")
            TempStockBatch.NamaItem = DR("NamaItem")
            TempStockBatch.KodeProduksi = DR("KodeProduksi")
            TempStockBatch.Qty = DR("Qty")
            TempStockBatch.KodeUnitSAP = DR("KodeUnit")
            TempStockBatch.KodeLokasi = DR("KodeLokasi")

            DaftarStockBacth.Add(TempStockBatch)

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
        Dim DTSB As New DaftarTempStockBatch(ActiveSession)
        DTSB.DeleteAll()

        AmbilDataStockSap()

        DTSB.AddTempConsole(cboKodeLokasi.ComboBox.SelectedValue, cboKelompok.ComboBox.SelectedIndex + 1)
        DTSB.AddTempSap()
        DTSB.AddKontrol()

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
        RPTObject.Load(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\rptStockComparison.RPT")

        For Each DataTable In RPTObject.Database.Tables
            DataTable.LogOnInfo.ConnectionInfo = Server
            DataTable.ApplyLogOnInfo(DataTable.LogOnInfo)
        Next

        'Informasi
        RPTObject.DataDefinition.FormulaFields("UserID").Text = "'" + ActiveSession.KodeUser + "'"
        RPTObject.DataDefinition.FormulaFields("NamaPerusahaan").Text = "'" + UCase(ActiveSession.NamaPerusahaan) + "'"
        RPTObject.DataDefinition.FormulaFields("Periode").Text = "'PER :  " + Now.ToString("dd-MM-yyyy HH:mm:ss") + "'"
        RPTObject.DataDefinition.FormulaFields("Lokasi").Text = "'LOKASI : " + New DaftarLokasi(ActiveSession).Find(cboKodeLokasi.ComboBox.SelectedValue).NamaLokasi.ToUpper + "'"

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
