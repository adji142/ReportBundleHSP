Imports Dapper

Namespace HSP.Data
    Public Class KeteranganToleransi
        Public Property KodeKeterangan As String
        Public Property NamaKeterangan As String
        Public Property Toleransi As Double
    End Class

    Public Class DaftarKeteranganToleransi : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KeteranganToleransi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tkettoleransi " +
                  "(KodeKeterangan, NamaKeterangan, Toleransi) " +
                  "VALUES " +
                  "(@KodeKeterangan, @NamaKeterangan, @Toleransi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As KeteranganToleransi) As Integer
            Dim SQL As String

            SQL = "UPDATE tkettoleransi SET " +
                  "KodeKeterangan = @KodeKeterangan, " +
                  "NamaKeterangan = @NamaKeterangan, " +
                  "Toleransi      = @Toleransi " +
                  "WHERE KodeKeterangan = @KodeKeterangan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tkettoleransi " +
                  "WHERE KodeKeterangan = @KodeKeterangan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeKeterangan = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As KeteranganToleransi
            Dim SQL As String

            SQL = "SELECT * FROM tkettoleransi " +
                  "WHERE KodeKeterangan = @KodeKeterangan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of KeteranganToleransi)(SQL, New With {.KodeKeterangan = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KS.KodeKeterangan                                            AS 'Kode', " +
                  "KS.NamaKeterangan                                            AS 'Keterangan' " +
                  "FROM tkettoleransi KS " +
                  "WHERE CONCAT(KS.KodeKeterangan, ' ', KS.NamaKeterangan) LIKE @Kriteria "

            Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%")

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
                  "KS.KodeKeterangan                                            AS 'Kode', " +
                  "KS.NamaKeterangan                                            AS 'Keterangan' " +
                  "FROM tkettoleransi KS " +
                  "WHERE CONCAT(KS.KodeKeterangan, ' ', KS.NamaKeterangan) LIKE @Kriteria "

            TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                GetLookup = DS
            End Using
        End Function
    End Class
End Namespace

