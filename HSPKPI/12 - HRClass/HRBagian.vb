Imports Dapper

Namespace HSP.Data
    Public Class HRBagian
        Public Property KodeBagian As String
        Public Property NamaBagian As String
        Public Property KodeDepartemen As String
    End Class

    Public Class DaftarHRBagian : Implements IDataLookup
        Private _HRDBConnection As HRDBConnection

        Public Enum enumLookupBagian
            DaftarBagian = 1
        End Enum

        Sub New()
            _HRDBConnection = New HRDBConnection()
        End Sub

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeDepartemen As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KDBAG                            AS 'Kode', " +
                  "A.NMBAG                            AS 'Nama Bagian', " +
                  "A.KDDEPT                           AS 'Kode Dept', " +
                  "B.NMDEPT                           AS 'Departemen' " +
                  "FROM KPI_BAGIAN A " +
                  "LEFT JOIN KPI_DEPT B ON A.KDDEPT=B.KDDEPT " +
                  "WHERE CONCAT(A.KDBAG,' ',A.NMBAG) LIKE @Kriteria"

            If KodeDepartemen <> "" Then
                SQL += " AND A.KDDEPT = '" + KodeDepartemen + "'"
            End If

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
            Dim KodeDept As String = Parameter(1)

            Select Case Lookup
                Case enumLookupBagian.DaftarBagian

                    SQL = "SELECT " +
                          "A.KDBAG                            AS 'Kode', " +
                          "A.NMBAG                            AS 'Nama Bagian', " +
                          "B.NMDEPT                           AS 'Departemen' " +
                          "FROM KPI_BAGIAN A " +
                          "LEFT JOIN KPI_DEPT B ON A.KDDEPT=B.KDDEPT " +
                          "WHERE A.KDDEPT = '" + KodeDept + "' AND " +
                          "CONCAT(A.KDBAG,' ',A.NMBAG) LIKE @Kriteria"

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

