use LPU_Db;

CREATE TABLE StudentInfo (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(100),
    StudentAddress VARCHAR(200), 
    Age INT,
    City VARCHAR(50)
);

INSERT INTO StudentInfo VALUES (1, 'Amit Sharma', '12 MG Road', 20, 'Delhi');
INSERT INTO StudentInfo VALUES (2, 'Neha Verma', '45 Park Street', 21, 'Kolkata');
INSERT INTO StudentInfo VALUES (3, 'Rahul Mehta', '78 Ring Road', 22, 'Mumbai');
INSERT INTO StudentInfo VALUES (4, 'Priya Singh', '22 Civil Lines', 19, 'Lucknow');
INSERT INTO StudentInfo VALUES (5, 'Karan Patel', '10 SG Highway', 23, 'Ahmedabad');
INSERT INTO StudentInfo VALUES (6, 'Anjali Gupta', '90 Model Town', 20, 'Chandigarh');
INSERT INTO StudentInfo VALUES (7, 'Rohit Kumar', '5 Nehru Place', 24, 'Delhi');
INSERT INTO StudentInfo VALUES (8, 'Sneha Iyer', '33 Anna Nagar', 21, 'Chennai');
INSERT INTO StudentInfo VALUES (9, 'Vikram Joshi', '67 FC Road', 22, 'Pune');
INSERT INTO StudentInfo VALUES (10, 'Pooja Nair', '88 Marine Drive', 23, 'Kochi');
