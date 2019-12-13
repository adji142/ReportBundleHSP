Public Class Form1

    Private Sub MeetingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeetingToolStripMenuItem.Click
        Dim ifrmChild As New frmDaftarMeeting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub

    Private Sub NotulenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotulenToolStripMenuItem.Click
        Dim ifrmChild As New FrmNotulen
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()

    End Sub

    Private Sub NotulenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NotulenToolStripMenuItem1.Click
        Dim ifrmChild As New frmDaftarNotulen
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()

    End Sub

    Private Sub UserSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserSettingToolStripMenuItem.Click
        Dim ifrmChild As New frmDaftarUserSetting
        IsMdiContainer = True
        ifrmChild.MdiParent = Me
        'frmformDO.Dock = DockStyle.Fill
        ifrmChild.Show()
    End Sub
End Class
