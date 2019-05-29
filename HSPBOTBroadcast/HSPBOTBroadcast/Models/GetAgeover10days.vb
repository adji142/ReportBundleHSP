Imports Dapper
Imports HSPBOTBroadcast.BOT
Public Class ListUsers
    Public Property UserID As String
End Class
Public Class GetAgeover10days
    Dim _Server As Object = Nothing

    Private _DBConnection As New DBConnection
    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Function GetAge() As DataSet
        Dim DS As New DataSet
        Dim SQL = "CALL hspspm.fsp_getumurstock(); select coalesce(UserIDTelegram,'') UserIDTelegram from hspspm.lokasiuser where KodeLokasi in (SELECT distinct kodelokasi from hspspm.temp where umur > 10); drop table hspspm.temp;"
        Try
            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        GetAge = DS
    End Function
End Class
