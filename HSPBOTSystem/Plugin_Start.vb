Public Class Plugin_Start

    Dim _Server As Object = Nothing

    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Sub Execute()
        _Server.Response(">>" + vbCrLf +
                         "Selamat datang di layanan BOT" + vbCrLf +
                         "**PT. Hardo Soloplast**" + vbCrLf +
                         "Ketik Q atau pilih /MODUL untuk melihat daftar modul yang tersedia pada BOT Server" + vbCrLf +
                         "<<")
    End Sub

End Class
