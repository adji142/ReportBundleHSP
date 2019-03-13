Imports Dapper

Namespace HSP.Data

    Public Class ProduksiBenangExtruder
        Public Property RowID As String
        Public Property NoTransaksi As String
        Public Property TglTransaksi As DateTime
        Public Property TglTimbang As DateTime
        Public Property NomorWO As String
        Public Property KodeUnitSAP As String
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeShift As String
        Public Property KodeGrup As String
        Public Property KodeUnit As String
        Public Property KodeMesin As String
        Public Property Keterangan As String
        Public Property KodeLokasi As String
        Public Property KodeProduksi As String
        Public Property BeratBrutto As Double
        Public Property KodeMedia1 As String
        Public Property KodeMedia2 As String
        Public Property KodeMedia3 As String
        Public Property JumlahMedia1 As Double
        Public Property JumlahMedia2 As Double
        Public Property JumlahMedia3 As Double
        Public Property BeratMedia1 As Double
        Public Property BeratMedia2 As Double
        Public Property BeratMedia3 As Double
        Public Property BeratNetto As Double
        Public Property KodeArea As String
        Public Property StatusQC As Byte
        Public Property InputData As Byte
        Public Property UserID As String
        Public Property TRX As String
        Public Property PrevShift As Byte
    End Class

    Public Class DaftarProduksiBenangExtruder
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As ProduksiBenangExtruder) As Integer
            Dim SQL As String

            SQL = "INSERT INTO produksibenangextruder " +
                  "(RowID, NoTransaksi, TglTransaksi, TglTimbang, NomorWO, KodeUnitSAP, KodeItem, NamaItem, KodeShift, KodeGrup, KodeUnit, KodeMesin, Keterangan, " +
                  "KodeLokasi, KodeProduksi, BeratBrutto, KodeMedia1, KodeMedia2, KodeMedia3, JumlahMedia1, JumlahMedia2, JumlahMedia3, " +
                  "BeratMedia1, BeratMedia2, BeratMedia3, BeratNetto, KodeArea, StatusQC, InputData, UserID, PrevShift, TRX) " +
                  "VALUES " +
                  "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglTimbang, @NomorWO, @KodeUnitSAP, @KodeItem, @NamaItem, @KodeShift, @KodeGrup, @KodeUnit, @KodeMesin, @Keterangan, " +
                  "@KodeLokasi, @KodeProduksi, @BeratBrutto, @KodeMedia1, @KodeMedia2, @KodeMedia3, @JumlahMedia1, @JumlahMedia2, @JumlahMedia3, " +
                  "@BeratMedia1, @BeratMedia2, @BeratMedia3, @BeratNetto, @KodeArea, @StatusQC, @InputData, @UserID, @PrevShift, '" + TRX() + "')"

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

                SQL = "SELECT MAX(`NoTransaksi`) AS Total FROM produksibenangextruder "

                Temp = (Val(Microsoft.VisualBasic.Right(DBX.Query(SQL).FirstOrDefault.Total, 5)) + 1).ToString
                Nomor = Temp.PadLeft(5).Replace(" ", "0")

            End Using
            GetNomorTransaksi = Prefik + Nomor

        End Function

        Public Function GetKodeProduksi(KodeUnit As String, ByVal KodeMesin As String, ByVal Periode As String) As String
            Dim SQL As String
            Dim Prefik, Nomor, Temp As String

            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = New DaftarUnitProduksi(ActiveSession).Find(KodeUnit).PrefikKodeProduksi.Trim() + Periode

                SQL = "SELECT COUNT(*) AS Total FROM stockbenangextruder " +
                      "WHERE LEFT(KodeProduksi, LENGTH(@Prefik)) = @Prefik "

                Temp = (DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total + 1).ToString
                Nomor = Temp.PadLeft(13 - Prefik.Length).Replace(" ", "0")

            End Using
            GetKodeProduksi = Prefik + KodeMesin + Nomor

        End Function

        Public Function GetLastKodeProduksi(KodeUnit As String, ByVal KodeMesin As String, ByVal Periode As String) As Integer
            Dim SQL As String
            Dim Prefik As String
            Using DBX As IDbConnection = _DBConnection.Connection()
                Prefik = New DaftarUnitProduksi(ActiveSession).Find(KodeUnit).PrefikKodeProduksi.Trim() + Periode

                SQL = "SELECT COUNT(*) AS Total FROM stockbenangextruder " +
                      "WHERE LEFT(`KodeProduksi`, LENGTH(@Prefik)) = @Prefik "

                GetLastKodeProduksi = DBX.Query(SQL, New With {.Prefik = Prefik}).FirstOrDefault.Total
            End Using
        End Function
    End Class
End Namespace
