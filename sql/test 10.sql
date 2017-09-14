--10
-- creating a view to store total attendance  and employ attendance

CREATE VIEW temp5 as 
(SELECT EmpID,SUM(Workingdays)AS TOTAL_ATTEN,SUM(PresentDays) AS EMP_ATTEN
FROM employeeAttendance
GROUP BY EmpID)

--joining Employee table and EmployeeAttendance using join
--then using where condition to check leave more than 3 

Select Name
FROM Employee as e
JOIN temp5 as t
on e.ID=t.EmpID
where t.TOTAL_ATTEN-t.EMP_ATTEN>3;

--there is no person having leave more than 3


