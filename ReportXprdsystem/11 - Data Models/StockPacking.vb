Imports Dapper

Namespace HSP.Data
    Public Class StockPacking

        Public Enum enumKelompokPackingPcs
            PackingKarung = 1
            PackingCementBag = 2
        End Enum

        Public Property RowID As String
        Public Property Kelompok As enumKelompokPackingPcs
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglTimbang As DateTime
        Public Property NomorWO As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeUnit As String
        Public Property KodeMesin As String
        Public Property KodeLokasi As String
        Public Property KodeProduksi As String
        Public Property BeratBrutto As Double
        Public Property KodeMedia As String
        Public Property BeratMedia As Double
        Public Property BeratNetto As Double
        Public Property BeratStandar As Double
        Public Property Pcs As Double
        Public Property StatusStock As Byte
        Public Property StatusQc As Byte
        Public Property KodeStatus As String
        Public Property StatusDisposisi As Byte
        Public Property KodeDisposisi As String
        Public Property Keterangan As String
        Public Property UserID As String
        Public Property TRX As String
        'Public Property StatusData As String
    End Class

    Public Class DaftarStockPacking
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As StockPacking) As Integer
            Dim SQL As String

            SQL = "INSERT INTO stockpacking " +
                  "(RowID, Kelompok, NoTransaksi, TglTransaksi, TglTimbang, NomorWO, KodeItem, NamaItem, KodeShift, " +
                  "KodeGrup, KodeUnit, KodeMesin, KodeLokasi, KodeProduksi, BeratBrutto, " +
                  "KodeMedia, BeratMedia, BeratNetto, BeratStandar, Pcs, StatusStock, " +
                  "StatusQc, KodeStatus, StatusDisposisi, KodeDisposisi, " +
                  "Keterangan, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @Kelompok, @NoTransaksi, @TglTransaksi, @TglTimbang, @NomorWO, @KodeItem, @NamaItem, @KodeShift, " +
                  "@KodeGrup, @KodeUnit, @KodeMesin, @KodeLokasi, @KodeProduksi, @BeratBrutto, " +
                  "@KodeMedia, @BeratMedia, @BeratNetto, @BeratStandar, @Pcs, @StatusStock, " +
                  "@StatusQc, @KodeStatus, @StatusDisposisi, @KodeDisposisi, " +
                  "@Keterangan, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal KodeProduksi As String, Optional First As Boolean = False) As StockPacking
            Dim SQL As String

            If First Then
                SQL = "SELECT * FROM stockpacking " +
                                  "WHERE KodeProduksi = @KodeProduksi ORDER BY TglTimbang ASC LIMIT 1"
            Else
                SQL = "SELECT * FROM stockpacking " +
                                  "WHERE StatusStock = 1 AND KodeProduksi = @KodeProduksi "
            End If

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of StockPacking)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindExist(ByVal KodeProduksi As String) As StockPacking
            Dim SQL As String

            SQL = "SELECT * FROM stockpacking " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindExist = DBX.Query(Of StockPacking)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastID(ByVal KodeProduksi As String) As StockPacking
            Dim SQL As String

            SQL = "SELECT * FROM stockpacking " +
                  "WHERE KodeProduksi = @KodeProduksi " +
                  "ORDER BY TglTimbang DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastID = DBX.Query(Of StockPacking)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastProductionID(Kodeunit As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT KodeProduksi FROM stockpacking " +
                  "WHERE KodeUnit='" + Kodeunit + "' " +
                  "ORDER BY TglTimbang DESC, NoTransaksi DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastProductionID = DBX.Query(Of StockRoll)(SQL).FirstOrDefault
            End Using
        End Function


        Public Function UpdateStatus(ByVal KodeProduksi As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockpacking SET " +
                  "StatusStock = 0 " +
                  "WHERE StatusStock = 1 AND KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateStatus = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi})
            End Using
        End Function

        Public Function ReadStock(ByVal Kriteria As String, Kelompok As Byte, KodeLokasi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "R.KodeProduksi 				                AS 'Kode Produksi', " +
                  "R.NomorWO 				                    AS 'Nomor WO', " +
                  "R.KodeItem 				                    AS 'Kode Item', " +
                  "R.NamaItem 				                    AS 'Nama Item', " +
                  "R.Pcs					                    AS 'Lembar', " +
                  "R.BeratNetto				                    AS 'Kilogram', " +
                  "IF(R.StatusQc = 0, '-', " +
                  "IF(R.StatusQc = 1, 'OK', " +
                  "IF(R.StatusQc = 2, 'NON OK', " +
                  "IF(R.StatusQc = 3, 'OVER', " +
                  "IF(R.StatusQc = 4, 'UNDER', '???')))))       AS 'Status QC', " +
                  "R.TglTimbang				                    AS 'Tgl Produksi', " +
                  "U.NamaUnit                                   AS 'Produksi' " +
                  "FROM stockpacking R " +
                  "LEFT JOIN tunitproduksi U ON U.KodeUnit = R.KodeUnit " +
                  "WHERE R.StatusStock = 1 AND CONCAT(R.KodeProduksi, ' ', " +
                  "             R.KodeProduksi, ' ', " +
                  "             R.NamaItem, ' ', " +
                  "             U.NamaUnit) LIKE @Kriteria "

            SQL += " AND R.Kelompok = " & Kelompok.ToString & " "
            SQL += " AND R.KodeLokasi = '" & KodeLokasi & "' "
            SQL += " ORDER BY R.KodeProduksi "


            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadStock = DS
            End Using

        End Function

        Public Function Read(ByVal Kriteria As String, ByVal Status As Byte, Optional KodeLokasi As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "R.KodeProduksi                                     AS 'Kode', " +
                  "R.KodeItem                                         AS 'Kode Item', " +
                  "R.NamaItem                                         AS 'Nama Item', " +
                  "U.NamaUnit                                         AS 'Hasil Produksi', " +
                  "R.BeratStandar                                     AS 'Berat Standar', " +
                  "R.BeratNetto                                       AS 'Berat Netto', " +
                  "IF(R.StatusQC=0, 'INSPEKSI', " +
                  "IF(R.StatusQC=1, 'OK', " +
                  "IF(R.StatusQC=2, 'NON OK', " +
                  "IF(R.StatusQC=3, 'BERAT OVER', " +
                  "IF(R.StatusQC=4, 'BERAT UNDER','-')))))            AS 'Status' " +
                  "FROM stockpacking R " +
                  "LEFT JOIN tunitproduksi U ON U.KodeUnit = R.KodeUnit " +
                  "WHERE R.StatusStock = 1 AND CONCAT(R.KodeProduksi, ' ', " +
                  "             R.NamaItem, ' ', " +
                  "             U.NamaUnit) LIKE @Kriteria "

            Select Case Status
                Case 0
                    SQL += "AND R.StatusQc = 0 "
                Case 1
                    SQL += "AND R.StatusQc IN (2,3,4) AND StatusDisposisi = 0 "
                Case 2
                    SQL += "AND R.StatusQc =1 OR StatusDisposisi = 1 "
            End Select

            If KodeLokasi <> "" Then
                SQL += "AND R.KodeLokasi = '" & KodeLokasi & "'"
            End If

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using
        End Function

        Public Function UpdateQCInspeksi(ByVal KodeProduksi As String, _
                                         ByVal StatusQC As Byte, _
                                         ByVal KodeStatus As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockpacking SET " +
                  "StatusQC = " + StatusQC.ToString + ", " +
                  "KodeStatus = '" + KodeStatus + "'" +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateQCInspeksi = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi})
            End Using
        End Function

        Public Function UpdateQCDisposisi(ByVal KodeProduksi As String, _
                                          ByVal KodeDisposisi As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockpacking SET " +
                  "StatusDisposisi = 1, " +
                  "KodeDisposisi = '" + KodeDisposisi + "' " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateQCDisposisi = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi})
            End Using
        End Function

        'Get Kode Produksi Timbang Roll Masuk
        Public Function GetKodeProduksi(KodeUnit As String, ByVal KodeMesin As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Prefik Nomor Transaksi
            '------------------------------------------------------------------------------------------
            Prefik = New DaftarUnitProduksi(ActiveSession).Find(KodeUnit).PrefikKodeProduksi.Trim() + Periode
            '------------------------------------------------------------------------------------------

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM stockpacking " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(11 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetKodeProduksi = Prefik + KodeMesin + Nomor

        End Function
    End Class
End Namespace

