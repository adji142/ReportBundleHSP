Imports Dapper

Namespace HSP.Data
    Public Class ProduksiCutting

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
        Public Property RMKodeProduksi As String
        Public Property RMKodeItem As String
        Public Property RMNamaItem As String
        Public Property RMPanjangPotong As Double
        Public Property RMStockPanjang As Double
        Public Property RMStockBerat As Double
        Public Property RMStockPcs As Double
        Public Property RMPemakaianPanjang As Double
        Public Property RMPemakaianBerat As Double
        Public Property RMPemakaianPcs As Double
        Public Property RMSisaPanjang As Double
        Public Property RMSisaBerat As Double
        Public Property RMSisaPcs As Double

        Public Property SBKodeProduksi As String
        Public Property SBPanjang As Double
        Public Property SBPcs As Double
        Public Property SBBeratBrutto As Double
        Public Property SBBeratNetto As Double
        Public Property SBKodeMedia As String
        Public Property SBBeratMedia As Double

        Public Property UserID As String
        Public Property TRX As String

    End Class

    Public Class DaftarProduksiCutting
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiCutting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksicutting " +
                  "     (RowID, " +
                  "     NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnitSAP, KodeUnit, KodeShift, KodeGrup, KodeMesin, ShiftSebelumnya, " +
                  "     FGKodeLokasi, FGKodeItem, FGNamaItem, FGPcs, FGBs, FGTotal, FGKodeUnitPeruntukan, FGKeterangan, " +
                  "     RMKodeLokasi, RMKodeProduksi, RMKodeItem, RMNamaItem, RMPanjangPotong, RMStockPanjang, RMStockBerat, RMStockPcs, RMPemakaianPanjang, RMPemakaianBerat, RMPemakaianPcs, RMSisaPanjang, RMSisaBerat, RMSisaPcs, " +
                  "     SBKodeProduksi, SBPanjang, SBPcs, SBBeratBrutto, SBBeratNetto, SBKodeMedia, SBBeratMedia, " +
                  "     UserID, TRX) " +
                  "VALUES " +
                  "     (REPLACE(UUID(),'-',''), " +
                  "     @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnitSAP, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @ShiftSebelumnya, " +
                  "     @FGKodeLokasi, @FGKodeItem, @FGNamaItem, @FGPcs, @FGBs, @FGTotal, @FGKodeUnitPeruntukan, @FGKeterangan, " +
                  "     @RMKodeLokasi, @RMKodeProduksi, @RMKodeItem, @RMNamaItem, @RMPanjangPotong,  @RMStockPanjang, @RMStockBerat, @RMStockPcs, @RMPemakaianPanjang, @RMPemakaianBerat, @RMPemakaianPcs, @RMSisaPanjang, @RMSisaBerat, @RMSisaPcs, " +
                  "     @SBKodeProduksi, @SBPanjang, @SBPcs, @SBBeratBrutto, @SBBeratNetto, @SBKodeMedia, @SBBeratMedia, " +
                  "     @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal NoTransaksi As String) As ProduksiCutting
            Dim SQL As String

            SQL = "SELECT * FROM produksicutting " +
                  "WHERE StatusTransaksi = 1 AND NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ProduksiCutting)(SQL, New With {.NoTransaksi = NoTransaksi}).FirstOrDefault
            End Using
        End Function

        Public Function ReadTransaction(TglAwal As Date, TglAkhir As Date, ByVal Kriteria As String, KodeLokasi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "NoTransaksi  				            AS 'No.Transaksi', " +
                  "TglTransaksi  				            AS 'Tanggal', " +
                  "NomorWO 				                    AS 'Nomor WO', " +
                  "FGKodeItem 				                AS 'Kode Item', " +
                  "FGNamaItem 				                AS 'Nama Item', " +
                  "FGPcs					                AS 'PCS', " +
                  "FGBS				                        AS 'BS', " +
                  "FGTotal				                    AS 'Total', " +
                  "RMKodeProduksi				            AS 'Roll Bahan', " +
                  "CONCAT(KodeShift,'/',KodeGrup)           AS 'S/G', " +
                  "UserID                                   AS 'User' " +
                  "FROM produksicutting " +
                  "WHERE StatusTransaksi = 1 AND CONCAT(NomorWO, ' ', " +
                  "      FGKodeItem, ' ', " +
                  "      FGNamaItem, ' ', " +
                  "      RMKodeProduksi) LIKE @Kriteria "

            SQL += "AND FGKodeLokasi = '" & KodeLokasi & "' "
            SQL += "AND TglTransaksi BETWEEN @TglAwal AND @TglAkhir "
            SQL += "ORDER BY NoTransaksi DESC"


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

                ReadTransaction = DS
            End Using

        End Function

        'Read
        Public Function ReadPanjangPotongNol() As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM produksicutting WHERE RMPanjangPotong = 0  "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadPanjangPotongNol = DS
            End Using
        End Function

        Public Function FindQtyHasil(NomorWO As String) As ProduksiCutting
            Dim SQL As String

            SQL = "SELECT IFNULL(SUM(FGPcs),0) AS QtyHasil FROM produksicutting " +
                  "WHERE NomorWO ='" + NomorWO + "' AND StatusTransaksi =1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                Dim Temp As ProduksiCutting = Nothing

                If DR.Read Then
                    Temp = New ProduksiCutting
                    Temp.FGPcs = DR("QtyHasil")
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
                Prefik = "PFCT-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksicutting " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

