Public Class aMenu

    Private Sub SaldoStockBahanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoStockBahanToolStripMenuItem.Click
        Dim frm As New frmRPTPro_SaldoStockBahan
        frm.ShowDialog()
    End Sub

    Private Sub PenyelesaianWOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyelesaianWOToolStripMenuItem.Click
        Dim frm As New frmRPT100_150_Extruder
        frm.ShowDialog()
    End Sub

    Private Sub MonitoringWorkOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoringWorkOrderToolStripMenuItem.Click
        Dim frm As New frmRPT900_100_Produksi
        frm.ShowDialog()
    End Sub

    Private Sub ExecuteStagingRMIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteStagingRMIssueToolStripMenuItem.Click
        Dim frm As New frmExecuteRMIssue
        frm.ShowDialog()
    End Sub

    Private Sub ExecuteStagingFGReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteStagingFGReceiptToolStripMenuItem.Click
        Dim frm As New frmExecuteFGReceipt
        frm.ShowDialog()
    End Sub

    Private Sub ExecuteStagingInventoryTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecuteStagingInventoryTransferToolStripMenuItem.Click
        Dim frm As New frmExecuteInventoryTransfer
        frm.ShowDialog()
    End Sub

    Private Sub PenerimaanAfvalSementaraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanAfvalSementaraToolStripMenuItem.Click
        Dim frm As New frmProduksiAfvalSementara
        frm.ShowDialog()
    End Sub

    Private Sub PenerimaanAfvalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanAfvalToolStripMenuItem.Click
        Dim frm As New frmRPT600_110_GudangAfval
        frm.ShowDialog()
    End Sub
End Class