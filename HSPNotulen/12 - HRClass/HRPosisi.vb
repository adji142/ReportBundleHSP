Imports Dapper

Namespace HSP.Data
    Public Class HRPosisi
        Public Property KodePosisi As String
        Public Property NamaPosisi As String
        Public Property KodeBagian As String
    End Class

    Public Class DaftarHRPosisi : Implements IDataLookup
        Private _HRDBConnection As HRDBConnection

        Public Enum enumLookupPosisi
            DaftarPosisi = 1
        End Enum

        Sub New()
            _HRDBConnection = New HRDBConnection()
        End Sub

        Public Function Read(ByVal Kriteria As String, Optional ByVal KodeBagian As String = "") As DataSet
            Dim SQL As String

            SQL = "SELECT " +
                  "A.KDPOSISI                            AS 'Kode', " +
                  "A.NMPOSISI                            AS 'Nama Posisi', " +
                  "A.KDBAG                               AS 'Kode Bagian', " +
                  "B.NMBAG                           	 AS 'Bagian' " +
                  "FROM KPI_POSISI A " +
                  "LEFT JOIN KPI_BAGIAN B ON A.KDBAG=B.KDBAG  " +
                  "WHERE CONCAT(A.KDPOSISI,' ',A.NMPOSISI) LIKE @Kriteria"

            If KodeBagian <> "" Then
                SQL += " AND A.KDBAG = '" + KodeBagian + "'"
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
            Dim KodeBagian As String = Parameter(1)

            Select Case Lookup
                Case enumLookupPosisi.DaftarPosisi

                    SQL = "SELECT " +
                          "A.KDPOSISI                            AS 'Kode', " +
                          "A.NMPOSISI                            AS 'Nama Posisi', " +
                          "B.NMBAG                           	 AS 'Bagian' " +
                          "FROM KPI_POSISI A " +
                          "LEFT JOIN KPI_BAGIAN B ON A.KDBAG=B.KDBAG  " +
                          "WHERE A.KDBAG = '" + KodeBagian + "' AND " +
                          "CONCAT(A.KDPOSISI,' ',A.NMPOSISI) LIKE @Kriteria"

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

