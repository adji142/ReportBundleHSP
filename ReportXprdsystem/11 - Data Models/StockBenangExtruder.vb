Imports Dapper

Namespace HSP.Data

    Public Class StockBenangExtruder
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglTimbang As DateTime
        Public Property NomorWO As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeUnit As String
        Public Property KodeMesin As String
        Public Property KodeLokasi As String
        Public Property KodeProduksi As String
        Public Property BeratNetto As Double
        Public Property StatusQC As Byte
        Public Property Satuan1 As String
        Public Property Satuan2 As String
        Public Property Satuan3 As String
        Public Property Jumlah1 As String
        Public Property Jumlah2 As String
        Public Property Jumlah3 As String
        Public Property Keterangan As String
        Public Property KodeArea As String
        Public Property InputData As Byte
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarStockBenangExtruder
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As StockBenangExtruder) As Integer
            Dim SQL As String

            SQL = "INSERT INTO stockbenangextruder " +
                  "(RowID, NoTransaksi, TglTransaksi, TglTimbang, NomorWO, KodeItem, NamaItem, KodeShift, KodeGrup, KodeUnit, KodeMesin, KodeLokasi, " +
                  "KodeProduksi, BeratNetto, StatusQC, Satuan1, Satuan2, Satuan3, Jumlah1, Jumlah2, Jumlah3, Keterangan, KodeArea, InputData, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglTimbang, @NomorWO, @KodeItem, @NamaItem, @KodeShift, @KodeGrup, @KodeUnit, @KodeMesin, @KodeLokasi, " +
                  "@KodeProduksi, @BeratNetto, @StatusQC, @Satuan1, @Satuan2, @Satuan3, @Jumlah1, @Jumlah2, @Jumlah3, @Keterangan, @KodeArea, @InputData, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal KodeProduksi As String) As StockBenangExtruder
            Dim SQL As String

            SQL = "SELECT * FROM stockbenangextruder " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of StockBenangExtruder)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function UpdateStatus(ByVal KodeProduksi As String, ByVal KodeLokasi As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockbenangextruder SET " +
                  "StatusStock = 0 " +
                  "WHERE KodeProduksi = @KodeProduksi AND KodeLokasi = @KodeLokasi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateStatus = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi, .KodeLokasi = KodeLokasi})
            End Using
        End Function

        Public Function GetLastKodeProduksi(KodeUnit As String, ByVal KodeMesin As String, ByVal Periode As String) As Integer
            Dim SQL As String
            Dim Prefik As String
            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = New DaftarUnitProduksi(ActiveSession).Find(KodeUnit).PrefikKodeProduksi.Trim() + Periode

                SQL = "SELECT COUNT(*) AS Total FROM stockbenangextruder " +
                      "WHERE LEFT(`KodeProduksi`, LENGTH(@Prefik)) = @Prefik "

                GetLastKodeProduksi = DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total
            End Using
        End Function
    End Class
End Namespace
