Imports Dapper

Namespace HSP.Data
    Public Class TempStockSAP
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeProduksi As String
        Public Property Qty As Double
    End Class

    Public Class DaftarTempStock
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TempStockSAP) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tempitemstocksap " +
                  "(KodeItem, NamaItem, KodeProduksi, Qty) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @KodeProduksi, @Qty)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete() As Integer
            Dim SQL As String

            SQL = "DELETE FROM tempitemstocksap "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL)
            End Using
        End Function
    End Class
End Namespace

