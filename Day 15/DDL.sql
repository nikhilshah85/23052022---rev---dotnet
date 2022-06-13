
--DDL 

create database employeeManagementDB


use employeeManagementDB

--create
--create object objectname .......defination 
	--eg. create table tablename
	--	create view viewname
	--	create procedure procedurename
	--	create function functionname
create table tbl_employeeDetails
(
	empNo int primary key,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary float,
	empIsPermenant bit
)

--alter
 alter table tbl_employeeDetails add empCity varchar(20)
 alter table tbl_employeeDetails alter column empDesignation varchar(80)
 alter table tbl_employeeDetails alter column empSalary int

 --drop 
 drop table tbl_employeeDetails -- this will drop the table from database 
 alter table tbl_employeeDetails drop column empCity

 --truncate
 --suppose table has 200 records, we just want to empty the table, 
 --but we do not wana to drop the table
 truncate table tbl_employeeDetails










