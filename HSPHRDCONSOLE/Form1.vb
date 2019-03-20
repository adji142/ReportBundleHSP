Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New DaftarUserSettingBrowse
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FrmHRBroadcastBrowse
        frm.ShowDialog()
    End Sub
End Class
