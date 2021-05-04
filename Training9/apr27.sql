create function totCal(@basic int,@hra int,@da int,@deduction int)
returns float
as 
begin
declare 
@total float
set @total =@basic+@hra+@da-@deduction
return @total
end

select * from Salary

select sal_id,basic_sal,hra,da,deduction ,dbo.totCal(basic_sal,hra,da,deduction) as TotalSalaray from Salary

create function fn_structTable(@id int)
returns @empSalTax Table(Ename varchar(15),TotalSal float,Tax float)
as 
begin
declare
@total float,
@tax float,
@taxPayable float,
@Ename varchar(15)
set @total=(select avg(basic_sal+hra+da-deduction) as total_salary from Salary where sal_id =
(select sal_id from empSalary where emp_id=@id))
if(@total<1000000)
	set @tax=0
else if(@total>100000 and @total <= 200000)
       set @total=5
else if(@total >200000 and @total <=350000)
           set @total=6
else
	       set @total=7.5

set @taxPayable=@total*@tax/100
set @Ename=(select name from employee where emp_id=@id)
insert into @empSalTax values(@Ename,@total,@taxPayable)
return
end

select * from dbo.empSalTax(101)

create table urkne(fun int,name char)

alter trigger tgr_urkne on urkne
after insert
as
begin
select concat('Hello',fun) from inserted
end


select * from urkne

insert into urkne values(100,'h')

create trigger trg_emp
on empSalary
after insert
as begin
declare
@totalsal float
set @totalsal=(select dbo.totCal(basic_sal,hra,da,deduction) from Salary where sal_id=(select sal_id from inserted))
insert into fn_structTable values((select transc_num from inserted),@totalsal)
end


create trigger task
on employee
after insert
as
begin
select concat('Welcome Mr.',name)from inserted
end

insert into employee(name,age,phone,gender,email) values
('Bhaskar',20,'888811112','Male','bhaskar@hotmail.com')

select * from employee

--transaction

begin transaction
	insert into employee(name,age,gender,phone,email) values('Vishnu',30,'888811112','Male','VishnuR@hotmail.com')
	insert into empSalary values('ae13123',105,101,'2021-04-27')
	if((select max(emp_id) from empSalary)=104)
		commit
	else
		rollback

select * from employee
select * from empSalary

declare @eid int,@ename varchar(15)
declare cur_employee cursor for
select emp_id,name from employee
open cur_employee
fetch next from cur_employee
into @eid,@ename
print '------Employee Details------'
print '============================'
while @@FETCH_STATUS=0
begin
	print 'Employee Id :'+cast(@eid as varchar(10))
	print 'Employee Name:'+@ename
	print '_/\_ _/\_ _/\_ _/\_ _/\_ _/\_ _/\_'
	fetch next from cur_employee
	into @eid,@ename
end
close cur_employee
deallocate cur_employee

select * from authors
select * from sales
select * from titleauthor
select * from titles


--1----

create proc proc_authorSold(@aufname varchar(20),@aulname varchar(20))
as
begin
select title_id ,qty from sales where title_id in  
(select title_id from titleauthor where au_id in
(select au_id from authors where 
(au_lname=@aulname and au_fname=@aufname)))
end

exec proc_authorSold 'Johnson' ,'White'

--2--

select pub_name as Publisher_name ,au_fname as First_Name,price from authors,titles,publishers join titleauthor on 
titleauthor.title_id = title_id

select * from publishers

--3--
--Print the publisher name Then print all the titles published by the publisher under every title print the authors for it
--For every title print the number of quantity sold and the date of sale
--PS - use cursor

declare @pname varchar(20),@titles varchar(80),@au_name varchar(20),@qty smallint,@date datetime
declare cur_pub cursor for
select pub_name,au_lname,title,qty,ord_date from authors,titles,publishers join sales on
sales.title_id = title_id

open cur_pub

fetch next from cur_pub
into @pname,@titles,@au_name,@qty,@date

print 'data:'
print '============================'
while @@FETCH_STATUS = 0
begin
print  'Publisher name: ' + cast(@pname as varchar(20))
print  'aurthor name: ' + cast(@au_name as varchar(20))
print  'Title name: ' + cast(@titles as varchar(80))
print   'Date:' +cast(@date as varchar(20))
print	'Quantity:' +cast(@qty as varchar(20))
print	'_/\_ _/\_ _/\_ _/\_ _/\_ _/\_ _/\_ _/\_'

end

close cur_pub
deallocate cur_pub

--4 Create a account table
--account number,name, balance, status(open/blocked)(default- open)
--Create a transaction table
--tran_id, from_account,to_account,amount,remarks

--Execute the transaction only if the transaction meets the following criterias
--a) Account should have min balance of 1500 after the debit
--b) credit or debit cannot be done to blocked account

create table account(acc_number varchar(20),name varchar(20),balance float,status varchar(20) default 'open')

create table transaction_e(train_id int,from_acc int,to_acc int,amount float,remarks varchar(10))

begin transaction
	insert into account values('928129','dheeraj',1600,'open')
	if((select balance from account)>1500 and (select status from account)='open')
		commit
	else
		rollback

select * from account

--5---
create trigger trg_calculate
on transactions
after update
as begin
if (select remarks from inserted) = 'void'
begin
update account set balance = balance + (select amount from transactions where tran_id = (select tran_id from inserted))
where account_number = (select from_acc from transactions where tran_id = (select tran_id from inserted))
update account set balance = balance + (select amount from transactions where tran_id = (select tran_id from inserted)) 
where account_number = (select to_acc from transactions where tran_id = (select tran_id from inserted))
--set @total = ((select (balance-amount) from insetred) join tranasactions on where tranansactions.tran_id=tran_id)
--print('Amount deducted')
end
end

update transactions set remarks = 'void' where tran_id = 2



