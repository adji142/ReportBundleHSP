Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data


Public Class SAPPPIC

    Public Function ReadMonitoringHasilProduksiWO(Kriteria As String, UnitSAP As String, Status As String, TglMulai As Date) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String = ""

        Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%").ToUpper

        SQL = "SELECT " +
                "       A.""NomorWO""                               AS ""Nomor"", " +
                "       A.""TglMulai""                              AS ""Tgl Mulai"", " +
                "       A.""TglSelesai""                            AS ""Tgl Selesai"", " +
                "       A.""KodeItem""                              AS ""Kode Item"", " +
                "       A.""NamaItem""                              AS ""Nama Item"", " +
                "       CAST(A.""QtyPlan"" AS DOUBLE)               AS ""Order"", " +
                "       CAST(A.""QtySelesai"" AS DOUBLE)            AS ""Penyelesaian"", " +
                "       CAST(A.""QtyPlan"" AS DOUBLE) - " +
                "       CAST(A.""QtySelesai"" AS DOUBLE)            AS ""Kebutuhan"", " +
                "       (CAST(A.""QtySelesai"" AS DOUBLE) / " +
                "       CAST(A.""QtyPlan"" AS DOUBLE)) * 100        AS ""%"", " +
                "       CAST(B.""Stock"" AS DOUBLE)                 AS ""Stock"", " +
                "       A.""Satuan""                                AS ""Satuan"", " +
                "       A.""StatusWO""                              AS ""Status"" " +
              "FROM HSP_PROD_WO_FG A " +
              "LEFT JOIN (SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" FROM ""OITW"" GROUP BY ""ItemCode"" ) B " +
              "ON B.""ItemCode"" = A.""KodeItem"" " +
              "WHERE A.""Unit"" = '" + UnitSAP + "' AND (UCASE(A.""NomorWO"") LIKE '" + Kriteria + "' OR UCASE(A.""KodeItem"") LIKE '" + Kriteria + "' OR UCASE(A.""NamaItem"") LIKE '" + Kriteria + "') "

        If Status = "OPEN" Then
            SQL += " AND A.""StatusWO"" = '" + Status + "' "
        ElseIf Status = "CLOSE" Then
            SQL += " AND A.""StatusWO"" ='" + Status + "' " +
                 " AND A.""TglMulai"" >= '" + TglMulai.ToString("yyyyMMdd") + "' "
        Else
            SQL += " AND A.""TglMulai"" >= '" + TglMulai.ToString("yyyyMMdd") + "' "
        End If

        SQL += " ORDER BY A.""TglMulai"", A.""TglSelesai"""

        'SQL = "SELECT " +
        '          "     W.""NomorWO""                               AS ""Nomor"" , " +
        '          "     W.""TglMulai""                              AS ""Tgl Mulai"", " +
        '          "     W.""TglSelesai""                            AS ""Tgl Selesai"", " +
        '          "     W.""KodeItem""                              AS ""Kode Item"", " +
        '          "     W.""NamaItem""                              AS ""Nama Item"", " +
        '          "     W.""QtyPlan""                               AS ""Order"", " +
        '          "     W.""QtySelesai""                            AS ""Penyelesaian"", " +
        '          "     W.""QtyPlan"" - W.""QtySelesai""            AS ""Kebutuhan"", " +
        '          "     (W.""QtySelesai"" / W.""QtyPlan"") * 100    AS ""%"", " +
        '          "     S.""Stock""                                 AS ""Stock"", " +
        '          "     UCASE(W.""Satuan"")                         AS ""Satuan"", " +
        '          "     W.""Status""                                AS ""Status"" " +
        '          "FROM HSP_PROD_WO_FG W " +
        '          "LEFT JOIN " +
        '          "(" +
        '          "     SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" " +
        '          "     FROM ""OITW"" " +
        '          "     GROUP BY ""ItemCode"" " +
        '          ") AS S ON S.""ItemCode"" = W.""KodeItem"" " +
        '          "WHERE W.""Unit"" = '" + UnitSAP + "' AND (UCASE(W.""NomorWO"") LIKE '" + Kriteria + "' OR UCASE(W.""KodeItem"") LIKE '" + Kriteria + "' OR UCASE(W.""NamaItem"") LIKE '" + Kriteria + "') "

        'If Status = "OPEN" Then
        '    SQL += "AND W.""Status"" = '" + Status + "' "
        'ElseIf Status = "CLOSE" Then
        '    SQL += "AND W.""Status"" = '" + Status + "' "
        '    SQL += "AND ""TglMulai"" >= '" + TglMulai.ToString("yyyyMMdd") + "' "
        'Else
        '    SQL += "AND ""TglMulai"" >= '" + TglMulai.ToString("yyyyMMdd") + "' "
        'End If

        'SQL += "ORDER BY W.""TglMulai"", W.""TglSelesai"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadMonitoringHasilProduksiWO = DS
        End Using

    End Function

    Public Function ReadMonitoringBahanProduksiWO(Kriteria As String, UnitSAP As String, KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String = ""

        Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%").ToUpper

        SQL = "SELECT " +
              "     ""Kode Item"", " +
              "     ""Nama Item"", " +
              "     ""Kelompok"", " +
              "     ""Tgl Mulai"", " +
              "     ""Nomor"", " +
              "     CAST(""Rencana Bahan"" AS DOUBLE)   AS ""Rencana Bahan"", " +
              "     CAST(""Pemakaian Bahan"" AS DOUBLE) AS ""Pemakaian Bahan"", " +
              "     CAST(""Rencana Bahan"" AS DOUBLE) - " +
              "     CAST(""Pemakaian Bahan"" AS DOUBLE) AS ""Kebutuhan Bahan"", " +
              "     CAST(""%""  AS DOUBLE)              AS ""%"", " +
              "     CAST(""Stock Produksi"" AS DOUBLE)  AS ""Stock Produksi"", " +
              "     ""Satuan"" " +
              "FROM HSP_MONITORING_BAHAN " +
              "WHERE ""Unit"" = '" + UnitSAP + "' " +
              "ORDER BY ""Kode Item"", ""Tgl Mulai"", ""Nomor"" "

        'SQL = "SELECT " +
        '            "   A.""ItemCode""                                          AS ""Kode Item"", " +
        '            "   UCASE(B.""ItemName"")                                   AS ""Nama Item"", " +
        '            "   UCASE(C.""ItmsGrpNam"")                                 AS ""Kelompok"", " +
        '            "   D.""TglMulai""                                          AS ""Tgl Mulai"", " +
        '            "   D.""NomorWO""                                           AS ""Nomor"", " +
        '            "   E.""RM_Quantity""                                       AS ""Rencana Bahan"", " +
        '            "   A.""Qty""                                               AS ""Pemakaian Bahan"" " +
        '            " FROM HSP_PROD_RM_ISSUE A " +
        '            " LEFT JOIN OITM B ON B.""ItemCode"" = A.""ItemCode"" " +
        '            " LEFT JOIN OITB C ON C.""ItmsGrpCod"" = B.""ItmsGrpCod"" " +
        '            " LEFT JOIN HSP_PROD_WO_FG D ON D.""ID"" = A.""BELNR_ID"" " +
        '            " LEFT JOIN SOL_WO_BOM E ON E.""WO_ID"" = A.""BELNR_ID"" AND E.""RM_ItemCode"" = A.""ItemCode"" " +
        '            " WHERE (UCASE(A.""ItemCode"") LIKE '" + Kriteria + "' OR UCASE(B.""ItemName"") LIKE '" + Kriteria + "') " +
        '            " AND D.""StatusWO"" = 'OPEN' AND D.""Unit"" = '" + UnitSAP + "' " +
        '            " ORDER BY A.""ItemCode"", D.""TglMulai"", D.""NomorWO"" "

        'SQL = " SELECT " +
        '            "   RM.""RM_ItemCode""                                      AS ""Kode Item"", " +
        '            "   UCASE(RM.""RM_ItemName"")                               AS ""Nama Item"", " +
        '            "   UCASE(GI.""ItmsGrpNam"")                                AS ""Kelompok"", " +
        '            "   FG.""StartDate""                                        AS ""Tgl Mulai"", " +
        '            "   FG.""WO_Number""                                        AS ""Nomor"", " +
        '            "   RM.""PlannedQty""                                       AS ""Rencana Bahan"", " +
        '            "   RM.""IssuedQty""                                        AS ""Pemakaian Bahan"", " +
        '            "   RM.""PlannedQty"" - RM.""IssuedQty""                    AS ""Kebutuhan Bahan"", " +
        '            "   (RM.""IssuedQty"" / RM.""PlannedQty"") * 100            AS ""%"", " +
        '            "   SP.""Stock""                                            AS ""Stock Produksi"", " +
        '            "   0                                                       AS ""Alokasi Stock"", " +
        '            "   UCASE(RM.""UomCode"")                                   AS ""Satuan"" " +
        '            " FROM SOL_PROD_WO_RM RM " +
        '            " LEFT JOIN SOL_PROD_WO_FG FG ON FG.WO_ID = RM.WO_ID " +
        '            " LEFT JOIN ""OITM"" IM ON IM.""ItemCode"" = RM.""RM_ItemCode"" " +
        '            " LEFT JOIN ""OITB"" GI ON GI.""ItmsGrpCod"" = IM.""ItmsGrpCod"" " +
        '            " LEFT JOIN " +
        '            " ( " +
        '            " SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" " +
        '            " FROM ""OITW"" " +
        '            " WHERE ""WhsCode"" = '" + KodeLokasi + "' " +
        '            " GROUP BY ""ItemCode"" " +
        '            " ) AS SP ON SP.""ItemCode"" = RM.""RM_ItemCode"" " +
        '            " WHERE (UCASE(RM.""RM_ItemCode"") LIKE '" + Kriteria + "' OR UCASE(RM.""RM_ItemName"") LIKE '" + Kriteria + "') " +
        '            " AND FG.""Status"" = 'R' AND FG.""Routing"" = '" + UnitSAP + "' AND RM.""ItemType"" = 4 AND RM.""PlannedQty"" >0 " +
        '            " ORDER BY RM.""RM_ItemCode"", FG.""StartDate"", FG.""WO_Number"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadMonitoringBahanProduksiWO = DS
        End Using

    End Function

    Public Function ReadMonitoringBahanProduksiWO(Nomor As String, KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String = ""

        SQL = "SELECT " +
              "     ""Kode Item"", " +
              "     ""Nama Item"", " +
              "     ""Kelompok"", " +
              "     CAST(""Rencana Bahan"" AS DOUBLE)   AS ""Rencana Bahan"", " +
              "     CAST(""Pemakaian Bahan"" AS DOUBLE) AS ""Pemakaian Bahan"", " +
              "     CAST(""Rencana Bahan"" AS DOUBLE) - " +
              "     CAST(""Pemakaian Bahan"" AS DOUBLE) AS ""Kebutuhan Bahan"", " +
              "     CAST(""%""  AS DOUBLE)              AS ""%"", " +
              "     CAST(""Stock Produksi"" AS DOUBLE)  AS ""Stock Produksi"", " +
              "     ""Satuan"" " +
              "FROM HSP_MONITORING_BAHAN " +
              "WHERE ""Nomor"" ='" + Nomor + "' AND  CAST(""Rencana Bahan"" AS DOUBLE)>0 " +
              "ORDER BY ""Kode Item"" "

        'SQL = " SELECT " +
        '            "   RM.""RM_ItemCode""                                      AS ""Kode Item"", " +
        '            "   UCASE(RM.""RM_ItemName"")                               AS ""Nama Item"", " +
        '            "   UCASE(GI.""ItmsGrpNam"")                                AS ""Kelompok"", " +
        '            "   RM.""PlannedQty""                                       AS ""Rencana Bahan"", " +
        '            "   RM.""IssuedQty""                                        AS ""Pemakaian Bahan"", " +
        '            "   RM.""PlannedQty"" - RM.""IssuedQty""                    AS ""Kebutuhan Bahan"", " +
        '            "   (RM.""IssuedQty"" / RM.""PlannedQty"") * 100            AS ""Konsumsi (%)"", " +
        '            "   SP.""Stock""                                            AS ""Stock Produksi"", " +
        '            "   UCASE(RM.""UomCode"")                                   AS ""Satuan"" " +
        '            " FROM SOL_PROD_WO_RM RM " +
        '            " LEFT JOIN SOL_PROD_WO_FG FG ON FG.WO_ID = RM.WO_ID " +
        '            " LEFT JOIN ""OITM"" IM ON IM.""ItemCode"" = RM.""RM_ItemCode"" " +
        '            " LEFT JOIN ""OITB"" GI ON GI.""ItmsGrpCod"" = IM.""ItmsGrpCod"" " +
        '            " LEFT JOIN " +
        '            " ( " +
        '            " SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" " +
        '            " FROM ""OITW"" " +
        '            " WHERE ""WhsCode"" = '" + KodeLokasi + "' " +
        '            " GROUP BY ""ItemCode"" " +
        '            " ) AS SP ON SP.""ItemCode"" = RM.""RM_ItemCode"" " +
        '            " WHERE FG.""WO_Number"" = '" + Nomor + "' AND RM.""ItemType"" = 4 AND RM.""PlannedQty"" >0 " +
        '            " ORDER BY RM.""RM_ItemCode"" "

        '"   (RM.""PlannedQty"" / FG.""PlannedQty"") * 100           AS ""Komposisi (%)"", " +

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadMonitoringBahanProduksiWO = DS
        End Using

    End Function


    Public Function ReadMonitoringKebutuhanBahan(Kriteria As String, UnitSAP As String, KodeLokasi As String) As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String = ""

        Kriteria = String.Concat(Space(1), Kriteria.Trim, Space(1)).Replace(" ", "%").ToUpper

        SQL = "SELECT " +
             "     ""Kode Item"", " +
             "     ""Nama Item"", " +
             "     ""Kelompok"", " +
             "     SUM(CAST(""Rencana Bahan"" AS DOUBLE))   AS ""Rencana Bahan"", " +
             "     SUM(CAST(""Pemakaian Bahan"" AS DOUBLE)) AS ""Pemakaian Bahan"", " +
             "     SUM(CAST(""Rencana Bahan"" AS DOUBLE)) - " +
             "     SUM(CAST(""Pemakaian Bahan"" AS DOUBLE)) AS ""Kebutuhan Bahan"", " +
             "     (SUM(CAST(""Pemakaian Bahan"" AS DOUBLE)) / " +
             "     SUM(CAST(""Rencana Bahan"" AS DOUBLE))) * 100         AS ""%"", " +
             "     CAST(""Stock Produksi"" AS DOUBLE)  AS ""Stock Produksi"", " +
             "     CAST(B.""Stock"" AS DOUBLE)         AS ""Stock Lokasi Lain"", " +
             "     ""Satuan"" " +
             "FROM HSP_MONITORING_BAHAN " +
             "LEFT JOIN (SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" FROM OITW WHERE ""WhsCode""<>'" + KodeLokasi + "' GROUP BY ""ItemCode"") B ON B.""ItemCode"" = HSP_MONITORING_BAHAN.""Kode Item"" " +
             "WHERE ""Unit"" = '" + UnitSAP + "' " +
             "GROUP BY ""Kode Item"", ""Nama Item"", ""Kelompok"", CAST(""Stock Produksi"" AS DOUBLE), CAST(B.""Stock"" AS DOUBLE), ""Satuan"" " +
             "ORDER BY ""Kode Item"" "

        'SQL = " SELECT " +
        '          "     RM.""RM_ItemCode""                                      AS ""Kode Item"", " +
        '          "     UCASE(RM.""RM_ItemName"")                               AS ""Nama Item"", " +
        '          "     UCASE(GI.""ItmsGrpNam"")                                AS ""Kelompok"", " +
        '          "     SUM(RM.""PlannedQty"")                                  AS ""Rencana Bahan"", " +
        '          "     SUM(RM.""IssuedQty"")                                   AS ""Pemakaian Bahan"", " +
        '          "     SUM(RM.""PlannedQty"") - SUM(RM.""IssuedQty"")          AS ""Kebutuhan Bahan"", " +
        '          "     (SUM(RM.""IssuedQty"") / SUM(RM.""PlannedQty"")) * 100  AS ""%"", " +
        '          "     SP.""Stock""                                            AS ""Stock Produksi"", " +
        '          "     SL.""Stock""                                            AS ""Stock Lokasi Lain"", " +
        '          "     UCASE(RM.""UomCode"")                                   AS ""Satuan"" " +
        '          " FROM SOL_PROD_WO_RM RM " +
        '          " LEFT JOIN SOL_PROD_WO_FG FG ON FG.WO_ID = RM.WO_ID " +
        '          " LEFT JOIN ""OITM"" IM ON IM.""ItemCode"" = RM.""RM_ItemCode"" " +
        '          " LEFT JOIN ""OITB"" GI ON GI.""ItmsGrpCod"" = IM.""ItmsGrpCod"" " +
        '          " LEFT JOIN " +
        '          " ( " +
        '          "     SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" " +
        '          "     FROM ""OITW"" " +
        '          "     WHERE ""WhsCode"" = '" + KodeLokasi + "' " +
        '          "     GROUP BY ""ItemCode"" " +
        '          " ) AS SP ON SP.""ItemCode"" = RM.""RM_ItemCode"" " +
        '          " LEFT JOIN " +
        '          " ( " +
        '          "     SELECT ""ItemCode"", SUM(""OnHand"") AS ""Stock"" " +
        '          "     FROM ""OITW"" " +
        '          "     WHERE ""WhsCode"" <> '" + KodeLokasi + "' " +
        '          "     GROUP BY ""ItemCode"" " +
        '          " ) AS SL ON SL.""ItemCode"" = RM.""RM_ItemCode"" " +
        '          " WHERE (UCASE(RM.""RM_ItemCode"") LIKE '" + Kriteria + "' OR UCASE(RM.""RM_ItemName"") LIKE '" + Kriteria + "') " +
        '          " AND FG.""Status"" = 'R' AND FG.""Routing"" = '" + UnitSAP + "' AND RM.""ItemType"" = 4 AND RM.""PlannedQty"" >0 " +
        '          " GROUP BY RM.""RM_ItemCode"", RM.""RM_ItemName"", GI.""ItmsGrpNam"", SP.""Stock"", SL.""Stock"", RM.""UomCode"" "

        Using DBX As IDbConnection = DB.Connection()

            Dim CMD As New HanaCommand(SQL, DBX)
            Dim DA As New HanaDataAdapter
            Dim DS As New DataSet

            DA.SelectCommand = CMD
            DA.Fill(DS, "View")

            ReadMonitoringKebutuhanBahan = DS
        End Using

    End Function

    
End Class
