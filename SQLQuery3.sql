Create database Order_Management_System;


CREATE TABLE Users (
userId INT PRIMARY KEY,
password NVARCHAR(255) NOT NULL,
role NVARCHAR(50) CHECK (role IN ('Admin', 'User'))
);



CREATE TABLE Products (
productId INT PRIMARY KEY,
productName NVARCHAR(255) NOT NULL,
description NVARCHAR(MAX),
price DECIMAL(10, 2) NOT NULL,
quantityInStock INT NOT NULL,
type NVARCHAR(50) CHECK (type IN ('Electronics', 'Clothing')),
-- Attributes specific to Electronics
brand NVARCHAR(255),
warrantyPeriod INT,
-- Attributes specific to Clothing
size NVARCHAR(50),
color NVARCHAR(50)
);





