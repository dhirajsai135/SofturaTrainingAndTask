create database dbSoftTransport

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