Imports Dapper
Imports HSPProduction.HSP.Data

Public Class HeaderMutasiAreaBenang
    Public Property RowID As String
    Public Property NoTransaksi As String
    Public Property TglTransaksi As DateTime
    Public Property KodeLokasi As String
    Public Property KodeAreaAsal As String
    Public Property KodeAreaTujuan As String
    Public Property Keterangan As String
    Public Property UserID As String
    Public Property TRX As String
End Class

Public Class DetailMutasiAreaBenang
    Public Property RowID As String
    Public Property NoTransaksi As String
    Public Property NoUrut As Integer
    Public Property KodeProduksi As String
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property QtyUnit As Double
    Public Property QtyTimbang As Double
    Public Property KodeLokasiAsal As String
    Public Property KodeLokasiTujuan As String
End Class

Public Class DaftarMutasiAreaBenang
    Private _DBConnection As DBConnection

    Sub New(ByVal Session As Object)
        _DBConnection = New DBConnection(Session)
    End Sub

    Public Function AddHeader(ByVal Data As HeaderMutasiAreaBenang) As Integer
        Dim SQL As String

        SQL = "INSERT INTO headermutasiareabenang " +
              "(RowID, NoTransaksi, TglTransaksi, KodeLokasi, KodeAreaAsal, KodeAreaTujuan, Keterangan, UserID, TRX) " +
              "VALUES " +
              "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @KodeLokasi, @KodeAreaAsal, @KodeAreaTujuan, @Keterangan, @UserID, '" + TRX() + "')"

        Using DBX As IDbConnection = _DBConnection.Connection
            AddHeader = DBX.Execute(SQL, Data)
        End Using
    End Function

    Public Function AddDetail(ByVal Data As DetailMutasiAreaBenang) As Integer
        Dim SQL As String

        SQL = "INSERT INTO detailmutasiareabenang " +
              "(RowID, NoTransaksi, NoUrut, KodeProduksi, KodeItem, NamaItem, QtyUnit, QtyTimbang, KodeLokasiAsal, KodeLokasiTujuan) " +
              "VALUES " +
              "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeProduksi, @KodeItem, @NamaItem, @QtyUnit, @QtyTimbang, @KodeLokasiAsal, @KodeLokasiTujuan)"

        Using DBX As IDbConnection = _DBConnection.Connection
            AddDetail = DBX.Execute(SQL, Data)
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
            SQL = "SELECT COUNT(*) AS Total FROM headermutasiareabenang " +
                  "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

            Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
            Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
            '------------------------------------------------------------------------------------------

        End Using
        GetNomorTransaksi = Prefik + Nomor

    End Function
End Class

