create database bankingLINQ

use bankingLINQ

create table branchInfo
(
	branchId int primary key,
	branchName varchar(20),
	branchCity varchar(20),
	branchEmail varchar(40)
)
insert into branchInfo values(10,'K Square','Manhattan','ksquare@bank.com')

insert into branchInfo values(20,'Street M','Singapore','streetm@bank.com')

insert into branchInfo values(30,'Wan Tiers','Hong Kong','wantiers@bank.com')



create table AccountsInfo
(
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accBranch int,
	constraint fk_accBranch foreign key(accBranch) references branchInfo)

	insert into AccountsInfo values(1,'Nikhil','Savings',200,20)
	insert into AccountsInfo values(2,'Micheal','Loan',1200,10)
	insert into AccountsInfo values(3,'Sammy','Savings',2200,30)
	insert into AccountsInfo values(4,'Kane','Savings',2600,20)
	insert into AccountsInfo values(5,'John','Loan',300,10)
	insert into AccountsInfo values(6,'Maria','Savings',2400,20)

	
	create table transactioninfo
	(
		trNo int primary key identity,
		trFromAccount int,
		trToAccount int,
		trAmount int,
		trType varchar(20),

		constraint fk_fromAccount foreign key(trFromAccount) references Accountsinfo,
		constraint fk_toAccount foreign key(trToAccount) references Accountsinfo
	)
	insert into transactioninfo values(2,4,10,'Transfer')
	insert into transactioninfo values(4,6,30,'Transfer')
	insert into transactioninfo values(6,1,25,'Transfer')
	insert into transactioninfo values(1,3,60,'Transfer')















