Imports Sap.Data.Hana
Imports HSPSchadulingWO.HSP.Data

Public Class LokasiSAP
    Public Property Kode As String
    Public Property Lokasi As String
End Class

Public Class SAPLokasi : Implements IDataLookup
    Public Function Read(ByVal Kriteria As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""WhsCode""        AS ""Kode"", " +
              "     ""WhsName""        AS ""Lokasi"" " +
              " FROM ""OWHS"" " +
              " WHERE ""WhsCode"" = '" + Kriteria + "' and ""U_beas_lck"" = 'VSP'" +
              " ORDER BY ""WhsName"" "

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
        Dim WhsCode = ""
        If (Parameter IsNot Nothing) Then
            WhsCode = Parameter(0)
        End If
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""WhsCode""        AS ""Kode"", " +
              "     ""WhsName""        AS ""Lokasi"" " +
              "FROM ""OWHS"" " +
              "WHERE CONCAT(""WhsCode"",""WhsName"") LIKE '" + TextSearch + "' and ""U_beas_lck"" = 'VSP' " '+
        '"ORDER BY ""WhsName"" "
        If WhsCode <> "" Then
            SQL += "AND ""WhsCode"" LIKE '%" + WhsCode + "%'"
        End If
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
