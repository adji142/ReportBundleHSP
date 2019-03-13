Imports Dapper
Imports HSPProduction.HSP.Data

Public Class HeaderPemakaianBahanLoom
    Public Property RowID As String
    Public Property NoTransaksi As String
    Public Property TglTransaksi As DateTime
    Public Property TglPencatatan As DateTime
    Public Property NomorWO As String
    Public Property KodeUnit As String
    Public Property KodeShift As String
    Public Property KodeGrup As String
    Public Property KodeLokasi As String
    Public Property KodeMesin As String
    Public Property FGKodeItem As String
    Public Property FGNamaItem As String
    Public Property FGQtyMeter As Double
    Public Property FGQtyTimbang As Double
    Public Property FGKodeProduksi As String
    Public Property UserID As String
    Public Property TRX As String
End Class

Public Class DetailPemakaianBahanLoom
    Public Property RowID As String
    Public Property NoTransaksi As String
    Public Property NoUrut As Integer
    Public Property RMKodeItem As String
    Public Property RMNamaItem As String
    Public Property RMQty As Double
    Public Property RMLokasi As String
End Class

Public Class DaftarPemakaianBahanLoom
    Private _DBConnection As DBConnection

    Sub New(ByVal Session As Object)
        _DBConnection = New DBConnection(Session)
    End Sub

    Public Function AddHeader(ByVal Data As HeaderPemakaianBahanLoom) As Integer
        Dim SQL As String

        SQL = "INSERT INTO headerpemakaianbahanloom " +
              "(RowID, NoTransaksi, TglTransaksi, TglPencatatan, NomorWO, KodeUnit, " +
              "KodeShift, KodeGrup, KodeLokasi, KodeMesin, FGKodeItem, FGNamaItem, " +
              "FGQtyMeter, FGQtyTimbang, FGKodeproduksi, UserID, TRX) " +
              "VALUES " +
              "(REPLACE(UUID(),'-',''), @NoTransaksi, @TglTransaksi, @TglPencatatan, @NomorWO, @KodeUnit, " +
              "@KodeShift, @KodeGrup, @KodeLokasi, @KodeMesin, @FGKodeItem, @FGNamaItem, " +
              "@FGQtyMeter, @FGQtyTimbang, @FGKodeproduksi, @UserID, '" + TRX() + "' )"

        Using DBX As IDbConnection = _DBConnection.Connection
            AddHeader = DBX.Execute(SQL, Data)
        End Using
    End Function

    Public Function AddDetail(ByVal Data As DetailPemakaianBahanLoom) As Integer
        Dim SQL As String

        SQL = "INSERT INTO detailpemakaianbahanloom " +
              "(RowID, NoTransaksi, NoUrut, RMKodeItem, RMNamaItem, RMQty, RMLokasi) " +
              "VALUES " +
              "(REPLACE(UUID(),'-',''), @NoTransaksi, @NoUrut, @RMKodeItem, @RMNamaItem, @RMQty, @RMLokasi) "

        Using DBX As IDbConnection = _DBConnection.Connection
            AddDetail = DBX.Execute(SQL, Data)
        End Using
    End Function
End Class
