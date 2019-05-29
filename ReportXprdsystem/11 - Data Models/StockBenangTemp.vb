Imports Dapper

Namespace HSP.Data
    Public Class StockBenangTemp
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

    Public Class DaftarStockBenangTemp
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Tambahkan Transaksi Penerimaan(Timbang) Benang
        Public Function Add(ByVal Data As StockBenangTemp) As Integer
            Dim SQL As String

            SQL = "INSERT INTO temp_stockbenang " +
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
        Public Function Edit(ByVal Data As StockBenangTemp) As Integer
            Dim SQL As String

            SQL = "UPDATE temp_stockbenang SET " +
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

        Public Function Find(ByVal ID As String) As StockBenangTemp
            Dim SQL As String

            SQL = "SELECT * FROM temp_stockbenang " +
                  "WHERE KodeProduksi = @KodeProduksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of StockBenangTemp)(SQL, New With {.KodeProduksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastID() As StockBenangTemp
            Dim SQL As String

            SQL = "SELECT * FROM temp_stockbenang " +
                  "ORDER BY M_TglTimbang DESC LIMIT 1 "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastID = DBX.Query(Of StockBenangTemp)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function ReadByCode(ByVal KodeItem As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "SBT.KodeProduksi                                 AS 'Kode', " +
                  "SBT.NamaItem                                     AS 'Item', " +
                  "AP.NamaArea                                      AS 'Area', " +
                  "IF(SBT.KodeStatusQC=1,'OK',IF(SBT.KodeStatusQC=2,'NON OK',IF(SBT.KodeStatusQC=3,'OVER',IF(SBT.KodeStatusQC=4,'UNDER','-')))) AS 'Status', " +
                  "CONCAT(SBT.Jumlah2,' ',SBT.Satuan2)              AS 'QtyUnit', " +
                  "ROUND(SBT.BeratNetto,3)                          AS 'QtyTimbang' " +
                  "FROM temp_stockbenang SBT " +
                  "LEFT JOIN tareaproduksi AP ON AP.KodeArea=SBT.KodeArea " +
                  "WHERE SBT.KodeItem = @KodeItem"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@KodeItem", KodeItem)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadByCode = DS
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
                  "FROM temp_stockbenang PB " +
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
                  "AP.NamaArea                                      AS 'Area', " +
                  "CONCAT(ROUND(SB.Jumlah2,2),' ',SB.Satuan2)       AS 'Jumlah', " +
                  "CONCAT(ROUND(SB.Jumlah3,3),' ',SB.Satuan3)       AS 'Berat' " +
                  "FROM temp_stockbenang SB " +
                  "LEFT JOIN tareaproduksi AP ON AP.KodeArea=SB.KodeArea " +
                  "WHERE SB.KodeArea='" & KodeArea & "' "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadMutasi = DS
            End Using
        End Function

        'Nomor Transaksi Masuk
        Public Function GetNomorTransaksiIn(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = "EXHP-" & Periode

                SQL = "SELECT MAX(RIGHT(M_NoTimbang,5)) AS Total FROM temp_stockbenang " +
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

                SQL = "SELECT COUNT(*) AS Total FROM temp_stockbenang " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")

            End Using
            GetKodeProduksi = Prefik + KodeMesin + Nomor

        End Function

        'Get Nomor Transaksi Keluar
        Public Function GetNomorTransaksiOut(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = "EXTK-" & Periode

                SQL = "SELECT MAX(RIGHT(K_NoTimbang,5)) AS Total FROM temp_stockbenang " +
                      "WHERE LEFT(K_NoTimbang, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksiOut = Prefik + Nomor

        End Function
    End Class
End Namespace

