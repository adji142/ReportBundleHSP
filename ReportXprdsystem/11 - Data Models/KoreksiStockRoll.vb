Imports Dapper

Namespace HSP.Data
    Public Class KoreksiStockRoll
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property NoRef As String
        Public Property KodeProduksi As String
        Public Property UnitPeruntukanLama As String
        Public Property KeteranganLama As String
        Public Property UnitPeruntukanBaru As String
        Public Property KeteranganBaru As String
        Public Property AlasanPerubahan As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarKoreksiStockRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KoreksiStockRoll) As Integer
            Dim SQL As String

            SQL = "INSERT INTO koreksistockroll " +
                  "(RowID, NoTransaksi, TglTransaksi, NoRef, KodeProduksi, " +
                  "UnitPeruntukanLama, KeteranganLama, UnitPeruntukanBaru, KeteranganBaru, AlasanPerubahan, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @NoRef, @KodeProduksi, " +
                  "@UnitPeruntukanLama, @KeteranganLama, @UnitPeruntukanBaru, @KeteranganBaru, @AlasanPerubahan, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        'Get Nomor Transaksi Masuk
        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "KRSR-" + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM koreksistockroll " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

