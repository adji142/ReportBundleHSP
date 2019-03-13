Imports Dapper

Namespace HSP.Data
    Public Class QCStatus
        Public Property KodeUnit As String
        Public Property KodeStatus As String
        Public Property Keterangan As String
    End Class

    Public Class DaftarQCStatus : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As QCStatus) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tqcstatus " +
                  "(KodeUnit, KodeStatus, Keterangan) " +
                  "VALUES " +
                  "(@KodeUnit, @KodeStatus, @Keterangan)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As QCStatus) As Integer
            Dim SQL As String

            SQL = "UPDATE tqcstatus SET " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeStatus = @KodeStatus, " +
                  "Keterangan = @Keterangan " +
                  "WHERE KodeStatus = @KodeStatus"

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM tqcstatus " +
                  "WHERE KodeStatus= @KodeStatus"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.KodeStatus = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As QCStatus
            Dim SQL As String

            SQL = "SELECT * FROM tqcstatus " +
                  "WHERE KodeStatus= @KodeStatus"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of QCStatus)(SQL, New With {.KodeStatus = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeUnit As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "D.KodeStatus                                                     AS 'Kode', " +
                  "D.Keterangan                                                     AS 'Keterangan', " +
                  "UP.NamaUnit                                                      AS 'Unit Produksi' " +
                  "FROM tqcstatus D " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = D.KodeUnit " +
                  "WHERE CONCAT(D.KodeStatus, ' ', D.Keterangan) LIKE @Kriteria "

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
                  "D.KodeStatus                                                     AS 'Kode', " +
                  "D.Keterangan                                                     AS 'Keterangan', " +
                  "UP.NamaUnit                                                      AS 'Unit Produksi' " +
                  "FROM tqcstatus D " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = D.KodeUnit " +
                  "WHERE CONCAT(D.KodeStatus, ' ', D.Keterangan) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND D.KodeUnit = '" + KodeUnit + "' "
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

