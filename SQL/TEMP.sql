create table A(
ID int Identity(1,1),
entrydate datetime,
CONSTRAINT A_PK PRIMARY KEY (ID)

)

INSERT INTO A(entrydate) VALUES(DATE('17/12/2015', 'YYYY-MM-DD'))
select * from A