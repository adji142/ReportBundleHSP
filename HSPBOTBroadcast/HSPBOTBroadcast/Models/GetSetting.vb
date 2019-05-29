Imports Dapper
Imports HSPBOTBroadcast.BOT
Public Class GetSettingUser
    Public Property UserID As String
End Class
Public Class GetSetting
    Dim _Server As Object = Nothing

    Private _DBConnection As New DBConnection
    Public Sub New(Server As Object)
        _Server = Server
    End Sub

    Public Function GetSetting_BC() As DataSet
        Dim DS As New DataSet
        Dim SQL = "select * from botsrv.broadcastsetting where statusset = 1;"
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
        GetSetting_BC = DS
    End Function
End Class