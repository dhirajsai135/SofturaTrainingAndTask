create database dbSoftTransportuse dbSoftTransport--AA12DD0000create table tblEmployee(Id int identity(101,1) primary key,Name varchar(20) not null,Password varchar(20) not null,Location varchar(20),Phone varchar(20),Vechicle_Id char(8))create table tblDriver(ID int identity(1000,1) primary key,Name varchar(20),Phone varchar(20),status varchar(50) check(status in ('active','not active')))create table tblVehicle(Vechicle_number char(8) primary key,Type varchar(10),Capacity int,Driver_ID int references tblDriver(id),Filled_Status int ,status varchar(50) check(status in ('running','discard')))alter table tblEmployeeadd constraint fk_VID foreign key(Vechicle_Id) references tblVehicle(Vechicle_number)

--Stored Procedure For Inserting into Employees Table

create proc proc_InsertEmployees
(@eName varchar(20),
@ePassword varchar(20),
@eLocation varchar(20),
@ePhone varchar(12))
as 
insert into tblEmployee(name,Password,Phone,Location) values(@eName,@ePassword,@ePhone,@eLocation)

--Updating the password(Stored Procedure)

create proc proc_UpdatePassword(@eid int,@ePassword varchar(20))
as
update tblEmployee set Password=@ePassword where id=@eid

create proc proc_GetAllEmployees
as
select * from tblEmployee