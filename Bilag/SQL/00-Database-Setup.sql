-- DROP KoekkenFanatikeren;

use KoekkenFanatikeren;

/**/
create table [Employees] (
	[Id] int identity(1000, 1) not null primary key,
);

/**/
create table [Customers] (
	[Id] int identity(1000, 1) not null primary key,
);

/**/
create table [Orders] (
	[Id] int identity(1000, 1) not null primary key,
	[CustomerId] int foreign key references [Customers]([Id]),
	[CreatorId] int foreign key references [Employees]([Id]),
	[TotalPrice] float,
);

/**/
create table [ItemCategorys] (
	[Categorys] int identity(0,1) not null primary key,
);

/**/
create table [Items] (
	[Id] int identity(1000, 1) not null primary key,
	[ItemCategory] int foreign key references [ItemCategorys]([Categorys]),
	[Name] varchar(255) not null,
	[Producer] varchar(255) not null,
	[Quantity] int not null,
	[UnitPrice] float not null,
);

/**/
create table [OrderItems] (
	[OrderId] int foreign key references [Orders]([Id]),
	[ItemId] int foreign key references [Items]([Id]),
	[Quantity] int not null,
);
