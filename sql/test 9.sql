--9 
--Using temp 4 created in last question to find out the attendance 
select Name
from Employee AS e
LEFT JOIN temp4 AS t                                          -- joining temp4 table and Employee table
ON e.ID=t.EMPID
where fullattendance=(Select min(fullattendance) from temp4)   --calculating lowest attendance by using minimum function 

