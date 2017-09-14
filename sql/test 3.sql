--3
-- creating view to store DeptName and total gross
create view [temp1] as
(select DeptName,Name, sum(HR+DA+Basics) as total_gross
FROM Department AS d
INNER JOIN Employee AS e
ON d.DeptID=e.DepartID
group by Name,DeptName)

--using view to  get highest salary by department name
select DeptName, Name, total_gross from temp1
where total_gross in (select max(total_gross) from temp1  group by DeptName );