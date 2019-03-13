Imports Sap.Data.Hana
Imports HSPProduction.HSP.Data

Public Class SAPKelompokItem
    Public Property KodeKelompok As String
    Public Property NamaKelompok As String
End Class

Public Class DaftarSAPKelompokItem : Implements IDataLookup

    Public Function Read(ByVal Kriteria As String, Optional ByVal Kelompok As String = "") As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "       CAST(""ItmsGrpCod"" AS VARCHAR)           AS ""Kode"", " +
              "       ""ItmsGrpNam""                            AS ""Kelompok"" " +
              "FROM ""OITB"" " +
              "WHERE ""ItmsGrpCod"" ||' '||""ItmsGrpNam"" LIKE '%" + Kriteria + "%' "

        If Kelompok <> "" Then
            SQL += " AND ""ItmsGrpCod"" IN(" + Kelompok + ") "
        End If

        SQL += "ORDER BY ""ItmsGrpCod"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using

    End Function

    Public Function ReadKelompok(Optional ByVal Kelompok As String = "") As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "       CAST(""ItmsGrpCod"" AS VARCHAR)           AS ""Kode"", " +
              "       ""ItmsGrpNam""                            AS ""Kelompok"" " +
              "FROM ""OITB"" " +
              "WHERE CAST(""ItmsGrpCod"" AS VARCHAR)<>'' "

        If Kelompok <> "" Then
            SQL += " AND ""ItmsGrpCod"" IN(" + Kelompok + ") "
        End If

        SQL += "ORDER BY ""ItmsGrpCod"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadKelompok = DS
        End Using

    End Function


    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements HSP.Data.IDataLookup.GetLookup
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "       CAST(""ItmsGrpCod"" AS VARCHAR)           AS ""Kode"", " +
              "       ""ItmsGrpNam""                            AS ""Kelompok"" " +
              "FROM ""OITB"" " +
              "WHERE ""ItmsGrpCod"" ||' '||""ItmsGrpNam"" LIKE '%" + TextSearch + "%' " +
              "ORDER BY ""ItmsGrpCod"" "

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
