Imports HSPProduction.HSP.Data

Public Class frmExecuteFGReceipt
    Public Sub ResetData()
        txtNoTransaksi.Text = ""
        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtLokasiAsal.Text = ""
        txtQty.Text = ""

        txtNoTransaksi.Focus()

        SetEnableCommand()
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        'If txtNoTransaksi.Text <> "" Then
        '    Dim SAP As New SAPStaging
        '    Dim Data As FGReceipt = SAP.GetStagingFGReceipt(txtNoTransaksi.Text.Trim)
        '    If Not IsNothing(Data) Then
        '        txtKodeProduksi.Text = Data.KodeProduksi
        '        txtKodeItem.Text = Data.KodeItem
        '        txtNamaItem.Text = Data.NamaItem
        '        txtLokasiAsal.Text = Data.Lokasi
        '        txtQty.Value = Data.Quantity
        '    Else
        '        MessageBox.Show("Nomor Transaksi Tidak Valid...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        ResetData()
        '        txtNoTransaksi.Focus()
        '    End If
        'End If

        'SetEnableCommand()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim SAP As New SAPStaging

        'Update Status Imported >> N
        SAP.UpdateStagingFGReceipt(txtNoTransaksi.Text.Trim)
        '-----------------------------------------------------------------------------------

        'Execute From Staging
        SAP.Execute(txtNoTransaksi.Text.Trim, SAPStaging.enumTransaction.FinishedGoodReceipt)

        'MessageBox.Show("Eksekusi FG Receipt Berhasil...")
        'ResetData()

    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtKodeItem.Text = "", False, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SAP As New SAPStaging

        'Execute From Staging
        SAP.Execute("RSHP-17120117", HSPProduction.SAPStaging.enumTransaction.DirectProcess)
    End Sub
End Class