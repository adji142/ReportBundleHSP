Imports Dapper

Namespace HSP.Data
    Public Class ShiftProduksi
        Public Property KodeShift As String
        Public Property NamaShift As String
        Public Property Mulai As DateTime
        Public Property Selesai As DateTime
    End Class

    Public Class DaftarShiftProduksi : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As ShiftProduksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tshiftproduksi " +
                  "(KodeShift, NamaShift, Mulai, Selesai) " +
                  "VALUES " +
                  "(@KodeShift, @NamaShift, @Mulai, @Selesai)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As ShiftProduksi) As Integer
            Dim SQL As String

            SQL = "UPDATE tshiftproduksi SET " +
                  "KodeShift = @KodeShift, " +
                  "NamaShift = @NamaShift, " +
                  "Mulai = @Mulai, " +
                  "Selesai = @Selesai " +
                  "WHERE KodeShift = @KodeShift"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tshiftproduksi " +
                  "WHERE KodeShift = @KodeShift"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeShift = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As ShiftProduksi
            Dim SQL As String

            SQL = "SELECT * FROM tshiftproduksi " +
                  "WHERE KodeShift = @KodeShift"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ShiftProduksi)(SQL, New With {.KodeShift = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeShift                                    AS 'Kode', " +
                  "NamaShift                                    AS 'Nama Shift', " +
                  "Mulai                                        AS 'Mulai', " +
                  "Selesai                                      AS 'Selesai' " +
                  "FROM tshiftproduksi " +
                  "WHERE CONCAT(KodeShift, ' ', NamaShift) LIKE @Kriteria"

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
                  "KodeShift                                    AS 'Kode', " +
                  "NamaShift                                    AS 'Nama Shift' " +
                  "FROM tshiftproduksi " +
                  "WHERE CONCAT(KodeShift, ' ', NamaShift) LIKE @Kriteria"

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

