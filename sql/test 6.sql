--6
--Creating view to store number department name with number of employees
create view [temp3] as
(SELECT DeptName,count(DeptID) as number_of_employees  --counting number of employees
FROM Department AS d
INNER JOIN Employee AS e
ON d.DeptID=e.DepartID
GROUP BY DeptName)

--Showing department which have more than 3 number_of_employees
SELECT DeptName,number_of_employees
FROM temp3
where number_of_employees>3;