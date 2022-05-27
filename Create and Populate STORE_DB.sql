use master
go
if exists (select name
 from master.sys.databases
 where name = 'StoreDB')
 begin
   drop database StoreDB
 end
go
create database StoreDB
go
USE [StoreDB]
GO

create table CUSTOMER(
	CustID int identity(1,1) primary key,
	CustUsername varchar(20) not null,
	CustPassword varchar(20) not null,
	CustCreditLimit decimal(8,2) not null,
	CustCurrBalance decimal(8,2) not null,
	constraint[UIX_USERNAME_PASSWORD] unique (CustUsername, CustPassword)
)

create table ITEM(
	ItemID int identity(1,1) primary key,
	ItemDescription varchar(20) not null,
	ItemCost decimal(8,2) not null
)

create table PURCHASE(
	PurchaseID int identity(1,1) primary key,
	CustID int not null,
	OrderTotal decimal(8,2) not null,
	PurchaseDate as getdate(),
	constraint[Purchase_Cust] foreign key (CustID) references Customer(CustID),
)

create table PURCHASE_ITEM(
	PurchaseItemID int identity(1,1) primary key,
	CustID int not null,
	PurchaseID int not null,
	ItemID int not null,
	Qty int not null,
	constraint[FK_PURCHASE] foreign key (PurchaseID) references Purchase(PurchaseID),
	constraint[FK_ITEM] foreign key (ItemID) references Item(ItemID),
	constraint[FK_CUST] foreign key (CustID) references Customer(CustID)
)

insert into CUSTOMER 
values('soprano','T9jGT\J/vB]+wP!z',150.00,0.00)
insert into	CUSTOMER
values('yipman','b5FC+E5)',180.00,0.00)
insert into CUSTOMER
values('user','password',100.00,0.00)

insert into ITEM
values('Bread','3.89')
insert into ITEM
values('Meat','14.99')
insert into ITEM
values('Fish','7.33')
insert into ITEM
values('Cheese','10.64')
insert into ITEM
values('Pasta','4.59')
insert into ITEM
values('Cereal','3.56')
insert into ITEM
values('Ice Cream','2.39')
insert into ITEM
values('Milk','1.89')
insert into ITEM
values('Hot Dogs','2.77')
insert into ITEM
values('Cream Cheese','2.43')
insert into ITEM
values('Crackers','4.55')
insert into ITEM
values('Candy','2.65')