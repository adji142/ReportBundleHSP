Imports Dapper
Namespace HSP.Data
    Public Class ListUsers
        Public Property UserID As String
        Public Property Username As String
    End Class
    Public Class TelegramUsers : Implements IDataLookup
        Private _DBConnection As DBConnection
        Public Enum enumLookupKaryawan
            DaftarKaryawan = 1
        End Enum

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub


        Public Function Find(ByVal ID As String) As ListUsers
            Dim SQL As String

            SQL = "Select UserID,Username from botsrv.user where UserID = @userid"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ListUsers)(SQL, New With {.userid = ID}).FirstOrDefault
            End Using
        End Function
        Public Function Read(ByVal ID As String) As DataSet
            Dim SQL As String

            SQL = "Select UserID,Username from botsrv.user where UserID = '" + ID + "'"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                Read = DS
            End Using
        End Function
        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements HSP.Data.IDataLookup.GetLookup
            Dim param = ""
            If (Parameter IsNot Nothing) Then
                param = Parameter(0)
            End If
            Dim SQL As String

            SQL = "Select UserID,Username from botsrv.user where CONCAT(UserID,Username) like '" + TextSearch + "'"
            '"ORDER BY ""WhsName"" "
            If param <> "" Then
                SQL += "AND UserID ='" + param + "'"
            End If
            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function
    End Class
End Namespace
