Imports Dapper

Namespace HSP.Data
    Public Class TempStockBatch
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property KodeProduksi As String
        Public Property Qty As Double
        Public Property KodeUnitSAP As String
        Public Property KodeLokasi As String
    End Class

    Public Class DaftarTempStockBatch
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As TempStockBatch) As Integer
            Dim SQL As String = ""

            SQL = "INSERT INTO x_rpt_stockbatch " +
                  "(KodeItem, NamaItem, KodeProduksi, Qty, KodeUnitSAP, KodeLokasi) " +
                  "VALUES " +
                  "(@KodeItem, @NamaItem, @KodeProduksi, @Qty, @KodeUnitSAP, @KodeLokasi) "

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using

        End Function

        Public Function DeleteAll() As Integer
            Dim SQL As String = ""
            SQL = "DELETE FROM x_rpt_stockbatch"

            Using DBX As IDbConnection = _DBConnection.Connection
                DeleteAll = DBX.Execute(SQL)
            End Using
        End Function

        Public Function AddTempConsole(KodeLokasi As String, Kelompok As String)
            Dim SQL As String = ""

            SQL = "CALL sp_stockbatch_console('" & KodeLokasi & "', '" & Kelompok & "')"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddTempConsole = DBX.Execute(SQL)
            End Using
        End Function

        Public Function AddTempSap()
            Dim SQL As String = ""

            SQL = "CALL sp_stockbatch_sap"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddTempSap = DBX.Execute(SQL)
            End Using
        End Function

        Public Function AddKontrol()
            Dim SQL As String = ""

            SQL = "CALL sp_kontrol_batch"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddKontrol = DBX.Execute(SQL)
            End Using
        End Function
    End Class
End Namespace

