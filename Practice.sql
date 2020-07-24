create database practice

use practice 

create table temp1
(
	number int primary key, 
	name varchar(max)
)


 
insert into dbo.temp1 values 
(1, 'nabeel'),
(2, 'nabeel'),
(3, 'nabeel'),
(4, 'nabeel'),
(5, 'nabeel'),
(6, 'nabeel')


select* from temp1

begin tran
delete from temp1
where number = 1

delete from temp1
where number = 2

save tran A 

delete from temp1
where number = 3

save tran B 

delete from temp1
where number = 4

commit 

begin tran
rollback tran A

truncate table temp1 

-- Adventure Works Database

select * from HumanResources.Department

select* from HumanResources.Employee 

select* from HumanResources.EmployeeDepartmentHistory 

select BusinessEntityID, ROW_NUMBER () over (partition by BusinessEntityID order by BusinessEntityID) as temp 
from HumanResources.EmployeeDepartmentHistory 

select COUNT(*)
from HumanResources.EmployeeDepartmentHistory
where BusinessEntityID = 4