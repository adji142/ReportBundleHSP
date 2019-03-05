Imports Dapper

Namespace HSP.Data
    Public Class TransaksiPricelistPrinting
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Harga1 As Double
        Public Property Harga2 As Double
        Public Property Harga3 As Double
        Public Property Kelompok As String
        Public Property Jenis As String
        Public Property Denier As String
        Public Property Merek As String
        Public Property Lebar As String
        Public Property Panjang As String
        Public Property Warna As String
        Public Property JmlSisiPrt As String
        Public Property JmlWrnPrt As String
        Public Property Jahit As String
    End Class

    Public Class DaftarTransaksiPricelistPrinting
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TransaksiPricelistPrinting) As Integer
            Dim SQL As String

            SQL = "INSERT INTO transaksipricelist_printing " +
                  "(NoTransaksi, TglTransaksi, KodeItem, NamaItem, Harga1, Harga2, Harga3, Kelompok, Jenis, Denier, Merek, Lebar, Panjang, Warna, JmlSisiPrt, JmlWrnPrt, Jahit) " +
                  "VALUES " +
                  "(@NoTransaksi, @TglTransaksi, @KodeItem, @NamaItem, @Harga1, @Harga2, @Harga3, @Kelompok, @Jenis, @Denier, @Merek, @Lebar, @Panjang, @Warna, @JmlSisiPrt, @JmlWrnPrt, @Jahit)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM transaksipricelist_printing " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function Find(ByVal ID As String) As TransaksiPricelistPrinting
            Dim SQL As String

            SQL = "SELECT * FROM transaksipricelist_printing " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of TransaksiPricelistPrinting)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function Find(ByVal Kelompok As String, ByVal JenisBenang As String, ByVal Denier As String, ByVal Brand As String) As TransaksiPricelistPrinting
            Dim SQL As String

            SQL = "SELECT * FROM transaksipricelist_printing " +
                   "WHERE Kelompok = '" + Kelompok + "' AND Jenis ='" + JenisBenang + "' AND Denier ='" + Denier + "' AND Merek ='" + Brand + "' " +
                   "ORDER BY TglTransaksi DESC LIMIT 1"

            Using DBX As IDbConnection = _DBConnection.Connection
                Find = DBX.Query(Of TransaksiPricelistPrinting)(SQL).FirstOrDefault
            End Using
        End Function

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.NoTransaksi                                    AS 'Nomor', " +
                  "A.TglTransaksi                                   AS 'Tanggal', " +
                  "IFNULL(B.NamaKelompok,'')                        AS 'Kelompok', " +
                  "A.Jenis                                          AS 'Jenis Karung', " +
                  "A.Denier                                         AS 'Denier', " +
                  "A.Merek                                          AS 'Merek' " +
                  "FROM transaksipricelist_printing A " +
                  "LEFT JOIN tkelompokitemsap B ON B.KodeKelompok = A.Kelompok " +
                  "GROUP BY A.NoTransaksi, B.NamaKelompok, A.Jenis, A.Denier, A.Merek "

            Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%")

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

        Public Function ReadDetail(ByVal NoTransaksi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM transaksipricelist_printing " +
                  "WHERE NoTransaksi = @NoTransaksi " +
                  "Group By Lebar, Panjang, Warna, JmlSisiPrt, JmlWrnPrt " +
                  "Order BY Lebar, Panjang, Warna, JmlSisiPrt, JmlWrnPrt "

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

        Public Function ReadDetail(ByVal Kelompok As String, ByVal JenisBenang As String, ByVal Denier As String, ByVal Brand As String) As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM transaksipricelist_printing " +
                  "WHERE Kelompok = '" + Kelompok + "' AND Jenis ='" + JenisBenang + "' AND Denier ='" + Denier + "' AND Merek ='" + Brand + "' " +
                  "Group By Lebar, Panjang, Warna, Printing " +
                  "Order BY Lebar, Panjang, Warna, Printing "

            Using DBX As IDbConnection = _DBConnection.Connection
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand(SQL, DBX)
                Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter
                Dim DS As New DataSet

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
                Prefik = "TRXP-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM transaksipricelist_printing " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

