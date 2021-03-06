﻿Imports Dapper

Namespace HSP.Data
    Public Class HeaderPengeluaranBenang
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglPengeluaran As DateTime
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property NoPermintaan As String
        Public Property TglPermintaan As DateTime
        Public Property KodeUnit As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property QtyPermintaan As Double
        Public Property QtyRealisasi As Double
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DetailPengeluaranBenang
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeProduksi As String
        Public Property Qty As Double
    End Class

    Public Class DaftarPengeluaranBenang
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddHeader(ByVal Data As HeaderPengeluaranBenang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headerpengeluaranbenang " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPengeluaran, " +
                  "KodeShift, KodeGrup, NoPermintaan, TglPermintaan, " +
                  "KodeUnit, KodeItem, NamaItem, QtyPermintaan, QtyRealisasi, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPengeluaran, " +
                  "@KodeShift, @KodeGrup, @NoPermintaan, @TglPermintaan, " +
                  "@KodeUnit, @KodeItem, @NamaItem, @QtyPermintaan, @QtyRealisasi, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function EditHeader(ByVal Data As HeaderPengeluaranBenang) As Integer
            Dim SQL As String

            SQL = "UPDATE headerpengeluaranbenang SET " +
                  "NoTransaksi = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "TglPengeluaran = @TglPengeluaran, " +
                  "KodeShift = @KodeShift, " +
                  "KodeGrup = @KodeGrup, " +
                  "NoPermintaan = @NoPermintaan, " +
                  "TglPermintaan = @TglPermintaan, " +
                  "KodeUnit = @KodeUnit, " +
                  "KodeItem = @KodeItem, " +
                  "NamaItem = @NamaItem, " +
                  "QtyPermintaan = @QtyPermintaan, " +
                  "QtyRealisasi = @QtyRealisasi, " +
                  "UserID = @UserID, " +
                  "TRX = '" + TRX() + "' " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                EditHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteHeader(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM headerpengeluaranbenang " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteHeader = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderPengeluaranBenang
            Dim SQL As String

            SQL = "SELECT * FROM headerpengeluaranbenang " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderPengeluaranBenang)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function AddDetail(ByVal Data As DetailPengeluaranBenang) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailpengeluaranbenang " +
            "(RowID, NoTransaksi, NoUrut, KodeProduksi, Qty) " +
            "VALUES " +
            "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeProduksi, @Qty)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM detailpengeluaranbenang " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String, ByVal Tanggal As DateTime, ByVal KodeShift As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "HB.NoTransaksi                                       AS 'Nomor', " +
                  "DATE(HB.TglPengeluaran)                              AS 'Tanggal', " +
                  "HB.NoPermintaan                                      AS 'No Permintaan', " +
                  "UP.NamaUnit                                          AS 'Unit Produksi', " +
                  "HB.NamaItem                                          AS 'Item Produksi', " +
                  "HB.QtyRealisasi                                      AS 'Qty' " +
                  "FROM headerpengeluaranbenang HB " +
                  "LEFT JOIN tunitproduksi UP ON UP.KodeUnit = HB.KodeUnit " +
                  "WHERE CONCAT(HB.NoTransaksi, ' ', " +
                  "             HB.Namaitem) LIKE @Kriteria "

            SQL += " AND DATE(HB.TglTransaksi) = @Tanggal AND HB.KodeShift='" & KodeShift & "'"

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

        Public Function ReadConsole(ByVal Tanggal As DateTime) As DataSet
            Dim SQL As String = ""

            SQL = "SELECT " +
                  "NomorWO                                          AS 'Nomor WO', " +
                  "SUM(QtyPengeluaran)                              AS 'Qty' " +
                  "FROM vpengeluaranbenangperwo " +
                  "WHERE DATE(vpengeluaranbenangperwo.TglTransaksi) = @Tanggal " +
                  "GROUP BY NomorWO ORDER BY NomorWO "

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

        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = "EXTK-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headerpengeluaranbenang " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

        Public Function ReadMiss() As DataSet
            Dim SQL As String = ""

            SQL = "SELECT * FROM headerpengeluaranbenang " +
                  "WHERE NoTransaksi>'EXTK-18122597' AND KodeGrup='C' "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ReadMiss = DS
            End Using
        End Function
    End Class

End Namespace

