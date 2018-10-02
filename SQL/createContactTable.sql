USE hitech
CREATE TABLE Contacts(
id int IDENTITY,
name varchar(15),
number bigint,
PRIMARY KEY(id)
);

INSERT INTO Contacts(name,number) VALUES('dharmesh',88666);
INSERT INTO Contacts(name,number) VALUES('chandan',846000);
SELECT * FROM Contacts;

CREATE TABLE UserLogin(
id int IDENTITY PRIMARY KEY,
userid varchar(20),
password varchar(10)
);

INSERT INTO UserLogin(userid,password)VALUES('dharmesh',111);
select * from UserLogin;