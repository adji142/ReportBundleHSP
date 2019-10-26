Imports Dapper

Namespace HSP.Data
    Public Class HRKaryawan
        Public Property KodeKaryawan As String
        Public Property NamaKaryawan As String
        Public Property KodePosisi As String
    End Class

    Public Class DaftarHRKaryawan : Implements IDataLookup
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
            Dim KodePosisi As String = Parameter(1)
            Dim Periode As String = Parameter(2)

            Select Lookup
                Case enumLookupKaryawan.DaftarKaryawan

                    SQL = "SELECT DISTINCT " +
                          "A.KDKARYAWAN                             AS 'Kode', " +
                          "A.NMKARYAWAN                             AS 'Nama Karyawan' " +
                          "FROM KPI_KARYAWAN A "
                    If Periode <> "" Then
                        SQL += "WHERE (A.KDPOSISI = '" + KodePosisi + "') " +
                        "(IIF(YEAR(A.ResignDate)='1900' or A.ResignDate IS NULL,'999999',FORMAT(A.ResignDate,'yyyyMM'))> '" + Periode + "' AND FORMAT(A.JoinDate,'yyyyMM')<='" + Periode + "') "
                    Else
                        SQL += "WHERE A.ResignDate IS NULL "
                    End If
                    SQL += "AND CONCAT(A.KDKARYAWAN,' ',A.NMKARYAWAN) LIKE @Kriteria "
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

        Public Function Cek(ByVal ID As String) As HRKaryawan
            Dim SQL As String

            SQL = "SELECT KDKARYAWAN AS KodeKaryawan,NMKARYAWAN As NamaKaryawan, KDPOSISI as KodePosisi  FROM KPI_KARYAWAN " +
                  "WHERE KDPOSISI = @ID "

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Cek = DBX.Query(Of HRKaryawan)(SQL, New With {.ID = ID}).FirstOrDefault
            End Using
        End Function
        Public Function FindKaryawan(ByVal KDKARYAWAN As String) As HRKaryawan
            Dim SQL As String
            SQL = "SELECT KDKARYAWAN AS KodeKaryawan,NMKARYAWAN As NamaKaryawan, KDPOSISI as KodePosisi FROM KPI_KARYAWAN WHERE KDKARYAWAN = @KDKARYAWAN AND Resigndate IS NULL"

            Using DBX As IDbConnection = _HRDBConnection.Connection
                FindKaryawan = DBX.Query(Of HRKaryawan)(SQL, New With {.KDKARYAWAN = KDKARYAWAN}).FirstOrDefault
            End Using
        End Function

        Public Function ShowKaryawan(ByVal KodePosisi As String, ByVal Periode As String) As DataSet
            Dim SQL As String

            SQL = "SELECT DISTINCT " +
                  "A.KDKARYAWAN                             AS 'Kode', " +
                  "A.NMKARYAWAN                             AS 'Nama Karyawan' " +
                  "FROM KPI_KARYAWAN A " +
                  "WHERE A.KDPOSISI =@KodePosisi AND " +
                  "CASE WHEN YEAR(A.ResignDate)='1900' or A.ResignDate IS NULL then '9999/12/31' else A.ResignDate end  " +
                  ">= DATEADD(MONTH,-1, CAST( DATEADD(day,DATEDIFF(day,@Periode,CAST(DATEPART(year,@Periode) AS varchar)+'-'+ CAST( DATEPART(MM,@Periode) AS varchar) +'-26'),@Periode) as date)) AND " +
                  "A.JoinDate <= CAST( DATEADD(day,DATEDIFF(day,@Periode,CAST(DATEPART(year,@Periode) AS varchar)+'-'+ CAST( DATEPART(MM,@Periode) AS varchar) +'-25'),@Periode) as date) " +
                  "ORDER BY A.NMKARYAWAN"

            '            "IIF(YEAR(A.ResignDate)='1900' or A.ResignDate IS NULL,'999999',FORMAT(A.ResignDate,'yyyyMM'))> '" + Periode + "' AND FORMAT(A.JoinDate,'yyyyMM')<='" + Periode + "' AND " +
            '"CONCAT(A.KDKARYAWAN,' ',A.NMKARYAWAN) LIKE @Kriteria"

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet

                CMD.Parameters.AddWithValue("@KodePosisi", KodePosisi)
                CMD.Parameters.AddWithValue("@Periode", Periode)
                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                ShowKaryawan = DS
            End Using
        End Function
        Public Function Read() As DataSet
            Dim SQL As String

            SQL = "SELECT DISTINCT " +
                    "A.KDKARYAWAN                             AS 'Kode', " +
                    "A.NMKARYAWAN                             AS 'Nama Karyawan' " +
                    "FROM KPI_KARYAWAN A WHERE A.ResignDate IS NULL"

            Using DBX As IDbConnection = _HRDBConnection.Connection
                Dim CMD As New SqlClient.SqlCommand(SQL, DBX)
                Dim DA As New SqlClient.SqlDataAdapter
                Dim DS As New DataSet

                DA.SelectCommand = CMD
                DA.Fill(DS, "View")

                Read = DS
            End Using
        End Function


        Public Function Locked(ByVal ID As String) As Boolean
            Locked = False
        End Function
    End Class
End Namespace

