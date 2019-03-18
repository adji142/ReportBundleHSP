Imports Dapper

Namespace HSP.Data

    Public Class DaftarHRKaryawan_HRD : Implements IDataLookup
        Private _HRDBConnection As HRDBConnection

        Public Enum enumLookupKaryawan
            DaftarKaryawan = 1
        End Enum

        Sub New()
            _HRDBConnection = New HRDBConnection()
        End Sub

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Lookup As String = Parameter(0)


            Select Case Lookup
                Case enumLookupKaryawan.DaftarKaryawan

                    SQL = "SELECT * FROM VW_HrKaryawan A " +
                          "WHERE CONCAT(A.EmpNo,' ',A.FullName) LIKE @Kriteria"

                    TextSearch = String.Concat(Space(1), TextSearch.Trim, Space(1)).Replace(" ", "%")

            End Select

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", TextSearch)

                DA.SelectCommand = CMD
                DA.Fill(DS, "Lookup")

                GetLookup = DS
            End Using
        End Function
        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function
    End Class
End Namespace

