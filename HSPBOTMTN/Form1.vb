Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As New Plugin_PemakaianObat(Nothing)
        X._Create()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As New Plugin_PemakaianATK(Nothing)
        X._Create()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim X As New Plugin_PemakaianATK_Rekap(Nothing)
        X._Create()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim X As New Plugin_PemakaianObat_Rekap(Nothing)
        X._Create()
    End Sub
End Class
