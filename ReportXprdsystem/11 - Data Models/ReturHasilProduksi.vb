Imports Dapper

Namespace HSP.Data
    Public Class HeaderReturHasilProduksi
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property NoRef As String
        Public Property KodeLokasiAsal As String
        Public Property KodeLokasiTujuan As String
        Public Property Keterangan As String
        Public Property UserID As String
        Public Property nPrint As Byte
        Public Property TRX As String
        Public Property Kelompok As Byte
    End Class

    Public Class DetailReturHasilProduksi
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeProduksi As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Packing As Double
        Public Property Pcs As Double
        Public Property Timbang As Double
        Public Property Keterangan As String
        Public Property Satuan1 As String
        Public Property Satuan2 As String
        Public Property Satuan3 As String
        Public Property Kelompok As Byte
    End Class

    Public Class DaftarReturHasilProduksi
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddHeader(ByVal Data As HeaderReturHasilProduksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headerreturhasilproduksi " +
                  "(RowID, NoTransaksi, TglTransaksi, NoRef, KodeLokasiAsal, KodeLokasiTujuan, " +
                  "Keterangan, UserID, nPrint, Kelompok, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @NoRef, @KodeLokasiAsal, @KodeLokasiTujuan, " +
                  "@Keterangan, @UserID, @nPrint, @Kelompok, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        'Public Function EditHeader(ByVal Data As HeaderPenyerahanHasilProduksi) As Integer
        '    Dim SQL As String

        '    SQL = "UPDATE headerpenyerahanhasilproduksi SET " +
        '          "NoTransaksi          = @NoTransaksi, " +
        '          "TglTransaksi         = @TglTransaksi, " +
        '          "NoRef                = @NoRef, " +
        '          "KodeLokasiAsal       = @KodeLokasiAsal, " +
        '          "KodeLokasiTujuan     = @KodeLokasiTujuan, " +
        '          "Keterangan           = @Keterangan, " +
        '          "UserID               = @UserID, " +
        '          "nPrint               = @nPrint, " +
        '          "TRX                  = @TRX " +
        '          "WHERE NoTransaksi    = @NoTransaksi"

        '    Using DBX As IDbConnection = _DBConnection.Connection
        '        EditHeader = DBX.Execute(SQL, Data)
        '    End Using
        'End Function

        Public Function FindHeader(ByVal ID As String) As HeaderReturHasilProduksi
            Dim SQL As String

            SQL = "SELECT * FROM headerreturhasilproduksi " +
                  "WHERE NoTransaksi = @NoTransaksi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderReturHasilProduksi)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function AddDetail(ByVal Data As DetailReturHasilProduksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailreturhasilproduksi " +
                  "(RowID, NoTransaksi, NoUrut, KodeProduksi, KodeItem, NamaItem, " +
                  "Packing, Pcs, Timbang, Keterangan, Satuan1, Satuan2, Satuan3, Kelompok) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeProduksi, @KodeItem, @NamaItem, " +
                  "@Packing, @Pcs, @Timbang, @Keterangan, @Satuan1, @Satuan2, @Satuan3, @Kelompok)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function DeleteDetail(ByVal ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM detailreturhasilproduksi " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteDetail = DBX.Execute(SQL, New With {.NoTransaksi = ID})
            End Using
        End Function

        Public Function ReadDetail(ByVal NoTransaksi As String) As DataSet
            Dim SQL As String

            SQL = "SELECT * FROM detailreturhasilproduksi " +
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
                Prefik = "RTHP-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headerreturhasilproduksi " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

