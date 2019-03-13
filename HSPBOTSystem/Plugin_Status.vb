Public Class Plugin_Status

    Dim _Server As Object = Nothing

    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Sub Execute()
        _Server.Response("HSP BOT Server Versi Beta" + vbCrLf +
                         "Status : Running")
    End Sub

End Class
