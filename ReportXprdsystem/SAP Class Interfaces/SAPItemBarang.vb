Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Class SAPItemBarang
    Public Property KodeKelompok As String
    Public Property KodeItem As String
    Public Property NamaItem As String
End Class

Public Class DaftarSAPItemBarang : Implements IDataLookup

    Public Function ReadJenisBenang() As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              "       ""U_SOL_BNG_JENIS""                              AS ""Kode"" " +
              "FROM ""OITM"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadJenisBenang = DS
        End Using
    End Function

    Public Function ReadDenier() As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              "       ""U_SOL_BNG_DENIER""                              AS ""Kode"" " +
              "FROM ""OITM"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadDenier = DS
        End Using
    End Function

    Public Function ReadBrand() As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT DISTINCT " +
              "       IFNULL(""U_SOL_CUT_MERKDAGANG"",'')                              AS ""Kode"" " +
              "FROM ""OITM"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadBrand = DS
        End Using
    End Function

    Public Function Read(Optional ByVal Kelompok As String = "") As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "       ""ItemCode""                              AS ""Kode"", " +
              "       ""ItemName""                              AS ""Nama Item"", " +
              "       ""ItmsGrpNam""                            AS ""Kelompok"" " +
              "FROM ""OITM"" A " +
              "LEFT JOIN ""OITB"" B ON B.""ItmsGrpCod"" = A.""ItmsGrpCod"" "

        If Kelompok <> "" Then
            SQL += " WHERE A.""ItmsGrpCod"" ='" + Kelompok + "' "
        End If

        SQL += "ORDER BY A.""ItemCode"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using

    End Function

    Public Function Read(ByVal Kelompok As String, ByVal JenisBenang As String, ByVal Denier As String, ByVal Brand As String, Optional ByVal Printing As Boolean = False) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        If Printing = True Then
            SQL = "SELECT DISTINCT " +
                          "     U_SOL_LOM_LEBAR                                                  AS ""Lebar"", " +
                          "     U_SOL_CUT_PJGKRG                                                 AS ""PjgKarung"", " +
                          "     IFNULL(U_SOL_LOM_BLOCKWARNA,'')                                  AS ""Warna"", " +
                          "     IFNULL(U_SOL_PRT_JMLSSPRNT,'')                                   AS ""Sisi"", " +
                          "     IFNULL(U_SOL_PRT_JMLWRNDPN,'')                                   AS ""WrnPrint"" " +
                          "FROM OITM " +
                          "WHERE ""ItmsGrpCod"" ='" & Kelompok & "' AND " +
                          "     U_SOL_BNG_DENIER='" & Denier & "' AND " +
                          "     U_SOL_BNG_JENIS='" & JenisBenang & "' AND " +
                          "     (IFNULL(U_SOL_CUT_MERKDAGANG,'')='" & Brand & "' OR (case when U_SOL_CUT_MERKDAGANG='*' then '' end)='" & Brand & "') AND ""validFor""='Y' " +
                          "ORDER BY U_SOL_LOM_LEBAR, U_SOL_CUT_PJGKRG "
        Else
            SQL = "SELECT DISTINCT " +
                          "     U_SOL_LOM_LEBAR                                                  AS ""Lebar"", " +
                          "     U_SOL_CUT_PJGKRG                                                 AS ""PjgKarung"", " +
                          "     IFNULL(U_SOL_LOM_BLOCKWARNA,'')                                  AS ""Warna"", " +
                          "     IFNULL(U_SOL_PRT_JMLWRNDPN,'')                                   AS ""Printing"" " +
                          "FROM OITM " +
                          "WHERE ""ItmsGrpCod"" ='" & Kelompok & "' AND " +
                          "     U_SOL_BNG_DENIER='" & Denier & "' AND " +
                          "     U_SOL_BNG_JENIS='" & JenisBenang & "' AND " +
                          "     (IFNULL(U_SOL_CUT_MERKDAGANG,'')='" & Brand & "' OR (case when U_SOL_CUT_MERKDAGANG='*' then '' end)='" & Brand & "') AND ""validFor""='Y' " +
                          "ORDER BY U_SOL_LOM_LEBAR, U_SOL_CUT_PJGKRG "
        End If


        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            Read = DS
        End Using
    End Function

    Public Function ReadItem(ByVal Kelompok As String, ByVal JenisBenang As String, ByVal Denier As String, ByVal Brand As String, ByVal Lebar As String, ByVal Panjang As String, ByVal Warna As String, ByVal Printing As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""ItemCode""                         AS ""KodeItem"", " +
              "     ""ItemName""                         AS ""NamaItem"" " +
              "FROM OITM " +
              "WHERE ""ItmsGrpCod"" ='" & Kelompok & "' AND " +
              "     U_SOL_BNG_DENIER='" & Denier & "' AND " +
              "     U_SOL_BNG_JENIS='" & JenisBenang & "' AND " +
              "     (IFNULL(U_SOL_CUT_MERKDAGANG,'')='" & Brand & "' OR (case when U_SOL_CUT_MERKDAGANG='*' then '' end)='" & Brand & "') AND " +
              "     U_SOL_LOM_LEBAR='" & Lebar & "' AND " +
              "     U_SOL_CUT_PJGKRG='" & Panjang & "' AND " +
              "     IFNULL(U_SOL_LOM_BLOCKWARNA,'')= (CASE IFNULL('" & Warna & "','') WHEN '' THEN '' ELSE '" & Warna & "' END) AND " +
              "     IFNULL(U_SOL_PRT_JMLWRNDPN,'')= (CASE IFNULL('" & Printing & "','') WHEN '' THEN '' ELSE '" & Printing & "' END) AND ""validFor""='Y' AND (IFNULL(U_SOL_JHM_TIPEJAHIT,'')<>'JM' AND IFNULL(U_SOL_JHM_TIPEJAHIT,'')<>'JU')  "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadItem = DS
        End Using
    End Function

    Public Function ReadItem(ByVal Kelompok As String, ByVal JenisBenang As String, ByVal Denier As String, ByVal Brand As String, ByVal Lebar As String, ByVal Panjang As String, ByVal Warna As String, ByVal Sisi As String, ByVal WrnPrint As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "     ""ItemCode""                         AS ""KodeItem"", " +
              "     ""ItemName""                         AS ""NamaItem"" " +
              "FROM OITM " +
              "WHERE ""ItmsGrpCod"" ='" & Kelompok & "' AND " +
              "     U_SOL_BNG_DENIER='" & Denier & "' AND " +
              "     U_SOL_BNG_JENIS='" & JenisBenang & "' AND " +
              "     (IFNULL(U_SOL_CUT_MERKDAGANG,'')='" & Brand & "' OR (case when U_SOL_CUT_MERKDAGANG='*' then '' end)='" & Brand & "') AND " +
              "     U_SOL_LOM_LEBAR='" & Lebar & "' AND " +
              "     U_SOL_CUT_PJGKRG='" & Panjang & "' AND " +
              "     IFNULL(U_SOL_LOM_BLOCKWARNA,'')= (CASE IFNULL('" & Warna & "','') WHEN '' THEN '' ELSE '" & Warna & "' END) AND " +
              "     IFNULL(U_SOL_PRT_JMLSSPRNT,'')= (CASE IFNULL('" & Sisi & "','') WHEN '' THEN '' ELSE '" & Sisi & "' END) AND " +
              "     IFNULL(U_SOL_PRT_JMLWRNDPN,'')= (CASE IFNULL('" & WrnPrint & "','') WHEN '' THEN '' ELSE '" & WrnPrint & "' END) AND ""validFor""='Y' AND (IFNULL(U_SOL_JHM_TIPEJAHIT,'')<>'JM' AND IFNULL(U_SOL_JHM_TIPEJAHIT,'')<>'JU')  "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadItem = DS
        End Using
    End Function

    Public Function ReadItemAll(ByVal Kriteria As String, ByVal Kelompok As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "       ""ItemCode""                              AS ""Kode"", " +
              "       ""ItemName""                              AS ""Nama Item"", " +
              "       ""ItmsGrpNam""                            AS ""Kelompok"" " +
              "FROM ""OITM"" A " +
              "LEFT JOIN ""OITB"" B ON B.""ItmsGrpCod"" = A.""ItmsGrpCod"" " +
              "WHERE ""ItemCode""||' '||""ItemName"" LIKE '%" + Kriteria + "%' "

        If Kelompok <> "" Then
            SQL += " AND A.""ItmsGrpCod"" ='" + Kelompok + "' "
        End If

        SQL += "ORDER BY A.""ItemCode"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadItemAll = DS
        End Using
    End Function
    Public Function ReadItemByWhs(Optional ByVal Kelompok As String = "") As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        SQL = "SELECT " +
              "       A.""ItemCode""                              AS ""Kode"", " +
              "       A.""ItemName""                              AS ""Nama Item"", " +
              "       B.""WhsCode""                            AS ""WhsCode"" " +
              "FROM ""OITM"" A " +
              "LEFT JOIN ""OITW"" B ON B.""ItemCode"" = A.""ItemCode"" "

        If Kelompok <> "" Then
            SQL += " WHERE B.""WhsCode"" ='" + Kelompok + "' "
        End If

        SQL += "ORDER BY A.""ItemCode"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadItemByWhs = DS
        End Using

    End Function
    Public Function GetLookup(TextSearch As String, Parameter As Object) As DataSet Implements IDataLookup.GetLookup
        Dim DB As New SAPDBConnection
        Dim SQL As String

        Dim Kelompok As String = Parameter(0)

        SQL = "SELECT " +
              "       ""ItemCode""                              AS ""Kode"", " +
              "       ""ItemName""                              AS ""Nama Item"", " +
              "       ""ItmsGrpNam""                            AS ""Kelompok"" " +
              "FROM ""OITM"" A " +
              "LEFT JOIN ""OITB"" B ON B.""ItmsGrpCod"" = A.""ItmsGrpCod"" " +
              "WHERE ""ItemCode""||' '||""ItemName"" LIKE '%" + TextSearch + "%' "

        If Kelompok <> "" Then
            SQL += " AND A.""ItmsGrpCod"" ='" + Kelompok + "' "
        End If

        SQL += "ORDER BY A.""ItemCode"" "

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
