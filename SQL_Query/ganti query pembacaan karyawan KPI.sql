SELECT DISTINCT 
A.KDKARYAWAN                             AS 'Kode', 
A.NMKARYAWAN                             AS 'Nama Karyawan'
FROM KPI_KARYAWAN A
WHERE A.KDPOSISI ='100.45.7.939' AND
-- IIF(YEAR(A.ResignDate)='1900' or A.ResignDate IS NULL,'9999/12/31',A.ResignDate)>= @Periode AND A.JoinDate<= @Periode
CASE WHEN YEAR(A.ResignDate)='1900' or A.ResignDate IS NULL then '9999/12/31' else A.ResignDate end 
>= CAST( DATEADD(day,DATEDIFF(day,'2019-03-31','2019-'+ CAST( DATEPART(MM,'2019-03-31') AS varchar) +'-26'),'2019-03-31') as date) AND
A.JoinDate <= DATEADD(MONTH,1, CAST( DATEADD(day,DATEDIFF(day,'2019-03-31','2019-'+ CAST( DATEPART(MM,'2019-03-31') AS varchar) +'-25'),'2019-03-31') as date))
ORDER BY A.NMKARYAWAN

select * from P_PersonnelContract where EndContract between '2019-03-26' and '2019-04-25'
select * from KPI_KARYAWAN where KDKARYAWAN = '17101664'

select * from KPI_POSISI where KDPOSISI = '100.40.5.837,2'

select '2019-03-23' ResignDate,'1/1/2019' joindate
select CAST( DATEADD(day,DATEDIFF(day,'2019-03-31','2019-'+ CAST( DATEPART(MM,'2019-03-31') AS varchar) +'-26'),'2019-03-31') as date) awal
select DATEADD(MONTH,1, CAST( DATEADD(day,DATEDIFF(day,'2019-03-31','2019-'+ CAST( DATEPART(MM,'2019-03-31') AS varchar) +'-25'),'2019-03-31') as date)) akhir



SELECT DISTINCT 
-- A.KDKARYAWAN                             AS 'Kode', 
-- A.NMKARYAWAN                             AS 'Nama Karyawan'
*
FROM KPI_KARYAWAN A
WHERE A.KDPOSISI ='100.45.7.939' AND
IIF(YEAR(A.ResignDate)='1900' or A.ResignDate IS NULL,'9999/12/31',A.ResignDate)>= '2019-03-31' AND A.JoinDate<= '2019-03-31'
ORDER BY A.NMKARYAWAN