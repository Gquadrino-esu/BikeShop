CREATE DATABASE BikeShop;
GO
USE BikeShop;

CREATE TABLE BikeBrand (
	BikeBrandID int Identity(1, 1) PRIMARY KEY,
	BikeBrandName varchar(20)
);

CREATE TABLE BikeCategory (
	BikeCatID int Identity(1, 1) PRIMARY KEY,
	BikeCatName varchar(20)
);

CREATE TABLE BikeName (
	BikeNameID int Identity(1, 1) PRIMARY KEY,
	BikeName varchar(20),
	BikeYear varchar(4),
	BikePrice float,
	BikeBrandID int,
	BikeCatID int,
	FOREIGN KEY(BikeBrandID) REFERENCES BikeBrand(BikeBrandID),
	FOREIGN KEY(BikeCatID) REFERENCES BikeCategory(BikeCatID)
);

CREATE TABLE Customer (
	CustID int Identity(1, 1) PRIMARY KEY,
	CustFName varchar(20),
	CustLName varchar(20),
	CustCCNum varchar(16),
	CustCCPin varchar(4)
);

CREATE TABLE Staff (
	StaffID int Identity(1, 1) PRIMARY KEY,
	StaffFName varchar(20),
	StaffLName varchar(20)
);

CREATE TABLE Store (
	StoreID int Identity(1, 1) PRIMARY KEY,
	StoreName varchar(20),
	StaffPhone varchar(10),
	ManagerID int,
	FOREIGN KEY(ManagerID) REFERENCES Staff(StaffID)
);

CREATE TABLE CustomerOrder (
	CustOrderID int Identity(1, 1) PRIMARY KEY,
	OrderDate DATE,
	CustID int,
	StoreID int,
	StaffID int,
	OrderDiscount int,
	FOREIGN KEY(CustID) REFERENCES Customer(CustID),
	FOREIGN KEY(StaffID) REFERENCES Staff(StaffID),
	FOREIGN KEY(StoreID) REFERENCES Store(StoreID)
);

CREATE TABLE CustomerOrderItems (
	CustOrderProID int Identity(1, 1) PRIMARY KEY,
	CustOrderID int,
	BikeNameID int,
	StoreID int,
	BikeQty int,
	FOREIGN KEY(BikeNameID) REFERENCES BikeName(BikeNameID),
	FOREIGN KEY(CustOrderID) REFERENCES CustomerOrder(CustOrderID),
	FOREIGN KEY(StoreID) REFERENCES Store(StoreID)
);

CREATE TABLE Stock (
	StockID int Identity(1, 1) PRIMARY KEY,
	StoreID int,
	BikeNameID int,
	BikeQty int,
	FOREIGN KEY(BikeNameID) REFERENCES BikeName(BikeNameID),
	FOREIGN KEY(StoreID) REFERENCES Store(StoreID)
);