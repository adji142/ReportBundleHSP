Imports Dapper

Namespace HSP.Data
    Public Class RptPlanWO
        Public Property ID As String
        Public Property NomorWO As String
        Public Property TglMulai As DateTime
        Public Property TglSelesai As DateTime
        Public Property KodeItem As String
        Public Property NamaItem As String
        Public Property QtyPlan As Double
        Public Property Satuan As String
        Public Property Unit As String
        Public Property StatusWO As String
    End Class

    Public Class DaftarRptPlanWO
        Private _DBConnection As DBConnection

        Sub New(ByVal Session As Object)
            _DBConnection = New DBConnection(Session)
        End Sub

        Public Function Add(ByVal Data As RptPlanWO) As Integer
            Dim SQL As String

            SQL = "INSERT INTO x_rpt_planwo " +
                  "(ID, NomorWO, TglMulai, TglSelesai, KodeItem, NamaItem, QtyPlan, Satuan, Unit, StatusWO) " +
                  "VALUES " +
                  "(@ID, @NomorWO, @TglMulai, @TglSelesai, @KodeItem, @NamaItem, @QtyPlan, @Satuan, @Unit, @StatusWO)"

            Using DBX As IDbConnection = _DBConnection.Connection
                Add = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function AddTest(ByVal Data As RptPlanWO) As Integer
            Dim SQL As String

            SQL = "INSERT INTO x_rpt_planwo_test " +
                  "(ID, NomorWO, TglMulai, TglSelesai, KodeItem, NamaItem, QtyPlan, Satuan, Unit, StatusWO) " +
                  "VALUES " +
                  "(@ID, @NomorWO, @TglMulai, @TglSelesai, @KodeItem, @NamaItem, @QtyPlan, @Satuan, @Unit, @StatusWO)"

            Using DBX As IDbConnection = _DBConnection.Connection
                AddTest = DBX.Execute(SQL, Data)
            End Using
        End Function

        Public Function Delete(ID As String) As Integer
            Dim SQL As String

            SQL = "DELETE FROM x_rpt_planwo " +
                  "WHERE ID = @ID "

            Using DBX As IDbConnection = _DBConnection.Connection
                Delete = DBX.Execute(SQL, New With {.ID = ID})
            End Using
        End Function

        Public Function Truncate() As Integer
            Dim SQL As String

            SQL = "TRUNCATE TABLE x_rpt_planwo " 

            Using DBX As IDbConnection = _DBConnection.Connection
                Truncate = DBX.Execute(SQL)
            End Using
        End Function
    End Class
End Namespace

