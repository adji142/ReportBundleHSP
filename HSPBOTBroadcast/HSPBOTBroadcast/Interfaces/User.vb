Imports Dapper

Namespace BOT

    'Class User
    Public Class User

        'Daftar Properti
        Public Property UserID As String
        Public Property UserName As String
        Public Property Active As Byte

    End Class

    'Class UserList
    Public Class UserList : Implements IDataLookup

        Private _DBConnection As DBConnection

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add UserName Barang 
        Public Function Add(ByVal Data As User) As Integer
            Dim SQL As String

            SQL = "INSERT INTO user " +
                  "(UserID, UserName, Active) " +
                  "VALUES " +
                  "(@UserID, @UserName, @Active)"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Add = DBX.Execute(SQL, Data)
            End Using

        End Function

        'Edit UserName Barang 
        Public Function Edit(ByVal Data As User) As Integer
            Dim SQL As String

            SQL = "UPDATE user SET " +
                  "UserID = @UserID, " +
                  "UserName = @UserName, " +
                  "Active = @Active " +
                  "WHERE UserID=@UserID"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Edit = DBX.Execute(SQL, Data)
            End Using

        End Function

        'Delete Berdasarkan ID
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM user " +
                  "WHERE UserID=@UserID"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Delete = DBX.Execute(SQL, New With {.UserID = ID})
            End Using

        End Function

        'Find Berdasarkan ID
        Public Function Find(ByVal ID As String) As User
            Dim SQL As String

            SQL = "SELECT * FROM user " +
                  "WHERE UserID = @UserID "

            Using DBX As IDbConnection = _DBConnection.Connection()
                Find = DBX.Query(Of User)(SQL, New With {.UserID = ID}).FirstOrDefault
            End Using

        End Function

        'Baca Data
        Public Function Read(ByVal TextSearch As String) As DataSet
            Dim SQL As String

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            SQL = "SELECT " +
                  "UserID                                                         AS 'ID', " +
                  "UserName                                                       AS 'User Name', " +
                  "IF(Active=1, 'Yes', 'No')                                      AS 'Active' " +
                  "FROM user " +
                  "WHERE CONCAT( " +
                  "             UserID, ' ', " +
                  "             UserName " +
                  "            ) LIKE @TextSearch "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@TextSearch", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS

            End Using

        End Function

        Public Function ReadUser(ByVal Keyword As String) As DataSet
            Dim SQL As String

            SQL = "SELECT DISTINCT UserID AS ID FROM useraccess WHERE Keyword = @Keyword "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Keyword", Keyword)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadUser = DS

            End Using
        End Function
        Public Function ReadUser_PTG(ByVal Keyword As String) As DataSet
            Dim SQL As String

            SQL = "SELECT DISTINCT UserID AS ID FROM useraccess WHERE userid = @Keyword "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Keyword", Keyword)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadUser_PTG = DS

            End Using
        End Function

        'Lookup
        Public Function GetLookup(ByVal TextSearch As String, ByVal Parameter As Object) As DataSet Implements IDataLookup.GetLookup

            Dim SQL As String

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            SQL = "SELECT " +
                 "UserID                                                         AS 'ID', " +
                 "UserName                                                       AS 'User Name', " +
                 "IF(Active=1, 'Yes', 'No')                                      AS 'Active' " +
                 "FROM user " +
                 "WHERE Active = 1 AND " +
                 "      CONCAT( " +
                 "         UserID, ' ', " +
                 "         UserName " +
                 "      ) LIKE @TextSearch "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@TextSearch", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS

            End Using

        End Function

    End Class

End Namespace
