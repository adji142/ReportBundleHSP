Imports Sap.Data.Hana
Imports ReportBundleHSP.HSP.Data

Public Class LokasiSAP
    Public Property Kode As String
    Public Property Lokasi As String
End Class

Public Class DataWarehouse : Implements IDataLookup
    Public Function Read(ByVal Kriteria As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""WhsCode""        AS ""Kode"", " +
              "     ""WhsName""        AS ""Lokasi"" " +
              "FROM ""OWHS"" " +
              "WHERE ""WhsCode"" ||' '||""WhsName"" LIKE '%" + Kriteria + "%' " +
              "ORDER BY ""WhsName"" "

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

        SQL = "SELECT " +
              "     ""WhsCode""        AS ""Kode"", " +
              "     ""WhsName""        AS ""Lokasi"" " +
              "FROM ""OWHS"" " +
              "WHERE ""WhsCode"" ||' '||""WhsName"" LIKE '%" + TextSearch + "%' and U_beas_lck = 'VSP'" +
              "ORDER BY ""WhsName"" "

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
