Imports Dapper

Namespace HSP.Data
    Public Class QCUpdateStatusBall
        Public Property RowID As String
        Public Property TglUpdate As DateTime
        Public Property KodeProduksi As String
        Public Property StatusQcLama As Byte
        Public Property StatusQcBaru As Byte
        Public Property KodeStatus As String
        Public Property KodeDisposisi As String
        Public Property UserID As String
        Public Property TRX As String
    End Class

    Public Class DaftarQCUpdateStatusBall
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As QCUpdateStatusBall) As Integer
            Dim SQL As String

            SQL = "INSERT INTO qcupdatestatusball " +
                               "(RowID, TglUpdate, KodeProduksi, StatusQcLama, StatusQcBaru, KodeStatus, " +
                               "KodeDisposisi, UserID, TRX) " +
                  "VALUES " +
                               "(REPLACE(UUID(), '-',''), @TglUpdate, @KodeProduksi, @StatusQcLama, @StatusQcBaru, @KodeStatus, " +
                               "@KodeDisposisi, @UserID,'" + TRX() + "') "

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

    End Class
End Namespace

