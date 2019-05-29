select H."NoSO",H."OP_Nomor",G.AUFTRAG,B."DistNumber",K."WhsCode",K."WhsName",A."ItemCode",
L."ItemName",H."QtySO" SO,F."Quantity"
from OITW A 
INNER JOIN OBTN B ON A."ItemCode" = B."ItemCode"
INNER JOIN ITL1 C ON C."LogEntry" = B."AbsEntry"
INNER JOIN OITL D ON D."LogEntry" = C."LogEntry"
INNER JOIN OIGN E ON E."DocEntry" = D."DocEntry"
INNER JOIN IGN1 F ON E."DocEntry" = F."DocEntry" AND F."ItemCode" = A."ItemCode" AND F."WhsCode" = A."WhsCode"
INNER JOIN BEAS_FTHAUPT G ON G.BELNR_ID = F."U_beas_belnrid"
INNER JOIN HSP_WORKFLOW_WO H ON G.AUFTRAG = H."NoWO"
INNER JOIN OWHS K ON K."WhsCode" = A."WhsCode"
INNER JOIN OITM L ON L."ItemCode" = A."ItemCode"
WHERE K."WhsCode" = '530'
--AND J."OJ_Nomor" = '211181479' AND A."ItemCode" ='303.0324'

--AND A."ItemCode" IN (
  --SELECT "OJ_KodeItem" FROM HSP_WORKFLOW_SO
--)
-- 530
--select * from OITW where "ItemCode" = '302.0003' and "WhsCode" = '530'
-- SELECT * fROM OWHS
--SELECT * FROM HSP_WORKFLOW_SO WHERE "OJ_KodeItem" = '303.0324'
--SELECT * FROM OBTN WHERE "OJ_KodeItem" = '403.0571'

select * from HSP_WORKFLOW_WO order by BELNR_ID


select C.AUFTRAG NOWO,B."ItemCode",F."ItemCode", 
B."WhsCode",E."WhsName",B."Quantity",D."QtyWO",D."QtyOP" "QtyReq",
D."QtyOPJadi"--,D."NoSO",D."OP_Nomor"
from OIGN A
LEFT JOIN IGN1 B ON A."DocEntry" = B."DocEntry"
LEFT JOIN BEAS_FTHAUPT C ON C.BELNR_ID = B."U_beas_belnrid"
LEFT JOIN HSP_WORKFLOW_WO D ON C.AUFTRAG = D."NoWO" AND D."ItemCode" = B."ItemCode"
LEFT JOIN OWHS E ON E."WhsCode" = B."WhsCode"
LEFT JOIN OITM F ON F."ItemCode" = B."ItemCode"
WHERE B."WhsCode" = '530'
ORDER BY C.AUFTRAG



SET SCHEMA "HARDO_LIVE";
CREATE VIEW HARDO_LIVE.HSP_WORKFLOW_STK_PROD ("U_beas_belnrid","NoSO","OP_Nomor","NoWO","ItemCode","ItemName","WhsCode","WhsName","QtyWO","QtyReq","OP_QtyHasil","QtyProduksi") AS 

select B."U_beas_belnrid",D."NoSO",D."OP_Nomor",D."NoWO",B."ItemCode",F."ItemName", 
B."WhsCode",E."WhsName",D."QtyWO",D."QtyReq" "QtyReq",
D."OP_QtyHasil",SUM(B."Quantity") "QtyProduksi"
from OIGN A
LEFT JOIN IGN1 B ON A."DocEntry" = B."DocEntry"
LEFT JOIN HSP_WORKFLOW_WO D ON B."U_beas_belnrid" = D.BELNR_ID AND D."OP_KodeItem" = B."ItemCode"
LEFT JOIN OWHS E ON E."WhsCode" = B."WhsCode"
LEFT JOIN OITM F ON F."ItemCode" = B."ItemCode" 
WHERE B."WhsCode" = '530' AND D."NoWO" IS NOT NULL
GROUP BY B."U_beas_belnrid",D."NoSO",D."OP_Nomor",D."NoWO",B."ItemCode",F."ItemName", 
B."WhsCode",E."WhsName",D."QtyWO",D."QtyReq",
D."OP_QtyHasil"
ORDER BY D."NoWO"
;


select * from HSP_WORKFLOW_STK_PROD

select * from HSP_WORKFLOW_WO