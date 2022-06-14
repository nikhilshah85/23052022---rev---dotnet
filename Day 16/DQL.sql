
		use bankingDB;

		create table accountsInfo
		(
			accNo int primary key,
			accName varchar(20),
			accType varchar(20),
			accBalance float,
			accIsActive bit
		)
		insert into accountsInfo values(1,'Nikhil','Savings',9000,1)
		insert into accountsInfo values(2,'Bruce','Checking',9000,0)
		insert into accountsInfo values(3,'Anakin','Loan',9000,1)
		insert into accountsInfo values(4,'Yugi','Loan',9000,1)
		insert into accountsInfo values(5,'Joey','Loan',9000,1)
		insert into accountsInfo values(6,'Feebie','Checking',9000,0)
		insert into accountsInfo values(7,'Charles','Loan',9000,1)
		insert into accountsInfo values(8,'Nikita','Loan',9000,1)
		insert into accountsInfo values(9,'Rachel','Loan',9000,0)
		insert into accountsInfo values(10,'Monica','Savings',9000,1)
		insert into accountsInfo values(11,'Sheldon','Checking',9000,0)
		insert into accountsInfo values(12,'Penny','Savings',9000,1)
		insert into accountsInfo values(13,'Rajesh','Savings',9000,0)
		insert into accountsInfo values(14,'Howard','Savings',9000,1)
		insert into accountsInfo values(15,'Mark','Checking',9000,1)
		insert into accountsInfo values(16,'Peter','Savings',9000,1)
		insert into accountsInfo values(17,'Mohan','Savings',9000,1)
		insert into accountsInfo values(18,'Rohan','Savings',9000,1)
		insert into accountsInfo values(19,'Sohan','Savings',9000,0)
		insert into accountsInfo values(20,'Nikhil','Savings',9000,1)
		insert into accountsInfo values(21,'Jacob','Savings',9000,1)
		insert into accountsInfo values(22,'Josheph','Savings',9000,1)
		insert into accountsInfo values(23,'Diago','Savings',9000,1)
		insert into accountsInfo values(24,'Kyle','Savings',9000,1)
		insert into accountsInfo values(25,'Katherine','Savings',9000,1)
		insert into accountsInfo values(26,'Kuavo','Savings',9000,1)

		update accountsInfo set accBalance = accBalance + 250 where accType = 'Loan'
		update accountsInfo set accBalance = accBalance + 860 where accIsActive = 'true'
		update accountsInfo set accBalance = accBalance * 1.1 where accNo > 12
		update accountsInfo set accBalance = accBalance - 1000 where accType = 'Savings'

		update accountsInfo set accName = 'Chadwick' where accNo = 15
		select * from accountsInfo

		delete from accountsInfo where accNo > 20
		select * from accountsInfo






		--DQL Statements
		--select 
		
--All	
		select * from accountsInfo
--limited col	
	select accNo,accName,accBalance from accountsInfo
--column alias
	select accNo as [Account Number],
		   accName as [Account Holder],
		   accBalance as [AvailableBalance]
	from accountsInfo

-- select with concat
	select accName + ' has a '+ accType + ' with bank ' as Information from accountsInfo
-- select with calculations
	select accName as Name,
		  accBalance as [Available Balance], 
		accBalance * 0.1 as Intrest,
		accBalance * 0.2 as Bonus,
		accBalance + (accBalance * 0.1) + (accBalance * 0.2) as [Effective Balance]
		from accountsInfo

--select with function
	--string function
	select accName,UPPER(accName) as UpperCase,lower(accName) as Lowercase from accountsInfo
	select accName,len(accName), SUBSTRING(accName,1,3) from accountsInfo
	select CONCAT(accName,' Has a ',accType,' Account with bank ',accBalance,' As Balance') as  info from accountsInfo 

	--Bank wish to create an email address for all the account holders, with the below format
	name.first2charactersofacctype@citibank.co.us

	select LOWER(concat(accName,'.',substring(accType,1,2),'@citibank.co.us')) from accountsInfo

	--aggregate function - sum,min,max,count,avg
	select SUM(accBalance) as [Total Balance with Bank] from accountsInfo
	select count(accNo) as [Total Accounts] from accountsInfo
	select max(accBalance) as [Maximum Balance] from accountsInfo
	select min(accBalance) as [Minimum Balance] from accountsInfo
	select AVG(accBalance) as [Average Balance with Bank] from accountsInfo
	select SUM(accBalance), count(accNo) from accountsInfo

	--select with date and time functions
	--we need to perform below activities on server, get the date, calculate date, add, date
	select GETDATE() 
	select GETDATE() + 10
	select DATEPART(WEEKDAY,getdate()) as Weekday,
		   DATEPART(month,getdate()) as Month,
		   datepart(Hour,getdate()) as Hour

	select DATEADD(DAY,60,getdate())
	select DATEDIFF(day,'10-10-2019',getdate())
	select DATEDIFF(MONTH,'10-10-2019',getdate()) as Month
	select DATEDIFF(HOUR,'05-23-2022',getdate()) as Hour
	--select DATEDIFF(WEEK,'05-23-2022',) as week
	select DATEADD(WEEK,12,'05-23-2022')

	
--with wild card operator
	select * from accountsInfo where accName like 'Jo%'
	select * from accountsInfo where accName like '%l'
	select * from accountsInfo where accName like '_i%'
	select* from accountsInfo where accName like '%i_'
	select upper(accName) as Name from accountsInfo where accName like '%ee'

-- with Sorting - order by clause
	select * from accountsInfo order by accName
	select * from accountsInfo order by accType,accName,accBalance desc

--with filter - where clause
	select * from accountsInfo where accName like 'N%' and accBalance > 10000
	select * from accountsInfo where accType = 'Savings' order by accBalance
	select count(accNo) from accountsInfo where accType='loan'
	select sum(accBalance) from accountsInfo where accIsActive = 'true' and accType = 'Savings'

-- with group by
	select accType,count(accNo) as [Total Accounts]from accountsInfo group by accType 
															order by [Total Accounts] desc

	select count(accNo) as Total, accisactive as Active from accountsInfo group by accIsActive


--with case statement
	--we wish to give 'stars to accounts with type', 3 star for savings, 4 stars for checking and 5 for loan

	select accName,accType,case accType  when 'Savings' then '***'
									when 'Checking' then '****'
									when 'Loan' then '*****'
									end as 'Ratings'
								from accountsInfo


	select accName, accBalance as [Available Balance], case accType when 'Savings' then accBalance * 1.1
																	when 'Checking' then accBalance * 1.2
																	when 'Loan' then accBalance * 0.7
																	end
																	as Bonus 
																	from accountsInfo

	--select with Join 
					





















	












		


















		










