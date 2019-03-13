Imports Dapper

Namespace HSP.Data

    Public Enum enumStatusQC
        qcINSPEKSI = 0
        qcOK = 1
        qcNOK = 2
        qcOVR = 3
        qcUDR = 4
    End Enum

    Public Class StockRoll
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglTimbang As DateTime
        Public Property NomorWO As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeUnit As String
        Public Property KodeUnitPeruntukan As String
        Public Property KodeMesin As String
        Public Property KodeLokasi As String
        Public Property KodeProduksi As String
        Public Property BeratBrutto As Double
        Public Property KodeMedia As String
        Public Property JumlahMedia As Double
        Public Property BeratMedia As Double
        Public Property BeratNetto As Double
        Public Property PanjangRoll As Double
        Public Property Pcs As Double
        Public Property BeratPerMeter As Double = 0
        Public Property Transaksi As Byte
        Public Property StatusStock As Byte
        Public Property StatusQc As Byte
        Public Property KodeStatus As String
        Public Property StatusDisposisi As Byte
        Public Property KodeDisposisi As String
        Public Property Satuan1 As String
        Public Property Satuan2 As String
        Public Property Satuan3 As String
        Public Property Jumlah1 As Double
        Public Property Jumlah2 As Double
        Public Property Jumlah3 As Double
        Public Property Keterangan As String
        Public Property InputData As Byte
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarStockRoll : Implements IDataLookup
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As StockRoll) As Integer
            Dim SQL As String

            SQL = "INSERT INTO stockroll " +
                  "(RowID, NoTransaksi, TglTransaksi, TglTimbang, NomorWO, KodeItem, NamaItem, KodeShift, " +
                  "KodeGrup, KodeUnit, KodeUnitPeruntukan, KodeMesin, KodeLokasi, KodeProduksi, BeratBrutto, " +
                  "KodeMedia, JumlahMedia, BeratMedia, BeratNetto, PanjangRoll, Pcs, BeratPerMeter, Transaksi, StatusStock, " +
                  "StatusQc, KodeStatus, StatusDisposisi, KodeDisposisi, Satuan1, Satuan2, Satuan3, Jumlah1, Jumlah2, Jumlah3, " +
                  "Keterangan, InputData, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglTimbang, @NomorWO, @KodeItem, @NamaItem, @KodeShift, " +
                  "@KodeGrup, @KodeUnit, @KodeUnitPeruntukan, @KodeMesin, @KodeLokasi, @KodeProduksi, @BeratBrutto, " +
                  "@KodeMedia, @JumlahMedia, @BeratMedia, @BeratNetto, @PanjangRoll, @Pcs, @BeratPerMeter, @Transaksi, @StatusStock, " +
                  "@StatusQc, @KodeStatus, @StatusDisposisi, @KodeDisposisi, @Satuan1, @Satuan2, @Satuan3, @Jumlah1, @Jumlah2, @Jumlah3, " +
                  "@Keterangan, @InputData, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal KodeProduksi As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "WHERE StatusStock = 1 AND KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of StockRoll)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindExist(ByVal KodeProduksi As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindExist = DBX.Query(Of StockRoll)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindExist(ByVal KodeProduksi As String, ByVal Kriteria As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "WHERE KodeProduksi = @KodeProduksi AND LEFT(NoTransaksi,4)='" + Kriteria + "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindExist = DBX.Query(Of StockRoll)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastID(ByVal KodeProduksi As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "WHERE KodeProduksi = @KodeProduksi " +
                  "ORDER BY TglTimbang DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastID = DBX.Query(Of StockRoll)(SQL, New With {.KodeProduksi = KodeProduksi}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastProductionID(Kodeunit As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT KodeProduksi FROM stockroll " +
                  "WHERE KodeUnit='" + Kodeunit + "' " +
                  "ORDER BY TglTimbang DESC, NoTransaksi DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastProductionID = DBX.Query(Of StockRoll)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function LastID() As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "ORDER BY TglTimbang DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                LastID = DBX.Query(Of StockRoll)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function FindTimbang(ByVal NoTimbang As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindTimbang = DBX.Query(Of StockRoll)(SQL, New With {.NoTransaksi = NoTimbang}).FirstOrDefault
            End Using
        End Function


        Public Function Find(ByVal KodeProduksi As String, ByVal KodeLokasi As String) As StockRoll
            Dim SQL As String

            SQL = "SELECT * FROM stockroll " +
                  "WHERE StatusStock = 1 AND KodeProduksi = @KodeProduksi AND KodeLokasi = @KodeLokasi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of StockRoll)(SQL, New With {.KodeProduksi = KodeProduksi, .KodeLokasi = KodeLokasi}).FirstOrDefault
            End Using
        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim KodeLokasi As String = Parameter(0)
            Dim ItemList As String = Parameter(1)

            SQL = "SELECT " +
                  "A.KodeProduksi                                       AS 'Kode Produksi', " +
                  "A.KodeItem                                           AS 'Kode Item', " +
                  "A.NamaItem                                           AS 'Nama Item', " +
                  "B.NamaUnit                                           AS 'Produksi', " +
                  "A.Jumlah2                                            AS 'Meter', " +
                  "A.Jumlah3                                            AS 'Kilogram' " +
                  "FROM stockroll A " +
                  "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnit " +
                  "WHERE A.StatusStock = 1 AND CONCAT(A.KodeProduksi, ' ', A.KodeItem, ' ', A.NamaItem) LIKE @Kriteria  "

            SQL += "AND A.KodeLokasi = '" + KodeLokasi + "' "
            SQL += "AND A.KodeItem IN (" + ItemList + ") "

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function

        Public Function UpdateStatus(ByVal KodeProduksi As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockroll SET " +
                  "StatusStock = 0 " +
                  "WHERE StatusStock = 1 AND KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateStatus = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi})
            End Using
        End Function

        Public Function UpdateQCInspeksi(ByVal KodeProduksi As String, _
                                         ByVal StatusQC As Byte, _
                                         ByVal KodeStatus As String, _
                                         ByVal KodeUnitPeruntukan As String, _
                                         ByVal Keterangan As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockroll SET " +
                  "StatusQC = " + StatusQC.ToString + ", " +
                  "KodeStatus = '" + KodeStatus + "', " +
                  "KodeUnitPeruntukan = '" + KodeUnitPeruntukan + "', " +
                  "Keterangan = '" + Keterangan + "' " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateQCInspeksi = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi})
            End Using
        End Function

        Public Function UpdateQCDisposisi(ByVal KodeProduksi As String, _
                                          ByVal KodeDisposisi As String, _
                                          ByVal KodeUnitPeruntukan As String, _
                                          ByVal Keterangan As String) As Integer
            Dim SQL As String

            SQL = "UPDATE stockroll SET " +
                  "StatusDisposisi = 1, " +
                  "KodeDisposisi = '" + KodeDisposisi + "', " +
                  "KodeUnitPeruntukan = '" + KodeUnitPeruntukan + "', " +
                  "Keterangan = '" + Keterangan + "' " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                UpdateQCDisposisi = DBX.Execute(SQL, New With {.KodeProduksi = KodeProduksi})
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, ByVal Status As Byte, Optional KodeLokasi As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "R.KodeProduksi                                     AS 'Kode', " +
                  "R.KodeItem                                         AS 'Kode Item', " +
                  "R.NamaItem                                         AS 'Nama Item', " +
                  "U.NamaUnit                                         AS 'Hasil Produksi', " +
                  "IF(R.StatusQC=0, 'INSPEKSI', " +
                  "IF(R.StatusQC=1, 'OK', " +
                  "IF(R.StatusQC=2, 'NON OK', " +
                  "IF(R.StatusQC=3, 'BERAT OVER', " +
                  "IF(R.StatusQC=4, 'BERAT UNDER','-')))))            AS 'Status' " +
                  "FROM stockroll R " +
                  "LEFT JOIN tunitproduksi U ON U.KodeUnit = R.KodeUnit " +
                  "WHERE CONCAT(R.KodeProduksi, ' ', " +
                  "             R.NamaItem, ' ', " +
                  "             U.NamaUnit) LIKE @Kriteria AND R.StatusTransaksi=1 "

            Select Case Status
                Case 0
                    SQL += "AND R.StatusQc = 0 "
                Case 1
                    SQL += "AND R.StatusQc IN (2,3,4) AND R.StatusDisposisi = 0 "
                Case 2
                    SQL += "AND R.StatusQc =1 OR R.StatusDisposisi = 1 "
            End Select

            If KodeLokasi <> "" Then
                SQL += " AND R.KodeLokasi = '" & KodeLokasi & "'"
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

        Public Function ReadProduksiLoom(ByVal Lokasi As String, ByVal TglAwal As DateTime, ByVal TglAkhir As DateTime, ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                "A.KodeProduksi                           AS 'Kode Produksi', " +
                "A.NomorWO                                AS 'Nomor WO', " +
                "A.KodeItem                               AS 'Kode Item', " +
                "A.NamaItem                               AS 'Nama Item', " +
                "A.PanjangRoll                            AS 'Panjang', " +
                "A.BeratNetto                             AS 'Berat', " +
                "IF(A.StatusQC=0, 'NONE', " +
                "IF(A.StatusQC=1, 'OK', " +
                "IF(A.StatusQC=2, 'NON OK', " +
                "IF(A.StatusQC=3, 'OVER', " +
                "IF(A.StatusQC=4, 'UNDER', '')))))        AS 'Status', " +
                "B.NamaUnit                               AS 'Unit Peruntukan', " +
                "A.Keterangan                             AS 'Keterangan' " +
                "FROM stockroll A " +
                "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnitPeruntukan " +
                "WHERE CONCAT(A.KodeProduksi, ' ', A.KodeItem, ' ', A.NamaItem) LIKE @Kriteria AND " +
                "KodeLokasi = @KodeLokasi AND A.TglTransaksi BETWEEN @TglAwal AND @TglAkhir "

            Kriteria = String.Concat(Space(1) + Kriteria.Trim() + Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                CMD.Parameters.AddWithValue("@KodeLokasi", Lokasi)
                CMD.Parameters.AddWithValue("@TglAwal", TglAwal)
                CMD.Parameters.AddWithValue("@TglAkhir", TglAkhir)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadProduksiLoom = DS
            End Using

        End Function

        Public Function ReadTransactionProduksiLoom(ByVal TglAwal As DateTime, ByVal TglAkhir As DateTime, ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                "A.KodeProduksi                           AS 'Kode', " +
                "A.NomorWO                                AS 'Nomor WO', " +
                "A.KodeItem                               AS 'Kode Item', " +
                "A.NamaItem                               AS 'Nama Item', " +
                "A.PanjangRoll                            AS 'Panjang', " +
                "A.BeratNetto                             AS 'Berat', " +
                "IF(A.StatusQC=0, 'NONE', " +
                "IF(A.StatusQC=1, 'OK', " +
                "IF(A.StatusQC=2, 'NON OK', " +
                "IF(A.StatusQC=3, 'OVER', " +
                "IF(A.StatusQC=4, 'UNDER', '')))))        AS 'Status', " +
                "B.NamaUnit                               AS 'Unit Peruntukan', " +
                "A.Keterangan                             AS 'Keterangan' " +
                "FROM stockroll A " +
                "LEFT JOIN tunitproduksi B ON B.KodeUnit = A.KodeUnitPeruntukan " +
                "WHERE CONCAT(A.KodeProduksi, ' ', A.KodeItem, ' ', A.NamaItem) LIKE @Kriteria AND " +
                "DATE(A.TglTimbang) BETWEEN @TglAwal AND @TglAkhir AND LEFT(A.NoTransaksi,4) = 'LMHP'"

            Kriteria = String.Concat(Space(1) + Kriteria.Trim() + Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                CMD.Parameters.AddWithValue("@TglAwal", TglAwal)
                CMD.Parameters.AddWithValue("@TglAkhir", TglAkhir)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadTransactionProduksiLoom = DS
            End Using

        End Function

        Public Function ReadHasilProduksiSlitting(ByVal NoTransaksi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT KodeProduksi FROM stockroll  " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@NoTransaksi", NoTransaksi)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadHasilProduksiSlitting = DS
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
                SQL = "SELECT COUNT(*) AS Total FROM stockroll " +
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
                SQL = "SELECT COUNT(*) AS Total FROM stockroll " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(11 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetKodeProduksi = Prefik + KodeMesin + Nomor

        End Function

        'Get Kode Produksi Timbang Roll Masuk
        Public Function GetKodeProduksiNew(PrefikTransaksi As String, KodeUnit As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = PrefikTransaksi + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM stockroll " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(11 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetKodeProduksiNew = Prefik + KodeUnit + Nomor

        End Function
    End Class
End Namespace

