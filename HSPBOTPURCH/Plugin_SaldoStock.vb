Public Class Plugin_SaldoStock
    Dim _Server As Object = Nothing
    Dim _Date As Date = Now.Date

    Public Sub New(Server As Object)
        _Server = Server
    End Sub
End Class
