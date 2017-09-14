--1)

SELECT DeptName,Gender,count(DeptID) as number_of_employees		--counting number of employees
FROM Department AS d
INNER JOIN Employee AS e
ON d.DeptID=e.DepartID
GROUP BY DeptName,Gender										--grouping by Gender and department name
order by DeptName												--ordering data according to DeptName