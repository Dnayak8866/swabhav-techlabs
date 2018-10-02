SELECT GETDATE()
CREATE TABLE Student(
	rollNo int,
	fname varchar(10),
	lname varchar(10),
	cgpa float,
	PRIMARY KEY(rollNo)
);
INSERT INTO Student(rollNo,fname,lname,cgpa) VALUES(111,'Dharmesh','Nayak',8.98);
INSERT INTO Student(rollNo,fname,lname,cgpa) VALUES(222,'Abhishek','Singh',8.97);
INSERT INTO Student(rollNo,fname,lname,cgpa) VALUES(333,'Chandan','Nayak',8.99);
INSERT INTO Student(rollNo,fname,lname,cgpa) VALUES(444,'Sunil','Maharana',8.88);

SELECT * FROM Student;
SELECT fname,lname FROM Student;
SELECT fname FROM Student WHERE cgpa>8 AND cgpa<8.99 ;

DELETE FROM Student;


