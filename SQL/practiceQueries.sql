USE hitech;
go
SELECT * FROM EMP;
SELECT * FROM DEPT;
SELECT * FROM EMP WHERE DEPTNO=10;
SELECT * FROM EMP ORDER BY SAL DESC;
SELECT * FROM EMP WHERE ENAME LIKE 'A%';
SELECT * FROM EMP WHERE COMM IS NULL;
SELECT * FROM EMP WHERE NOT DEPTNO=10;
SELECT ENAME, ((SAL+ISNULL(COMM,0) )*12) AS ['CTC'] FROM EMP; 
SELECT ENAME,DEPTNO FROM EMP;
SELECT DISTINCT  DEPTNO FROM EMP;
SELECT HIREDATE, DATEDIFF(YEAR,HIREDATE,GETDATE()) AS ['TENURE'] FROM EMP;
SELECT GETDATE();
SELECT * FROM EMP WHERE JOB='MANAGER';
SELECT TOP 3 ENAME,SAL FROM EMP ORDER BY SAL DESC;
SELECT * FROM EMP WHERE ENAME='SCOTT';
SELECT * FROM EMP WHERE DEPTNO IN (SELECT DEPTNO FROM EMP WHERE ENAME='SCOTT');
SELECT * FROM EMP WHERE JOB IN (SELECT JOB FROM EMP WHERE ENAME= 'SMITH');

SELECT MAX(SAL) FROM EMP;
SELECT MAX(SAL) FROM EMP WHERE SAL < (SELECT MAX(SAL) FROM EMP);

SELECT * FROM EMP WHERE SAL IN 
(SELECT MAX(SAL)FROM EMP WHERE SAL NOT IN
 (SELECT MAX(SAL)  FROM EMP));

SELECT SUM(SAL) AS ["TOTAL SALARY AMOUNT"] FROM EMP;
SELECT COUNT(*) AS [''] FROM EMP;

SELECT DEPTNO,COUNT(*)AS [HEADCOUNT]
 FROM EMP
 GROUP BY DEPTNO; 

SELECT JOB,COUNT(*) AS [HEADCOUNT]
FROM EMP
 GROUP BY JOB 
 HAVING COUNT(*)>2  
 ORDER BY HEADCOUNT;
 
 SELECT JOB,DEPTNO,COUNT(*) AS [HEADCOUNT] 
 FROM EMP 
 GROUP BY JOB,DEPTNO
 ORDER BY DEPTNO
 
 /*3NF MORMALIZATION */
CREATE TABLE COLLEGE(
id INT,
name VARCHAR(30),
location VARCHAR(20),
PRIMARY KEY(id)
);
INSERT INTO COLLEGE(id,name,location)
VALUES(1,'Mgiter','navsari');
INSERT INTO COLLEGE(id,name,location)
VALUES(2,'Gecdahod','dahod');

CREATE TABLE STUDENTS(
id INT,
firstname VARCHAR(20),
lastname VARCHAR(20),
cgpa  FLOAT,
collegeid INT,
contactno INT,
PRIMARY KEY(ID),

FOREIGN KEY(Collegeid)REFERENCES COLLEGE(ID)
);

INSERT INTO STUDENTS(id,firstname,lastname,cgpa,collegeid,contactno)
VALUES(101,'dharmesh','nayak',8.98,1,8866);
INSERT INTO STUDENTS(id,firstname,lastname,cgpa,collegeid,contactno)
VALUES(102,'chandan','maharana',8.98,2,8460);

SELECT * FROM STUDENTS
SELECT * FROM COLLEGE;


SELECT firstname,lastname,cgpa,name FROM STUDENTS s JOIN COLLEGE c ON s.collegeid=c.id;

/*Joins*/
SELECT ENAME,DNAME
 FROM DEPT 
 INNER JOIN EMP 
 ON DEPT.DEPTNO=EMP.DEPTNO;

SELECT DNAME,ENAME
 FROM DEPT
 LEFT JOIN EMP
 ON DEPT.DEPTNO=EMP.DEPTNO;

SELECT DNAME ,ENAME
 FROM DEPT
 LEFT JOIN EMP
ON DEPT.DEPTNO=EMP.DEPTNO
WHERE EMP.ENAME IS NULL

SELECT DNAME,COUNT(*) AS [HEADCOUNT]
FROM DEPT JOIN EMP 
ON DEPT.DEPTNO=EMP.DEPTNO
GROUP BY DNAME

SELECT x.ENAME  AS [ENAME],Y.ENAME AS [BOSS]
FROM EMP x
LEFT JOIN EMP y
ON x.MGR = y.EMPNO

--EMPLOYEE BOSS DEPARTMENTNAME
SELECT X.ENAME AS [EMPLOYEE], Y.ENAME AS [BOSS],D.DNAME
FROM EMP X
LEFT JOIN (EMP Y LEFT JOIN DEPT D ON Y.DEPTNO=D.DEPTNO)
ON X.MGR=Y.EMPNO

--FUNCTION
CREATE FUNCTION getCustomDate()
RETURNS VARCHAR(20)
AS
BEGIN
	
	DECLARE @mydate DATETIME
	
	 
	RETURN (SELECT REPLACE(CONVERT(VARCHAR,GETDATE(),105),'-',''))
END
DROP FUNCTION getCustomDate
SELECT dbo.getCustomdate()

--STOREPROCEDURE
CREATE TABLE EMPTEMP(
EMPID INT,
ENAME VARCHAR(20),
SAL MONEY
);
INSERT INTO EMPTEMP(EMPID,ENAME,SAL) VALUES(111,'DHARMESH',20000)
INSERT INTO EMPTEMP(EMPID,ENAME,SAL) VALUES(111,'CHANDAN',20000)
SELECT * FROM EMPTEMP
DROP TABLE EMPTEMP

CREATE PROCEDURE usp_giveHikeToEmployee
@empid INT,@hikepercent INT
AS
BEGIN
	
	SET NOCOUNT ON;
	UPDATE EMPTEMP SET SAL=SAL+(SAL*@hikepercent/100) WHERE EMPID=@empId;
END

EXEC usp_giveHikeToEmployee 111,20
DROP PROCEDURE usp_giveHikeToEmployee

SELECT * INTO EMPCOPY FROM EMP
SELECT * FROM EMPCOPY
SELECT* FROM EMP

CREATE PROCEDURE usp_giveDeptwiseHike
@deptno INT,@hikepercent INT
AS
BEGIN
	SET NOCOUNT OFF;
	UPDATE EMP SET SAL=SAL+(SAL*@hikepercent/100) WHERE DEPTNO=@deptno;
END
EXEC usp_giveDeptwiseHike 10,10

--CHECKING ACTUAL EXECUTION PLAN
SELECT* FROM EMP
SELECT * FROM EMPCOPY

SELECT * FROM EMP WHERE DEPTNO=20
SELECT * FROM EMPCOPY WHERE DEPTNO=20

SELECT * FROM EMP WHERE ENAME LIKE '%SC%'
SELECT * FROM EMPCOPY WHERE ENAME LIKE '%SC%'

--TRIGGERS
SELECT * FROM STUDENTS

CREATE TRIGGER trgInsteadOfInsert ON STUDENTS
INSTEAD OF INSERT
AS
DECLARE 
		@id INT,
		@firstname VARCHAR(20),
		@lastname VARCHAR(20),
		@cgpa FLOAT,
		@collegeid INT,
		@contactno INT;
SELECT @id=i.id
FROM INSERTED i;
SELECT @firstname=UPPER(i.firstname) 
FROM INSERTED i;
SELECT @lastname=UPPER(i.lastname) 
FROM INSERTED i;
SELECT @cgpa=i.cgpa 
FROM INSERTED i;
SELECT @collegeid=i.collegeid 
FROM INSERTED i;
SELECT @contactno=i.contactno 
FROM INSERTED i;

BEGIN 
	
	INSERT INTO STUDENTS(id,firstname,lastname,cgpa,collegeid,contactno)
	VALUES(@id,@firstname,@lastname,@cgpa,@collegEid,@contactno) ;
END

INSERT INTO STUDENTS(id,firstname,lastname,cgpa,collegeid,contactno)
	VALUES(103,'abhi','sing',9.2,2,9033)
	
	----------------
	
CREATE TABLE CUSTOMERS(
id INT,
name VARCHAR(20),
balance MONEY,
PRIMARY KEY(id)
);
DROP TABLE CUSTOMERS
SELECT * FROM CUSTOMERS
INSERT INTO CUSTOMERS VALUES(111,'customer1',20000)
INSERT INTO CUSTOMERS VALUES(222,'customer2',20000)
INSERT INTO CUSTOMERS VALUES(333,'customer3',20000)
INSERT INTO CUSTOMERS VALUES(444,'customer4',20000)
		
		
CREATE TABLE MERCHANTS(
id INT,
name VARCHAR(20),
balance MONEY,
PRIMARY KEY(id)
);
SELECT * FROM MERCHANTS
INSERT INTO MERCHANTS VALUES(1,'merchant1',30000);
INSERT INTO MERCHANTS VALUES(2,'merchant2',30000);
INSERT INTO MERCHANTS VALUES(3,'merchant3',30000);
INSERT INTO MERCHANTS VALUES(4,'merchant4',30000);



USE Swabhav
go
SELECT * FROM dbo.__MigrationHistory

USE Contact
go

SELECT * FROM dbo.contacts
SELECT * FROM dbo.Users
INSERT INTO dbo.Users(Id,Name,Password) VALUES(1,'dharmesh','pass');
INSERT INTO dbo.Users(Id,Name,Password) VALUES(2,'chandan','pass');


Use Swabhav
go

SELECT * FROM dbo.Departments
SELECT * FROM dbo.Employees

SELECT * FROM dbo.MovieActors
SELECT * FROM dbo.Actors
SELECT * FROM dbo.Movies


