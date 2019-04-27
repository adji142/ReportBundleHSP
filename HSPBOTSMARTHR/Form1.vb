Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As New Plugin_MultiLevelLate(Nothing)
        X._Create()
        'X.Execute()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As New Plugin_MultilevelAnualLeave(Nothing)
        X._Create()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As New Plugin_CutiPerUser(Nothing)
        x._Create()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New PluginKeterlambatan(Nothing)
        x._Create()
    End Sub
End Class
