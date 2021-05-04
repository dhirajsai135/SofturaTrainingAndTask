use pubs
select * from authors

select au_lname,phone,city,state,zip from authors

select au_lname Firstname,phone MobileNum from authors

select * from authors where state='CA'

select * from authors where state!='CA'

select * from employee

select * from employee where minit is not null

select * from employee where job_id between 10 and 15

select * from employee where job_lvl>100

select * from employee where job_id=11 or job_id=14 or job_id=6

select * from employee where job_id in(11,14,6)

select * from employee where job_id not in(11,14,6)

select * from employee where fname like 'Mar%'

select * from employee where fname like '_e%'

select * from employee where minit=' '

select emp_id,fname,minit,job_id from employee where job_lvl>100

select * from titles

select distinct pub_id from titles
select sum(advance) Total from titles
select max(advance) Maximum from titles
select count(advance) Number_count from titles
select min(advance) Minimum from titles
select avg(advance) Average from titles

select pub_id,count(*) from titles group by pub_id

select pub_id,avg(advance) Average from titles group by pub_id

select sum(qty),title_id from sales group by title_id

select * from sales

select avg(royalty) Average,title from titles group by title

select count(payterms) as Number_of_orders,stor_id from sales group by stor_id

select count(payterms) as Number_of_orders,stor_id from sales group by stor_id having count(payterms)>2

select avg(royalty) Average,type from titles group by type having avg(royalty) <15

select * from authors

select * from authors order by au_lname,state,city desc

select * from sales where title_id=
(select title_id from titles where title='Straight Talk About Computers')
select * from sales where title_id in
(select title_id from titles where pub_id=(select pub_id from publishers where pub_name='New Moon Books'))


select title,qty from titles join sales on titles.title_id=sales.title_id

select title_id from sales

select distinct title_id from sales

select title_id from titles where title_id not in(select distinct title_id from sales)

select t.title_id,title,qty
from titles t LEFT JOIN sales s on t.title_id=s.title_id

select * from authors
select * from sales
select * from publishers

select pub_name,title from publishers left outer join titles
on 
publishers.pub_id=titles.pub_id

--<<<<<<<<<<<<<<<<<<<<<<<Task>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

select * from authors

select * from titles

select * from publishers

select * from sales

select * from pub_info

select * from titleauthor

select * from publishers

select * from employee

--1.Question1

select au_lname,au_fname from authors

--2.Question1

select * from titles order by title desc

--3.Question3

select  distinct title_id,count(*) as Number_of_titles from titleauthor group by title_id

--4.Question4

select distinct au_fname,au_lname, title from authors,titles

--5.Question5

select pub_name,avg(advance) Average from titles, publishers group by pub_name

--6.Question6

select pub_name,au_fname as FIrstN, au_lname as Lastn, title, qty*price as SaleAmount from 
authors, publishers p left outer join titles t on p.pub_id=t.pub_id join sales s on t.title_id=s.title_id

--7-Question7

select price from titles where title like '%s'

--8.Question8

select title from titles where title like '%and%'

--9.Question9

select pub_name,fname from publishers join employee on
publishers.pub_id = employee.pub_id

--10.Question10

select pub_name,count(emp_id) from publishers,employee group by pub_name

--11.Question11

select pub_name,au_fname from authors,publishers where pub_name='Algodata Infosystems'

--12.Question12

select pub_name,fname from publishers join employee on
publishers.pub_id = employee.pub_id
where pub_name='Algodata Infosystems'
