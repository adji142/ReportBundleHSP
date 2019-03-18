Public Class eMenuTester

    Private Sub KelompokToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles KelompokToolStripMenuItem.Click
        Dim frm As New frmDaftarKelompok
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AspekToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AspekToolStripMenuItem.Click
        Dim frm As New frmDaftarAspek
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DataPenilaianKerjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPenilaianKerjaToolStripMenuItem.Click
        Dim frm As New frmDaftarKPI
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PenilaianKerjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenilaianKerjaToolStripMenuItem.Click
        Dim frm As New frmReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KPIBulananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KPIBulananToolStripMenuItem.Click
        Dim frm As New frmRepKPIBulanan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KPITahunanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KPITahunanToolStripMenuItem.Click
        Dim frm As New frmRepKPITahunan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OJTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OJTToolStripMenuItem.Click
        Dim frm As New frmDaftarOJT
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProgressInputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgressInputToolStripMenuItem.Click
        Dim frm As New frmRepProgressInput
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PrpgressLengkapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrpgressLengkapToolStripMenuItem.Click
        Dim frm As New frmRepProgressLengkap
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LaporanIPKUnderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanIPKUnderToolStripMenuItem.Click
        Dim frm As New frmRepIPKUnder
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LaporanIPKOverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanIPKOverToolStripMenuItem.Click
        Dim frm As New frmRepIPKOver
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
