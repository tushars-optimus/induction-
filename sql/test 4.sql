--4
--creting view for id, Name and Total gross salary 
create view [temp2] as
(select ID,Name, sum(HR+DA+Basics) as total_gross
FROM Employee 
group by Name,ID)

--using View displaying total_gross above 15000
select ID,Name,total_gross from temp2
where total_gross>15000