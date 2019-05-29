Imports Dapper

Namespace HSP.Data
    Public Class JenisKoreksi
        Public Property Kode As String
        Public Property Keterangan As String
        Public Property KodeKelompok As String
    End Class

    Public Class DaftarJenisKoreksi : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As JenisKoreksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tjeniskoreksi " +
                  "(Kode, Keterangan, KodeKelompok) " +
                  "VALUES " +
                  "(@Kode, @Keterangan, @KodeKelompok)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As JenisKoreksi) As Integer
            Dim SQL As String

            SQL = "UPDATE tjeniskoreksi SET " +
                  "Kode = @Kode, " +
                  "Keterangan = @Keterangan, " +
                  "KodeKelompok = @KodeKelompok " +
                  "WHERE Kode = @Kode "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tjeniskoreksi " +
                  "WHERE Kode = @Kode "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.Kode = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As JenisKoreksi
            Dim SQL As String

            SQL = "SELECT * FROM tjeniskoreksi " +
                  "WHERE Kode = @Kode "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of JenisKoreksi)(SQL, New With {.Kode = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal Kelompok As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.Kode                                         AS 'Kode', " +
                  "A.Keterangan                                   AS 'Keterangan', " +
                  "B.NamaKelompok                                 AS 'Kelompok' " +
                  "FROM tjeniskoreksi A " +
                  "LEFT JOIN (SELECT * FROM tkelompokkoreksi GROUP BY KodeKelompok) B ON B.KodeKelompok = A.KodeKelompok " +
                  "WHERE CONCAT(A.Kode, ' ', A.Keterangan) LIKE @Kriteria "

            If Kelompok <> "" Then
                SQL += " AND A.KodeKelompok ='" + Kelompok + "' "
            End If

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

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Kelompok As String = Parameter(0)

            SQL = "SELECT " +
                  "Kode                                         AS 'Kode', " +
                  "Keterangan                                   AS 'Keterangan' " +
                  "FROM tjeniskoreksi " +
                  "WHERE CONCAT(Kode, ' ', Keterangan) LIKE @Kriteria "

            If Kelompok <> "" Then
                SQL += " AND KodeKelompok ='" + Kelompok + "' "
            End If

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function

        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function
    End Class
End Namespace

