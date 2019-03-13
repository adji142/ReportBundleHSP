Imports Dapper

Namespace HSP.Data
    Public Class QCDisposisi
        Public Property KodeUnit As String
        Public Property KodeDisposisi As String
        Public Property Disposisi As String
    End Class

    Public Class DaftarQCDisposisi : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As QCDisposisi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tqcdisposisi " +
                  "(KodeUnit, KodeDisposisi, Disposisi) " +
                  "VALUES " +
                  "(@KodeUnit, @KodeDisposisi, @Disposisi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As QCDisposisi) As Integer
            Dim SQL As String

            SQL = "UPDATE tqcdisposisi SET " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeDisposisi = @KodeDisposisi, " +
                  "Disposisi = @Disposisi " +
                  "WHERE KodeDisposisi = @KodeDisposisi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tqcdisposisi " +
                  "WHERE KodeDisposisi = @KodeDisposisi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeDisposisi = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As QCDisposisi
            Dim SQL As String

            SQL = "SELECT * FROM tqcdisposisi " +
                  "WHERE KodeDisposisi = @KodeDisposisi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of QCDisposisi)(SQL, New With {.KodeDisposisi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "D.KodeDisposisi                                                      AS 'Kode', " +
                  "D.Disposisi                                                          AS 'Disposisi', " +
                  "UP.NamaUnit                                                          AS 'Unit Produksi' " +
                  "FROM tqcdisposisi D " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = D.KodeUnit " +
                  "WHERE CONCAT(D.KodeDisposisi, ' ', D.Disposisi) LIKE @Kriteria "

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
            Dim KodeUnit As String = Parameter(0)

            SQL = "SELECT " +
                  "D.KodeDisposisi                                                      AS 'Kode', " +
                  "D.Disposisi                                                          AS 'Disposisi', " +
                  "UP.NamaUnit                                                          AS 'Unit Produksi' " +
                  "FROM tqcdisposisi D " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = D.KodeUnit " +
                  "WHERE CONCAT(D.KodeDisposisi, ' ', D.Disposisi) LIKE @Kriteria "

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL)
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

