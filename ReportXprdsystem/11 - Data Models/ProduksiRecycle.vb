Imports Dapper

Namespace HSP.Data


    Public Class HeaderProduksiRecycle
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeLokasi As String
        Public Property Keterangan As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DetailProduksiRecycle
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property NoUrut As Integer
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property Qty As Double
        Public Property Satuan As String
        Public Property Keterangan As String
    End Class

    Public Class DaftarProduksiRecycle
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function AddHeader(ByVal Data As HeaderProduksiRecycle) As Integer
            Dim SQL As String

            SQL = "INSERT INTO headerproduksirecycle " +
                  "(RowID, NoTransaksi, TglTransaksi, KodeShift, KodeGrup, KodeLokasi, Keterangan, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @KodeShift, @KodeGrup, @KodeLokasi, @Keterangan, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddHeader = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function FindHeader(ByVal ID As String) As HeaderProduksiRecycle
            Dim SQL As String

            SQL = "SELECT * FROM headerproduksirecycle " +
                  "WHERE NoTransaksi = @NoTranskasi "

            Using DBX As IDbConnection = _DBConnection.Connection
                FindHeader = DBX.Query(Of HeaderProduksiRecycle)(SQL, New With {.NoTransaksi = ID}).FirstOrDefault
            End Using
        End Function

        Public Function AddDetail(ByVal Data As DetailProduksiRecycle) As Integer
            Dim SQL As String

            SQL = "INSERT INTO detailproduksirecycle " +
                  "(RowID, NoTransaksi, NoUrut, KodeItem, NamaItem, Qty, Satuan, Keterangan) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @KodeItem, @NamaItem, @Qty, @Satuan, @Keterangan)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddDetail = DBX.Execute(SQL, Data)
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
                Prefik = "RSHP-" & Periode

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT COUNT(*) AS Total FROM headerproduksirecycle " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace
