Imports Dapper

Namespace HSP.Data
    Public Class HeaderPemakaianBahan
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPencatatan As DateTime
        Public Property NomorWO As String
        Public Property KodeUnit As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeMesin As String
        Public Property KodeItemFG As String
        Public Property NamaItemFG As String
        Public Property Keterangan As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DetailPemakaianBahan
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeItemRM As String
        Public Property NamaItemRM As String
        Public Property Qty As Double
        Public Property Satuan As String
        Public Property Keterangan As String
    End Class

    Public Class PemakaianBahanZero
        Public Property NomorWO As String
        Public Property KodeBahan As String
        Public Property NamaBahan As String
        Public Property Qty As Double
    End Class

    Public Class DaftarPemakaianBahan
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        'CRUD HeaderPemakaianBahan
        '------------------------------------------------------------------------------------------------------------------
        Public Function AddHeader(ByVal Data As HeaderPemakaianBahan) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksiheaderpemakaianbahan " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnit, KodeShift, KodeGrup, " +
                  "KodeMesin, KodeItemFG, NamaItemFG, Keterangan, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnit, @KodeShift, @KodeGrup, " +
                  "@KodeMesin, @KodeItemFG, @NamaItemFG, @Keterangan, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderPemakaianBahan) As Integer
            Dim SQL As String

            SQL = "UPDATE produksiheaderpemakaianbahan SET " +
                  "RowID = REPLACE(UUID(),'-',''), " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPencatatan = @TglPencatatan, " +
                  "NomorWO = @NomorWO, " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeShift = @KodeShift, " +
                  "KodeGrup = @KodeGrup, " +
                  "KodeMesin = @KodeMesin, " +
                  "KodeItemFG = @KodeItemFG, " +
                  "NamaItemFG = @NamaItemFG, " +
                  "Keterangan = @Keterangan, " +
                  "UserID = @UserID, " +
                  "TRX = '" + TRX() + "' " +
                  "WHERE NoTransaksi = @NoTransaksi AND Status=0 "

            Using DBX As IDbConnection = _DBConnection.Connection
                EditHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM produksiheaderpemakaianbahan " +
                  "WHERE NoTransaksi = @NoTransaksi AND Status=0 "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderPemakaianBahan
            Dim SQL As String

            SQL = "SELECT * FROM produksiheaderpemakaianbahan " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderPemakaianBahan)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        'CRUD DetailPemakaianBahan
        '------------------------------------------------------------------------------------------------------------------

        Public Function AddDetail(ByVal Data As DetailPemakaianBahan) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksidetailpemakaianbahan " +
                  "(RowID, NoTransaksi, NoUrut, KodeItemRM, NamaItemRM, Qty, Satuan, Keterangan) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeItemRM, @NamaItemRM, @Qty, @Satuan, @Keterangan)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM produksidetailpemakaianbahan " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function IsEmpty(ByVal NomorWO As String) As Boolean
            Dim SQL As String
            Dim JumlahData As Double

            SQL = "SELECT " +
                  "IFNULL(COUNT(NoTransaksi),0) AS JumlahData " +
                  "FROM produksiheaderpemakaianbahan  " +
                  "WHERE NomorWO = @NomorWO LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader

                CMD.Parameters.AddWithValue("@NomorWO", NomorWO)
                DR = CMD.ExecuteReader

                If DR.Read Then
                    JumlahData = DR("JumlahData")
                End If

                If JumlahData = 0 Then
                    IsEmpty = True
                Else
                    IsEmpty = False
                End If

                DR.Close()
            End Using
        End Function

        Public Function IsPemakaianBahan(ByVal NomorWO As String) As Boolean
            Dim SQL As String
            'Dim Status As Boolean

            SQL = "SELECT " +
                  "D.KodeItemRM, SUM(D.Qty) AS Jumlah " +
                  "FROM produksidetailpemakaianbahan D " +
                  "LEFT JOIN produksiheaderpemakaianbahan H ON H.NoTransaksi = D.NoTransaksi " +
                  "WHERE NomorWO = @NomorWO " +
                  "GROUP BY D.KodeItemRM " +
                  "HAVING SUM(D.Qty)<=0 "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader

                CMD.Parameters.AddWithValue("@NomorWO", NomorWO)
                DR = CMD.ExecuteReader

                If DR.Read Then
                    IsPemakaianBahan = False
                Else
                    IsPemakaianBahan = True
                End If

                'Dim XX As New DaftarPemakaianBahan(ActiveSession)
                'If XX.IsEmpty(NomorWO) Then
                '    IsPemakaianBahan = False
                'Else
                '    IsPemakaianBahan = True
                'End If
            End Using
        End Function

        Public Function ReadTransaction(ByVal TglAwal As Date, ByVal TglAkhir As Date, ByVal TextSearch As String, KodeUnit As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "HPB.RowID                                            AS 'RowID', " +
                  "HPB.NoTransaksi                                      AS 'Nomor', " +
                  "HPB.TglTransaksi                                     AS 'Tanggal', " +
                  "HPB.NomorWO                                          AS 'Nomor WO', " +
                  "HPB.KodeItemFG                                       AS 'Kode Item', " +
                  "HPB.NamaItemFG                                       AS 'Nama Item' " +
                  "FROM produksiheaderpemakaianbahan HPB " +
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

            SQL = "SELECT * FROM produksidetailpemakaianbahan " +
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

        Public Function ReadPerformance(ByVal Tanggal As Date, ByVal KodeUnit As String, ByVal KodeMesin As String, ByVal KodeShift As String, ByVal KodeGrup As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KodeItemRM                                 AS 'KodeBahan', " +
                  "A.NamaItemRM                                 AS 'NamaBahan', " +
                  "SUM(A.Qty)                                   AS 'Qty', " +
                  "A.Satuan                                     AS 'Satuan' " +
                  "FROM produksidetailpemakaianbahan A " +
                  "LEFT JOIN produksiheaderpemakaianbahan B ON B.NoTransaksi = A.NoTransaksi " +
                  "WHERE B.TglTransaksi = @Tanggal AND B.KodeUnit = '" + KodeUnit + "' AND " +
                  "B.KodeMesin = '" + KodeMesin + "' AND B.KodeShift = '" + KodeShift + "' AND " +
                  "B.KodeGrup = '" + KodeGrup + "' " +
                  "GROUP BY A.KodeItemRM "

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

        Public Function GetItemZero(ByVal NomorWO As String) As PemakaianBahanZero
            Dim SQL As String

            SQL = "SELECT " +
                  "A.NomorWO					AS NomorWO, " +
                  "A.KodeItem					AS KodeItem, " +
                  "A.NamaItem					AS NamaItem, " +
                  "SUM(C.Qty)					AS Qty " +
                  "FROM x_pemakaianbahan A " +
                  "LEFT JOIN produksiheaderpemakaianbahan B ON B.NomorWO = A.NomorWO " +
                  "LEFT JOIN produksidetailpemakaianbahan C ON C.NoTransaksi = B.NoTransaksi AND C.KodeItemRM = A.KodeItem " +
                  "WHERE A.NomorWO = '" + NomorWO + "' " +
                  "GROUP BY A.NomorWO, A.KodeItem " +
                  "HAVING SUM(C.Qty)=0"

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DR As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                Dim Temp As PemakaianBahanZero = Nothing

                If DR.Read Then
                    Temp = New PemakaianBahanZero

                    Temp.NomorWO = DR("NomorWO")
                    Temp.KodeBahan = DR("KodeItem")
                    Temp.NamaBahan = DR("NamaItem")
                    Temp.Qty = DR("Qty")
                End If

                DR.Close()
                GetItemZero = Temp

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
                Prefik = "EXPB-" & Periode
                
                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM produksiheaderpemakaianbahan " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

