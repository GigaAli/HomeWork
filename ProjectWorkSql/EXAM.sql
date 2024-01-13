CREATE TABLE ManufacturingCountries(
	id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
);

CREATE TABLE FuelTypes(
	id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
);

CREATE TABLE BodyTypes(
	id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
);

CREATE TABLE Colors(
	id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
);

CREATE TABLE Users(
	id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
	[Login] NVARCHAR(MAX) UNIQUE NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	Email NVARCHAR(MAX) UNIQUE NOT NULL CHECK (Email LIKE '%@%.%'),
	Link VARCHAR(255) CHECK (Link LIKE 'http://%')
);

CREATE TABLE Sellers(
	id INT PRIMARY KEY IDENTITY(1,1),
	CompanyName NVARCHAR(MAX) NOT NULL,
	ContactNumber NVARCHAR(MAX) CHECK (ContactNumber LIKE '(___) ___-____'),
	Model NVARCHAR(MAX) NOT NULL,
	ManufactureDate DATE NOT NULL CHECK(ManufactureDate > '1990-01-01'),
	Rating INT NOT NULL,
	CountryId int foreign key references ManufacturingCountries(id),
	UserId int foreign key references Users(id)
);

CREATE TABLE Cars(
	id INT PRIMARY KEY IDENTITY(1,1),
	Brand NVARCHAR(MAX) NOT NULL,
	Model NVARCHAR(MAX) NOT NULL,
	ManufactureDate DATE NOT NULL CHECK(ManufactureDate > '1990-01-01'),
	FuelTypeId int foreign key references FuelTypes(id),
	BodyTypeId int foreign key references BodyTypes(id)
);
CREATE TABLE ProductList(
	id INT PRIMARY KEY IDENTITY(1,1),
	Price int NOT NULL,
	Quantity int NOT NULL,
	CarId int foreign key references Cars(id),
	SellerId int foreign key references Sellers(id)
);



