Imports Dapper

Namespace HSP.Data
    Public Class Notuler
        Public Property id As Integer
        Public Property KodeDept As String
        Public Property Departement As String
        Public Property NIK As String
        Public Property NamaNotulen As String
    End Class
    Public Class DaftarNotuler
        Private _DBConnection As DBConnection
        Private _activeSession As SessionApp

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function Add(ByVal Data As Notuler) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tnotulen " +
                "(KodeDept,Departement,NIK,NamaNotulen) " +
                "VALUES " +
                "(@KodeDept,@Departement,@NIK,@NamaNotulen)"
            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Edit(ByVal Data As Notuler) As Integer
            Dim SQL As String

            SQL = "UPDATE tnotulen SET " +
                "KodeDept = @KodeDept," +
                "Departement = @Departement," +
                "NIK = @NIK," +
                "NamaNotulen = @NamaNotulen," +
                "WHERE id = @ID"
            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function
        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tnotulen " +
                  "WHERE id = @id"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.id = ID})
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "CAST(K.id AS CHAR)        AS 'Kode', " +
                  "K.KodeDept                   AS 'Kode Departement', " +
                  "K.Departement                AS 'Nama Departement', " +
                  "CAST(K.NIK AS CHAR)                        AS 'NIK', " +
                  "K.NamaNotulen                AS 'Nama Notulen' " +
                  "FROM tnotulen K " +
                  "WHERE CONCAT(K.NamaNotulen, ' ', K.NIK) LIKE @Kriteria "

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using
        End Function
        Public Function Find(ByVal ID As String) As Notuler
            Dim SQL As String

            SQL = "SELECT * FROM tnotulen " +
                  "WHERE id = @id"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Notuler)(SQL, New With {.id = ID}).FirstOrDefault
            End Using
        End Function
        Public Function GetMaxID() As Notuler
            Dim SQL As String
            SQL = "SELECT MAX(id) id FROM tnotulen"
            Using DBX As IDbConnection = _DBConnection.Connection
                GetMaxID = DBX.Query(Of Notuler)(SQL).FirstOrDefault
            End Using
        End Function
        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function

    End Class
End Namespace
