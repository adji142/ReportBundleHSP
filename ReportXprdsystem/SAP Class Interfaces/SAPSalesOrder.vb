Imports Sap.Data.Hana
Imports ReportXprdsystem.HSP.Data

Public Class SAPSalesOrder
    Public Function Read(TglAwal As DateTime, TglAkhir As DateTime, Optional ByVal NoSO As String = "") As DataSet
        Dim DB As New SAPDBConnection
        Dim SQL As String

        If NoSO <> "" Then
            SQL = "SELECT " +
                          "CAST(B.""DocNum"" AS VARCHAR)                 AS ""NoTransaksi"", " +
                          "B.""DocDate""                                 AS ""TglTransaksi"", " +
                          "B.""CardCode""                                AS ""KodeCustomer"", " +
                          "C.""CardName""                                AS ""NamaCustomer"", " +
                          "A.""ItemCode""                                AS ""KodeItem"", " +
                          "D.""ItemName""                                AS ""NamaItem"", " +
                          "A.""Quantity""                                AS ""Qty"", " +
                          "A.""PriceAfVAT""                              AS ""Harga"", " +
                          "IFNULL(D.""U_SOL_BNG_DENIER"",'')||" +
                          "IFNULL(D.""U_SOL_BNG_JENIS"",'')||" +
                          "IFNULL(D.""U_SOL_LOM_LEBAR"",'')||" +
                          "IFNULL(D.""U_SOL_CUT_PJGKRG"",'')||" +
                          "IFNULL(D.""U_SOL_CUT_MERKDAGANG"",'')         AS ""Grup"", " +
                          "IFNULL(D.""U_SOL_PRT_JMLWRNDPN"",'')          AS ""Printing"", " +
                          "IFNULL(A.""CogsOcrCo4"",'')                   AS ""Cabang"", " +
                          "IFNULL(A.""U_HSP_WILAYAH"",'')                AS ""Wilayah"" " +
                          "FROM RDR1 A " +
                          "LEFT JOIN ORDR B ON B.""DocEntry"" = A.""DocEntry"" " +
                          "LEFT JOIN OCRD C ON C.""CardCode"" = B.""CardCode"" " +
                          "LEFT JOIN OITM D ON D.""ItemCode"" = A.""ItemCode"" " +
                          "WHERE A.""DocDate"" BETWEEN '" + TglAwal.Date.ToString("yyyyMMdd") + "' AND '" + TglAkhir.Date.ToString("yyyyMMdd") + "' AND " +
                          "B.""CANCELED""='N' AND (B.U_SOL_TIPE_SALES=1 OR B.U_SOL_TIPE_SALES=2) " +
                          " AND D.""ItmsGrpCod"" IN ('200','201','202','203','204','210','211','212','213','214','197') AND CAST(B.""DocNum"" AS VARCHAR) = '" & NoSO & "' "
        Else
            SQL = "SELECT " +
                          "CAST(B.""DocNum"" AS VARCHAR)                 AS ""NoTransaksi"", " +
                          "B.""DocDate""                                 AS ""TglTransaksi"", " +
                          "B.""CardCode""                                AS ""KodeCustomer"", " +
                          "C.""CardName""                                AS ""NamaCustomer"", " +
                          "A.""ItemCode""                                AS ""KodeItem"", " +
                          "D.""ItemName""                                AS ""NamaItem"", " +
                          "A.""Quantity""                                AS ""Qty"", " +
                          "A.""PriceAfVAT""                              AS ""Harga"", " +
                          "IFNULL(D.""U_SOL_BNG_DENIER"",'')||" +
                          "IFNULL(D.""U_SOL_BNG_JENIS"",'')||" +
                          "IFNULL(D.""U_SOL_LOM_LEBAR"",'')||" +
                          "IFNULL(D.""U_SOL_CUT_PJGKRG"",'')||" +
                          "IFNULL(D.""U_SOL_CUT_MERKDAGANG"",'')         AS ""Grup"", " +
                          "IFNULL(D.""U_SOL_PRT_JMLWRNDPN"",'')          AS ""Printing"", " +
                          "IFNULL(A.""CogsOcrCo4"",'')                   AS ""Cabang"", " +
                          "IFNULL(A.""U_HSP_WILAYAH"",'')                AS ""Wilayah"" " +
                          "FROM RDR1 A " +
                          "LEFT JOIN ORDR B ON B.""DocEntry"" = A.""DocEntry"" " +
                          "LEFT JOIN OCRD C ON C.""CardCode"" = B.""CardCode"" " +
                          "LEFT JOIN OITM D ON D.""ItemCode"" = A.""ItemCode"" " +
                          "WHERE A.""DocDate"" BETWEEN '" + TglAwal.Date.ToString("yyyyMMdd") + "' AND '" + TglAkhir.Date.ToString("yyyyMMdd") + "' AND " +
                          "B.""CANCELED""='N' AND (B.U_SOL_TIPE_SALES=1 OR B.U_SOL_TIPE_SALES=2) " +
                          " AND D.""ItmsGrpCod"" IN ('200','201','202','203','204','210','211','212','213','214','197') "
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
End Class
