SELECT 
  e."DocEntry" "DocID",
  CAST(e."DocNum" AS VARCHAR) "NoOrder",
  e."DocDate" AS "TglOrder",
  e."DocDueDate" AS "TglSelesai",
  a."ItemCode" AS "KodeItem",
  g."ItemName" AS "NamaItem",
  0                                                   AS "QtyPackingOrder",
  0                                                   AS "QtyPcsOrder",
  0                                                   AS "QtyTimbangOrder",
  COUNT(c."DistNumber") AS "QtyPackingProduksi",
  SUM(b."Quantity") AS QtyPcsProduksi,
  SUM(CASE WHEN g."InvntryUom" = 'KG' THEN b."Quantity" ELSE c."LotNumber" END ) QtyTimbangProduksi,
  P.U_SOL_NAMA_UOM "SatuanPacking",
  g."InvntryUom"                                      AS "SatuanPcs",
  'KG'                                                AS "SatuanTimbang"
FROM OWTR y
-- LEFT JOIN WTR1 x on y."DocEntry" = x."DocEntry"
LEFT JOIN OITL a on a."DocEntry" = y."DocEntry"
LEFT JOIN ITL1 b on a."LogEntry" = b."LogEntry"
LEFT JOIN OBTN c on b."MdAbsEntry" = c."AbsEntry"
--LEFT JOIN WTR1 x on x."DocEntry" = a."DocEntry"
--LEFT JOIN OWTR y on y."DocEntry" = x."DocEntry"
LEFT JOIN OWOR d on c.U_HSP_WO_ID = d."DocEntry"
LEFT JOIN ORDR e on d."OriginNum" = e."DocNum"
LEFT JOIN OCRD f on e."CardCode" = f."CardCode"
LEFT JOIN OITM g on a."ItemCode" = g."ItemCode"
LEFT JOIN "HARDO_LIVE"."@SOL_UOM_PACKAGE" P ON P."Code" = g."U_SOL_UOM_PACK"
WHERE e.U_SOL_SUMBER_SO = 2 AND e.U_SOL_TIPE_SALES = 4
AND e."DocDate" BETWEEN '2019-05-01' AND '2019-06-24'
AND a."DocQty" > 0 AND y."Filler" IN ('511','530','900','550') AND y."ToWhsCode" = '100'
AND a."DocNum" = '190051651'
GROUP BY e."DocEntry",e."DocNum",e."DocDate",e."DocDueDate",a."ItemCode",g."ItemName",
P.U_SOL_NAMA_UOM,G."InvntryUom",E."DocNum"
ORDER BY e."DocDate" DESC