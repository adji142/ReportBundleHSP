update P_Personnel set P_Personnel.EmpPosition=P_PersonnelContract.EmpPosition  
from P_PersonnelContract  
left join P_Personnel on P_Personnel.EmpNo = P_PersonnelContract.EmpNo  
where IsActive=1 AND P_PersonnelContract.EmpPosition <> P_Personnel.EmpPosition;  