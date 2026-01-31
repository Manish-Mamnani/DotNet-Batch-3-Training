USE LPU_Db;

/*
CREATE TABLE Department
(
    DeptId INT IDENTITY(1,1) PRIMARY KEY,
    DeptName VARCHAR(30)
);

CREATE TABLE Employee
(
    EmpId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(40) NOT NULL,
    Age INT,
    Salary INT,
    DeptId INT,
    JoinDate DATE,
    City VARCHAR(30),

    FOREIGN KEY (DeptId) REFERENCES Department(DeptId)
);

INSERT INTO Department(DeptName)
VALUES
('IT'),
('HR'),
('Sales'),
('Finance');

INSERT INTO Employee(Name,Age,Salary,DeptId,JoinDate,City)
VALUES
('Manish',21,40000,1,'2024-06-01','Jaipur'),
('Rahul',23,30000,2,'2023-03-15','Delhi'),
('Neha',22,35000,1,'2024-01-10','Mumbai'),
('Mohit',24,25000,3,'2022-11-20','Pune'),
('Aarti',21,NULL,2,'2025-01-05','Delhi'),
('Rohit',25,45000,4,'2021-08-12','Jaipur');
*/

select * from Employee
where Name LIKE 'M%';
GO

select * from Employee
where Salary is Null;
GO

select E.Name,D.DeptName
from Employee E
JOIN Department D
ON E.DeptId = D.DeptId;
GO

select E.Name, E.Salary
from Employee E
ORDER BY Salary DESC
OFFSET 0 ROWS
FETCH NEXT 1 ROWS ONLY;
GO

SELECT DISTINCT Name, Salary
FROM Employee
WHERE Salary IS NOT NULL
ORDER BY Salary DESC
OFFSET 1 ROWS
FETCH NEXT 1 ROWS ONLY;
GO

SELECT D.DeptName, COUNT(E.DeptId) as 'Number of Employees'
FROM Employee E
JOIN Department D
ON E.DeptId = D.DeptId
GROUP BY DeptName
HAVING COUNT(E.DeptId) > 1;
GO
