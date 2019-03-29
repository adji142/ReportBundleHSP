Imports Dapper
Namespace HSP.Data
    Public Class DaftarArea : Implements IDataLookup
        Private _DBConnection As DBConnection
        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub
        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup

        End Function
    End Class
End Namespace
