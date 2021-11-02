--Show all Finnish customers in the Customers' table.
SELECT * 
FROM Customers 
WHERE Country = 'Finland'

--Practice 1.2. Show all customerID from Orders' table where the ID is QUEDE.
SELECT * 
FROM Orders 
WHERE CustomerID = 'QUEDE'

--Practice 1.2, alternative implementation with a sub query. Same result as the previous one.
SELECT * 
FROM Orders 
WHERE CustomerID = (
	SELECT CustomerID
	FROM Customers
	WHERE CompanyName = 'Que Delícia'
)

--Practice 1.3
SELECT * 
FROM Employees
WHERE City = 'London' AND Country = 'UK'

--Day 9, Practice 2.1
SELECT COUNT(CustomerID)
FROM Customers

--Practice 2.2
SELECT SUM(UnitPrice*UnitsInStock) AS 'Value in $'
FROM Products

--Practice 2.3. Why squary brackets? The Order Details table has a space in its name.
SELECT SUM(UnitPrice*Quantity) AS 'Value in $'
FROM [Order Details]
WHERE ProductID = 14
