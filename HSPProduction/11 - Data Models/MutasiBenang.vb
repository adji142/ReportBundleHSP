Imports Dapper

Namespace HSP.Data
    Public Class HeaderMutasiBenang
        Public Property RowID
        Public Property NoTransaksi
        Public Property TglTransaksi
        Public Property KodeAreaLama
        Public Property KodeAreaBaru
        Public Property Keterangan
        Public Property UserID
        Public Property TRX
    End Class

    Public Class DaftarMutasiAreaExtruder
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub


        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(ByVal KodeLokasi As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = KodeLokasi + "-04-" + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT MAX(RIGHT(NoTransaksi,5)) AS Total FROM mutasiarea_extruder " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(16 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

