Public Class Form1

    Private Sub PengeluaranBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranBarangToolStripMenuItem.Click

        Dim ifrmChild As New FrmPengeluaranBarang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub TambahLokasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahLokasiToolStripMenuItem.Click
        'Dim ifrmChild As New FrmTambahLokasiUser
        'IsMdiContainer = True
        'ifrmChild.MdiParent = Me
        ''frmformDO.Dock = DockStyle.Fill
        'ifrmChild.Show()
    End Sub

    Private Sub PengeluaranBonSparepartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranBonSparepartToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7701_PengeluaranBarang
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub PenerimaanSparepartReturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenerimaanSparepartReturToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7702_PenerimaanBarangRetur
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub

    Private Sub DistribusiSparepartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribusiSparepartToolStripMenuItem.Click
        Dim ifrmChil As New FrmRPT_7703_DistribusiSparePart
        IsMdiContainer = True
        ifrmChil.MdiParent = Me
        ifrmChil.Show()
    End Sub
End Class
