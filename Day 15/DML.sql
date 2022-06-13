--DML 

--insert
insert into tbl_employeeDetails values(101,'Nikhil','Trainer',600,1)
insert into tbl_employeeDetails values(102,'Rickey','HR',600,1)
insert into tbl_employeeDetails values(103,'Monty','Sales',600,0)
insert into tbl_employeeDetails values(104,'Jennifer','Accounts',600,1)
insert into tbl_employeeDetails values(105,'Karla','Trainer',600,0)

select * from tbl_employeeDetails
--update
update tbl_employeeDetails set empName = 'Rickey Martin' where empNo = 102
update tbl_employeeDetails set empSalary = 900
update tbl_employeeDetails set empSalary = 1200 where empName = 'Nikhil'
update tbl_employeeDetails set empDesignation = '' where empName = 'Karla'
--delete

delete from tbl_employeeDetails -- this will delete everything
delete from tbl_employeeDetails where empDesignation = 'Sales'