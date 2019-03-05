Imports Dapper

Namespace HSP.Data
    Public Class DaftarProduksi : Implements IDataLookup

        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function ReadForAfvalManual(ByVal Tanggal As Date, ByVal KodeUnit As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "Tanggal                                 AS 'Tanggal', " +
                  "NomorWO                                 AS 'Nomor WO' " +
                  "FROM v_nomorwohasil " +
                  "WHERE Tanggal = @Tanggal AND KodeUnit = '" + KodeUnit + "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Tanggal", Tanggal)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadForAfvalManual = DS
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Tanggal As Date = Parameter(0)
            Dim KodeUnit As String = Parameter(1)

            SQL = "SELECT " +
                  "NomorWO                                 AS 'Nomor WO', " +
                  "Tanggal                                 AS 'Tanggal' " +
                  "FROM v_nomorwohasil " +
                  "WHERE Tanggal = @Tanggal AND KodeUnit = '" + KodeUnit + "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Tanggal", Tanggal)
                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function
    End Class
End Namespace

