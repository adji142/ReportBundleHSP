Imports Dapper

Namespace HSP.Data
    Public Class PengakuanRoll
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeProduksiInput As String
        Public Property KodeProduksi As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property PanjangOld As Double
        Public Property BeratOld As Double
        Public Property PanjangNew As Double
        Public Property BeratNew As Double
        Public Property KodeUnit As String
        Public Property KodeUnitPeruntukan As String
        Public Property Keterangan As String
        Public Property UserID As String
    End Class

    Public Class DaftarPengakuanRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As PengakuanRoll) As Integer
            Dim SQL As String

            SQL = "INSERT INTO pengakuanroll " +
                  "(RowID, NoTransaksi, TglTransaksi, KodeProduksiInput, KodeProduksi, KodeItem, NamaItem, " +
                  "PanjangOld, BeratOld, PanjangNew, BeratNew, KodeUnit, KodeUnitPeruntukan, Keterangan, UserID) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @KodeProduksiInput, @KodeProduksi, @KodeItem, @NamaItem, " +
                  "@PanjangOld, @BeratOld, @PanjangNew, @BeratNew, @KodeUnit, @KodeUnitPeruntukan, @Keterangan, @UserID)"

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
                SQL = "SELECT COUNT(*) AS Total FROM pengakuanroll " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

