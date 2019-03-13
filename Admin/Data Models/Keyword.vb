
Imports Dapper

' -----------------------------------------------------------------------------------------------------------
' Nama File   : PluginKeywordID.vb
' Deskripsi   : Class Untuk Mengelola Data PluginKeywordID
' Author      : Yudy Patrianto
' Tool        : VB.NET 
' Database    : MySQL 5.x  
' Tanggal     : 31 Desember 2012
' ----------------------------------------------------------------------------------------------------------- */

Namespace BOTSRV.Data

    'Class Modul Aplikasi
    Public Class Keyword

        'Daftar Properti
        Public Property PluginID As String
        Public Property PluginKeywordID As String
        Public Property Keyword As String
        Public Property KeywordParameter As String
        Public Property Description As String

    End Class

    'Class KeywordList
    Public Class KeywordList

        Private _DBConnection As DBConnection

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add PluginKeywordID
        Public Function Add(ByVal Data As Keyword) As Integer
            Dim SQL As String

            SQL = "INSERT INTO keyword " +
                  "(PluginID, PluginKeywordID, Keyword, KeywordParameter, Description) " +
                  "VALUES " +
                  "(@PluginID, @PluginKeywordID, UCASE(@Keyword), @KeywordParameter, @Description)"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        'Edit PluginKeywordID
        Public Function Edit(ByVal Data As Keyword) As Integer
            Dim SQL As String

            SQL = "UPDATE keyword SET " +
                  "PluginID = @PluginID, " +
                  "PluginKeywordID = @PluginKeywordID, " +
                  "Keyword  = UCASE(@Keyword), " +
                  "KeywordParameter = @KeywordParameter, " +
                  "Description = @Description " +
                  "WHERE Keyword = @Keyword"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Edit = DBX.Execute(SQL, Data)
            End Using

        End Function

        'Delete Berdasarkan ID
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM keyword " +
                  "WHERE Keyword=@Keyword"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Delete = DBX.Execute(SQL, New With {.Keyword = ID})
            End Using
        End Function

        'Find Berdasarkan ID
        Public Function Find(ByVal ID As String) As Keyword
            Dim SQL As String

            SQL = "SELECT * FROM keyword " +
                  "WHERE Keyword = @Keyword "

            Using DBX As IDbConnection = _DBConnection.Connection()
                Find = DBX.Query(Of Keyword)(SQL, New With {.Keyword = ID}).FirstOrDefault
            End Using

        End Function

        'Baca Data
        Public Function Read(ByVal TextSearch As String, PluginID As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "K.Keyword                                                   AS 'Keyword', " +
                  "K.Description                                               AS 'Description', " +
                  "CONCAT(P.Description,'/', P.FileName)                       AS 'Plugin', " +
                  "K.PluginKeywordID                                           AS 'Keyword ID' " +
                  "FROM keyword K " +
                  "LEFT JOIN plugin P ON P.PluginID = K.PluginID " +
                  "WHERE K.PluginKeywordID <> '' AND CONCAT(K.Keyword, ' ', K.Description) LIKE @TextSearch "

            If PluginID <> "" Then
                SQL += " AND K.PluginID = '" + PluginID + "' "
            End If

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

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

        'Baca Data
        Public Function ReadUserAccess() As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "K.Keyword                                                   AS 'Keyword', " +
                  "K.Description                                               AS 'Description', " +
                  "K.PluginID                                                  AS 'PluginID', " +
                  "P.Description                                               AS 'PluginDescription', " +
                  "CONCAT(P.Description,'/', P.FileName)                       AS 'Plugin', " +
                  "K.PluginKeywordID                                           AS 'KeywordID' " +
                  "FROM keyword K " +
                  "LEFT JOIN plugin P ON P.PluginID = K.PluginID " +
                  "ORDER BY K.PluginID, K.PluginKeywordID, K.Keyword"

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadUserAccess = DS

            End Using

        End Function

        'Baca Data
        Public Function ReadGroup(UserID As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "K.Keyword                                                   AS 'Keyword', " +
                  "K.Description                                               AS 'Description', " +
                  "CONCAT(P.Description,'/', P.FileName)                       AS 'Plugin', " +
                  "K.PluginKeywordID                                           AS 'Keyword ID' " +
                  "FROM keyword K " +
                  "LEFT JOIN plugin P ON P.PluginID = K.PluginID " +
                  "WHERE K.PluginKeywordID = '' AND K.Keyword IN (SELECT Keyword FROM useraccess WHERE UserID = @UserID) "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@UserID", UserID)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadGroup = DS

            End Using
        End Function


        'Baca Data
        Public Function ReadDetail(UserID As String, PluginID As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "K.Keyword                                                   AS 'Keyword', " +
                  "K.Description                                               AS 'Description', " +
                  "CONCAT(P.Description,'/', P.FileName)                       AS 'Plugin', " +
                  "K.PluginKeywordID                                           AS 'Keyword ID' " +
                  "FROM keyword K " +
                  "LEFT JOIN plugin P ON P.PluginID = K.PluginID " +
                  "WHERE K.PluginKeywordID <> '' AND K.Keyword IN (SELECT Keyword FROM useraccess WHERE UserID = @UserID) "

            If PluginID <> "" Then
                SQL += " AND K.PluginID = '" + PluginID + "' "
            End If

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@UserID", UserID)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS

            End Using

        End Function

        'Cek Jika Kode PluginKeywordIDSudah Digunakan
        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function

    End Class

End Namespace
