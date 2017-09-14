--2
select DeptName,
count(DeptID) as number_of_employee,
sum(HR+DA+Basics) as Highest_Gross_SALARY,        -- Calculating gross salary
(sum(HR+DA+Basics)- sum(e.TAX))  as Total_Salary  --calculating total salary
FROM Department AS d
INNER JOIN Employee AS e
ON d.DeptID=e.DepartID
GROUP BY DeptName;                                 -- grouping by department

