create database RestaurantDB

use RestaurantDB

create table MenuList
(
itemId int primary key identity,
itemName varchar(20),
itemCategory  varchar(20),
itemPrice float
)

insert into MenuList values('Cheese Fries','Fries',5)
insert into MenuList values('Dosa','Break-fast',5)
insert into MenuList values('Idli','Break-fast',5)
insert into MenuList values('Pav Bhajji','Fast-Food',5)
insert into MenuList values('Burger','Burger',5)
insert into MenuList values('Pizza','Pizza',5)
insert into MenuList values('Tandoori Chicken','Curry',5)
insert into MenuList values('Choclate Vanilla','Ice-cream',5)
insert into MenuList values('Strawberry MilkShake','Milkshake',5)
insert into MenuList values('Peri-Peri Fries','Fries',5)

select * from MenuList

----------------------------------------------------------------
create table CustomersDetails
(
customerId int primary key,
customerName varchar(20),
customerType varchar(20),
customerContactNo int,
customerEmail varchar(50),
customerWalletBalance int, 

constraint chk_customerType check(customerType in ('Regular','Visitor')),
constraint chk_walletBalance check (customerWalletBalance > 0)
)

insert into CustomersDetails values(101,'Kyle','Regular',93244634,'kyle@gmail.com',20)
insert into CustomersDetails values(102,'Harper','Visitor',26156,'kyle@gmail.com',50)
insert into CustomersDetails values(103,'Eric','Regular',189895,'kyle@gmail.com',60)
insert into CustomersDetails values(104,'Edward','Visitor',4653,'kyle@gmail.com',10)
insert into CustomersDetails values(105,'Kuavo','Regular',1111156,'kyle@gmail.com',90)
insert into CustomersDetails values(106,'Katherine','Regular',128887,'kyle@gmail.com',120)
insert into CustomersDetails values(107,'Roba','Visitor',15161,'kyle@gmail.com',780)
insert into CustomersDetails values(108,'Jamal','Regular',1561112,'kyle@gmail.com',632)
insert into CustomersDetails values(109,'James','Regular',425485,'kyle@gmail.com',20)
insert into CustomersDetails values(110,'Diego','Regular',153212,'kyle@gmail.com',80)
insert into CustomersDetails values(111,'Kevin Dean','Visitor',15613,'kyle@gmail.com',125)
insert into CustomersDetails values(112,'Kevin G','Regular',435456,'kyle@gmail.com',365)
insert into CustomersDetails values(113,'Juwan','Visitor',5454555,'kyle@gmail.com',135)
insert into CustomersDetails values(114,'Jacob','Regular',1516565,'kyle@gmail.com',780)







select CustomersDetails.customerName,customerWalletBalance  from CustomersDetails where customerWalletBalance = 
		(select max(CustomersDetails.customerWalletBalance) from CustomersDetails)




create table Orders
(
BillNo int primary key identity,
orderNumber  int,
itemId int, 
customerId int,
orderQty int not null,

constraint fk_itemId foreign key(itemId) references Menulist,
constraint fk_customerId foreign key (customerId) references CustomersDetails,
constraint chk_orderQty check(orderQty > 0)
)

insert into Orders values(500,3,112,3)
insert into Orders values(501,4,111,12)
insert into Orders values(502,5,105,31)
insert into Orders values(503,6,112,32)
insert into Orders values(504,7,112,23)
insert into Orders values(505,4,108,63)
insert into Orders values(506,9,102,73)
insert into Orders values(507,10,107,23)
insert into Orders values(508,6,114,5)
insert into Orders values(509,2,107,8)
insert into Orders values(510,3,101,5)
insert into Orders values(511,3,105,13)
insert into Orders values(512,3,113,18)
insert into Orders values(513,3,111,15)
insert into Orders values(514,3,109,19)
insert into Orders values(515,3,105,13)
insert into Orders values(516,3,103,3)
insert into Orders values(517,3,102,30)
insert into Orders values(518,3,114,23)
insert into Orders values(519,7,113,63)
insert into Orders values(520,6,106,2)


select * from Orders
-------------------------------------------------------------------------------------------------

Display OrderNumber, CustomerName,CustomerType, ItemName, OrderQty

select Orders.orderNumber as [Order Number],
	   CustomersDetails.customerName as [Customer],
	   CustomersDetails.customerType as [Type Of Customer],
	   MenuList.itemName as [Item],
	   Orders.orderQty as [Quantity]
	   from Orders, CustomersDetails, MenuList
	   where Orders.customerId = CustomersDetails.customerId 
	   and
	   Orders.itemId = MenuList.itemId
			

			select MenuList.itemCategory as Category,
					count(Orders.BillNo) as [Total Orders]
					from Orders, MenuList
					where Orders.itemId = MenuList.itemId
					group by MenuList.itemCategory


		select * from Orders order by orderQty desc


