create database td8

create table Employee1
(id int identity(101,1) primary key,
name varchar(20),
age int default 19,
manager_id int )

--Drop table Employee

alter table Employee1
add constraint empManageId foreign key(manager_id) references Employee1(id)

insert into Employee1(name,age) values('dheeraj',21)
insert into Employee1(name,age) values('venkat',22)
insert into Employee1(name,age) values('phani',20)

insert into Employee1(name,age,manager_id) values('sai',21,101)
insert into Employee1(name,age,manager_id) values('krishna',21,103)

delete from Employee1 where id=105

select * from Employee1

select 
emp.id employee_id,emp.name employee_name,
emp.age employee_age,mng.id manager_id,
mng.name manager_name from Employee1 emp join Employee1 mng on emp.manager_id=mng.id

--Below this done in pubs database

create procedure exe
as
begin
select * from titles
end
exec exe

create proc ex1(@name varchar(20))
as begin
select concat('Hello',@name)
end
exec ex1 'dheeraj'

create proc example(@name varchar(20),@age varchar(10))
as begin

	if(@age ='Male')
		select concat('Hello Mr.',@name)
	else
		select concat('Hello Miss.',@name)
end
exec example 'dheeraj','Male'
exec example 'Alexa','Female'

create proc author_search(@fname varchar(20))
as 
begin

select * from titles where title_id in
(select title_id from titleauthor where au_id in
(select au_id from authors where au_fname=@fname))
end

select * from authors

exec author_search 'Meander'

select * from sales
select * from titles

--getting out for sales about particular title

alter proc task1(@op varchar(20))
as 
begin
select * from sales  where title_id in 
(select title_id from titles where title =@op)

end

exec task1 'Net Etiquette'

--counting the sales of each book and returning a statement

alter proc task2(@op2 varchar(20))
as 
begin
declare
@salecount int
	set @salecount=(select count(*) from sales where title_id=
	(select title_id from titles where title=@op2))
	if(@salecount >1)
		select concat('Good sales with',@salecount)
	else
		select concat('Not Good',@salecount)
end

select * from titles

exec task2 'The Busy Executive''s Database Guide'

create table Employee1
(id int identity(101,1) primary key,
name varchar(20),
age int default 19,
manager_id int )

alter table Employee1
add constraint empManageId foreign key(manager_id) references Employee1(id)

insert into Employee1(name,age) values('dheeraj',21)
insert into Employee1(name,age) values('venkat',22)
insert into Employee1(name,age) values('phani',20)

insert into Employee1(name,age,manager_id) values('sai',21,101)
insert into Employee1(name,age,manager_id) values('krishna',21,103)

--procedural language for stopping enetering data if it more than 6 employees for manager

alter proc task3(@name varchar(20),@age int,@id int)
as begin
declare
@empCount int

set @empcount=(select count(*) from Employee1 where manager_id=@id)

	if(@empCount <6 )
		insert into Employee1(name,age,manager_id) values(@name,@age,@id)
	else
		select 'manager already has 6 employees'
end

exec task3 'sai',20,103
select * from Employee1

--opParameter example

create proc outParameter(@dataIn int,@dataOut int out)
as 
begin
	set @dataIn= @dataOut*100;
end

declare
@myData int
exec outParameter 25,@myData out
select @myData
