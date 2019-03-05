Imports Dapper
Imports ReportBundleHSP.HSP.Data

Public Class MutasiRoll
    Public Property RowID As String
    Public Property NoTransaksi As String
    Public Property TglTransaksi As DateTime
    Public Property LokasiAsal As String
    Public Property LokasiTujuan As String
    Public Property KodeProduksi As String
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property UserID As String
    Public Property TRX As String
End Class

Public Class DaftarMutasiRoll
    Private _DBConnection As DBConnection

    Sub New(ByVal Session As Object)
        _DBConnection = New DBConnection(Session)
    End Sub

    Public Function Add(ByVal Data As MutasiRoll) As Integer
        Dim SQL As String

        SQL = "INSERT INTO mutasiroll " +
               "(RowID, NoTransaksi, TglTransaksi, LokasiAsal, LokasiTujuan, " +
               "KodeProduksi, KodeItem, NamaItem, UserID, TRX) " +
               "VALUES " +
               "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @LokasiAsal, @LokasiTujuan, " +
               "@KodeProduksi, @KodeItem, @NamaItem, @UserID, '" + TRX() + "')"

        Using DBX As IDbConnection = _DBConnection.Connection
            Add = DBX.Execute(SQL, Data)
        End Using
    End Function

    Public Function Read(ByVal Kriteria As String, ByVal TglAwal As DateTime, ByVal TglAkhir As DateTime) As DataSet
        Dim SQL As String

        SQL = "SELECT " +
              "MR.NoTransaksi                                       AS 'Nomor', " +
              "MR.TglTransaksi                                      AS 'Tanggal', " +
              "LPA.NamaLokasi                                       AS 'Lokasi Asal', " +
              "LPT.NamaLokasi                                       AS 'Lokasi Tujuan', " +
              "MR.KodeProduksi                                      AS 'Kode Produksi', " +
              "MR.NamaItem                                          AS 'Item Produksi' " +
              "FROM mutasiroll MR " +
              "LEFT JOIN tlokasiproduksi LPA ON LPA.KodeLokasi = MR.LokasiAsal " +
              "LEFT JOIN tlokasiproduksi LPT ON LPT.KodeLokasi = MR.LokasiTujuan " +
              "WHERE CONCAT(MR.NoTransaksi, ' ', " +
              "             MR.KodeProduksi, ' ', " +
              "             MR.NamaItem) LIKE @Kriteria "

        SQL += "AND TglTransaksi BETWEEN @TglAwal AND @TglAkhir"

        Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

        Using DBX As IDbConnection = _DBConnection.Connection
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
            Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
            Dim DS As New DataSet

            CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
            CMD.Parameters.AddWithValue("@TglAwal", TglAwal)
            CMD.Parameters.AddWithValue("@TglAkhir", TglAkhir)
            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
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
            Prefik = "LMMR-" + Periode
            '------------------------------------------------------------------------------------------

            'Nomor Transaksi
            '------------------------------------------------------------------------------------------
            SQL = "SELECT COUNT(*) AS Total FROM mutasiroll " +
                  "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

            Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
            Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
            '------------------------------------------------------------------------------------------

        End Using
        GetNomorTransaksi = Prefik + Nomor

    End Function
End Class
