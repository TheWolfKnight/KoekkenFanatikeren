-- drop database KoekkenFanatikeren;
-- create database KoekkenFanatikeren;

use KoekkenFanatikeren;

/*
	@Name:		Employees
	@Column:	Id, int, Cannot be null, is a primary key,
				Contains the ID of the employee, which is uniqe to all employees.
	@Column:	FullName, chars between 0 - 255, not null,
				Contains the full name of an employee.
*/
create table [Employees] (
	[Id] int identity(1000, 1) not null primary key,
	[FullName] varchar(255) not null,
);

/*
	@Name:		Customers
	@Column:	Id, int, identity starting at 1000 and incromenting by 1, cannot be null, is a primary key
				Contains the id of a customer, which is uniqe to all customers.
	@Column:	FullName: chars between 0 - 255, cannot be null,
				Contains the full name of a customer.
	@Column:	PhoneNumber, chars of 8, cannot be null,
				Contains the phone number of a customer.
	@Column:	Email, chars between 0 - 255,
				Contains the email of a customer.
*/
create table [Customers] (
	[Id] int identity(1000, 1) not null primary key,
	[FullName] varchar(255) not null,
	[PhoneNumber] char(8) not null,
	[Email] varchar(255) not null,
);

/*
	@Name:			Orders
	@Column:		Id, int identity starts at 1000 incroments by 1, not null, is a primary key,
					Contains the id of a Order
	@Column:		CustomerId, int, cannot be null, is a refernce to the table Customers Id column
					Contains the id of the customer, who placed the order.
	@Column:		CreatorId, int, cannot be null, is a reference to the table Employees Id column
					The id of the employee who created the order.
	@Column:		TotalPrice, float
					The total price of all elements of the order, can be null if there are no emelents in the order
*/
create table [Orders] (
	[Id] int identity(1000, 1) not null primary key,
	[CustomerId] int not null foreign key references [Customers]([Id]),
	[CreatorId] int not null foreign key references [Employees]([Id]),
	[TotalPrice] float,
);

/*
	@Name:			ItemCategorys
	@Column:		Categorys, int identity starts at 0 incroments by 1, cannot be null, is a primary key
					Is used as an enumeratort for other tables to have an easy time destinctioning between different item categorys.
	@Column:		Name, chars between 0 - 255, cannot be null,
					The name of a given item category, which can easily by the Id.
*/
create table [ItemCategorys] (
	[Category] int identity(0,1) not null primary key,
	[Name] varchar(255) not null,
);

/*
	@Name:			Item
	@Column:		Id, int identity starts at 1000 incroments by 1, cannot be null, is a priamry key,
					Contains the id of a item, for reference use.
	@Column:		ItemCategory, int, cannot be null, is a reference to the ItemCategorys Category column
					Used to sort the items based upon different category specifications.
	@Column:		Name, chars between 0 - 255, cannot be null,
					Contains the name of an item.
	@Column:		Producer, chars between 0 - 255, cannot be null,
					Contains the name of the company who make the item in question.
	@Column:		Quantity, int, cannot be null,
					Contains the amount of the item currently in stock.
	@Column:		UnitPrice, float, cannot be null,
					Contains the price for each unit of a given item, used later to calculate the total price
					of a given order.
*/
create table [Items] (
	[Id] int identity(1000, 1) not null primary key,
	[ItemCategory] int not null foreign key references [ItemCategorys]([Category]),
	[Name] varchar(255) not null,
	[Producer] varchar(255) not null,
	[Quantity] int not null,
	[UnitPrice] float not null,
);

/*
	@Name:			OrderItems
	@Column:		OrderId, int, cannot be null, is a refernce to the Orders id column,
					Contains the Id for the order, to which this item belongs.
	@Column:		ItemId, int, cannot be null, is a refernce to the Items id column,
					Contains the id of the item, that belongs to a specific order.
	@Column:		Quantity, int, cannot be null,
					Contains the amount of a specific item an order needs, to be forfiled.
*/
create table [OrderItems] (
	[OrderId] int not null foreign key references [Orders]([Id]),
	[ItemId] int not null foreign key references [Items]([Id]),
	[Quantity] int not null,
);

go