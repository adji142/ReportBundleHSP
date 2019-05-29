Imports Dapper

Namespace HSP.Data
    Public Class KelompokItem
        Public Property KodeKelompok As String
        Public Property NamaKelompok As String
    End Class

    Public Class DaftarKelompokItem : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KelompokItem) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tkelompokitem " +
                  "(KodeKelompok, NamaKelompok) " +
                  "VALUES " +
                  "(@KodeKelompok, @NamaKelompok)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As KelompokItem) As Integer
            Dim SQL As String

            SQL = "UPDATE tkelompokitem SET " +
                  "KodeKelompok = @KodeKelompok, " +
                  "NamaKelompok = @NamaKelompok " +
                  "WHERE KodeKelompok = @KodeKelompok"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tkelompokitem " +
                  "WHERE KodeKelompok = @KodeKelompok"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeKelompok = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As KelompokItem
            Dim SQL As String

            SQL = "SELECT * FROM tkelompokitem " +
                  "WHERE KodeKelompok = @KodeKelompok"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of KelompokItem)(SQL, New With {.KodeKelompok = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeKelompok                                         AS 'Kode', " +
                  "NamaKelompok                                         AS 'Kelompok' " +
                  "FROM tkelompokitem " +
                  "WHERE CONCAT(KodeKelompok, ' ', NamaKelompok) LIKE @Kriteria "

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

            SQL = "SELECT " +
                  "KodeKelompok                                         AS 'Kode', " +
                  "NamaKelompok                                         AS 'Kelompok' " +
                  "FROM tkelompokitem " +
                  "WHERE CONCAT(KodeKelompok, ' ', NamaKelompok) LIKE @Kriteria "

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
            Dim SQL As String

            SQL = "SELECT KodeKelompok FROM titemproduksi WHERE KodeKelompok = @KodeKelompok LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Locked = If(IsNothing(DBX.Query(SQL, New With {.KodeKelompok = ID}).FirstOrDefault), False, True)
            End Using
        End Function
    End Class
End Namespace

