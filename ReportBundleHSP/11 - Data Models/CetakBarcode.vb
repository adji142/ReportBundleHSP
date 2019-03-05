Imports Dapper

Namespace HSP.Data
    Public Class CetakBarcode
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeUnit As String
        Public Property KodeProduksi As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Unit As Double
        Public Property Timbang As Double
        Public Property Status As Byte
        Public Property Keterangan As String
    End Class

    Public Class DaftarCetakBarcode
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As CetakBarcode) As Integer
            Dim SQL As String

            SQL = "INSERT INTO temp_barcode " +
                  "(NoTransaksi, TglTransaksi, Kodeunit, KodeProduksi, KodeItem, NamaItem, Unit, Timbang, Status, Keterangan) " +
                  "VALUES " +
                  "(@NoTransaksi, @TglTransaksi, @Kodeunit, @KodeProduksi, @KodeItem, @NamaItem, @Unit, @Timbang, @Status, @Keterangan)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal NoTransaksi As String) As CetakBarcode
            Dim SQL As String

            SQL = "SELECT * FROM temp_barcode WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of CetakBarcode)(SQL, New With {.NoTransaksi = NoTransaksi}).FirstOrDefault
            End Using
        End Function

        'Get Nomor Transaksi Masuk
        Public Function GetNomorTransaksi(PrefikTransaksi As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = PrefikTransaksi + "-" + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM temp_barcode " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

        'Get Kode Produksi Timbang Roll Masuk
        Public Function GetKodeProduksi(KodeUnit As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------

                Prefik = KodeUnit + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM temp_barcode " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetKodeProduksi = Prefik + Nomor

        End Function
    End Class
End Namespace

