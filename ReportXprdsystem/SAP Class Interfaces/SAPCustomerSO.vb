Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Class SAPCustomerSO
    Public Property KodeCustomer As String
    Public Property NamaCustomer As String
End Class

Public Class SAPDaftarCustomerSO : Implements IDataLookup

    Public Function Read(ByVal Kriteria As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""CardCode""        AS ""Kode"", " +
              "     ""CardName""        AS ""Customer"" " +
              "FROM ""OCRD"" " +
              "WHERE ""CardType""='C' AND ""CardCode"" ||' '||""CardName"" LIKE '%" + Kriteria + "%' " +
              "ORDER BY ""CardName"" "

        'SELECT "CardCode", "CardName" FROM OCRD WHERE "CardType"='C' ORDER BY "CardName"

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
              "     ""CardCode""        AS ""Kode"", " +
              "     ""CardName""        AS ""Customer"" " +
              "FROM ""OCRD"" " +
              "WHERE ""CardType""='C' AND ""CardCode"" ||' '||""CardName"" LIKE '%" + TextSearch + "%' " +
              "ORDER BY ""CardName"" "

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
