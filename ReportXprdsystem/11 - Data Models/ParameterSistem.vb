Imports Dapper

Namespace HSP.Data
    Public Class ParameterSistem
        Public Property LoomPS1 As Double
        Public Property LoomPS2 As Double
        Public Property LoomPS3 As Double

        Public Property PackingPcsToleransiOver As Double
        Public Property PackingPcsToleransiUnder As Double
    End Class

    Public Class DaftarParameterSistem
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function GetParameterSistem() As ParameterSistem
            Dim SQL As String

            SQL = "SELECT * FROM parametersistem "

            Using DBX As IDbConnection = _DBConnection.Connection
                GetParameterSistem = DBX.Query(Of ParameterSistem)(SQL).FirstOrDefault
            End Using
        End Function
    End Class
End Namespace

