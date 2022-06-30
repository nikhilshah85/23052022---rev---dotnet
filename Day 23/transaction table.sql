select * from accountsInfo

create table transactions
(
	trNo int primary key identity,
	transactionType varchar(20),
	transactionDate date,
	fromAccount int,
	toAccount int,
	constraint fk_fromAcc foreign key(fromAccount) references accountsinfo,
	constraint fk_ToAcc foreign key(toAccount) references accountsinfo
)

alter table transactions add amount int




select * from accountsInfo

102 - 12000
104 - 18000
select * from transactions