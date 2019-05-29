Imports Dapper

Namespace HSP.Data

    Public Class TransferBenangKeluar
        Public Property RowID
        Public Property NoTransaksi
        Public Property TglTransaksi
        Public Property TglPencatatan
        Public Property KodeShift
        Public Property KodeGrup
        Public Property KodeItem
        Public Property NamaItem
        Public Property KodeArea
        Public Property KodeStatus
        Public Property KodeLokasiAsal
        Public Property KodeLokasiTujuan
        Public Property KodeProduksi
        Public Property BeratNetto
        Public Property Keterangan
        Public Property UserID
        Public Property TRX
        Public Property StatusTransaksi
    End Class

    Public Class DaftarTransferBenangKeluar
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TransferBenangKeluar) As Integer
            Dim SQL As String

            SQL = "INSERT INTO transferbenangkeluar " +
                  "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, KodeShift, KodeGrup, KodeItem, NamaItem, KodeArea, " +
                  "KodeStatus, KodeLokasiAsal, KodeLokasiTujuan, KodeProduksi, BeratNetto, Keterangan, UserID, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeShift, @KodeGrup, @KodeItem, @NamaItem, @KodeArea, " +
                  "@KodeStatus, @KodeLokasiAsal, @KodeLokasiTujuan, @KodeProduksi, @BeratNetto, @Keterangan, @UserID, '" + TRX() + "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function GetNomorTransaksi(PrefikTransaksi As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Periode = Periode.Substring(2, 4)

            Using DBX As IDbConnection = _DBConnection.Connection()

                Prefik = PrefikTransaksi + "-" + Periode

                SQL = "SELECT MAX(`NoTransaksi`) AS Total FROM transferbenangkeluar "

                Temp = (Val(Microsoft.VisualBasic.Right(DBX.Query(SQL).FirstOrDefault.Total, 5)) + 1).ToString
                Nomor = Temp.PadLeft(5).Replace(" ", "0")

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function
    End Class
End Namespace



