use Supermarket

create table Category
(
 Category_Id int identity (100000,1) primary key,
 Category_Name nvarchar (80) not null,
 Category_Observation nvarchar (50) not null,
)

go
insert into PayMode values('Lacteos', 'queso')
insert into PayMode values('Carnes', 'jamon')
