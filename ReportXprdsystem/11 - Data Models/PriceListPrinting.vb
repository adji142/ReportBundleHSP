Imports Dapper

Namespace HSP.Data
    Public Class PriceListPrinting
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Harga1 As Double
        Public Property Harga2 As Double
        Public Property Harga3 As Double
        Public Property Harga4 As Double
    End Class

    Public Class DaftarPriceListPrinting
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As PriceListPrinting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tpricelist_printing " +
                  "(KodeItem, NamaItem, Harga1, Harga2, Harga3) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @Harga1, @Harga2, @Harga3)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As PriceListPrinting) As Integer
            Dim SQL As String

            SQL = "UPDATE tpricelist_printing SET " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "Harga1 = @Harga1, Harga2 = @Harga2, Harga3 = @Harga3 " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal ID As String) As PriceListPrinting
            Dim SQL As String

            SQL = "SELECT * FROM tpricelist_printing " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of PriceListPrinting)(SQL, New With {.KodeItem = ID}).FirstOrDefault
            End Using
        End Function
    End Class
End Namespace

