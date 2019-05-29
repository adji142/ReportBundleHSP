Imports Sap.Data.Hana
Imports HSPSchadulingWO.HSP.Data

Public Class WO
    Public Property Kode As String
    Public Property Lokasi As String
End Class

Public Class SAPWOList : Implements IDataLookup
    Public Function Read(ByVal Kriteria As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
            "a.""DocEntry"",a.""DocNum"", a.""PostDate"" ""Tanggal WO"", " +
            "a.U_SOL_NO_WO ""No WO"", a.U_SOL_ROUTING ""Routing"", " +
            "b.""ItemCode"" ""Kode Item"", b.""ItemName"" ""Nama Item"", " +
            "a.""PlannedQty"" ""Qty WO"" " +
            "from OWOR a " +
            "INNER JOIN OITM b on a.""ItemCode"" = b.""ItemCode"" " +
            "Where a.""PostDate"" = '" + Kriteria + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using
    End Function

    Public Function ReadWO(ByVal Kriteria As Date) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
            "a.""DocEntry"",a.""DocNum"", a.""PostDate"" ""Tanggal WO"", " +
            "a.U_SOL_NO_WO ""No WO"", a.U_SOL_ROUTING ""Routing"", " +
            "b.""ItemCode"" ""Kode Item"", b.""ItemName"" ""Nama Item"", " +
            "a.""PlannedQty"" ""Qty WO"" " +
            "from OWOR a " +
            "INNER JOIN OITM b on a.""ItemCode"" = b.""ItemCode"" " +
            "Where a.""PostDate"" = '" + Kriteria.ToString("yyyy-MM-dd") + "'"

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadWO = DS
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
