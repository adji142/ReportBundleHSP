Imports Dapper

Namespace HSP.Data
    Public Class TmpItemRoll
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property BeratStandart As Double
    End Class

    Public Class DaftarTmpItemRoll
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TmpItemRoll) As Integer
            Dim SQL As String = ""

            SQL = "INSERT INTO x_tmp_itemroll " +
                  "(KodeItem, NamaItem, BeratStandart) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @BeratStandart) "

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using

        End Function

        Public Function DeleteAll() As Integer
            Dim SQL As String = ""
            SQL = "DELETE FROM x_tmp_itemroll"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteAll = DBX.Execute(SQL)
            End Using
        End Function

    End Class
End Namespace

