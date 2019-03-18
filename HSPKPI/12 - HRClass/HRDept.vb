Imports Dapper

Namespace HSP.Data
    Public Class HRDept
        Public Property KodeDept As String
        Public Property NamaDept As String
    End Class

    Public Class DaftarHRDept : Implements IDataLookup
        Private _HRDBConnection As HRDBConnection

        Public Enum enumLookupDept
            DaftarDept = 1
        End Enum

        Sub New()
            _HRDBConnection = New HRDBConnection()
        End Sub

        Public Function Read(ByVal Kriteria As String) As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "KDDEPT                           AS 'Kode', " +
                  "NMDEPT                           AS 'Departemen' " +
                  "FROM KPI_DEPT " +
                  "WHERE CONCAT(KDDEPT,' ',NMDEPT) LIKE @Kriteria"

            Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%")

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@Kriteria", Kriteria)

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using

        End Function

        Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
            Dim SQL As String
            Dim Lookup As String = Parameter(0)

            Select Case Lookup
                Case enumLookupDept.DaftarDept

                    SQL = "SELECT " +
                          "KDDEPT                            AS 'Kode', " +
                          "NMDEPT                            AS 'Departemen' " +
                          "FROM KPI_DEPT " +
                          "WHERE CONCAT(KDDEPT,' ',NMDEPT) LIKE @Kriteria"

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

