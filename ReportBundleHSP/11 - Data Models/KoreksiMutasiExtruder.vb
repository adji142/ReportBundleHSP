Imports Dapper

Namespace HSP.Data
    Public Class KoreksiMutasiExtruder
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property KodeProduksi As String
        Public Property KodeShiftBaru As String
        Public Property KodeShiftLama As String
        Public Property KodeGrupBaru As String
        Public Property KodeGrupLama As String
        Public Property KodeStatusBaru As Byte
        Public Property KodeStatusLama As Byte
        Public Property KodeUnitBaru As String
        Public Property KodeUnitLama As String
        Public Property KodeMesinBaru As String
        Public Property KodeMesinLama As String
        Public Property KodeItemBaru As String
        Public Property KodeItemLama As String
        Public Property Keterangan As String
        Public Property UserID As String
    End Class

    Public Class DaftarKoreksiMutasiExtruder
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As KoreksiMutasiExtruder) As Integer
            Dim SQL As String

            SQL = "INSERT INTO koreksimutasi_extruder " +
            "(RowID, NoTransaksi, " +
            "TglTransaksi, KodeProduksi, " +
            "KodeShiftBaru, KodeShiftLama, " +
            "KodeGrupBaru, KodeGrupLama, " +
            "KodeStatusBaru, KodeStatusLama, " +
            "KodeUnitBaru, KodeUnitLama, " +
            "KodeMesinBaru, KodeMesinLama, " +
            "KodeItemBaru, KodeItemLama, " +
            "Keterangan, UserID) " +
            "VALUES " +
            "(REPLACE(UUID(),'-',''), @NoTransaksi, " +
            "@TglTransaksi, @KodeProduksi, " +
            "@KodeShiftBaru, @KodeShiftLama, " +
            "@KodeGrupBaru, @KodeGrupLama, " +
            "@KodeStatusBaru, @KodeStatusLama, " +
            "@KodeUnitBaru, @KodeUnitLama, " +
            "@KodeMesinBaru, @KodeMesinLama, " +
            "@KodeItemBaru, @KodeItemLama, " +
            "@Keterangan, @UserID)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        'Get Nomor Transaksi
        Public Function GetNomorTransaksi(ByVal KodeLokasi As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            'Rubah Format Periode Dari YYYYMM Menjadi YYMM
            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                'Prefik Nomor Transaksi
                '------------------------------------------------------------------------------------------
                Prefik = KodeLokasi + "-03-" + Periode
                '------------------------------------------------------------------------------------------

                'Nomor Transaksi
                '------------------------------------------------------------------------------------------
                SQL = "SELECT MAX(RIGHT(NoTransaksi,5)) AS Total FROM koreksimutasi_extruder " +
                      "WHERE LEFT(NoTransaksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(16 - Prefik.Length).Replace(" ", "0")
                '------------------------------------------------------------------------------------------

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace

