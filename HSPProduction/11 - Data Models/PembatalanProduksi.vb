Imports Dapper

Namespace HSP.Data
    Public Class PembatalanProduksi
        Public Property RowID As String
        Public Property TglPembatalan As DateTime
        Public Property IDProduksi As Byte
        Public Property NoTransaksi As String
        Public Property KodeProduksi As String
        Public Property KodeUnit As String
        Public Property KodeLokasi As String
        Public Property Keterangan As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarPembatalanProduksi
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As PembatalanProduksi) As Integer
            Dim SQL As String

            SQL = "INSERT INTO pembatalanproduksi " +
                               "(RowID, TglPembatalan, IDProduksi, NoTransaksi, KodeProduksi, KodeUnit, KodeLokasi, " +
                               "Keterangan, UserID, TRX) " +
                  "VALUES " +
                               "(REPLACE(UUID(), '-',''), @TglPembatalan, @IDProduksi, @NoTransaksi, @KodeProduksi, @KodeUnit, @KodeLokasi, " +
                               "@Keterangan, @UserID,'" + TRX() + "') "

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using

        End Function

    End Class
End Namespace

