Imports Dapper

Namespace HSP.Data
    Public Class KeteranganStatus
        Public Property KodeKeterangan As String
        Public Property Keterangan As String
        Public Property KodeUnit As String
    End Class

    Public Class DaftarKeteranganStatus : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KeteranganStatus) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tketeranganstatus " +
                  "(KodeKeterangan, Keterangan, KodeUnit) " +
                  "VALUES " +
                  "(@KodeKeterangan, @Keterangan, @KodeUnit)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As KeteranganStatus) As Integer
            Dim SQL As String

            SQL = "UPDATE tketeranganstatus SET " +
                  "KodeKeterangan = @KodeKeterangan, " +
                  "Keterangan = @Keterangan, " +
                  "KodeUnit = @KodeUnit " +
                  "WHERE KodeKeterangan = @KodeKeterangan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tketeranganstatus " +
                  "WHERE KodeKeterangan = @KodeKeterangan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeKeterangan = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As KeteranganStatus
            Dim SQL As String

            SQL = "SELECT * FROM tketeranganstatus " +
                  "WHERE KodeKeterangan = @KodeKeterangan "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of KeteranganStatus)(SQL, New With {.KodeKeterangan = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KS.KodeKeterangan                                            AS 'Kode', " +
                  "KS.Keterangan                                                AS 'Keterangan', " +
                  "UP.NamaUnit                                                  AS 'Unit Produksi' " +
                  "FROM tketeranganstatus KS " +
                  "WHERE CONCAT(KS.KodeKeterangan, ' ', KS.Keterangan) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND KS.KodeUnit='" + KodeUnit + "'"
            End If

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
                  "KS.Keterangan                                                AS 'Keterangan', " +
                  "UP.NamaUnit                                                  AS 'Unit Produksi' " +
                  "FROM tketeranganstatus KS " +
                  "WHERE CONCAT(KS.KodeKeterangan, ' ', KS.Keterangan) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND KS.KodeUnit='" + KodeUnit + "'"
            End If

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

