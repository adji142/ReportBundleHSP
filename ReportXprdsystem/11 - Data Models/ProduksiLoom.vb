Imports Dapper

Namespace HSP.Data
    Public Class ProduksiLoom
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglTimbang As DateTime
        Public Property NomorWO As String
        Public Property KodeUnitSAP As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeUnit As String
        Public Property KodeMesin As String
        Public Property KodeUnitPeruntukan As String
        Public Property Keterangan As String
        Public Property KodeLokasi As string
        Public Property KodeProduksi As String
        Public Property BeratBrutto As Double
        Public Property KodeMedia As String
        Public Property JumlahMedia As Double
        Public Property BeratMedia As Double
        Public Property BeratNetto As Double
        Public Property PanjangRoll As Double
        Public Property Pcs As Double
        Public Property BeratPerMeter As Double
        Public Property Transaksi As Byte
        Public Property StatusStock As Byte
        Public Property StatusQC As Byte
        Public Property KodeStatus As String
        Public Property StatusDisposisi As Byte
        Public Property KodeDisposisi As String
        Public Property InputData As Byte
        Public Property UserID As String
        Public Property TRX As String
        Public Property StatusTransaksi As Byte
    End Class

    Public Class DaftarProduksiLoom
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As ProduksiLoom) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksiloom " +
                  "     (RowID, NoTransaksi, TglTransaksi, TglTimbang, NomorWO, KodeUnitSAP, KodeItem, NamaItem, " +
                  "     KodeShift, KodeGrup, KodeUnit, KodeMesin, KodeUnitPeruntukan, Keterangan, KodeLokasi, " +
                  "     KodeProduksi, BeratBrutto, KodeMedia, JumlahMedia, BeratMedia, BeratNetto, PanjangRoll, Pcs, " +
                  "     BeratPerMeter, Transaksi, StatusStock, StatusQC, KodeStatus, StatusDisposisi, KodeDisposisi, " +
                  "     InputData, UserID, StatusTransaksi, TRX) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglTimbang, @NomorWO, @KodeUnitSAP, @KodeItem, @NamaItem, " +
                  "     @KodeShift, @KodeGrup, @KodeUnit, @KodeMesin, @KodeUnitPeruntukan, @Keterangan, @KodeLokasi, " +
                  "     @KodeProduksi, @BeratBrutto, @KodeMedia, @JumlahMedia, @BeratMedia, @BeratNetto, @PanjangRoll, @Pcs, " +
                  "     @BeratPerMeter, @Transaksi, @StatusStock, @StatusQC, @KodeStatus, @StatusDisposisi, @KodeDisposisi, " +
                  "     @InputData, @UserID, @StatusTransaksi, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function FindTimbang(ByVal NoTimbang As String) As ProduksiLoom
            Dim SQL As String

            SQL = "SELECT * FROM produksiloom " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindTimbang = DBX.Query(Of ProduksiLoom)(SQL, New With {.NoTransaksi = NoTimbang}).FirstOrDefault
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
                SQL = "SELECT COUNT(*) AS Total FROM produksiloom " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

        'Get Kode Produksi Timbang Roll Masuk
        Public Function GetKodeProduksi(KodeUnit As String, ByVal KodeMesin As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------

                Prefik = New DaftarUnitProduksi(ActiveSession).Find(KodeUnit).PrefikKodeProduksi.Trim() + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksiloom " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(11 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetKodeProduksi = Prefik + KodeMesin + Nomor

        End Function
    End Class
End Namespace
