Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As New Plugin_Pembelian3Month(Nothing)
        X._Create()
    End Sub
End Class
