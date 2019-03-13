
' -----------------------------------------------------------------------------------------------------------
' Nama File   : UserAccess.vb
' Deskripsi   : Class Untuk Mengelola Data UserAccess
' Author      : Yudy Patrianto
' Tool        : VB.NET 
' Database    : MySQL 5.x  
' Tanggal     : 27 Januari 2011
' ----------------------------------------------------------------------------------------------------------- */

Imports Dapper

Namespace BOTSRV.Data

    'Class UserAccess
    Public Class UserAccess

        'Daftar Properti
        Public Property UserID As String
        Public Property Keyword As String

    End Class

    'Class UserAccessList
    Public Class UserAccessList

        Private _DBConnection As DBConnection

        'Overload Konstruktor
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add Keyword Barang 
        Public Function Add(ByVal Data As UserAccess) As Integer
            Dim SQL As String

            SQL = "INSERT INTO useraccess " +
                  "(UserID, Keyword) " +
                  "VALUES " +
                  "(@UserID, @Keyword)"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Add = DBX.Execute(SQL, Data)
            End Using

        End Function

        'Edit Keyword Barang 
        Public Function Edit(ByVal Data As UserAccess) As Integer
            Dim SQL As String

            SQL = "UPDATE useraccess SET " +
                  "UserID = @UserID, " +
                  "Keyword = @Keyword " +
                  "WHERE UserID=@UserID"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Edit = DBX.Execute(SQL, Data)
            End Using

        End Function

        'Delete Berdasarkan ID
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM useraccess " +
                  "WHERE UserID=@UserID"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Delete = DBX.Execute(SQL, New With {.UserID = ID})
            End Using

        End Function

        'Find Berdasarkan ID
        Public Function Find(ByVal ID As String, Keyword As String) As UserAccess
            Dim SQL As String

            SQL = "SELECT * FROM useraccess " +
                  "WHERE UserID = @UserID AND Keyword = @Keyword LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection()
                Find = DBX.Query(Of UserAccess)(SQL, New With {.UserID = ID, .Keyword = Keyword}).FirstOrDefault
            End Using

        End Function

        'Baca Data
        Public Function Read(UserID As String) As DataSet
            Dim SQL As String

            SQL = "SELECT * " +
                  "FROM useraccess " +
                  "WHERE UserID = @UserID "

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@UserID", UserID)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS

            End Using

        End Function

    End Class

End Namespace
