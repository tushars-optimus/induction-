--5


select ID,Name						-- displaying ID,Name on basis of second highest basics
From Employee
where Basics=(Select max(Basics)    --logic to create second highest basics
From Employee
where Basics<(select max(Basics) from Employee))