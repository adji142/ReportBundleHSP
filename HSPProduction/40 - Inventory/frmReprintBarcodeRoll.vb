Imports HSPProduction.HSP.Data

Public Class frmReprintBarcodeRoll

    Private Sub ResetData()
        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtMeter.Text = ""
        txtTimbang.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksiBahan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
            Dim StockRoll As StockRoll = DaftarStockRoll.Find(txtKodeProduksi.Text)
            If Not IsNothing(StockRoll) Then
                txtKodeItem.Text = StockRoll.KodeItem
                txtNamaItem.Text = StockRoll.NamaItem
                txtMeter.Text = StockRoll.Jumlah2
                txtTimbang.Text = StockRoll.BeratNetto
            Else
                MessageBox.Show("Kode Produksi Bahan Roll Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub SetEnableCommand()
        btPrint.Enabled = If(txtKodeProduksi.Text = "", False, True) And _
                        If(txtNamaItem.Text = "", False, True)
    End Sub

    Private Sub PrintBarcode(KodeProduksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockRoll As New DaftarStockRoll(ActiveSession)
        Dim StockRoll As StockRoll = DaftarStockRoll.Find(KodeProduksi)

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeRoll.btw", False, "")

        If Not IsNothing(StockRoll) Then
            FormatBt.SetNamedSubStringValue("NoTransaksi", StockRoll.NoTransaksi)
            FormatBt.SetNamedSubStringValue("Tanggal", StockRoll.TglTransaksi)
            FormatBt.SetNamedSubStringValue("NomorSpk", StockRoll.NomorWO)
            FormatBt.SetNamedSubStringValue("NamaItem", StockRoll.NamaItem)
            FormatBt.SetNamedSubStringValue("Unit", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnit).NamaUnit)
            If StockRoll.KodeUnitPeruntukan.Trim = "" Then
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", "")
            Else
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnitPeruntukan).NamaUnit)
            End If
            FormatBt.SetNamedSubStringValue("Kode", StockRoll.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeMesin", StockRoll.KodeMesin)
            FormatBt.SetNamedSubStringValue("BeratNetto", StockRoll.BeratNetto)
            FormatBt.SetNamedSubStringValue("PanjangRoll", StockRoll.PanjangRoll)
            FormatBt.SetNamedSubStringValue("Pcs", StockRoll.Pcs)
            FormatBt.SetNamedSubStringValue("BeratPerMeter", StockRoll.BeratPerMeter)
            FormatBt.SetNamedSubStringValue("Status", "A")
            FormatBt.SetNamedSubStringValue("KodeStatus", If(StockRoll.StatusQc = 0, "NONE", If(StockRoll.StatusQc = 1, "OK", If(StockRoll.StatusQc = 2, "NON OK", If(StockRoll.StatusQc = 3, "OVER", If(StockRoll.StatusQc = 4, "UNDER", ""))))))
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(StockRoll.Keterangan) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btPrint.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btPrint"
                PrintBarcode(txtKodeProduksi.Text)

            Case "btClose"
                Me.Close()
        End Select
    End Sub
End Class