SELECT 
  WO.U_SOL_NO_WO "NoWo",WO."ItemCodeFG",WO."ItemNameFG",WO."ItemCode",WO."ItemName",
  IP."Quantity" FG,RP."QTY" RM
FROM 
(
  SELECT 
  a."DocEntry",a."DocNum",a."OriginNum",a.U_SOL_NO_WO,a."PostDate",a."DueDate",
  a."ItemCode" "ItemCodeFG",d."ItemName" "ItemNameFG",a."Status",a."PlannedQty" "PlanedQtyFG",
  b."ItemCode",COALESCE(e."ItemName",c."ResName") "ItemName",b."PlannedQty",b."IssuedQty",b."BaseQty",c."ResType",
  a.U_SOL_ROUTING
FROM OWOR a
LEFT JOIN WOR1 b on a."DocEntry" = b."DocEntry"
LEFT JOIN ORSC c on b."ItemCode" = c."VisResCode"
LEFT JOIN OITM d on a."ItemCode" = d."ItemCode"
LEFT JOIN OITM e on e."ItemCode" = b."ItemCode"
) WO
LEFT JOIN (
  SELECT 
    a."DocEntry",a."DocNum",a."DocDate",b."ItemCode",b."BaseRef",b."Quantity"
  FROM OIGE a
  LEFT JOIN IGE1 b on a."DocEntry" = b."DocEntry"
  WHERE b."BaseRef" IS NOT NULL
) IP on IP."BaseRef" = WO."DocNum" --AND IP."ItemCode" = WO."ItemCode"
LEFT JOIN (
  SELECT x."BaseRef",x."ItemCode",SUM(x."Quantity") QTY FROM IGN1 x
  WHERE x."BaseRef" IS NOT NULL
  GROUP BY x."BaseRef",x."ItemCode"
)RP on RP."BaseRef" = WO."DocNum" AND RP."ItemCode" = WO."ItemCode"
WHERE WO."PostDate" BETWEEN '2019-06-10' AND '2019-06-15'
AND WO."Status" = 'L' AND WO.U_SOL_ROUTING = 'CLOOM'

-- Format Baru

SELECT 
  wo.U_SOL_NO_WO,wo."PostDate",wo."ItemCodeFG",wo."ItemNameFG",
  wo."PlanedQtyFG",wo."ItemCode",wo."ItemName",wo."PlannedQty",RM."RM",FG.FG
FROM (
SELECT 
  a."DocEntry",a."DocNum",a."OriginNum",a.U_SOL_NO_WO,a."PostDate",a."DueDate",
  a."ItemCode" "ItemCodeFG",d."ItemName" "ItemNameFG",a."Status",a."PlannedQty" "PlanedQtyFG",
  b."ItemCode",COALESCE(e."ItemName",c."ResName") "ItemName",b."PlannedQty",b."IssuedQty",b."BaseQty",c."ResType",
  a.U_SOL_ROUTING
FROM OWOR a
LEFT JOIN WOR1 b on a."DocEntry" = b."DocEntry"
LEFT JOIN ORSC c on b."ItemCode" = c."VisResCode"
LEFT JOIN OITM d on a."ItemCode" = d."ItemCode"
LEFT JOIN OITM e on e."ItemCode" = b."ItemCode"
)wo
--WHERE a."DocNum" = '190000138' AND (c."ResType" <> 'M' OR c."ResType" IS NULL)
LEFT JOIN (
  SELECT x."BaseRef",x."ItemCode",SUM(x."Quantity") FG FROM IGN1 x
  WHERE x."BaseRef" IS NOT NULL --AND x."BaseRef" = '190000456'
  GROUP BY x."BaseRef",x."ItemCode"
) FG ON wo."DocNum" = FG."BaseRef" AND wo."ItemCode" = FG."ItemCode"
LEFT JOIN (
  SELECT 
    b."ItemCode",b."BaseRef",SUM(b."Quantity") RM
  FROM OIGE a
  LEFT JOIN IGE1 b on a."DocEntry" = b."DocEntry"
  GROUP BY b."ItemCode",b."BaseRef"
) RM ON wo."DocNum" = RM."BaseRef" AND wo."ItemCode" = RM."ItemCode"
WHERE wo."DocNum" = '190000138'