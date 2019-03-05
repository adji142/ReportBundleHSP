Public Class Form1

    Private Sub PengeluaranBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengeluaranBarangToolStripMenuItem.Click

        Dim ifrmChild As New FrmPengeluaranBarang
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub
End Class
