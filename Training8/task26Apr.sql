create database employeeSalary

create table employee(
emp_id int identity(100,1) primary key,
name varchar(20),
age int default 18,
phone varchar(10) not null,
gender char(10))

alter table employee add email varchar(20)

create table Salary(
sal_id int identity(1,100) primary key,
basic_sal int,
hra int,
da int,
deduction int)



create table empSalary(
transc_num varchar(20) not null,
emp_id int,
sal_id int,
date date)



alter table empSalary add constraint pkey primary key(transc_num)
alter table empSalary add constraint unq unique(emp_id,sal_id,date)
alter table empSalary add foreign key (emp_id) references employee(emp_id)
alter table empSalary add foreign key (sal_id) references Salary(sal_id)

sp_help employee
sp_help Salary
sp_help empSalary

insert into employee(name,age,phone,gender,email) values
('dheeraj',20,'9999911112','Male','dheeraj@hotmail.com'),
('venkat',21,'8889911112','Male','venkat@gmail.com'),
('phani',22,'7777911112','Male','phani@hotmail.com'),
('sai',23,'9899911112','Male','sai@gmail.com')


select * from employee

insert into Salary(basic_sal,hra,da,deduction) values
(30000,7000,1000,2500),
(40000,8000,2000,3000),
(60000,7000,3000,3500),
(80000,15000,2600,5000)

select * from Salary



insert into empSalary values
('ae120456',101,1,'2021-03-31'),
('ae120929',102,101,'2021-04-01'),
('an823828',103,201,'2021-04-03'),
('ls230302',103,301,'2021-04-02')

select * from empSalary

--

alter proc totalSalary(@empid int)
as
begin 
select (basic_sal+hra+da-deduction) as total_salary from Salary where sal_id =
(select sal_id from empSalary where emp_id=@empid)

end

exec totalSalary 101

create proc avgSalary(@empid int)
as
begin 
select avg(basic_sal+hra+da-deduction) as total_salary from Salary where sal_id =
(select sal_id from empSalary where emp_id=@empid)

end

exec totalSalary 101

create proc taxSalary(@empid int,@tax float out)
as
begin 
declare
@total float,
@taxPayable float
set @total=(select avg(basic_sal+hra+da-deduction) as total_salary from Salary where sal_id =
(select sal_id from empSalary where emp_id=@empid))

if(@total<1000000)
	set @tax=0
else if(@total>100000 and @total <= 200000)
       set @total=5
else if(@total >200000 and @total <=350000)
           set @total=6
else
	       set @total=7.5

set @taxPayable=@total*@tax/100
select concat('Tax',@taxPayable)

end

declare
@myTax float
exec taxSalary 101,@myTax out
select @myTax