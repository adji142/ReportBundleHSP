Imports Dapper

Namespace HSP.Data
    Public Class ProduksiSlitting

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
        Public Property FGKodeItem As String
        Public Property FGNamaItem As String
        Public Property FGRoll As Double
        Public Property FGPanjang As Double
        Public Property FGBeratBrutto As Double
        Public Property FGBeratNetto As Double
        Public Property FGKodeMedia As String
        Public Property FGBeratMedia As Double
        Public Property FGKeterangan As String

        Public Property RMKodeLokasi As String
        Public Property RMKodeProduksi As String
        Public Property RMKodeItem As String
        Public Property RMNamaItem As String
        Public Property RMStockPanjang As Double
        Public Property RMStockBerat As Double
        Public Property RMPemakaianPanjang As Double
        Public Property RMPemakaianBerat As Double
        Public Property RMSisaPanjang As Double
        Public Property RMSisaBerat As Double

        Public Property SBKodeProduksi As String
        Public Property SBPanjang As Double
        Public Property SBBeratBrutto As Double
        Public Property SBBeratNetto As Double
        Public Property SBKodeMedia As String
        Public Property SBBeratMedia As Double

        Public Property UserID As String
        Public Property TRX As String

    End Class

    Public Class DaftarProduksiSlitting
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiSlitting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksislitting " +
                  "     (RowID, " +
                  "     NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnitSAP, KodeUnit, KodeShift, KodeGrup, KodeMesin, ShiftSebelumnya, " +
                  "     FGKodeLokasi, FGKodeItem, FGNamaItem, FGRoll, FGPanjang, FGBeratBrutto, FGBeratNetto, FGKodeMedia, FGBeratMedia, FGKeterangan, " +
                  "     RMKodeLokasi, RMKodeProduksi, RMKodeItem, RMNamaItem, RMStockPanjang, RMStockBerat, RMPemakaianPanjang, RMPemakaianBerat, RMSisaPanjang, RMSisaBerat, " +
                  "     SBKodeProduksi, SBPanjang, SBBeratBrutto, SBBeratNetto, SBKodeMedia, SBBeratMedia, " +
                  "     UserID, TRX) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), " +
                  "     @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnitSAP, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @ShiftSebelumnya, " +
                  "     @FGKodeLokasi, @FGKodeItem, @FGNamaItem, @FGRoll, @FGPanjang, @FGBeratBrutto, @FGBeratNetto, @FGKodeMedia, @FGBeratMedia, @FGKeterangan, " +
                  "     @RMKodeLokasi, @RMKodeProduksi, @RMKodeItem, @RMNamaItem, @RMStockPanjang, @RMStockBerat, @RMPemakaianPanjang, @RMPemakaianBerat, @RMSisaPanjang, @RMSisaBerat, " +
                  "     @SBKodeProduksi, @SBPanjang, @SBBeratBrutto, @SBBeratNetto, @SBKodeMedia, @SBBeratMedia, " +
                  "     @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
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
                Prefik = "PFSL-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS BeratBrutto FROM produksislitting " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.BeratBrutto + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

