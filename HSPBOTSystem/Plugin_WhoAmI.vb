Public Class Plugin_WhoAmI

    Dim _Server As Object = Nothing

    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Sub Execute()
        _Server.Response("Who Am I? Ini dia....", 2, "C:\XA\test.jpg")
    End Sub
End Class
