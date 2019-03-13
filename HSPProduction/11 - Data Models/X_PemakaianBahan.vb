Imports Dapper

Namespace HSP.Data
    Public Class X_PemakaianBahan
        Public Property NoTransaksi As String
        Public Property NomorWO As String
        Public Property KodeItem As String
        Public Property NamaItem As String
    End Class

    Public Class X_DaftarPemakaianBahan
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As X_PemakaianBahan) As Integer
            Dim SQL As String

            SQL = "INSERT INTO x_pemakaianbahan " +
                  "(NoTransaksi, NomorWO, KodeItem, NamaItem) " +
                  "VALUES " +
                  "(@NoTransaksi, @NomorWO, @KodeItem, @NamaItem)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ByVal NoTransaksi As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM x_pemakaianbahan " +
                  "WHERE NoTransaksi = @NoTransaksi"

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.NoTransaksi = NoTransaksi})
            End Using
        End Function
    End Class
End Namespace

