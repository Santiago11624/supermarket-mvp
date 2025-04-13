use Supermarket
create table Customer
(
 Document_Number int identity (100000,1) not null unique,
 First_Name nvarchar (50) not null,
 Last_Name char (50) not null,
 Address_ char (80),
 Birthday date,
 Phone_Number char (16),
 Email char (100),
)
go
insert into Customer values('Santiago', 'Cardenas')
insert into Customer values('pepito', 'Gomez')
