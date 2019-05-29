Imports Dapper

Namespace HSP.Data
    Public Class DaftarUnitProduksiPeruntukan : Implements IDataLookup

        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function ReadDetail(ByVal KodeUnit As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "UK.KodeUnit                              AS 'Kode', " +
                  "UK.KodeUnitPeruntukan                    AS 'Peruntukan', " +
                  "UP.NamaUnit                              AS 'Nama Unit Peruntukan' " +
                  "FROM tunitproduksi_peruntukan UK " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = UK.KodeUnitPeruntukan " +
                  "WHERE UK.KodeUnit='" + KodeUnit + "'"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Kodeunit As String = Parameter(0)

            SQL = "SELECT " +
                  "UK.KodeUnitPeruntukan                    AS 'Peruntukan', " +
                  "UP.NamaUnit                              AS 'Nama Unit Peruntukan' " +
                  "FROM tunitproduksi_peruntukan UK " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = UK.KodeUnitPeruntukan " +
                  "WHERE UK.KodeUnit='" + KodeUnit + "'"

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
    End Class
End Namespace

