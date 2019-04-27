select
count (CONCAT(cast(cast(scan_date as datetime) as varchar),pin,
CASE
	when inoutmode=1 then 'I0'
	when inoutmode=2 then 'O0'
	when inoutmode=3 then 'I0'
	when inoutmode=4 then 'O0'
	when inoutmode=5 then 'I0'
	when inoutmode=6 then 'O0'
	else '-'
end
)),scan_date,pin,inoutmode
--,cast(scan_date as datetime) HitDateTime,pin IdNumber,
--CASE
--	when inoutmode=1 then 'I0'
--	when inoutmode=2 then 'O0'
--	when inoutmode=3 then 'I0'
--	when inoutmode=4 then 'O0'
--	when inoutmode=5 then 'I0'
--	when inoutmode=6 then 'O0'
--	else '-'
--end HitStatus,
--RIGHT(sn,3) HitLocation,'0' isLoaded,'SQL' Remarks
 
--TANPA LIHAT INOUTMode by Mesin Finger (2017-05-08)
--select cast(scan_date as datetime) HitDateTime,pin IdNumber,'0' HitStatus,RIGHT(sn,3) HitLocation,'0' isLoaded,'SQL' Remarks
FROM OPENQUERY
(MYSQL_FIN_PRO,'SELECT * FROM fin_pro_new.att_log')
where scan_date between '2019-04-22' and '2019-04-23'
group by scan_date,pin,inoutmode
having count (CONCAT(cast(cast(scan_date as datetime) as varchar),pin,
CASE
	when inoutmode=1 then 'I0'
	when inoutmode=2 then 'O0'
	when inoutmode=3 then 'I0'
	when inoutmode=4 then 'O0'
	when inoutmode=5 then 'I0'
	when inoutmode=6 then 'O0'
	else '-'
end
)) > 1


select cast(scan_date as datetime) HitDateTime,pin IdNumber,
CASE
	when inoutmode=1 then 'I0'
	when inoutmode=2 then 'O0'
	when inoutmode=3 then 'I0'
	when inoutmode=4 then 'O0'
	when inoutmode=5 then 'I0'
	when inoutmode=6 then 'O0'
	else '-'
end HitStatus,RIGHT(sn,3) HitLocation,'0' isLoaded,'SQL' Remarks
 
--TANPA LIHAT INOUTMode by Mesin Finger (2017-05-08)
--select cast(scan_date as datetime) HitDateTime,pin IdNumber,'0' HitStatus,RIGHT(sn,3) HitLocation,'0' isLoaded,'SQL' Remarks
FROM OPENQUERY
(MYSQL_FIN_PRO,'SELECT * FROM fin_pro_new.att_log')
where scan_date between '2019-04-22' and '2019-04-23'
and pin =1706