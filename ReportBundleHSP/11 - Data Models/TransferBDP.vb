Imports Dapper

Namespace HSP.Data
    Public Class HeaderTransferBDP
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime        
        Public Property KodeUnit As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeMesin As String
        Public Property NomorWO As String
        Public Property KodeItemFG As String
        Public Property NamaItemFG As String
        Public Property KodeSatuanFG As String
        Public Property TglFG As Date
        Public Property NomorWOTransfer As String
        Public Property KodeItemFGTransfer As String
        Public Property NamaItemFGTransfer As String
        Public Property KodeSatuanFGTransfer As String
        Public Property TglFGTransfer As Date
        Public Property Keterangan As String
        Public Property TotalProduksi As Double
        Public Property TotalHasilProduksi As Double
        Public Property TotalReturProduksi As Double
        Public Property NilaiBDP As Double
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DetailTransferBDP
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeItemRM As String
        Public Property NamaItemRM As String
        Public Property Qty As Double
        Public Property Satuan As String
        Public Property Keterangan As String
        Public Property PB As Double
        Public Property RB As Double
        Public Property HP As Double
        Public Property RH As Double
        Public Property FlagTransfer As Byte
    End Class

    Public Class DaftarTransferBDP
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'CRUD HeaderTransferBDP
        '------------------------------------------------------------------------------------------------------------------
        Public Function AddHeader(ByVal Data As HeaderTransferBDP) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headertransferbdp " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, KodeUnit, KodeShift, KodeGrup, KodeMesin, NomorWO, KodeItemFG, NamaItemFG, KodeSatuanFG, TglFG, NomorWOTransfer, KodeItemFGTransfer, NamaItemFGTransfer, KodeSatuanFGTransfer, TglFGTransfer, Keterangan, TotalProduksi, TotalHasilProduksi, TotalReturProduksi, NilaiBDP, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeUnit, @KodeShift, @KodeGrup, @KodeMesin, @NomorWO, @KodeItemFG, @NamaItemFG, @KodeSatuanFG, @TglFG, @NomorWOTransfer, @KodeItemFGTransfer, @NamaItemFGTransfer, @KodeSatuanFGTransfer, @TglFGTransfer, @Keterangan, @TotalProduksi, @TotalHasilProduksi, @TotalReturProduksi, @NilaiBDP, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderTransferBDP) As Integer
            Dim SQL As String

            SQL = "UPDATE headertransferbdp SET " +
                  "RowID = REPLACE(UUID(),'-',''), " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPencatatan = @TglPencatatan, " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeShift = @KodeShift, " +
                  "KodeGrup = @KodeGrup, " +
                  "KodeMesin = @KodeMesin, " +
                  "NomorWO = @NomorWO, " +
                  "KodeItemFG = @KodeItemFG, " +
                  "NamaItemFG = @NamaItemFG, " +
                  "KodeSatuanFG = @KodeSatuanFG, " +
                  "TglFG = @TglFG, " +
                  "NomorWOTransfer = @NomorWOTransfer, " +
                  "KodeItemFGTransfer = @KodeItemFGTransfer, " +
                  "NamaItemFGTransfer = @NamaItemFGTransfer, " +
                  "KodeSatuanFGTransfer = @KodeSatuanFGTransfer, " +
                  "TglFGTransfer = @TglFGTransfer, " +
                  "Keterangan = @Keterangan, " +
                  "TotalProduksi = @TotalProduksi, " +
                  "TotalHasilProduksi = @TotalHasilProduksi, " +
                  "TotalReturProduksi = @TotalReturProduksi, " +
                  "NilaiBDP = @NilaiBDP, " +
                  "UserID = @UserID, " +
                  "TRX = '" + TRX() + "' " +
                  "WHERE NoTransaksi = @NoTransaksi AND Status=0 "

            Using DBX As IDbConnection = _DBConnection.Connection
                EditHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM headertransferbdp " +
                  "WHERE NoTransaksi = @NoTransaksi AND Status=0 "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderTransferBDP
            Dim SQL As String

            SQL = "SELECT * FROM headertransferbdp " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderTransferBDP)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        'CRUD DetailTransferBDP
        '------------------------------------------------------------------------------------------------------------------

        Public Function AddDetail(ByVal Data As DetailTransferBDP) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailtransferbdp " +
                  "(RowID, NoTransaksi, NoUrut, KodeItemRM, NamaItemRM, Qty, Satuan, Keterangan, PB, RB, HP, RH, FlagTransfer) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeItemRM, @NamaItemRM, @Qty, @Satuan, @Keterangan, @PB, @RB, @HP, @RH, @FlagTransfer) "

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM detailtransferbdp " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function ReadTransaction(ByVal TglAwal As Date, ByVal TglAkhir As Date, ByVal TextSearch As String, KodeUnit As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "HPB.RowID                                            AS 'RowID', " +
                  "HPB.NoTransaksi                                      AS 'Nomor', " +
                  "HPB.TglTransaksi                                     AS 'Tanggal', " +
                  "HPB.NomorWO                                          AS 'WO Asal', " +
                  "HPB.TglFG                                            AS 'Tanggal ->', " +
                  "HPB.NomorWOTransfer                                  AS 'WO Tujuan', " +
                  "HPB.TglFGTransfer                                    AS 'Tanggal' " +
                  "FROM headertransferbdp HPB " +
                  "WHERE CONCAT(HPB.NoTransaksi, ' ', " +
                  "             HPB.NomorWO, ' ', " +
                  "             HPB.KodeItemFG, ' ', " +
                  "             HPB.NamaItemFG " +
                  "             ) LIKE @TextSearch "

            SQL += " AND HPB.KodeUnit = '" + KodeUnit + "' "

            SQL += "AND HPB.TglTransaksi Between @TglAwal AND @TglAkhir " +
                   "ORDER BY HPB.TglTransaksi, HPB.NoTransaksi"

            TextSearch = String.Concat(Space(1), TextSearch.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@TextSearch", TextSearch)
                CMD.Parameters.AddWithValue("@TglAwal", TglAwal)
                CMD.Parameters.AddWithValue("@TglAkhir", TglAkhir)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadTransaction = DS
            End Using
        End Function

        Public Function ReadDetail(ByVal NoTransaksi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM detailtransferbdp " +
                  "WHERE NoTransaksi = @NoTransaksi " +
                  "ORDER BY NoUrut"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@NoTransaksi", NoTransaksi)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS
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
                Prefik = "TWIP-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headertransferbdp " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

