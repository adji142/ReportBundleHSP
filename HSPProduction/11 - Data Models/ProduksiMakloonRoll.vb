Imports Dapper

Namespace HSP.Data
    Public Class ProduksiMakloonRoll
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeShift As String
        Public Property KodeUnit As String
        Public Property KodeUnitPeruntukan As String
        Public Property Keterangan As String
        Public Property KodeLokasi As String
        Public Property KodeProduksi As String
        Public Property BeratNetto As Double
        Public Property Panjang As Double
        Public Property StatusQC As Byte
        Public Property UserID As String
        Public Property TRX As String
        Public Property StatusTransaksi As Byte
    End Class

    Public Class DaftarProduksiMakloonRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As ProduksiMakloonRoll) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksimakloonroll " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, KodeItem, NamaItem, KodeShift, KodeUnit, " +
                  "KodeUnitPeruntukan, Keterangan, KodeLokasi, KodeProduksi, BeratNetto, Panjang, StatusQC, UserID, TRX, StatusTransaksi) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeItem, @NamaItem, @KodeShift, @KodeUnit, " +
                  "@KodeUnitPeruntukan, @Keterangan, @KodeLokasi, @KodeProduksi, @BeratNetto, @Panjang, @StatusQC, @UserID, '" + TRX() + "', @StatusTransaksi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
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
                SQL = "SELECT COUNT(*) AS Total FROM produksimakloonroll " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

