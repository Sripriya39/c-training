create database Assignment

use Assignment

CREATE TABLE clients2(
 client_id INT PRIMARY KEY,
 cname VARCHAR(40) NOT NULL,
 address VARCHAR(30),
 email VARCHAR(30) UNIQUE,
 phone VARCHAR(10),
 business VARCHAR(20) NOT NULL
);

INSERT INTO clients2 (client_id, cname, address, email, phone, business) VALUES
(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturing'),
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),
(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),
(1004, 'Lawful Corp','Chennai','justice@lawful.com',9210342219,'professional')

select * from clients2


create table Departments(
Deptno int primary key,
Dname Varchar(15) Not Null,
Loc Varchar(20))


INSERT INTO Departments(Deptno, Dname, Loc) Values
(10,'Design','pune'),
(20,'Development','pune'),
(30,'testing','mumbai'),
(40,'Document','mumbai');


select* from Departments

CREATE TABLE employees (
    empno INT PRIMARY KEY,
    ename VARCHAR(20) NOT NULL,
    job VARCHAR(15),
    salary DECIMAL(7, 2) CHECK (salary > 0), 
    deptno INT FOREIGN KEY (deptno) REFERENCES Departments(deptno))

insert into employees(empno, ename, job, salary, deptno) VALUES
(7001,'sandeep','analyst',25000,10),
(7002,'rajesh','designer',30000,10),
(7003,'Madhav','developer',40000,20),
(7004,'manoj','developer',40000,20),
(7005,'abhey','designer',35000,10),
(7006,'uma','tester',30000,30),
(7007,'gita','tech.writer',30000,40),
(7008,'priya','tester',35000,30),
(7009,'nutan','developer',45000,20),
(7010,'smita','analyst',20000,10),
(7011,'anand','project mgr',65000,10)

select * from employees

CREATE TABLE Projects(
    Project_ID Int PRIMARY KEY,
    Descr VARCHAR(30) NOT NULL,
    Start_Date DATE,
    Planned_End_Date DATE,
    Actual_End_Date DATE,
    Budget int CHECK (Budget > 0),
    Client_ID int CONSTRAINT FK_ClientID1 FOREIGN KEY (Client_ID) REFERENCES Clients(Client_ID),
    CONSTRAINT CHK_ActualEndDate1 CHECK (Actual_End_Date IS NULL OR Actual_End_Date > Planned_End_Date)
);

INSERT INTO Projects (Project_ID, Descr, Start_Date, Planned_End_Date, Actual_End_date, Budget, Client_ID)
VALUES
(401, 'Inventory', 01-04-2011, 01-10-2011, 31-10-2011, 150000, 1001)
(402, 'Accounting', '01-08-2011', '01-01-2012', NULL, 500000, 1002),
(403, 'Payroll', '01-10-2011', '31-12-2011', NULL, 75000, 1003),
(404, 'Contact Mgmt', '01-11-2011', '31-12-2012', NULL, 50000, 1004);

CREATE TABLE EmpProjectTasks (
  Project_ID int,
  Empno VARCHAR(4),
  Start_Date DATE,
  End_Date DATE,
  Task VARCHAR(25) NOT NULL,
  Status VARCHAR(15) NOT NULL,
  CONSTRAINT PK_EmpProjectTasks PRIMARY KEY (Project_ID, Empno),
  CONSTRAINT FK_Project_ID FOREIGN KEY (Project_ID) REFERENCES Projects(Project_ID),
  CONSTRAINT FK_Empno FOREIGN KEY (Empno) REFERENCES Employees(empno)
);





