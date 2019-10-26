SELECT 
a."DocNum" AS "WO ID",
a.U_SOL_NO_WO "NOMOR WO",
a."ItemCode" "KODE ITEM",
b."ItemName" "NAMA ITEM",
a."PostDate" "START DATE",
a."DueDate" "END DATE",
a."PlannedQty" "QTY PLAN",
c."Quantity" "QTY COMPLATE",
c."DocNum" "FG ID"
FROM OWOR a
LEFT JOIN OITM b on a."ItemCode" = b."ItemCode"
LEFT JOIN(
  SELECT x."DocNum",xx."BaseRef",SUM(xx."Quantity") "Quantity" FROM OIGN x
  LEFT JOIN IGN1 xx on x."DocEntry" = xx."DocEntry"
  GROUP BY x."DocNum",xx."BaseRef"
)c on a."DocNum" = c."BaseRef"
WHERE a."PostDate" BETWEEN '2019-06-12' AND '2019-06-12'
AND a.U_SOL_ROUTING = 'EXTRUDER'
ORDER BY a."DocNum"