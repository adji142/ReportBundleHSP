Imports Dapper
Namespace HSP.Data
    Public Class MExecute
        Private _HRISDbConnection As New HRISDbConnection
        Private _Periode As String
        Private _KodeKry As String

        Sub New()

        End Sub

        Public Function GetData(ByVal Periode As String, ByVal idkry As String) As DataSet
            Dim SQL As String

            SQL = "exec rsp_CutiPerUser '" + Periode + "','" + idkry + "'"

            Using DBX As IDbConnection = _HRISDbConnection.Connection

                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet
                DA.SelectCommand = CMD
                DA.Fill(DS)

                GetData = DS
            End Using
        End Function
        Public Function GetData_Late(ByVal IdKry As String) As DataSet
            Dim SQL As String

            SQL = "exec Rsp_botKeterlambatanPerKry '" + IdKry + "'"

            Using DBX As IDbConnection = _HRISDbConnection.Connection

                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet
                DA.SelectCommand = CMD
                DA.Fill(DS)

                GetData_Late = DS
            End Using
        End Function
        Public Function GetData_CutiAll(ByVal Periode As String, ByVal idkry As String, ByVal Bagian As String, ByVal Dept As String, ByVal Superior As String) As DataSet
            Dim SQL As String

            SQL = "exec rsp_CutiMultiUser '" + Periode + "','" + idkry + "','" + Dept + "','" + Bagian + "','" + Superior + "'"

            Using DBX As IDbConnection = _HRISDbConnection.Connection

                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet
                DA.SelectCommand = CMD
                DA.Fill(DS)

                GetData_CutiAll = DS
            End Using
        End Function
    End Class

End Namespace

