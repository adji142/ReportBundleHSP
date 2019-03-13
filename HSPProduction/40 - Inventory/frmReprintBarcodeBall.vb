Imports HSPProduction.HSP.Data

Public Class frmReprintBarcodeBall

    Private Sub ResetData()
        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtPcs.Text = ""
        txtTimbang.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub txtKodeProduksiBahan_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeProduksi.Validating
        If txtKodeProduksi.Text <> "" Then
            Dim DaftarPL As New DaftarStockPacking(ActiveSession)
            Dim PL As StockPacking = DaftarPL.Find(txtKodeProduksi.Text.Trim)
            If Not IsNothing(PL) Then
                txtKodeItem.Text = PL.KodeItem
                txtNamaItem.Text = PL.NamaItem
                txtPcs.Text = PL.Pcs
                txtTimbang.Text = PL.BeratNetto
            Else
                MessageBox.Show("Kode Produksi Ball Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ResetData()
            End If
        End If
    End Sub

    Private Sub SetEnableCommand()
        btPrint.Enabled = If(txtKodeProduksi.Text = "", False, True) And _
                        If(txtKodeItem.Text = "", False, True)
    End Sub

    Private Sub PrintBarcode(KodeProduksi As String, Optional ReprintStatus As Boolean = False)
        Dim DaftarStockPacking As New DaftarStockPacking(ActiveSession)
        Dim StockPacking As StockPacking = DaftarStockPacking.Find(KodeProduksi)
        Dim KodeBall As String

        Dim AppBt As New BarTender.Application
        Dim FormatBt As BarTender.Format

        FormatBt = AppBt.Formats.Open(System.AppDomain.CurrentDomain.BaseDirectory() + "\Reports\BarcodePacking.btw", False, "")

        If Not IsNothing(StockPacking) Then

            KodeBall = ""
            For i = 1 To StockPacking.BeratNetto.ToString.Length
                KodeBall += GetFormat(Mid(StockPacking.BeratNetto.ToString, i, 1))
            Next

            FormatBt.SetNamedSubStringValue("Tanggal", StockPacking.TglTransaksi)
            FormatBt.SetNamedSubStringValue("KodeProduksi", StockPacking.KodeProduksi)
            FormatBt.SetNamedSubStringValue("KodeItem", StockPacking.NamaItem)
            FormatBt.SetNamedSubStringValue("Pcs", StockPacking.Pcs)
            FormatBt.SetNamedSubStringValue("Berat", KodeBall & " " & If(StockPacking.StatusQc < 3, "", If(StockPacking.StatusQc = 3, " /O", If(StockPacking.StatusQc = 4, " /U", ""))))
            FormatBt.SetNamedSubStringValue("Status", "")

            FormatBt.PrintOut(False, False)

            AppBt.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btPrint.Click, btClose.Click
        Select Case DirectCast(sender, Button).Name
            Case "btPrint"
                PrintBarcode(txtKodeProduksi.Text)
                ResetData()
            Case "btClose"
                Me.Close()
        End Select
    End Sub
End Class