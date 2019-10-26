Imports Dapper

Namespace HSP.Data
    Public Class HROtomatis
        Public Property Absensi As String
        Public Property Telat As String
        Public Property SP As String
        Public Property JH As String
    End Class

    Public Class DaftarHROtomatis
        Private _HRDBConnection As HRDBConnection

        Sub New()
            _HRDBConnection = New HRDBConnection()
        End Sub

        Public Function Absensi(ByVal TGL1 As Date, TGL2 As Date, NIK As String) As HROtomatis
            Dim SQL As String

            SQL = "EXEC KPI_ABSENSI @TGL1, @TGL2, @NIK "

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Absensi = DBX.Query(Of HROtomatis)(SQL, New With {.TGL1 = TGL1, .TGL2 = TGL2, .NIK = NIK}).FirstOrDefault
            End Using
        End Function

        Public Function Telat(ByVal TGL1 As Date, TGL2 As Date, NIK As String) As HROtomatis
            Dim SQL As String

            SQL = "EXEC KPI_TELAT @TGL1, @TGL2, @NIK "

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Telat = DBX.Query(Of HROtomatis)(SQL, New With {.TGL1 = TGL1, .TGL2 = TGL2, .NIK = NIK}).FirstOrDefault '
            End Using
        End Function

        Public Function JH(ByVal TGL1 As Date, TGL2 As Date, NIK As String) As HROtomatis
            Dim SQL As String

            SQL = "EXEC KPI_JAMHILANG @TGL1, @TGL2, @NIK "

            Using DBX As IDbConnection = _HRDBConnection.Connection
                JH = DBX.Query(Of HROtomatis)(SQL, New With {.TGL1 = TGL1, .TGL2 = TGL2, .NIK = NIK}).FirstOrDefault '
            End Using
        End Function

        Public Function SP(ByVal TGL1 As Date, TGL2 As Date, NIK As String) As HROtomatis
            Dim SQL As String

            SQL = "EXEC KPI_SP @TGL1, @TGL2, @NIK "

            Using DBX As IDbConnection = _HRDBConnection.Connection
                SP = DBX.Query(Of HROtomatis)(SQL, New With {.TGL1 = TGL1, .TGL2 = TGL2, .NIK = NIK}).FirstOrDefault '
            End Using
        End Function
        
    End Class
End Namespace

