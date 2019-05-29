Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Class SAPCustomer
    Public Property KodeCustomer As String
    Public Property NamaCustomer As String
    Public Property KodeKelompok As String
End Class

Public Class SAPDaftarCustomer : Implements IDataLookup

    Public Function Read(ByVal Kriteria As String, Optional ByVal KodeKelompok As String = "") As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""KodeCustomer""        AS ""Kode"", " +
              "     ""NamaCustomer""        AS ""Customer"" " +
              "FROM ""TCUSTOMER"" " +
              "WHERE ""KodeCustomer"" ||' '||""NamaCustomer"" LIKE '%" + Kriteria + "%' "

        If KodeKelompok <> "" Then
            SQL += " AND ""KodeKelompok"" = '" + KodeKelompok + "' "
        End If

        SQL += " ORDER BY ""KodeCustomer"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using
    End Function

    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements HSP.Data.IDataLookup.GetLookup
        Dim DB As New SAPDBConnection
        Dim SQL As String

        Dim KodeKelompok As String = Parameter(0)

        SQL = "SELECT " +
              "     ""KodeCustomer""        AS ""Kode"", " +
              "     ""NamaCustomer""        AS ""Customer"" " +
              "FROM ""TCUSTOMER"" " +
              "WHERE ""KodeCustomer""||' '||""NamaCustomer"" LIKE '%" + TextSearch + "%' "

        If KodeKelompok <> "" Then
            SQL += " AND ""KodeKelompok"" = '" + KodeKelompok + "' "
        End If

        SQL += " ORDER BY ""KodeCustomer"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "Lookup")

            GetLookup = DS
        End Using
    End Function
End Class
