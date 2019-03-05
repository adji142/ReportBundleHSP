Imports Dapper

Namespace HSP.Data
    Public Class ProduksiInner

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
        Public Property FGPcs As Double
        Public Property FGBs As Double
        Public Property FGTotal As Double
        Public Property FGKodeUnitPeruntukan As String
        Public Property FGKeterangan As String

        Public Property RMKodeLokasi As String
        Public Property RMKodeItem As String
        Public Property RMNamaItem As String
        Public Property RMPemakaianPcs As Double

        Public Property UserID As String
        Public Property TRX As String

    End Class

    Public Class DaftarProduksiInner
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiInner) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksiinner" +
                  "     (RowID, " +
                  "     NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnitSAP, KodeUnit, KodeShift, KodeGrup, KodeMesin, ShiftSebelumnya, " +
                  "     FGKodeLokasi, FGKodeItem, FGNamaItem, FGPcs, FGBs, FGTotal, FGKodeUnitPeruntukan, FGKeterangan, " +
                  "     RMKodeLokasi, RMKodeItem, RMNamaItem, RMPemakaianPcs, " +
                  "     UserID, TRX) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), " +
                  "     @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnitSAP, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @ShiftSebelumnya, " +
                  "     @FGKodeLokasi, @FGKodeItem, @FGNamaItem, @FGPcs, @FGBs, @FGTotal, @FGKodeUnitPeruntukan, @FGKeterangan, " +
                  "     @RMKodeLokasi, @RMKodeItem, @RMNamaItem, @RMPemakaianPcs, " +
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
                Prefik = "PFJH-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksiinner " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

