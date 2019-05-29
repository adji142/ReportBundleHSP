SELECT e.USERID,a."UserSign2",CAST(a."DocNum" AS VARCHAR) "NoSO",a."DocDate" "TglSO",c."DocDueDate" "DelivDateSebelum",
a."DocDueDate" "DelivDateSesudah",c."CancelDate" "CanceledDateSebelum",a."CancelDate" "CanceledDateSesudah",
e.U_NAME "Createdby",f.U_NAME "Updatedby",b."ItemCode",b."Dscription" "ItemName",
CASE WHEN d."Quantity" = b."Quantity"
  THEN NULL
  ELSE d."Quantity"
END 
 AS "QtySebelum",
CASE WHEN d."Quantity" = b."Quantity"
  THEN NULL
  ELSE b."Quantity"
END 
 AS "QtySesudah",
 a."CardName"
FROM ORDR a
INNER JOIN RDR1 b on a."DocEntry" = b."DocEntry"
LEFT JOIN ADOC c on a."DocNum" = c."DocNum"
LEFT JOIN ADO1 d on c."DocEntry" = d."DocEntry" and d."ItemCode" = b."ItemCode"
INNER JOIN OUSR e on a."UserSign" = e.USERID
INNER JOIN OUSR f on c."UserSign2" = f.USERID
LEFT JOIN OITM stk on stk."ItemCode" = d."ItemCode"
where a."DocDate" BETWEEN fromdate AND todate
and c."ObjType" = 17
and c."UserSign2" = 6;



SELECT
T4.USERID,T2."UserSign2",CAST(T2."DocNum" AS VARCHAR) "NoSO",T2."DocDate" "TglSO",T2."DocDueDate" "DelivDateSesudah",
TX."DocDueDate" "DelivDateSebelum",T2."CancelDate" "CanceledDateSesudah",TX."CancelDate" "CanceledDateSebelum",
T4."U_NAME" as "Updatedby",T1."ItemCode",T1."Dscription" "ItemName",
CASE WHEN T1."Quantity" = T0."Quantity" THEN NULL ELSE T1."Quantity" END as "QtySebelum", 
CASE WHEN T1."Quantity" = T0."Quantity" THEN NULL ELSE T0."Quantity" END as "QtySesudah",
T2."CardName"
FROM
ADOC T2
LEFT JOIN ADOC TX on T2."DocEntry" = TX."DocEntry" AND T2."ObjType" = TX."ObjType" and TX."LogInstanc" = T2."LogInstanc"-1
LEFT JOIN ADO1 T1 ON T2."DocEntry" = T1."DocEntry" AND T2."ObjType" = T1."ObjType" and T1."LogInstanc" = T2."LogInstanc"-1
LEFT JOIN ADO1 T0 ON T2."DocEntry" = T0."DocEntry" AND T2."ObjType" = T0."ObjType" AND T1."LineNum" = T0."LineNum"
INNER JOIN OUSR T4 ON T2."UserSign2" = T4.INTERNAL_K
AND T0."LogInstanc" = T2."LogInstanc"
WHERE T2."DocDate" BETWEEN fromdate AND todate
AND T2."ObjType" = 17
AND T2."UserSign2" = 6
--AND T2."DocNum" = '211181271'
ORDER BY T2."DocNum";















SELECT
		DISTINCT 
		Z."OldUpd", 
		IFNULL(Z."NewUpd", Z."CurUpd") as "UpdateDate",
		LEFT(RIGHT('0'||IFNULL(Z."NewUpdTS",Z."CurUpdTS"),6),2) || ':'
			|| LEFT(RIGHT(IFNULL(Z."NewUpdTS",Z."CurUpdTS"),4),2) ||':'
			|| RIGHT(IFNULL(Z."NewUpdTS",Z."CurUpdTS"),2) 
			as "UpdateTS",
		IFNULL(Z."NewUsr", Z."CurUsr") as "UpdateUser",
		Z."ObjType", Z."LogInstanc", 
		Z."DocEntry", Z."DocNum",
		Z."CardCode", Z."CardName",
		--Z."OldPrice", IFNULL(Z."NewPrice",Z."CurPrice") as "NewPrice",
		--Z."OldItem", IFNULL(Z."NewItem",Z."CurItem") as "NewItem",
		--Z."OldQty", IFNULL(Z."NewQty",Z."CurQty") as "NewQty",
		--Z."OldTotal", IFNULL(Z."NewTotal",Z."CurTotal") as "NewTotal",
		CASE
			WHEN Z."OldItem" <> IFNULL(Z."NewItem",Z."CurItem") THEN 'Perubahan Item'
			WHEN Z."OldPrice" <> IFNULL(Z."NewPrice",Z."CurPrice") THEN 'Perubahan Price'
			WHEN Z."OldQty" <> IFNULL(Z."NewQty",Z."CurQty") THEN 'Perubahan Quantity'
			WHEN Z."OldTotal" <> IFNULL(Z."NewTotal",Z."CurTotal") THEN 'Perubahan Total'
		END as "Reason",
    -- start new
    CAST(Z."DocNum" AS VARCHAR) "NoSO",
    Z."DocDate" "TglSO",Z."OldDDD" "DelivDateSebelum", Z."NewDDD" "DelivDateSesudah",
    
	FROM
		(SELECT X."ObjType", X."LogInstanc", 
			X."UpdateDate" as "OldUpd", XT."UpdateTS" as "NewUpdTS", A."UpdateTS" as "CurUpdTS" ,
			XT."UpdateDate" as "NewUpd", A."UpdateDate" as "CurUpd",
			XTU."USER_CODE" as "NewUsr", AU."USER_CODE" as "CurUsr",
			X."DocEntry", X."DocNum",X."CardCode", X."CardName",
			Y."ItemCode", 
			Y."PriceAfVAT" as "OldPrice", YT."PriceAfVAT" as "NewPrice", B."PriceAfVAT" as "CurPrice",
			Y."ItemCode" as "OldItem", YT."ItemCode" as "NewItem", B."ItemCode" as "CurItem",
			Y."InvQty" as "OldQty", YT."InvQty" as "NewQty", B."InvQty" as "CurQty",
			X."DocTotal" as "OldTotal", XT."DocTotal" as "NewTotal", A."DocTotal" as "CurTotal",
      A."DocDate",X."DocDueDate" "OldDDD",XT."DocDueDate" "NewDDD",X."CancelDate" "OldCancel" , XT."CancelDate" "NewCancel",
      
		FROM ADOC X
			JOIN ADO1 Y ON X."DocEntry" = Y."DocEntry" AND X."ObjType" = Y."ObjType" 
				AND X."LogInstanc" = Y."LogInstanc"
			JOIN ORDR A ON A."DocEntry" = X."DocEntry" AND A."ObjType" = X."ObjType" AND A."CANCELED" = 'N'
			JOIN RDR1 B ON A."DocEntry" = B."DocEntry" AND B."LineNum" = Y."LineNum"
			JOIN OUSR AU ON A."UserSign2" = AU."USERID"
			LEFT JOIN ADOC XT ON X."DocEntry" = XT."DocEntry" AND X."ObjType" = XT."ObjType"
				AND X."LogInstanc" + 1 = XT."LogInstanc"
			LEFT JOIN ADO1 YT ON XT."DocEntry" = YT."DocEntry" AND XT."ObjType" = YT."ObjType" 
				AND XT."LogInstanc" = YT."LogInstanc" AND Y."LineNum" = YT."LineNum"
			LEFT JOIN OUSR XTU ON XT."UserSign2" = XTU."USERID"
		) Z
	WHERE
		Z."ObjType" = '17' 
		--AND (Z."OldPrice" <> IFNULL(Z."NewPrice",Z."CurPrice")
			--OR Z."OldItem" <> IFNULL(Z."NewItem",Z."CurItem")
			--OR Z."OldQty" <> IFNULL(Z."NewQty",Z."CurQty")
			--OR Z."OldTotal" <> IFNULL(Z."NewTotal",Z."CurTotal"))
		AND Z."DocNum" = '211181774'
    -- IFNULL(Z."NewUpd",Z."CurUpd") BETWEEN :DATEFROM AND :DATETO
	--ORDER BY Z."DocNum", IFNULL(Z."NewUpd", Z."CurUpd"), IFNULL(Z."NewUpdTS",Z."CurUpdTS"), Z."ItemCode"
	ORDER BY "UpdateDate", "UpdateTS", Z."ObjType",Z."DocNum" ;
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	SELECT X.* FROM (

  SELECT
  T4.USERID,T2."UserSign2",CAST(T2."DocNum" AS VARCHAR) "NoSO",T2."DocDate" "TglSO",T2."DocDueDate" "DelivDateSesudah",
  TX."DocDueDate" "DelivDateSebelum",T2."CancelDate" "CanceledDateSesudah",TX."CancelDate" "CanceledDateSebelum",
  T4."U_NAME" as "Updatedby",T1."ItemCode",T1."Dscription" "ItemName",
  CASE WHEN T1."Quantity" = T0."Quantity" THEN NULL ELSE T1."Quantity" END as "QtySebelum", 
  CASE WHEN T1."Quantity" = T0."Quantity" THEN NULL ELSE T0."Quantity" END as "QtySesudah",
  T2."CardName",T2."UpdateDate"
  FROM
  ADOC T2
  LEFT JOIN ADOC TX on T2."DocEntry" = TX."DocEntry" AND T2."ObjType" = TX."ObjType" and TX."LogInstanc" = T2."LogInstanc"-1
  LEFT JOIN ADO1 T1 ON T2."DocEntry" = T1."DocEntry" AND T2."ObjType" = T1."ObjType" and T1."LogInstanc" = T2."LogInstanc"-1
  LEFT JOIN ADO1 T0 ON T2."DocEntry" = T0."DocEntry" AND T2."ObjType" = T0."ObjType" AND T1."LineNum" = T0."LineNum"
  INNER JOIN OUSR T4 ON T2."UserSign2" = T4.INTERNAL_K
  AND T0."LogInstanc" = T2."LogInstanc"
  WHERE T2."ObjType" = 17
  AND T2."UserSign2" = 6

  UNION ALL

  SELECT u.USERID,so."UserSign2",CAST(so."DocNum" as varchar) "NoSO",
  so."DocDate" "TglSO", so."DocDueDate" "DelivDateSebelum",
  lso."DocDueDate" "DelivDateSesudah", so."CancelDate" "CanceledDateSebelum",
  lso."CancelDate" "CanceledDateSesudah",u.U_NAME as "Updatedby",
  sod."ItemCode",sod."Dscription" "ItemName",
  CASE WHEN sod."Quantity" = lsod."Quantity" then NULL else lsod."Quantity" END as "QtySebelum",
  CASE WHEN sod."Quantity" = lsod."Quantity" then NULL else sod."Quantity" END as "QtySesudah",
  so."CardName",so."UpdateDate"
  FROM ORDR so
  LEFT JOIN RDR1 sod on so."DocEntry" = sod."DocEntry"
  LEFT JOIN ADOC lso on so."DocNum" = lso."DocNum"
  LEFT JOIN ADO1 lsod on lso."DocEntry" = lsod."DocEntry" and lsod."ItemCode" = sod."ItemCode"
  INNER JOIN OUSR u on so."UserSign2" = u.USERID
  WHERE (select MAX(z."LogInstanc") from ADOC z where z."DocNum" = lso."DocNum") -1 = 0 AND
  (select MAX(zz."LogInstanc") from ADO1 zz where zz."DocEntry" = lsod."DocEntry") - 1 = 0 AND
  so."UserSign2" = 6
  and lso."ObjType" = 17
)X
where CASE WHEN TIPE = 'SO' THEN "TglSO" ELSE "UpdateDate" END between fromdate and todate
ORDER BY "TglSO","NoSO"
;