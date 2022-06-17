create database employeeManagementDB

use employeeManagementDB

create table tbl_Login
(
	userName varchar(20),
	password varchar(20),
	accountStatus varchar(20) default 'Active',
	attempts int default(0),

	constraint pk_userName primary key(userName),
	constraint chk_password_len check(len(password) > 5),
	constraint chk_accountStatus_list check (accountStatus in ('Active','Blocked','Disabled')
))

insert into tbl_Login(userName,password) values('Nikhil','Password1234')
insert into tbl_Login(userName,password) values('Micheal','Password4321')

select count(*) from tbl_Login where userName =  'Eric' and password='fjlksd'


create table deptInfo
(
	dNo int,
	dName varchar(20),
	dLocation varchar(20),
	dEmail varchar(20),
	constraint pk_dNo primary key(dNo)
)
create table empInfo
(
	empNo int,
	empName varchar(20),
	empDesignation varchar(20),
	empSalary int,
	empDeptNo int,

	constraint pk_empNo primary key(empNo),
	constraint chk_empName check(len(empName) > 3),
	constraint fk_empDeptNo foreign key(empDeptNo) references deptInfo
)
insert into empInfo values(


update tbl_Login set password='password123456'

