--Select all the rows from the "Customers" table.
SELECT * FROM Customers;

--Get distinct countries from the Customers table. (Hint: research the DISTINCT keyword.)
SELECT DISTINCT Country
FROM Customers;

--Get all the rows from the table Customers where the Customer’s ID starts with “BL”.
SELECT *
FROM Customers
WHERE CustomerID LIKE 'BL%';

--Get the first 100 records of the orders table. (Hint: research the TOP keyword.) DISCUSS: Why would you do this? What else would you likely need to include in this query?
SELECT TOP 100 * FROM Orders;
/* This helps see what the data looks like. You can clearly see 100 examples of the data in this table. You would also likely include the specific columns you want to see in the SELECT statement. */

--Get all customers that live in the postal codes 1010, 3012, 12209, and 05023. (Hint: research the IN keyword.)
SELECT *
FROM Customers
WHERE PostalCode IN ('1010', '3012', '12209', '05023');

--Get all orders where the ShipRegion is not equal to NULL.
SELECT *
FROM Orders
WHERE ShipRegion IS NOT NULL;

--Get all customers ordered by the country, then by the city.
SELECT *
FROM Customers
ORDER BY Country, City;

--Add a new customer to the customers table. You can use whatever values.
INSERT INTO Customers (CustomerID, CompanyName)
VALUES ('AAAAA', 'This is a company');
SELECT * FROM Customers;

--Update all ShipRegion to the value ‘EuroZone’ in the Orders table, where the ShipCountry is equal to France.
UPDATE Orders
SET ShipRegion = 'EuroZone'
WHERE ShipCountry = 'France';
SELECT * FROM Orders WHERE ShipCountry = 'France';

--Delete all orders from OrderDetails that have quantity of 1. 
DELETE FROM [Order Details] WHERE Quantity = 1;
SELECT * FROM [Order Details] ORDER BY Quantity;

--Find the CustomerID that placed order 10290 (orders table).
SELECT CustomerID
FROM Orders
WHERE OrderID = '10290';

--Join the orders table to the customers table.
SELECT *
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

--Get employees’ firstname for all employees who report to no one.
SELECT FirstName
FROM Employees
WHERE ReportsTo IS NULL;

--Get employees’ firstname for all employees who report to Andrew.
SELECT FirstName
FROM Employees
WHERE ReportsTo = '2'

--Write an SQL command to create an index on the CustomerID column in the Customers table.
CREATE INDEX id_index
ON Customers (CustomerID);
SELECT * FROM Customers;
