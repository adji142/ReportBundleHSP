Imports HSPProduction.HSP.Data

Public Class frmExecuteRMReceipt
    Public Sub ResetData()
        txtNoTransaksi.Text = ""
        txtKodeProduksi.Text = ""
        txtKodeItem.Text = ""
        txtNamaItem.Text = ""
        txtLokasiAsal.Text = ""
        txtLokasiTujuan.Text = ""
        txtQty.Text = ""

        SetEnableCommand()
    End Sub

    Private Sub txtNoTransaksi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNoTransaksi.Validating
        'If txtNoTransaksi.Text <> "" Then
        '    Dim SAP As New SAPStaging
        '    Dim Data As InvTransfer = SAP.GetStagingInvTransfer(txtNoTransaksi.Text.Trim)
        '    If Not IsNothing(Data) Then
        '        txtKodeProduksi.Text = Data.KodeProduksi
        '        txtKodeItem.Text = Data.KodeItem
        '        txtNamaItem.Text = Data.NamaItem
        '        txtLokasiAsal.Text = Data.LokasiAsal
        '        txtLokasiTujuan.Text = Data.LokasiTujuan
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
        SAP.UpdateStagingRMReceipt(txtNoTransaksi.Text.Trim)
        '-----------------------------------------------------------------------------------

        'Execute From Staging
        SAP.Execute(txtNoTransaksi.Text, HSPProduction.SAPStaging.enumTransaction.MaterialReceipt)

    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub SetEnableCommand()
        btSave.Enabled = If(txtKodeProduksi.Text = "", False, True)
    End Sub
End Class