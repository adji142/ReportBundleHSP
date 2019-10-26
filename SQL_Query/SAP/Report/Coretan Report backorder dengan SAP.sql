SELECT 
  SO."DocEntry" "DocID",
  CAST(SO."DocNum" AS VARCHAR) "NoOrder",
  SO."DocDate" "TglOrder",
  SO."DocDueDate" "TglSelesai",
  FGD."ItemCode" "KodeItem",
  ITM."ItemName" "NamaItem",
  0                                                   AS "QtyPackingOrder",
  0                                                   AS "QtyPcsOrder",
  0                                                   AS "QtyTimbangOrder",
  WO."CmpltQty",
  COUNT(BTC."DistNumber") AS "QtyPackingProduksi",
  SUM(FGD."Quantity") AS QtyPcsProduksi,
  SUM(CASE WHEN ITM."InvntryUom" = 'KG' THEN BTC."LotNumber" ELSE FGD."Quantity" END ) QtyTimbangProduksi,
  P.U_SOL_NAMA_UOM "SatuanPacking",
  ITM."InvntryUom"                                      AS "SatuanPcs",
  'KG'                                                AS "SatuanTimbang"
FROM OIGN FG
LEFT JOIN IGN1 FGD ON FG."DocEntry" = FGD."DocEntry"
LEFT JOIN OWOR WO ON WO."DocNum" = FGD."BaseRef"
LEFT JOIN ORDR SO ON SO."DocNum" = WO."OriginNum"
LEFT JOIN OBTN BTC ON BTC.U_HSP_TX_ID = FG."Ref2"
LEFT JOIN OCRD CRD ON CRD."CardCode" = SO."CardCode"
LEFT JOIN OITM ITM ON ITM."ItemCode" = FGD."ItemCode"
LEFT JOIN "HARDO_LIVE"."@SOL_UOM_PACKAGE" P ON P."Code" = ITM."U_SOL_UOM_PACK"
where SO.U_SOL_SUMBER_SO = 2 AND SO.U_SOL_TIPE_SALES =4
AND SO."DocDate" BETWEEN '2019-06-01' AND '2019-06-17'
GROUP BY SO."DocEntry",CAST(SO."DocNum" AS VARCHAR),SO."DocDate",SO."DocDueDate",FGD."ItemCode",ITM."ItemName",
WO."CmpltQty",P.U_SOL_NAMA_UOM,ITM."InvntryUom",SO."DocNum"
ORDER BY SO."DocDate",SO."DocNum"