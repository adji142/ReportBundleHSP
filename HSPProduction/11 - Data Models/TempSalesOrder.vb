Imports Dapper

Namespace HSP.Data
    Public Class TempSalesOrder
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeCustomer As String
        Public Property NamaCustomer As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Quantity As Double
        Public Property Harga As Double
        Public Property Grup As String
        Public Property Printing As String
        Public Property Cabang As String
        Public Property Wilayah As String
    End Class

    Public Class DaftarTempSalesOrder
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TempSalesOrder) As Integer
            Dim SQL As String

            SQL = "INSERT INTO temp_salesorder_sap " +
                  "(NoTransaksi, TglTransaksi, KodeCustomer, NamaCustomer, KodeItem, NamaItem, Quantity, Harga, Grup, Printing, Cabang, Wilayah) " +
                  "VALUES " +
                  "(@NoTransaksi, @TglTransaksi, @KodeCustomer, @NamaCustomer, @KodeItem, @NamaItem, @Quantity, @Harga, @Grup, @Printing, @Cabang, @Wilayah) "

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Truncate() As Integer
            Dim SQL As String

            SQL = "TRUNCATE TABLE temp_salesorder_sap "

            Using DBX As IDbConnection = _DBConnection.Connection
                Truncate = DBX.Execute(SQL)
            End Using
        End Function
    End Class
End Namespace

