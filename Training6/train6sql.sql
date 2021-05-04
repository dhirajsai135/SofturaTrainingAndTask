create database train6

use train6

create table empdetails(id int, name varchar(20))
select * from empdetails
sp_help empdetails

create table skills
(skill_name varchar(20) constraint pk_skill primary key, skill_description text)

sp_help skills

create table cities
(zip_code char(4), 
city varchar(20),
primary key(zip_code))
sp_help cities

create table employees
(id char(4) primary key,
name varchar(20) not null,
phone varchar(15) not null,
zip char(4) references cities(zip_code))
sp_help employees

create table employeeskill
(employee_id char(4) references employees(id),
skill_name varchar(20) references skills(skill_name),
skill_level float default 1,
constraint pk_empskill primary key(employee_id,skill_name))
sp_help employeeskill

insert into skills(skill_name,skill_description) values('C','PLT')
insert into skills values('C++','OOPS')
insert into skills values('Java','Web')
insert into skills values('python',null)

update skills set skill_description='security' where skill_name='python'

delete skills where skill_name='java'
select * from skills

insert into cities values('9876','xyz'),('8769','yzx'),('1769','azx')
 
 insert into employees values
 ('E001','dheeraj','99999999','9876'),
 ('E002','venkat','9999988','9876'),
 ('E003','phani','99344999','1769'),
 ('E004','sai','89344999','1769'),
 ('E005','krishna','99344994','8769')

 select * from employees

 insert into employeeskill values('E001','Java','8'),('E001','C++','4')
