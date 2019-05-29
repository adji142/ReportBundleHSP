Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Class SAPKelompokCustomer
    Public Property KodeKelompok As String
    Public Property NamaKelompok As String
End Class

Public Class DaftarKelompokCustomer : Implements IDataLookup

    Public Function Read(ByVal Kriteria As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT * FROM ""TKELOMPOKCUSTOMER"" " +
              "ORDER BY ""KodeCustomer"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using
    End Function

    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup

    End Function
End Class
