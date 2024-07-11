--Retrieve all the columns from the Customers table for customers who are from the UK.
SELECT *
FROM Customers
WHERE Country = 'UK';


--Using the Products table, list the product names and their unit prices where the unit price is greater than 30.
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice > 30;


--Count the number of products in the Products table that have been discontinued
SELECT COUNT(Discontinued) AS TotalDiscontinued
FROM Products
WHERE Discontinued = 1;


--Find the average, maximum, and minimum unit prices from the Products table
SELECT
	AVG(UnitPrice) AS AvgUnitPrice,
	MIN(UnitPrice) AS MinUnitPrice,
	MAX(UnitPrice) AS MaxUnitPrice
FROM PRODUCTS;


--Retrieve the names of categories and the count of products in each category from the Categories and Products tables.
SELECT Categories.CategoryName, COUNT(Products.CategoryID) AS TotalProducts
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
GROUP BY Products.CategoryID, Categories.CategoryName;


--List the suppliers (SupplierID and CompanyName) from the Suppliers table who are not from USA, Germany, or UK.
SELECT SupplierID, CompanyName
FROM Suppliers
WHERE Country NOT IN ('USA', 'Germany', 'UK');


--Retrieve all the distinct countries from the Customers table
SELECT DISTINCT Country
FROM Customers;


--Find the top 5 most expensive products (Product name and Unit price) from the Products table
SELECT TOP 5 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC;

--Using the Orders and Order Details tables, calculate the total revenue for each order (OrderID).
SELECT OrderID, SUM(UnitPrice * Quantity) AS Revenue
FROM [Order Details]
GROUP BY OrderID

--List all employees (FirstName and LastName) and the count of orders they have taken from the Employees and Orders tables.
SELECT FirstName, LastName, COUNT(Orders.EmployeeID) AS OrdersTaken
FROM Employees
JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
GROUP BY FirstName, LastName, Orders.EmployeeID;

