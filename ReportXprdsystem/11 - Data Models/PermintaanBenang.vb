Imports Dapper

Namespace HSP.Data
    Public Class HeaderPermintaanBenang
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPermintaan As DateTime
        Public Property KodeUnit As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property QtyPS1 As Double
        Public Property QtyAS1 As Double
        Public Property QtyRS1 As Double
        Public Property QtyPS2 As Double
        Public Property QtyAS2 As Double
        Public Property QtyRS2 As Double
        Public Property QtyPS3 As Double
        Public Property QtyAS3 As Double
        Public Property QtyRS3 As Double
        Public Property UserID As String
        Public Property KodeUnitSAP As String
        Public Property TRX As String
    End Class

    Public Class DetailPermintaanBenang
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property NomorWO As String
        Public Property QtyProyeksi As Double
    End Class

    Public Class DaftarPermintaanBenang
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddHeader(ByVal Data As HeaderPermintaanBenang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headerpermintaanbenang " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPermintaan, KodeUnit, KodeItem, NamaItem, " +
                  "QtyPS1, QtyAS1, QtyRS1, QtyPS2, QtyAS2, QtyRS2, QtyPS3, QtyAS3, QtyRS3, " +
                  "UserID, KodeUnitSAP, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPermintaan, @KodeUnit, @KodeItem, @NamaItem, " +
                  "@QtyPS1, @QtyAS1, 0, @QtyPS2, @QtyAS2, 0, @QtyPS3, @QtyAS3, 0, " +
                  "@UserID, @KodeUnitSAP, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderPermintaanBenang) As Integer
            Dim SQL As String

            SQL = "UPDATE headerpermintaanbenang SET " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPermintaan = @TglPermintaan, " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "QtyPS1 = @QtyPS1, " +
                  "QtyAS1 = @QtyAS1, " +
                  "QtyPS2 = @QtyPS2, " +
                  "QtyAS2 = @QtyAS2, " +
                  "QtyPS3 = @QtyPS3, " +
                  "QtyAS3 = @QtyAS3, " +
                  "UserID = @UserID, " +
                  "KodeUnitSAP = @KodeUnitSAP, " +
                  "TRX = '" + TRX() + "' " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                EditHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM headerpermintaanbenang " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderPermintaanBenang
            Dim SQL As String

            SQL = "SELECT * FROM headerpermintaanbenang " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderPermintaanBenang)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function AddDetail(ByVal Data As DetailPermintaanBenang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailpermintaanbenang " +
                  "(RowID, NoTransaksi, NoUrut, NomorWO, QtyProyeksi) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @NomorWO, @QtyProyeksi)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM detailpermintaanbenang " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        'Read Detail
        Public Function ReadDetail(ByVal ID As String) As DataSet
            Dim SQL As String

            SQL = "SELECT NomorWO As Nomor, QtyProyeksi As Proyeksi, QtyProsentase As Prosentase, QtyKebutuhan As Kebutuhan FROM vdetailpermintaanbenang " +
                  "WHERE NoTransaksi = @NoTransaksi " +
                  "ORDER BY NoUrut"

            Using DBX As IDbConnection = _DBConnection.Connection()

                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@NoTransaksi", ID)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadDetail = DS
            End Using

        End Function

        Public Function Read(ByVal Kriteria As String, ByVal TglAwal As DateTime, ByVal TglAkhir As DateTime) As DataSet
            Dim SQL As String = ""

            SQL += "SELECT " +
                  "NoTransaksi                                      AS 'Nomor', " +
                  "TglPermintaan                                    AS 'Tgl. Transaksi', " +
                  "TglPermintaan                                    AS 'Tgl. Permintaan', " +
                  "KodeItem                                         AS 'Kode', " +
                  "NamaItem                                         AS 'Nama Item', " +
                  "QtyAS1                                           AS 'Shift 1', " +
                  "QtyAS2                                           AS 'Shift 2', " +
                  "QtyAS3                                           AS 'Shift 3', " +
                  "QtyAS1 + QtyAS2 + QtyAS3                         AS 'Total' " +
                  "FROM headerpermintaanbenang " +
                  "WHERE (CONCAT(KodeItem, ' ', NamaItem) LIKE @Kriteria) " +
                  "AND (TglTransaksi Between @TglAwal AND @TglAkhir) "

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

        Public Function Read(ByVal Kriteria As String, ByVal Tanggal As DateTime, ByVal KodeShift As String) As DataSet
            Dim SQL As String = ""

            SQL += "SELECT " +
                   "NoTransaksi                                      AS 'Nomor', " +
                   "TglPermintaan                                    AS 'Tanggal', " +
                   "KodeItem                                         AS 'Kode', " +
                   "NamaItem                                         AS 'Nama Item', "

            Select Case KodeShift
                Case "1"
                    SQL += "QtyAS1 - QtyRS1                          AS 'Qty' "
                Case "2"
                    SQL += "QtyAS2 - QtyRS2                          AS 'Qty' "
                Case "3"
                    SQL += "QtyAS3 - QtyRS3                          AS 'Qty' "
            End Select

            SQL += "FROM headerpermintaanbenang " +
                   "WHERE CONCAT(KodeItem, ' ', NamaItem) LIKE @Kriteria " +
                   "AND TglPermintaan = @Tanggal "

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
                CMD.Parameters.AddWithValue("@Tanggal", Tanggal)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
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
                Prefik = "LMBB-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headerpermintaanbenang " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(15 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

    End Class
End Namespace

