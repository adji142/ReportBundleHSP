Imports Dapper

Namespace HSP.Data
    Public Class QCUpdateStatusRoll
        Public Property RowID As String
        Public Property TglUpdate As DateTime
        Public Property KodeProduksi As String
        Public Property StatusQcLama As Byte
        Public Property StatusQcBaru As Byte
        Public Property KodeStatus As String
        Public Property KodeUnitLama As String
        Public Property KodeUnitBaru As String
        Public Property KetPeruntukanLama As String
        Public Property KetPeruntukanBaru As String
        Public Property KodeDisposisi As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarQCUpdateStatusRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As QCUpdateStatusRoll) As Integer
            Dim SQL As String

            SQL = "INSERT INTO qcupdatestatusroll " +
                               "(RowID, TglUpdate, KodeProduksi, StatusQcLama, StatusQcBaru, KodeStatus, KodeUnitLama, " +
                               "KodeUnitBaru, KetPeruntukanLama, KetPeruntukanBaru, KodeDisposisi, UserID, TRX) " +
                  "VALUES " +
                               "(REPLACE(UUID(), '-',''), @TglUpdate, @KodeProduksi, @StatusQcLama, @StatusQcBaru, @KodeStatus, @KodeUnitLama, " +
                               "@KodeUnitBaru, @KetPeruntukanLama, @KetPeruntukanBaru, @KodeDisposisi, @UserID,'" + TRX() + "') "

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

    End Class
End Namespace

