SELECT
      "DocID",
      "NoOrder",
      "TglOrder",
      "TglSelesai",
      "KodeItem",
      "NamaItem",
      SUM("QtyPackingOrder")      AS "QtyPackingOrder",
      SUM("QtyPcsOrder")          AS "QtyPcsOrder",
      SUM("QtyTimbangOrder")      AS "QtyTimbangOrder",
      
      SUM("QtyPackingProduksi")   AS "QtyPackingProduksi",
      SUM("QtyPcsProduksi")       AS "QtyPcsProduksi",
      SUM("QtyTimbangProduksi")   AS "QtyTimbangProduksi",
      
      SUM("QtyPackingRetur")      AS "QtyPackingRetur",
      SUM("QtyPcsRetur")          AS "QtyPcsRetur",
      SUM("QtyTimbangRetur")      AS "QtyTimbangRetur",
      
--    BO
      SUM(("QtyPackingOrder" - "QtyPackingProduksi") + "QtyPackingRetur") "BOPacking",
      SUM(("QtyPcsOrder" - "QtyPcsProduksi") + "QtyPcsRetur") "BOPcs",
      SUM(("QtyTimbangOrder" - "QtyTimbangProduksi") + "QtyTimbangRetur") "BOTimbang",
      "SatuanPacking",
      "SatuanPcs",
      "SatuanTimbang"
FROM (
      SELECT
            B."DocEntry"                                                    AS "DocID",
            CAST(B."DocNum" AS VARCHAR)                                     AS "NoOrder",
            B."DocDate"                                                     AS "TglOrder",
            B."DocDueDate"                                                  AS "TglSelesai",
            A."ItemCode"                                                    AS "KodeItem",
            C."ItemName"                                                    AS "NamaItem",
            IFNULL(CEIL(A."Quantity"/P."U_SOL_QTY_PACKAGE"),0)              AS "QtyPackingOrder",
            A."Quantity"                                                    AS "QtyPcsOrder",
            CASE C."InvntryUom" WHEN 'KG' THEN
			        A."Quantity"
			      ELSE
			        (A."Quantity" * IFNULL(C."U_SOL_SATUAN_GRM",0))/1000 END      AS "QtyTimbangOrder",
            0                                                               AS "QtyPackingProduksi",
            0                                                               AS "QtyPcsProduksi",
            0                                                               As "QtyTimbangProduksi",
            P.U_SOL_NAMA_UOM                                                AS "SatuanPacking",
            CASE WHEN A."TreeType"='N' THEN
              C."InvntryUom"
            ELSE
              A."unitMsr" END                                               AS "SatuanPcs",
            'KG'                                                            AS "SatuanTimbang",
            0                                                               AS "QtyPackingRetur",
            0                                                               AS "QtyPcsRetur",
            0                                                               AS "QtyTimbangRetur"
      FROM RDR1 A
      LEFT JOIN ORDR B ON B."DocEntry" = A."DocEntry"
      LEFT JOIN OITM C ON C."ItemCode" = A."ItemCode"
      LEFT JOIN "@SOL_UOM_PACKAGE" P ON P."Code" = C."U_SOL_UOM_PACK"
      WHERE B.U_SOL_SUMBER_SO = 2 AND B.U_SOL_TIPE_SALES = 4 AND B."DocDate" BETWEEN :TglAwal AND :TglAkhir AND
            B."DocStatus" = (CASE WHEN :Status='ALL' THEN
                                B."DocStatus"
                             ELSE
                                :Status END)

      UNION ALL

SELECT 
    E."DocEntry"                                  AS "DocID",
    CAST(E."DocNum" AS VARCHAR)                   AS "NoOrder",
    E."DocDate"                                   AS "TglOrder",
    E."DocDueDate"                                AS "TglSelesai",
    P."ItemCode"                                  AS "KodeItem",
    G."ItemName"                                  AS "NamaItem",
    0                                             AS "QtyPackingOrder",
    0                                             AS "QtyPcsOrder",
    0                                             AS "QtyTimbangOrder",
    COUNT(P."DistNumber")                         AS "QtyPackingProduksi",
    SUM(B."Quantity")                            AS "QtyPcsProduksi",
    SUM(CASE WHEN G."InvntryUom" = 'KG' THEN B."Quantity" ELSE P."LotNumber" END) AS "QtyTimbangProduksi",
    H.U_SOL_NAMA_UOM                              AS "SatuanPacking",
    G."InvntryUom"                                AS "SatuanPcs",
    'KG'                                          AS "SatuanTimbang",
    0                                             AS "QtyPackingRetur",
    0                                             AS "QtyPcsRetur",
    0                                             AS "QtyTimbangRetur"
FROM OWTR A
LEFT JOIN WTR1 B ON B."DocEntry" = A."DocEntry"
LEFT JOIN
		(SELECT DISTINCT OITL."ItemCode", ITL1."MdAbsEntry", OITL."DocEntry", OITL."DocLine", OITL."DocType", ITL1."PickedQty"
		 FROM OITL
		 INNER JOIN ITL1 ON OITL."LogEntry" = ITL1."LogEntry"
		 INNER JOIN OITM ON OITL."ItemCode" = OITM."ItemCode" 
		 WHERE OITM."ManBtchNum" = 'Y'
		) O ON O."ItemCode" = B."ItemCode" AND O."DocEntry" = A."DocEntry" 
		  AND O."DocLine" = B."LineNum" AND O."DocType" = A."ObjType"
LEFT JOIN OBTN P ON P."AbsEntry" = O."MdAbsEntry"
LEFT JOIN OWOR D on D."DocEntry" = P.U_HSP_WO_ID
LEFT JOIN ORDR E on D."OriginNum" = E."DocNum"
LEFT JOIN OCRD F ON E."CardCode" = F."CardCode"
LEFT JOIN OITM G ON G."ItemCode" = P."ItemCode"
LEFT JOIN "@SOL_UOM_PACKAGE" H ON H."Code" = G."U_SOL_UOM_PACK"
WHERE A."Filler" IN ('511','530','900','550') AND A."ToWhsCode" = '100' AND
E.U_SOL_SUMBER_SO = 2 AND E.U_SOL_TIPE_SALES = 4
AND E."DocDate" BETWEEN :TglAwal AND :TglAkhir
AND E."DocStatus" = (CASE WHEN :Status='ALL' THEN
                                E."DocStatus"
                             ELSE
                                :Status END)
GROUP BY E."DocEntry",E."DocNum",E."DocDate",E."DocDueDate",P."ItemCode",G."ItemName",
H.U_SOL_NAMA_UOM,G."InvntryUom"

UNION ALL

SELECT 
    E."DocEntry"                                  AS "DocID",
    CAST(E."DocNum" AS VARCHAR)                   AS "NoOrder",
    E."DocDate"                                   AS "TglOrder",
    E."DocDueDate"                                AS "TglSelesai",
    P."ItemCode"                                  AS "KodeItem",
    G."ItemName"                                  AS "NamaItem",
    0                                             AS "QtyPackingOrder",
    0                                             AS "QtyPcsOrder",
    0                                             AS "QtyTimbangOrder",
    0                                             AS "QtyPackingProduksi",
    0                                             AS "QtyPcsProduksi",
    0                                             AS "QtyTimbangProduksi",
    H.U_SOL_NAMA_UOM                              AS "SatuanPacking",
    G."InvntryUom"                                AS "SatuanPcs",
    'KG'                                          AS "SatuanTimbang",
    COUNT(P."DistNumber")                         AS "QtyPackingRetur",
    SUM(B."Quantity")                            AS "QtyPcsRetur",
    SUM(CASE WHEN G."InvntryUom" = 'KG' THEN B."Quantity" ELSE P."LotNumber" END) AS "QtyTimbangRetur"
FROM OWTR A
LEFT JOIN WTR1 B ON B."DocEntry" = A."DocEntry"
LEFT JOIN
		(SELECT DISTINCT OITL."ItemCode", ITL1."MdAbsEntry", OITL."DocEntry", OITL."DocLine", OITL."DocType", ITL1."PickedQty"
		 FROM OITL
		 INNER JOIN ITL1 ON OITL."LogEntry" = ITL1."LogEntry"
		 INNER JOIN OITM ON OITL."ItemCode" = OITM."ItemCode" 
		 WHERE OITM."ManBtchNum" = 'Y'
		) O ON O."ItemCode" = B."ItemCode" AND O."DocEntry" = A."DocEntry" 
		  AND O."DocLine" = B."LineNum" AND O."DocType" = A."ObjType"
LEFT JOIN OBTN P ON P."AbsEntry" = O."MdAbsEntry"
LEFT JOIN OWOR D on D."DocEntry" = P.U_HSP_WO_ID
LEFT JOIN ORDR E on D."OriginNum" = E."DocNum"
LEFT JOIN OCRD F ON E."CardCode" = F."CardCode"
LEFT JOIN OITM G ON G."ItemCode" = P."ItemCode"
LEFT JOIN "@SOL_UOM_PACKAGE" H ON H."Code" = G."U_SOL_UOM_PACK"
WHERE A."Filler" ='100' AND A."ToWhsCode" IN ('511','530','900','550') AND
E.U_SOL_SUMBER_SO = 2 AND E.U_SOL_TIPE_SALES = 4
AND E."DocDate" BETWEEN :TglAwal AND :TglAkhir
AND E."DocStatus" = (CASE WHEN :Status='ALL' THEN
                                E."DocStatus"
                             ELSE
                                :Status END)
GROUP BY E."DocEntry",E."DocNum",E."DocDate",E."DocDueDate",P."ItemCode",G."ItemName",
H.U_SOL_NAMA_UOM,G."InvntryUom"
WHERE 
) AS SO
GROUP BY "DocID", "NoOrder", "TglOrder", "TglSelesai", "KodeItem", "NamaItem", "SatuanPacking",
      "SatuanPcs",
      "SatuanTimbang"
ORDER BY "DocID", "NoOrder", "KodeItem";