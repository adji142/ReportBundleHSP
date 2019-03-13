Imports Dapper

Namespace HSP.Data
    Public Class PriceList
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Harga1 As Double
        Public Property Harga2 As Double
        Public Property Harga3 As Double
        Public Property Harga4 As Double
    End Class

    Public Class DaftarPriceList
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As PriceList) As Integer
            Dim SQL As String

            SQL = "INSERT INTO tpricelist " +
                  "(KodeItem, NamaItem, Harga1, Harga2, Harga3, Harga4) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @Harga1, @Harga2, @Harga3, @Harga4)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As PriceList) As Integer
            Dim SQL As String

            SQL = "UPDATE tpricelist SET " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "Harga1 = @Harga1, Harga2 = @Harga2, Harga3 = @Harga3, Harga4 = @Harga4 " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal ID As String) As PriceList
            Dim SQL As String

            SQL = "SELECT * FROM tpricelist " +
                  "WHERE KodeItem = @KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of PriceList)(SQL, New With {.KodeItem = ID}).FirstOrDefault
            End Using
        End Function
    End Class
End Namespace

