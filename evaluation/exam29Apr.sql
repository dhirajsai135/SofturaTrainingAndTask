
------------------------1--
select city,count(au_id) as Count_of_Authors from authors group by city


------------------------2--

select distinct city,au_fname,au_lname from authors where city not in
(select city from publishers where pub_name = 'New Moon Books')

select * from sales

------------------------3---

select * from titleauthor
select * from authors
select * from titles


create proc ValidateMoney(@fname varchar(20),@lname varchar(40),@price money)
as 
begin
update titles set price = @price
select au_fname,au_lname,price from authors,titles where au_fname = @afname
end

exec ValidateMoney 'Abraham','Bennet',20.99

----------------------------4--
drop function taxCalculator

select * from sales

alter function taxCalculator(@quant varchar(10))
returns @FinalTable table(title_id varchar(10),tax varchar(10))
as
begin
declare 
@cal int,
@taxPercentage varchar(10)
set @cal=(select distinct qty from sales where ord_num=@quant)

	if(@cal<10)
		set @taxPercentage='2%'

	else if(@cal>10 and @cal<20)	
		set @taxPercentage='5%'
	else if(@cal>20 and @cal<50)	
		set @taxPercentage='6%'
	else if(@cal >=50)	
		set @taxPercentage='7.5%'

	insert into @FinalTable values(@taxPercentage) 

	return
end



select tax from dbo.taxCalculator('QA7442.3')