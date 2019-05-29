Imports Dapper

Namespace HSP.Data
    Public Class ProduksiAfval
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime
        Public Property NomorWO As String = ""
        Public Property KodeUnit As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeMesin As String
        Public Property KodeItemAfval As String
        Public Property NamaItemAfval As String
        Public Property KodeMedia As String
        Public Property BeratBrutto As Double
        Public Property BeratMedia As Double
        Public Property BeratNetto As Double
        Public Property Keterangan As String
        Public Property ShiftSebelumnya As Byte
        Public Property NoKaryawan As String = ""
        Public Property UserID As String
        Public Property KodeLokasi As String
        Public Property KodeUnitSAP As String
        Public Property KodeItemSAP As String
        Public Property NamaItemSAP As String
        Public Property TRX As String
    End Class

    Public Class DaftarAfvalProduksi
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'Add
        '------------------------------------------------------------------------------------------------------------------
        Public Function Add(ByVal Data As ProduksiAfval) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksiafval " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnit, KodeShift, KodeGrup, KodeMesin, KodeItemAfval, NamaItemAfval, KodeMedia, BeratBrutto, BeratMedia, BeratNetto, Keterangan, ShiftSebelumnya, NoKaryawan, UserID, KodeLokasi, KodeUnitSAP, KodeItemSAP, NamaItemSAP, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @KodeItemAfval, @NamaItemAfval, @KodeMedia, @BeratBrutto, @BeratMedia, @BeratNetto, @Keterangan, @ShiftSebelumnya, @NoKaryawan, @UserID, @KodeLokasi, @KodeUnitSAP, @KodeItemSAP, @NamaItemSAP, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As ProduksiAfval) As Integer
            Dim SQL As String

            SQL = "UPDATE produksiafval SET " +
                  "RowID = REPLACE(UUID(),'-',''), " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPencatatan = @TglPencatatan, " +
                  "NomorWO = @NomorWO, " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeShift = @KodeShift, " +
                  "KodeGrup = @KodeGrup, " +
                  "KodeMesin = @KodeMesin, " +
                  "KodeItemAfval = @KodeItemAfval, " +
                  "NamaItemAfval = @NamaItemAfval, " +
                  "KodeMedia = @KodeMedia, " +
                  "BeratBrutto = @BeratBrutto, " +
                  "BeratMedia = @BeratMedia, " +
                  "BeratNetto = @BeratNetto, " +
                  "Keterangan = @Keterangan, " +
                  "ShiftSebelumnya = @ShiftSebelumnya, " +
                  "NoKaryawan = @NoKaryawan, " +
                  "UserID = @UserID, " +
                  "KodeLokasi = @KodeLokasi, " +
                  "KodeUnitSAP = @KodeUnitSAP, " +
                  "KodeItemSAP = @KodeItemSAP, " +
                  "NamaItemSAP = @NamaItemSAP, " +
                  "TRX = '" + TRX() + "' " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM produksiafval " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As ProduksiAfval
            Dim SQL As String

            SQL = "SELECT * FROM produksiafval " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of ProduksiAfval)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function FindLastID() As ProduksiAfval
            Dim SQL As String

            SQL = "SELECT * FROM produksiafval " +
                  "ORDER BY NoTransaksi DESC LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                FindLastID = DBX.Query(Of ProduksiAfval)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function ReadPerformance(ByVal Tanggal As Date, ByVal KodeUnit As String, ByVal KodeMesin As String, ByVal KodeShift As String, ByVal KodeGrup As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KodeItemAfval                                 AS 'KodeAfval', " +
                  "NamaItemAfval                                 AS 'NamaAfval', " +
                  "SUM(BeratNetto)                               AS 'QtyTimbang' " +
                  "FROM produksiafval " +
                  "WHERE TglTransaksi = @Tanggal AND KodeUnit = '" + KodeUnit + "' AND " +
                  "KodeMesin = '" + KodeMesin + "' AND KodeShift = '" + KodeShift + "' AND " +
                  "KodeGrup = '" + KodeGrup + "' " +
                  "GROUP BY KodeItemAfval "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Tanggal", Tanggal)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadPerformance = DS
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
                Prefik = "AFPR-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksiafval " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

