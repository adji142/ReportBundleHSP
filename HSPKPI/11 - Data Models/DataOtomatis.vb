Imports Dapper

Namespace HSP.Data
    Public Class DataOtomatis
        Public Property Eff As String
        Public Property Hasil As String
        Public Property Afval As String
    End Class

    Public Class DaftarDataOtomatis
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Eff(ByVal TGL1 As Date, TGL2 As Date, NIK As String) As DataOtomatis
            Dim SQL As String

            SQL = "CALL PRC_EFISIENSI (@TGL1, @TGL2, @NIK) "

            Using DBX As IDbConnection = _DBConnection.Connection
                Eff = DBX.Query(Of DataOtomatis)(SQL, New With {.TGL1 = TGL1, .TGL2 = TGL2, .NIK = NIK}).FirstOrDefault
            End Using
        End Function

        Public Function Afv(ByVal TGL1 As Date, TGL2 As Date, NIK As String) As DataOtomatis
            Dim SQL As String

            SQL = "CALL Prc_Afval (@TGL1, @TGL2, @NIK) "

            Using DBX As IDbConnection = _DBConnection.Connection
                Afv = DBX.Query(Of DataOtomatis)(SQL, New With {.TGL1 = TGL1, .TGL2 = TGL2, .NIK = NIK}).FirstOrDefault
            End Using
        End Function

    End Class
End Namespace

