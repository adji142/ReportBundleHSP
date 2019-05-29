Imports Sap.Data.Hana
Imports HSPProduction.HSP.Data

Public Class RoutingSAP
    Public Property Kode As String
    Public Property Lokasi As String
End Class

Public Class SAPRouting : Implements IDataLookup
    Public Function Read(ByVal Kriteria As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""Code""        AS ""Kode"", " +
              "     ""Name""        AS ""Rounting"" " +
              "FROM ""@SOL_ROUTING"" " +
              "WHERE ""Code"" ||' '||""Name"" LIKE '%" + Kriteria + "%' " +
              "ORDER BY ""Name"" "

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
              "     ""Code""        AS ""Kode"", " +
              "     ""Name""        AS ""Rounting"" " +
              "FROM ""@SOL_ROUTING"" " +
              "WHERE ""Code"" ||' '||""Name"" LIKE '%" + TextSearch + "%' " +
              "ORDER BY ""Name"" "

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
