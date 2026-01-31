USE Asset1DB

CREATE TABLE Customer(
	CustomerID INT PRIMARY KEY,
	CustomerName VARCHAR(100),
	CustomerPhone VARCHAR(20),
	CustomerCity VARCHAR(50)
);

CREATE TABLE Orders(
	OrderID INT PRIMARY KEY,
	OrderDate VARCHAR(20),
	CustID INT,
	FOREIGN KEY (CustID) REFERENCES Customer(CustomerID)
);

CREATE TABLE Products(
	ProductID INT PRIMARY KEY,
	ProductName VARCHAR(100),
	PricePerUnit INT
);

CREATE TABLE SalesPerson(
	SalesID INT PRIMARY KEY,
	PersonName VARCHAR(100)
);

CREATE TABLE OrderDetails(
	OrdID INT,
	ProdID INT,
	SaleID INT,
	Quantity INT
	FOREIGN KEY (OrdID) REFERENCES Orders(OrderID),
	FOREIGN KEY (ProdID) REFERENCES Products(ProductID),
	FOREIGN KEY (SaleID) REFERENCES SalesPerson(SalesID),
);




INSERT INTO Customer VALUES
(1, 'Ravi Kumar', '9876543210', 'Chennai'),
(2, 'Priya Sharma', '9123456789', 'Bangalore'),
(3, 'John Peter', '9988776655', 'Hyderabad');


INSERT INTO SalesPerson VALUES
(1, 'Anitha'),
(2, 'Suresh');

INSERT INTO Products VALUES
(1, 'Laptop', 55000),
(2, 'Mouse', 500),
(3, 'Keyboard', 1500),
(4, 'Monitor', 12000);

INSERT INTO Orders VALUES
(101, '2024-01-05', 1),
(102, '2024-01-06', 2),
(103, '2024-01-10', 1),
(104, '2024-02-01', 3),
(105, '2024-02-10', 2);

INSERT INTO OrderDetails (OrdID,ProdID,SaleID,Quantity)VALUES
(101, 1, 1, 1),  
(101, 2, 1, 2),  
(102, 3, 1, 1),  
(102, 2, 1, 1),  
(103, 1, 2, 1),  
(104, 4, 1, 1),  
(104, 2, 1, 1),  
(105, 1, 2, 1), 
(105, 3, 2, 1);  


SELECT O.OrdID as 'Order ID', SUM(P.PricePerUnit * O.Quantity) as 'Total Amount'
FROM OrderDetails O
JOIN Products P
ON O.ProdID = P.ProductID
GROUP BY O.OrdID
ORDER BY SUM(P.PricePerUnit * O.Quantity) DESC
OFFSET 2 ROWS
FETCH NEXT 1 ROWS ONLY;

SELECT S.PersonName as 'Sales Person', SUM(P.PricePerUnit * O.Quantity) as 'Total Amount'
FROM OrderDetails O
JOIN Products P
ON O.ProdID = P.ProductID
JOIN SalesPerson S
ON O.SaleID = S.SalesID
GROUP BY S.SalesID
HAVING SUM(P.PricePerUnit * O.Quantity) > 60000
ORDER BY SUM(P.PricePerUnit * O.Quantity);
