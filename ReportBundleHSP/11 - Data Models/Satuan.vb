Imports Dapper

Namespace HSP.Data
    Public Class Satuan
        Public Property KodeSatuan As String
        Public Property NamaSatuan As String
    End Class

    Public Class DaftarSatuan : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As Satuan) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tsatuan " +
                  "(KodeSatuan, NamaSatuan) " +
                  "VALUES " +
                  "(@KodeSatuan, @NamaSatuan)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As Satuan) As Integer
            Dim SQL As String

            SQL = "UPDATE tsatuan SET " +
                  "KodeSatuan = @KodeSatuan, " +
                  "NamaSatuan = @NamaSatuan " +
                  "WHERE KodeSatuan = @KodeSatuan"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tsatuan " +
                  "WHERE KodeSatuan = @KodeSatuan"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeSatuan = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As Satuan
            Dim SQL As String

            SQL = "SELECT * FROM tsatuan " +
                  "WHERE KodeSatuan = @KodeSatuan"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of Satuan)(SQL, New With {.KodeSatuan = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeSatuan                                         AS 'Kode', " +
                  "NamaSatuan                                         AS 'Satuan' " +
                  "FROM tsatuan " +
                  "WHERE CONCAT(KodeSatuan, ' ', NamaSatuan) LIKE @Kriteria "

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
                  "KodeSatuan                                         AS 'Kode', " +
                  "NamaSatuan                                         AS 'Satuan' " +
                  "FROM tsatuan " +
                  "WHERE CONCAT(KodeSatuan, ' ', NamaSatuan) LIKE @Kriteria "

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

