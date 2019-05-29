Imports Dapper

Namespace HSP.Data
    Public Class ProduksiPrintingRoll

        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As Date
        Public Property TglPencatatan As Date
        Public Property NomorWO As String
        Public Property KodeUnitSAP As String
        Public Property KodeUnit As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeMesin As String
        Public Property ShiftSebelumnya As Byte

        Public Property FGKodeLokasi As String
        Public Property FGKodeProduksi As String
        Public Property FGKodeItem As String
        Public Property FGNamaItem As String
        Public Property FGPanjang As Double
        Public Property FGBeratBrutto As Double
        Public Property FGBeratNetto As Double
        Public Property FGKodeMedia As String
        Public Property FGBeratMedia As Double
        Public Property FGKodeUnitPeruntukan As String
        Public Property FGKeterangan As String

        Public Property RM1KodeLokasi As String
        Public Property RM1KodeProduksi As String
        Public Property RM1KodeItem As String
        Public Property RM1NamaItem As String
        Public Property RM1StockPanjang As Double
        Public Property RM1StockBerat As Double
        Public Property RM1PemakaianPanjang As Double
        Public Property RM1PemakaianBerat As Double
        Public Property RM1SisaPanjang As Double
        Public Property RM1SisaBerat As Double

        Public Property RM2KodeLokasi As String
        Public Property RM2KodeProduksi As String
        Public Property RM2KodeItem As String
        Public Property RM2NamaItem As String
        Public Property RM2StockPanjang As Double
        Public Property RM2StockBerat As Double
        Public Property RM2PemakaianPanjang As Double
        Public Property RM2PemakaianBerat As Double
        Public Property RM2SisaPanjang As Double
        Public Property RM2SisaBerat As Double

        Public Property SBKodeProduksi As String
        Public Property SBPanjang As Double
        Public Property SBBeratBrutto As Double
        Public Property SBBeratNetto As Double
        Public Property SBKodeMedia As String
        Public Property SBBeratMedia As Double

        Public Property SisaDiMesin As Byte

        Public Property UserID As String
        Public Property TRX As String

        Public Property KodeKaryawan As String

    End Class

    Public Class DaftarProduksiPrintingRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiPrintingRoll) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksiprintingroll " +
                  "     (RowID, " +
                  "     NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnitSAP, KodeUnit, KodeShift, KodeGrup, KodeMesin, ShiftSebelumnya, " +
                  "     FGKodeLokasi, FGKodeProduksi, FGKodeItem, FGNamaItem, FGPanjang, FGBeratBrutto, FGBeratNetto, FGKodeMedia, FGBeratMedia, FGKodeUnitPeruntukan, FGKeterangan, " +
                  "     RM1KodeLokasi, RM1KodeProduksi, RM1KodeItem, RM1NamaItem, RM1StockPanjang, RM1StockBerat, RM1PemakaianPanjang, RM1PemakaianBerat, RM1SisaPanjang, RM1SisaBerat, " +
                  "     RM2KodeLokasi, RM2KodeProduksi, RM2KodeItem, RM2NamaItem, RM2StockPanjang, RM2StockBerat, RM2PemakaianPanjang, RM2PemakaianBerat, RM2SisaPanjang, RM2SisaBerat, " +
                  "     SBKodeProduksi, SBPanjang, SBBeratBrutto, SBBeratNetto, SBKodeMedia, SBBeratMedia, SisaDiMesin, KodeKaryawan, " +
                  "     UserID, TRX) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), " +
                  "     @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnitSAP, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @ShiftSebelumnya, " +
                  "     @FGKodeLokasi, @FGKodeProduksi, @FGKodeItem, @FGNamaItem, @FGPanjang, @FGBeratBrutto, @FGBeratNetto, @FGKodeMedia, @FGBeratMedia, @FGKodeUnitPeruntukan, @FGKeterangan, " +
                  "     @RM1KodeLokasi, @RM1KodeProduksi, @RM1KodeItem, @RM1NamaItem, @RM1StockPanjang, @RM1StockBerat, @RM1PemakaianPanjang, @RM1PemakaianBerat, @RM1SisaPanjang, @RM1SisaBerat, " +
                  "     @RM2KodeLokasi, @RM2KodeProduksi, @RM2KodeItem, @RM2NamaItem, @RM2StockPanjang, @RM2StockBerat, @RM2PemakaianPanjang, @RM2PemakaianBerat, @RM2SisaPanjang, @RM2SisaBerat, " +
                  "     @SBKodeProduksi, @SBPanjang, @SBBeratBrutto, @SBBeratNetto, @SBKodeMedia, @SBBeratMedia, @SisaDiMesin, @KodeKaryawan, " +
                  "     @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function FindFGKodeProduksiByRMKodeProduksi(RMKodeProduksi As String) As ProduksiPrintingRoll
            Dim SQL As String

            SQL = "SELECT * FROM produksiprintingroll " +
                  "WHERE " +
                  "RM1KodeProduksi = '" + RMKodeProduksi + "' OR " +
                  "RM2KodeProduksi = '" + RMKodeProduksi + "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindFGKodeProduksiByRMKodeProduksi = DBX.Query(Of ProduksiPrintingRoll)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function FindQtyHasil(NomorWO As String) As ProduksiPrintingRoll
            Dim SQL As String

            SQL = "SELECT IFNULL(SUM(FGPanjang),0) AS QtyHasil FROM produksiprintingroll " +
                  "WHERE NomorWO ='" + NomorWO + "' AND StatusTransaksi =1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                Dim Temp As ProduksiPrintingRoll = Nothing

                If DR.Read Then
                    Temp = New ProduksiPrintingRoll
                    Temp.FGPanjang = DR("QtyHasil")
                End If

                DR.Close()

                FindQtyHasil = Temp
            End Using
        End Function

        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "PFPR-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksiprintingroll " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

