Imports Dapper

Namespace HSP.Data
    Public Class StockBenang
        Public Property RowID As String
        Public Property KodeProduksi As String
        Public Property KodeProduksiLama As String
        Public Property StatusProduksi As Byte
        Public Property NomorWO As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeStatusQC As Byte
        Public Property NamaStatusQC As String
        Public Property KodeDisposisi As String
        Public Property NamaDisposisi As String
        Public Property BeratBrutto As Double
        Public Property KodePola As String
        Public Property KodeMedia1 As String
        Public Property BeratMedia1 As Double
        Public Property JumlahMedia1 As Double
        Public Property KodeMedia2 As String
        Public Property BeratMedia2 As Double
        Public Property JumlahMedia2 As Double
        Public Property KodeMedia3 As String
        Public Property BeratMedia3 As Double
        Public Property JumlahMedia3 As Double
        Public Property BeratNetto As Double
        Public Property Satuan1 As String
        Public Property Satuan2 As String
        Public Property Satuan3 As String
        Public Property Jumlah1 As Double
        Public Property Jumlah2 As Double
        Public Property Jumlah3 As Double
        Public Property KodeLokasi As String
        Public Property KodeArea As String
        Public Property Keterangan As String
        Public Property InputData As Byte
        Public Property M_NoTimbang As String
        Public Property M_TglTransaksi As DateTime
        Public Property M_TglTimbang As DateTime
        Public Property M_KodeShift As String
        Public Property M_KodeGrup As String
        Public Property M_PrevShift As Byte
        Public Property M_KodeUnit As String
        Public Property M_KodeMesin As String
        Public Property M_UserID As String
        Public Property K_NoTimbang As String
        Public Property K_TglTransaksi As DateTime
        Public Property K_TglTimbang As DateTime
        Public Property K_KodeShift As String
        Public Property K_KodeGrup As String
        Public Property K_KodeUnit As String
        Public Property K_UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarStockBenang
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Tambahkan Transaksi Penerimaan(Timbang) Benang
        Public Function Add(ByVal Data As StockBenang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO stockbenang " +
                    "(RowID, KodeProduksi, KodeProduksiLama, StatusProduksi, NomorWO, KodeItem, NamaItem, " +
                    "KodeStatusQC, NamaStatusQC, KodeDisposisi, NamaDisposisi, BeratBrutto, KodePola, " +
                    "KodeMedia1, BeratMedia1, JumlahMedia1, KodeMedia2, BeratMedia2, JumlahMedia2, KodeMedia3, BeratMedia3, JumlahMedia3, " +
                    "BeratNetto, Satuan1, Satuan2, Satuan3, Jumlah1, Jumlah2, Jumlah3, KodeLokasi, KodeArea, Keterangan, InputData, " +
                    "M_NoTimbang, M_TglTransaksi, M_TglTimbang, M_KodeShift, M_KodeGrup, M_PrevShift, M_KodeUnit, M_KodeMesin, M_UserID, TRX) " +
                    "VALUES " +
                    "(REPLACE(UUID(),'-',''), @KodeProduksi, @KodeProduksiLama, @StatusProduksi, @NomorWO, @KodeItem, @NamaItem, " +
                    "@KodeStatusQC, @NamaStatusQC, @KodeDisposisi, @NamaDisposisi, @BeratBrutto, @KodePola, " +
                    "@KodeMedia1, @BeratMedia1, @JumlahMedia1, @KodeMedia2, @BeratMedia2, @JumlahMedia2, @KodeMedia3, @BeratMedia3, @JumlahMedia3, " +
                    "@BeratNetto, @Satuan1, @Satuan2, @Satuan3, @Jumlah1, @Jumlah2, @Jumlah3, @KodeLokasi, @KodeArea, @Keterangan, @InputData, " +
                    "@M_NoTimbang, @M_TglTransaksi, @M_TglTimbang, @M_KodeShift, @M_KodeGrup, @M_PrevShift, @M_KodeUnit, @M_KodeMesin, @M_UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        'Update Data Transaksi ProduksiBenang Pada Saat Pengeluaran Benang
        Public Function Edit(ByVal Data As StockBenang) As Integer
            Dim SQL As String

            SQL = "UPDATE stockbenang SET " +
                  "K_NoTimbang = @K_NoTimbang, " +
                  "K_TglTransaksi = @K_TglTransaksi, " +
                  "K_TglTimbang = @K_TglTimbang, " +
                  "K_KodeShift = @K_KodeShift, " +
                  "K_KodeGrup = @K_KodeGrup, " +
                  "K_KodeUnit = @K_KodeUnit, " +
                  "K_UserID = @K_UserID " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Find(ByVal ID As String) As StockBenang
            Dim SQL As String

            SQL = "SELECT * FROM stockbenang " +
                  "WHERE KodeProduksi = @KodeProduksi AND StatusTransaksi=1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of StockBenang)(SQL, New With {.KodeProduksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindExist(ByVal ID As String) As StockBenang
            Dim SQL As String

            SQL = "SELECT * FROM stockbenang " +
                  "WHERE KodeProduksi = @KodeProduksi AND K_NoTimbang='' "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindExist = DBX.Query(Of StockBenang)(SQL, New With {.KodeProduksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastID() As StockBenang
            Dim SQL As String

            SQL = "SELECT * FROM stockbenang " +
                  "ORDER BY M_TglTimbang DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastID = DBX.Query(Of StockBenang)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function FindByNoTimbang(ByVal NoTimbang As String) As StockBenang
            Dim SQL As String

            SQL = "SELECT " +
                  "M_NoTimbang, " +
                  "M_TglTransaksi, " +
                  "M_TglTimbang, " +
                  "M_KodeShift, " +
                  "M_KodeGrup, " +
                  "NomorWO, " +
                  "KodeItem, " +
                  "NamaItem, " +
                  "M_KodeUnit, " +
                  "KodeLokasi, " +
                  "KodeArea, " +
                  "M_KodeMesin, " +
                  "KodeStatusQC, " +
                  "SUM(Jumlah1) AS Jumlah1, " +
                  "SUM(Jumlah2) AS Jumlah2, " +
                  "SUM(BeratBrutto) AS BeratBrutto, " +
                  "SUM(BeratNetto) AS BeratNetto, " +
                  "Keterangan " +
                  "FROM stockbenang " +
                  "WHERE M_NoTimbang = @M_NoTimbang AND K_NoTimbang='' " +
                  "GROUP BY M_NoTimbang "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindByNoTimbang = DBX.Query(Of StockBenang)(SQL, New With {.M_NoTimbang = NoTimbang}).FirstOrDefault
            End Using
        End Function

        Public Function FindByNoWO(ByVal NomorWO As String) As StockBenang
            Dim SQL As String

            SQL = "SELECT NomorWO AS NomorWO, SUM(BeratNetto) AS BeratNetto " +
                  "FROM stockbenang " +
                  "WHERE StatusTransaksi = 1 AND NomorWO = @NomorWO "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindByNoWO = DBX.Query(Of StockBenang)(SQL, New With {.NomorWO = NomorWO}).FirstOrDefault
            End Using
        End Function

        Public Function ReadTransaction(ByVal TglAwal As DateTime, ByVal TglAkhir As DateTime, ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "PB.M_NoTimbang                                                                                               AS 'Nomor', " +
                  "PB.M_TglTransaksi                                                                                            AS 'Tanggal', " +
                  "UP.NamaUnit                                                                                                  AS 'Unit Asal', " +
                  "SP.NamaShift                                                                                                 AS 'Shift', " +
                  "GP.NamaGrup                                                                                                  AS 'Grup', " +
                  "MP.NamaMesin                                                                                                 AS 'Mesin', " +
                  "PB.NamaItem                                                                                                  AS 'Item', " +
                  "IF(PB.KodeStatusQC=1, 'OK', " +
                  "IF(PB.KodeStatusQC=2, 'NON OK', " +
                  "IF(PB.KodeStatusQC=3, 'OVER', " +
                  "IF(PB.KodeStatusQC=4, 'UNDER','-'))))                                                                        AS 'Status', " +
                  "AP.NamaArea                                                                                                  AS 'Area', " +
                  "SUM(PB.BeratBrutto)                                                                                          AS 'Berat Brutto', " +
                  "SUM(PB.BeratNetto)                                                                                           AS 'Berat Netto', " +
                  "CONCAT(SUM(PB.Jumlah1),' ', UPPER(PB.Satuan1))                                                               AS 'Packing', " +
                  "CONCAT(SUM(PB.Jumlah2),' ', UPPER(PB.Satuan2))                                                               AS 'Pcs', " +
                  "PB.Keterangan                                                                                                AS 'Keterangan' " +
                  "FROM stockbenang PB " +
                  "LEFT JOIN tshiftproduksi SP ON SP.KodeShift = PB.M_KodeShift " +
                  "LEFT JOIN tgrupproduksi GP ON GP.KodeGrup = PB.M_KodeGrup " +
                  "LEFT JOIN tareaproduksi AP ON AP.KodeArea = PB.KodeArea " +
                  "LEFT JOIN tmesinproduksi MP ON MP.KodeMesin = PB.M_KodeMesin " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = PB.M_KodeUnit " +
                  "WHERE CONCAT(PB.M_NoTimbang, ' ', " +
                  "             PB.NamaItem) LIKE @Kriteria "

            SQL += "AND M_TglTransaksi BETWEEN @TglAwal AND @TglAkhir AND K_NoTimbang='' " +
                   "GROUP BY PB.M_NoTimbang " +
                   "ORDER BY PB.M_NoTimbang "

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

        Public Function ReadByTimbang(ByVal NoTimbang As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "PB.KodeProduksi                                                                                              AS 'Kode Produksi', " +
                  "PB.M_TglTimbang                                                                                              AS 'Tanggal', " +
                  "SP.NamaShift                                                                                                 AS 'Shift', " +
                  "GP.NamaGrup                                                                                                  AS 'Grup', " +
                  "PB.M_KodeMesin                                                                                               AS 'Mesin', " +
                  "PB.NamaItem                                                                                                  AS 'Item', " +
                  "IF(PB.KodeStatusQC=1, 'OK', " +
                  "IF(PB.KodeStatusQC=2, 'NON OK', " +
                  "IF(PB.KodeStatusQC=3, 'OVER', " +
                  "IF(PB.KodeStatusQC=4, 'UNDER','-'))))                                                                        AS 'Status', " +
                  "AP.NamaArea                                                                                                  AS 'Area', " +
                  "PB.BeratBrutto                                                                                               AS 'Berat Brutto', " +
                  "PB.BeratNetto                                                                                                AS 'Berat Netto', " +
                  "UPPER(PB.Satuan2)                                                                                            AS 'Media', " +
                  "PB.Jumlah2                                                                                                   AS 'Jumlah', " +
                  "IF(PB.K_NoTimbang<>'', 'OUT', 'AVAILABLE')                                                                   AS 'Stock', " +
                  "PB.Keterangan                                                                                                AS 'Keterangan' " +
                  "FROM stockbenang PB " +
                  "LEFT JOIN tshiftproduksi SP ON SP.KodeShift = PB.M_KodeShift " +
                  "LEFT JOIN tgrupproduksi GP ON GP.KodeGrup = PB.M_KodeGrup " +
                  "LEFT JOIN tareaproduksi AP ON AP.KodeArea = PB.KodeArea " +
                  "WHERE PB.M_NoTimbang='" & NoTimbang & "'"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@M_NoTimbang", NoTimbang)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadByTimbang = DS
            End Using
        End Function

        Public Function ReadLastID() As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "PB.KodeProduksi                                                                                              AS 'Kode Produksi', " +
                  "PB.M_TglTimbang                                                                                              AS 'Tanggal', " +
                  "SP.NamaShift                                                                                                 AS 'Shift', " +
                  "GP.NamaGrup                                                                                                  AS 'Grup', " +
                  "PB.M_KodeMesin                                                                                               AS 'Mesin', " +
                  "PB.NamaItem                                                                                                  AS 'Item', " +
                  "IF(PB.KodeStatusQC=1, 'OK', " +
                  "IF(PB.KodeStatusQC=2, 'NON OK', " +
                  "IF(PB.KodeStatusQC=3, 'OVER', " +
                  "IF(PB.KodeStatusQC=4, 'UNDER','-'))))                                                                        AS 'Status', " +
                  "AP.NamaArea                                                                                                  AS 'Area', " +
                  "PB.BeratBrutto                                                                                               AS 'Berat Brutto', " +
                  "PB.BeratNetto                                                                                                AS 'Berat Netto', " +
                  "UPPER(PB.Satuan2)                                                                                            AS 'Media', " +
                  "PB.Jumlah2                                                                                                   AS 'Jumlah', " +
                  "IF(PB.K_NoTimbang<>'', 'OUT', 'AVAILABLE')                                                                   AS 'Stock', " +
                  "PB.Keterangan                                                                                                AS 'Keterangan' " +
                  "FROM stockbenang PB " +
                  "LEFT JOIN tshiftproduksi SP ON SP.KodeShift = PB.M_KodeShift " +
                  "LEFT JOIN tgrupproduksi GP ON GP.KodeGrup = PB.M_KodeGrup " +
                  "LEFT JOIN tareaproduksi AP ON AP.KodeArea = PB.KodeArea " +
                  "ORDER BY PB.M_TglTimbang, PB.M_NoTimbang DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadLastID = DS
            End Using
        End Function

        Public Function ReadMutasi(ByVal KodeArea As String) As DataSet
            Dim SQL As String = ""

            SQL += "SELECT " +
                  "SB.KodeProduksi                                  AS 'Kode', " +
                  "SB.KodeItem                                      AS 'Kode Item', " +
                  "SB.NamaItem                                      AS 'Nama Item', " +
                  "SB.KodeArea                                      AS 'Area', " +
                  "CONCAT(ROUND(SB.Jumlah2,2),' ',SB.Satuan2)       AS 'Jumlah', " +
                  "CONCAT(ROUND(SB.Jumlah3,3),' ',SB.Satuan3)       AS 'Berat' " +
                  "FROM stockbenang SB " +
                  "LEFT JOIN tareaproduksi AP ON AP.KodeArea=SB.KodeArea " +
                  "WHERE SB.KodeArea='" & KodeArea & "' AND K_NoTimbang ='' "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadMutasi = DS
            End Using
        End Function

        Public Function ReadConsole(ByVal Tanggal As DateTime) As DataSet
            Dim SQL As String = ""

            SQL = "SELECT " +
                  "NomorWO				    AS 'Nomow WO', " +
                  "SUM(Qty)			        AS 'Qty', " +
                  "SUM(QtyCancel)			AS 'Qty Cancel' " +
                  "FROM ( " +
                        "SELECT " +
                            "NomorWO			    AS 'NomorWO', " +
                            "SUM(BeratNetto)		AS 'Qty', " +
                            "0			            AS 'QtyCancel' " +
                        "FROM StockBenang " +
                        "WHERE 	M_TglTransaksi= @Tanggal " +
                        "GROUP BY NomorWO " +
                  "UNION " +
                        "SELECT " +
                            "NomorWO			    AS 'NomorWO', " +
                            "0			            AS 'Qty', " +
                            "SUM(BeratNetto)		AS 'QtyCancel' " +
                        "FROM StockBenang " +
                        "WHERE 	M_TglTransaksi= @Tanggal AND StatusTransaksi=0 " +
                        "GROUP BY NomorWO " +
                  ") AS Hasil " +
                  "GROUP BY NomorWO "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Tanggal", Tanggal)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadConsole = DS
            End Using
        End Function

        Public Function ReadItem() As DataSet
            Dim SQL As String = ""

            SQL += "SELECT DISTINCT " +
                  "KodeItem                                         AS 'Kode', " +
                  "NamaItem                                         AS 'Nama Item' " +
                  "FROM stockbenang " +
                  "ORDER BY KodeItem "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadItem = DS
            End Using
        End Function

        Public Function ReadPerformance(ByVal Tanggal As Date, ByVal KodeUnit As String, ByVal KodeMesin As String, ByVal KodeShift As String, ByVal KodeGrup As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeItem                                 AS 'KodeHasil', " +
                  "NamaItem                                 AS 'NamaHasil', " +
                  "SUM(Jumlah1)                             AS 'QtyPacking', " +
                  "SUM(Jumlah2)                             AS 'QtyPcs', " +
                  "SUM(BeratNetto)                          AS 'QtyTimbang', " +
                  "KodeStatusQC                             AS 'KodeStatus', " +
                  "NamaStatusQC                             AS 'NamaStatus' " +
                  "FROM stockbenang " +
                  "WHERE M_TglTransaksi = @Tanggal AND M_KodeUnit = '" + KodeUnit + "' AND " +
                  "M_KodeMesin = '" + KodeMesin + "' AND M_KodeShift = '" + KodeShift + "' AND " +
                  "M_KodeGrup = '" + KodeGrup + "' " +
                  "GROUP BY KodeItem, KodeStatusQC "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Tanggal", Tanggal)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadPerformance = DS
            End Using
        End Function '

        'Nomor Transaksi Masuk
        Public Function GetNomorTransaksiIn(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = "EXHP-" & Periode

                SQL = "SELECT MAX(RIGHT(M_NoTimbang,5)) AS Total FROM stockbenang " +
                      "WHERE LEFT(M_NoTimbang, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
            End Using

            GetNomorTransaksiIn = Prefik + Nomor
        End Function

        'Get Kode Produksi Timbang Benang Masuk
        Public Function GetKodeProduksi(KodeUnit As String, ByVal KodeMesin As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = New DaftarUnitProduksi(ActiveSession).Find(KodeUnit).PrefikKodeProduksi.Trim() + Periode

                SQL = "SELECT COUNT(*) AS Total FROM stockbenang " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")

            End Using
            GetKodeProduksi = Prefik + KodeMesin + Nomor

        End Function

        Public Function GetKodeProduksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = "10" & Periode

                SQL = "SELECT COUNT(*) AS Total FROM stockbenang " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")

            End Using
            GetKodeProduksi = Prefik & Nomor
        End Function

        'Get Nomor Transaksi Keluar
        Public Function GetNomorTransaksiOut(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = "EXTK-" & Periode

                SQL = "SELECT MAX(RIGHT(K_NoTimbang,5)) AS Total FROM stockbenang " +
                      "WHERE LEFT(K_NoTimbang, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksiOut = Prefik + Nomor

        End Function
    End Class
End Namespace

