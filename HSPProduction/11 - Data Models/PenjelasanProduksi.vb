Imports Dapper

Namespace HSP.Data
    Public Class PenjelasanProduksi
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeUnit As String
        Public Property NomorWO As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property TglMulai As DateTime
        Public Property TglSelesai As DateTime
        Public Property QtyPlan As Double
        Public Property QtyHasilProduksi As Double
        Public Property Prosentase As Double
        Public Property Keterangan As String
        Public Property UserID As String
    End Class

    Public Class DaftarPenjelasanProduksi
        Private _DBConnection As DBConnection

        Sub New(Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As PenjelasanProduksi) As Integer
            Dim SQL As String = ""

            SQL = "INSERT INTO penjelasanproduksi " +
                  "(RowID, NoTransaksi, TglTransaksi, KodeUnit, NomorWO, KodeItem, NamaItem, TglMulai, TglSelesai, QtyPlan, QtyHasilProduksi, Prosentase, Keterangan, UserID) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @KodeUnit, @NomorWO, @KodeItem, @NamaItem, @TglMulai, @TglSelesai, @QtyPlan, @QtyHasilProduksi, @Prosentase, @Keterangan, @UserID)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Edit(ByVal Data As PenjelasanProduksi) As Integer
            Dim SQL As String = ""

            SQL = "UPDATE penjelasanproduksi SET " +
                  "NoTransaksi  = @NoTransaksi, " +
                  "TglTransaksi = @TglTransaksi, " +
                  "KodeUnit     = @KodeUnit, " +
                  "NomorWO      = @NomorWO, " +
                  "KodeItem     = @KodeItem, " +
                  "NamaItem     = @NamaItem, " +
                  "TglMulai     = @TglMulai, " +
                  "TglSelesai   = @TglSelesai, " +
                  "QtyPlan = @QtyPlan, " +
                  "QtyHasilProduksi  = @QtyHasilProduksi, " +
                  "Prosentase   = @Prosentase, " +
                  "Keterangan   = @Keterangan, " +
                  "UserID       = @UserID " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Edit = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String = ""

            SQL = "DELETE FROM penjelasanproduksi " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As PenjelasanProduksi
            Dim SQL As String = ""

            SQL = "SELECT * FROM penjelasanproduksi " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of PenjelasanProduksi)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal TglAwal As Date, ByVal TglAkhir As Date, ByVal Kriteria As String, KodeUnit As String) As DataSet
            Dim SQL As String = ""

            SQL = "SELECT " +
                  "NoTransaksi                              AS 'Nomor', " +
                  "TglTransaksi                             AS 'Tanggal', " +
                  "NomorWO                                  AS 'Nomor WO', " +
                  "KodeItem                                 AS 'Kode Item', " +
                  "NamaItem                                 AS 'Nama Item' " +
                  "FROM penjelasanproduksi " +
                  "WHERE CONCAT(NomorWO, ' ', KodeItem, ' ', NamaItem) LIKE @Kriteria "

            If KodeUnit <> "" Then
                SQL += " AND KodeUnit = '" + KodeUnit + "' "
            End If

            SQL += " AND TglTransaksi BETWEEN @TglAwal AND @TglAkhir "

            Kriteria = String.Concat(Space(1), Kriteria.Trim(), Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@TglAwal", TglAwal)
                CMD.Parameters.AddWithValue("@TglAkhir", TglAkhir)
                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)
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
                Prefik = "PJHP-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM penjelasanproduksi " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

