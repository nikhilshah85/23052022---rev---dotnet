create database bankingDBAPI

use bankingDBAPI

create table accountsInfo
(
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accIsActive bit
)

insert into accountsInfo values(101,'Kate','Savings',9000,1)
insert into accountsInfo values(102,'Angel','Checking',12000,1)
insert into accountsInfo values(103,'John','Savings',4000,0)
insert into accountsInfo values(104,'Michelle','Savings',18000,1)