CREATE DATABASE TEST  --CREATING DATABASE
USE TEST

CREATE TABLE Employee
(
ID int identity(1,1) not null,
Name varchar(50) not null,
Gender varchar(10) not null,
Basics int not null,
HR int not null,
DA int not null,
TAX int not null,
DepartID int
);

Insert into Employee values
('Anil','Male',10000,5000,1000,400,1),
('Sanjana','Female',12000,6000,1000,500,2),
('johnny','Male',5000,2500,500,200,3),
('Suresh','Male',6000,3000,500,250,1),
('Angila','Female',11000,5500,1000,500,4),
('Saurabh','Male',12000,6000,1000,600,1),
('Manish','Male',4000,2000,500,150,2),
('Neeraj','Male',5000,2500,500,200,3),
('Suman','Female',5000,2500,500,200,4),
('Tina','Female',6000,3000,500,220,1);

select * from Employee