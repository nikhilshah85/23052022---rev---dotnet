create database empManagementDB

use empManagementDB

create table deptInfo
(
	deptNo int,
	deptName varchar(20),
	deptLocation varchar(20),
	deptEmail varchar(20),

	constraint pk_deptNo primary key(deptNo)
	)
insert into deptInfo values (10,'Accounts','New Yark','accounts@rev.com')
insert into deptInfo values (20,'HR','Reston','hr@rev.com')
insert into deptInfo values (30,'Training','California','training@rev.com')
insert into deptInfo values (40,'Transport','Texas','transport@rev.com')
insert into deptInfo values (50,'Recruitment','Washington','recruitment@rev.com')
insert into deptInfo values (60,'QC','Mumbai','qc@rev.com')
insert into deptInfo values(70,'Cloud Management','Bangalore','cloud@rev.com')
insert into deptInfo values(80,'Cafereria','Boston','cafeteria@rev.com')

select * from deptInfo

--------------------------------------------------------------------------------------------------------------

create table empInfo
(
	empNo int,
	empName varchar(20),
	empDesigantion varchar(20),
	empSalary int,
	empIsActive bit,
	empDept int,
	constraint pk_empNo primary key(empNo),
	constraint fk_empDept foreign key(empDept) references deptInfo
	)

	insert into empInfo values(1,'Nikhil','Consultant',200,1,30)
	insert into empInfo values(2,'Jonathan','QC Manager',200,1,60)
	insert into empInfo values(3,'Karan','HR',200,1,20)
	insert into empInfo values(4,'Dinesh','QC Manager',200,1,60)
	insert into empInfo values(5,'Kate','Training Manager',200,1,30)
	insert into empInfo values(6,'Jackson','Sr Developer',200,1,30)
	insert into empInfo values(7,'John','Sr.Accounts',200,1,10)
	insert into empInfo values(8,'Shelby','HR Manager',200,1,20)
	insert into empInfo values(9,'Ola','QC Manger',200,1,60)	
	insert into empInfo values(10,'Shawn','HR Head',200,1,20)
	insert into empInfo values(11,'Micheal','Jr.Transport Manger',200,1,40)
	insert into empInfo values(12,'Christopher','Developer',200,1,30)
	insert into empInfo values(13,'Kishore','Sr.Developer',200,1,30)
	insert into empInfo values(14,'Dennies','Jr.Accountant',200,1,10)
	insert into empInfo values(15,'Adrian','Recruitment Spl',200,1,50)

	insert into empInfo(empNo,empName,empDesigantion,empSalary,empIsActive) values  (16,'Donald','Trainee' ,300,1)
	insert into empInfo(empNo,empName,empDesigantion,empSalary,empIsActive) values  (17,'Nick','Devloper' ,300,1)
	insert into empInfo(empNo,empName,empDesigantion,empSalary,empIsActive) values  (18,'Amala','Account' ,300,1)
	insert into empInfo(empNo,empName,empDesigantion,empSalary,empIsActive) values  (19,'Gabriel','Trainee' ,300,1)


	select * from deptInfo
	select * from empInfo
	update empInfo set empSalary = empSalary + 150 where empDept = 20
	update empInfo set empSalary = empSalary + 275 where empDept = 40
	update empInfo set empSalary = empSalary + 895 where empDept = 60
	update empInfo set empSalary = empSalary + 300 where empDept = 10

	update empInfo set empSalary = empSalary + 500 where empDesigantion like '%Manager%'
	update empInfo set empSalary = empSalary *  1.3 where empSalary > 600
	select *from empInfo










	update empInfo set empIsActive = 0 where empSalary < 400 and empDesigantion like 'Developer'


	---------- Inner Join - Equi Join - gives you only equal records from both the tables
									--equality value is primary key and FK 

					select * from empInfo join deptInfo
									on 
								  empInfo.empDept = deptInfo.deptNo

					select * from empInfo e join deptInfo d
									on 
								  e.empDept = d.deptNo 
								  where d.deptLocation = 'Reston'
								  order by e.empDept,e.empSalary

				select e.empNo,e.empName,e.empSalary, d.deptNo,d.deptLocation
						from empInfo e
						inner join deptInfo d
						on
						e.empDept = d.deptNo
						order by d.deptLocation

				select e.empNo,e.empName,e.empSalary, d.deptNo,d.deptLocation
						from empInfo e
						left join deptInfo d
						on
						e.empDept = d.deptNo
						order by d.deptLocation

				select e.empNo,e.empName,e.empSalary, d.deptNo,d.deptLocation
						from empInfo e
						right join deptInfo d
						on
						e.empDept = d.deptNo
						order by d.deptLocation



				
				select e.empNo,e.empName,e.empSalary, d.deptNo,d.deptLocation
						from empInfo e
						full join deptInfo d
						on
						e.empDept = d.deptNo
						order by d.deptLocation

				select e.empNo,e.empName,e.empSalary,e.empDept, d.deptNo,d.deptLocation
						from empInfo e
						full join deptInfo d
						on
						e.empDept = d.deptNo
						where e.empDept is null
						order by d.deptLocation











			--How many emp works in every location ?
			--what is the total salary paid to each department ?

			select count(e.empNo) [Total Employee],d.deptLocation 
								from empInfo e
								join deptInfo d
								on e.empDept = d.deptNo
								group by d.deptLocation

			select count(e.empNo) [Total Employee] 
								from empInfo e
								join deptInfo d
								on e.empDept = d.deptNo where d.deptLocation = 'New Yark'



				--frame a statement from both tables, empName is empDesignation and work from empLocation

				select CONCAT(e.empName,' is a ',e.empDesigantion, ' and works from ',d.deptLocation)
				from empInfo e
				join deptInfo d
				on e.empDept = d.deptNo

									
		









			


