
Imports Dapper

' -----------------------------------------------------------------------------------------------------------
' Nama File   : Plugin.vb
' Deskripsi   : Class Untuk Mengelola Data Plugin
' Author      : Yudy Patrianto
' Tool        : VB.NET 
' Database    : MySQL 5.x  
' Tanggal     : 31 Desember 2012
' ----------------------------------------------------------------------------------------------------------- */

Namespace BOTSRV.Data

    'Class Modul Aplikasi
    Public Class Plugin

        'Daftar Properti
        Public Property PluginID As String
        Public Property Description As String
        Public Property FileName As String
        Public Property Keyword As String

    End Class

    'Class Daftar Plugin
    Public Class PluginList : Implements IDataLookup

       Private _DBConnection As DBConnection

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add Plugin
        Public Function Add(ByVal Data As Plugin) As Integer
            Dim SQL As String

            SQL = "INSERT INTO plugin " +
                  "(PluginID, Description, FileName, Keyword) " +
                  "VALUES " +
                  "(@PluginID, @Description, @FileName, @Keyword)"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        'Edit Plugin
        Public Function Edit(ByVal Data As Plugin) As Integer
            Dim SQL As String

            SQL = "UPDATE plugin SET " +
                  "PluginID = @PluginID, " +
                  "Description = @Description, " +
                  "FileName  = @FileName, " +
                  "Keyword = @Keyword " +
                  "WHERE PluginID=@PluginID"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Edit = DBX.Execute(SQL, Data)
            End Using

        End Function

        'Delete Berdasarkan ID
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM plugin " +
                  "WHERE PluginID=@PluginID"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Delete = DBX.Execute(SQL, New With {.PluginID = ID})
            End Using
        End Function

        'Find Berdasarkan ID
        Public Function Find(ByVal ID As String) As Plugin
            Dim SQL As String

            SQL = "SELECT * FROM plugin " +
                  "WHERE PluginID = @PluginID "

            Using DBX As IDbConnection = _DBConnection.Connection()
                Find = DBX.Query(Of Plugin)(SQL, New With {.PluginID = ID}).FirstOrDefault
            End Using

        End Function

        'Baca Data
        Public Function Read(ByVal TextSearch As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "PluginID                                                   AS 'ID', " +
                  "Description                                                AS 'Description', " +
                  "FileName                                                   AS 'File Name', " +
                  "Keyword                                                    AS 'Keyword' " +
                  "FROM plugin " +
                  "WHERE CONCAT(PluginID, ' ', Description) LIKE @TextSearch "

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

        'Lookup
        Public Function GetLookup(ByVal TextSearch As String, ByVal Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String

            SQL = "SELECT " +
                  "PluginID                                                   AS 'ID', " +
                  "Description                                                AS 'Description', " +
                  "FileName                                                   AS 'File Name', " +
                  "Keyword                                                    AS 'Keyword' " +
                  "FROM plugin " +
                  "WHERE CONCAT(PluginID, ' ', Description) LIKE @TextSearch "

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

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

        'Cek Jika Kode PluginSudah Digunakan
        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function

    End Class

End Namespace
