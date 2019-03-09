Public Class Test

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As New Plugin_CutiAll(Nothing)
        X._Create()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As New Plugin_DataKaryawan(Nothing)
        X._Create()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim X As New Plugin_Ketidakhadiran(Nothing)
        X._Create()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim X As New Plugin_Keterlambatan(Nothing)
        X._Create()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim X As New Plugin_Tes(Nothing)
        X._Create()
    End Sub
End Class