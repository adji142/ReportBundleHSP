Imports HSPProduction.HSP.Data

Public Class frmReprintBarcodePrinting

    Private Sub ResetData()
        txtKodeProduksiBahan.Text = ""
        txtKodeProduksiHasil.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtMeter.Text = ""
        txtTimbang.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksiBahan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksiBahan.Validating
        If txtKodeProduksiBahan.Text <> "" Then
            Dim DaftarPL As New DaftarProduksiPrintingRoll(ActiveSession)
            Dim PL As ProduksiPrintingRoll = DaftarPL.FindFGKodeProduksiByRMKodeProduksi(txtKodeProduksiBahan.Text.Trim)
            If Not IsNothing(PL) Then
                txtKodeProduksiHasil.Text = PL.FGKodeProduksi
                txtKodeItem.Text = PL.FGKodeItem
                txtNamaItem.Text = PL.FGNamaItem
                txtMeter.Text = PL.FGPanjang
                txtTimbang.Text = PL.FGBeratNetto
            Else
                MessageBox.Show("Kode Produksi Bahan Roll Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub SetEnableCommand()
        btPrint.Enabled = If(txtKodeProduksiBahan.Text = "", False, True) And _
                        If(txtKodeProduksiHasil.Text = "", False, True)
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

            If StockRoll.KodeUnitPeruntukan.Trim <> "" Then
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", New DaftarUnitProduksi(ActiveSession).Find(StockRoll.KodeUnitPeruntukan).NamaUnit)
            Else
                FormatBt.SetNamedSubStringValue("UnitPeruntukan", "")
            End If

            FormatBt.SetNamedSubStringValue("Kode", StockRoll.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeMesin", StockRoll.KodeMesin)
            FormatBt.SetNamedSubStringValue("BeratNetto", StockRoll.BeratNetto)
            FormatBt.SetNamedSubStringValue("PanjangRoll", StockRoll.PanjangRoll)
            FormatBt.SetNamedSubStringValue("Pcs", StockRoll.Pcs)
            FormatBt.SetNamedSubStringValue("BeratPerMeter", StockRoll.BeratPerMeter)
            FormatBt.SetNamedSubStringValue("Status", "B")
            FormatBt.SetNamedSubStringValue("KodeStatus", If(StockRoll.StatusQc = 0, "NONE", If(StockRoll.StatusQc = 1, "OK", If(StockRoll.StatusQc = 2, "NON OK", If(StockRoll.StatusQc = 3, "OVER", If(StockRoll.StatusQc = 4, "UNDER", ""))))))
            FormatBt.SetNamedSubStringValue("Keterangan", UCase(StockRoll.Keterangan) & If(ReprintStatus, "*", ""))

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btPrint.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btPrint"
                PrintBarcode(txtKodeProduksiHasil.Text)

            Case "btClose"
                Me.Close()
        End Select
    End Sub
End Class