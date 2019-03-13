Imports HSPProduction.HSP.Data

Public Class frmReprintBarcodeBmf

    Private Sub ResetData()
        txtKodeProduksiBahan.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtMeter.Text = ""
        txtTimbang.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksiBahan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksiBahan.Validating
        If txtKodeProduksiBahan.Text <> "" Then
            Dim DaftarBMF As New DaftarStockBenangMultifilament(ActiveSession)
            Dim BMF As StockBenangMultifilament = DaftarBMF.Find(txtKodeProduksiBahan.Text.Trim)
            If Not IsNothing(BMF) Then
                txtKodeItem.Text = BMF.KodeItem
                txtNamaItem.Text = BMF.NamaItem
                txtMeter.Text = BMF.Jumlah2
                txtTimbang.Text = BMF.BeratNetto
            Else
                MessageBox.Show("Kode Produksi Bahan Roll Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub SetEnableCommand()
        btPrint.Enabled = If(txtKodeProduksiBahan.Text = "", False, True) And _
                        If(txtNamaItem.Text = "", False, True)
    End Sub

    Private Sub PrintBarcode(KodeProduksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarProduksiBenang As New DaftarStockBenangMultifilament(ActiveSession)
        Dim ProduksiBenang As StockBenangMultifilament = DaftarProduksiBenang.Find(KodeProduksi)
        Dim KodeBall As String = ""

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodeBmf.btw", False, "")

        If Not IsNothing(ProduksiBenang) Then

            For i = 1 To ProduksiBenang.BeratNetto.ToString.Length
                KodeBall += GetFormat(Mid(ProduksiBenang.BeratNetto.ToString, i, 1))
            Next

            FormatBt.SetNamedSubStringValue("Tanggal", ProduksiBenang.M_TglTransaksi)
            FormatBt.SetNamedSubStringValue("KodeProduksi", ProduksiBenang.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeItem", ProduksiBenang.NamaItem)
            FormatBt.SetNamedSubStringValue("Pcs", ProduksiBenang.Jumlah2)
            FormatBt.SetNamedSubStringValue("Shift", ProduksiBenang.M_KodeShift)
            FormatBt.SetNamedSubStringValue("Berat", KodeBall)
            FormatBt.SetNamedSubStringValue("Status", "")

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btPrint.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btPrint"
                PrintBarcode(txtKodeProduksiBahan.Text)

            Case "btClose"
                Me.Close()
        End Select
    End Sub
End Class