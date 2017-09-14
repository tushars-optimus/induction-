--7
--Using left join we are displaying DeptName and DEPT_Head_Name
SELECT DeptName, Name as DEPT_Head_Name
from Department as d
left join Employee as e
on d.DeptHeadid=e.ID