Imports Dapper
Imports HSPProduction.HSP.Data

Public Class TransferBenangMasuk
    Public Property RowID As String
    Public Property NoTransaksi As String
    Public Property TglTransaksi As DateTime
    Public Property TglPencatatan As DateTime
    Public Property KodeShift As String
    Public Property KodeGrup As String
    Public Property PrevShift As Byte
    Public Property KodeItem As String
    Public Property NamaItem As String
    Public Property KodeArea As String
    Public Property KodeStatus As Byte
    Public Property KodeLokasiAsal As String
    Public Property KodeLokasiTujuan As String
    Public Property BeratBrutto As Double
    Public Property KodeMedia1 As String
    Public Property KodeMedia2 As String
    Public Property KodeMedia3 As String
    Public Property BeratMedia1 As Double
    Public Property BeratMedia2 As Double
    Public Property BeratMedia3 As Double
    Public Property JumlahMedia1 As Double
    Public Property JumlahMedia2 As Double
    Public Property JumlahMedia3 As Double
    Public Property BeratNetto As Double
    Public Property Jumlah1 As Double
    Public Property Jumlah2 As Double
    Public Property Jumlah3 As Double
    Public Property Satuan1 As String
    Public Property Satuan2 As String
    Public Property Satuan3 As String
    Public Property Keterangan As String
    Public Property UserID As String
    Public Property TRX As String
End Class

Public Class DaftarTransferBenangMasuk
    Private _DBConnection As DBConnection

    Sub New(ByVal Session As Object)
        _DBConnection = New DBConnection(Session)
    End Sub

    Public Function Add(ByVal Data As TransferBenangMasuk) As Integer
        Dim SQL As String

        SQL = "INSERT INTO transferbenangmasuk " +
              "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, KodeShift, KodeGrup, PrevShift, " +
              "KodeItem, NamaItem, KodeArea, KodeStatus, KodeLokasiAsal, KodeLokasiTujuan, BeratBrutto, " +
              "KodeMedia1, KodeMedia2, KodeMedia3, BeratMedia1, BeratMedia2, BeratMedia3, JumlahMedia1, " +
              "JumlahMedia2, JumlahMedia3, BeratNetto, Jumlah1, Jumlah2, Jumlah3, Satuan1, Satuan2, Satuan3, " +
              "Keterangan, UserID, TRX) " +
              "VALUES " +
              "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @KodeShift, @KodeGrup, @PrevShift, " +
              "@KodeItem, @NamaItem, @KodeArea, @KodeStatus, @KodeLokasiAsal, @KodeLokasiTujuan, @BeratBrutto, " +
              "@KodeMedia1, @KodeMedia2, @KodeMedia3, @BeratMedia1, @BeratMedia2, @BeratMedia3, @JumlahMedia1, " +
              "@JumlahMedia2, @JumlahMedia3, @BeratNetto, @Jumlah1, @Jumlah2, @Jumlah3, @Satuan1, @Satuan2, @Satuan3, " +
              "@Keterangan, @UserID, '" + TRX() + "') "

        Using DBX As IDbConnection = _DBConnection.Connection
            Add = DBX.Execute(Sql, Data)
        End Using

    End Function
    Public Function GetNomorTransaksi(PrefikTransaksi As String, ByVal Periode As String) As String
        Dim SQL As String
        Dim Prefik, Nomor, Temp As String

        Periode = Periode.Substring(2, 4)

        Using DBX As IDbConnection = _DBConnection.Connection()

            Prefik = PrefikTransaksi + "-" + Periode

            SQL = "SELECT MAX(`NoTransaksi`) AS Total FROM transferbenangmasuk "

            Temp = (Val(Microsoft.VisualBasic.Right(DBX.Query(SQL).FirstOrDefault.Total, 5)) + 1).ToString
            Nomor = Temp.PadLeft(5).Replace(" ", "0")

        End Using
        GetNomorTransaksi = Prefik + Nomor

    End Function

End Class
