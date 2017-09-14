--8 
--Creating view to store empID and attendance

create view [temp4]as
(SELECT EMPID,COUNT(EMPID)AS fullattendance
from employeeAttendance
WHERE Workingdays=PresentDays
GROUP BY EMPID)

select Name
from Employee AS e
LEFT JOIN temp4 AS t
ON e.ID=t.EMPID
where fullattendance=(select top 1 COUNT(EMPID)     --counting total months using top function to find full attendance
from employeeAttendance
group by EMPID)

