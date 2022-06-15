drop table accountsInfo
drop table tbl_AccountDetails


create table branchInfo
(
	brNo int,
	brName varchar(20)not null,
	brCity varchar(20)not null,
	brEmail varchar(20),
	brContact varchar(20),
	constraint pk_brNo primary key(brNo),
	constraint unk_brEmail unique(brEmail),
	constraint unk_brContact unique(brContact),
)

insert into branchInfo values (1,'Bandra','Mumbai','bandra@citibank.com',232323)
insert into branchInfo values (2,'Kau Sang','Phuket','kausang@citibank.com',232324)
insert into branchInfo(brNo,brEmail,brContact,brName,brCity) values (3,'khapata@citibank.com',56233,'khapata','Hong Kong')

--alter table branchInfo nocheck constraint unk_brEmail


create table accountsInfo
(
	accNo int,
	accName varchar(20) not null,
	accType varchar(20) not null,
	accBalance int not null,
	accIsActive bit default(1),
	accBranch int,
	constraint pk_accNo primary key(accNo),
	constraint chk_accName check (len(accName) > 3),
	constraint chk_accType check (accType in ('Savings','Checking','Loan')),
	constraint chk_accBalance check (accBalance > 100),
	constraint fk_accBranch foreign key(accBranch) references branchInfo
)
insert into accountsInfo values(1,'Nikhil','Loan',150,1,1)
insert into accountsInfo values(2,'Micheal','Savings',150,0,2)




select * from accountsInfo
insert into accountsInfo(accNo,accName,accType,accBalance)
	values
	(3,'Kate','Checking',200)











