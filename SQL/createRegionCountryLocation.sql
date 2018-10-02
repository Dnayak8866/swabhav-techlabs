USE hitech
CREATE TABLE REGIONS
    ( region_id      int 
       CONSTRAINT  region_id_nn NOT NULL 
    , region_name    VARCHAR(25) 
    );


ALTER TABLE REGIONS
ADD CONSTRAINT reg_id_pk
                 PRIMARY KEY (region_id)
     ;
     
     
     CREATE TABLE COUNTRIES 
    ( COUNTRY_ID      CHAR(2) 
       CONSTRAINT  COUNTRY_ID_NN NOT NULL 
    , COUNTRY_NAME    VARCHAR(40) 
    , REGION_ID       int 
    , CONSTRAINT     COUNTRY_C_ID_PK 
                     PRIMARY KEY (COUNTRY_ID) 
    ) 
    
    
    
    ALTER TABLE COUNTRIES
ADD  CONSTRAINT COUNTR_REG_FK
                 FOREIGN KEY (REGION_ID)
                  REFERENCES REGIONS(REGION_ID) 
 
 
 
 
 CREATE TABLE LOCATIONS
    ( LOCATION_ID    int not null
    , STREET_ADDRESS VARCHAR(40)
    , POSTAL_CODE    VARCHAR(12)
    , CITY       VARCHAR(30)
        CONSTRAINT     LOC_CITY_NN  NOT NULL
    , STATE_PROVINCE VARCHAR(25)
    , COUNTRY_ID     CHAR(2)
    ) ;
    
    
    
    
    ALTER TABLE LOCATIONS
ADD  CONSTRAINT LOC_ID_PK
                 PRIMARY KEY (LOCATION_ID)
    , CONSTRAINT LOC_C_ID_FK
                 FOREIGN KEY (COUNTRY_ID)
                  REFERENCES COUNTRIES(COUNTRY_ID) 
                  
                  
                  
                  
                  
                  
INSERT INTO regions VALUES( 1, 'Europe');
INSERT INTO regions VALUES( 2, 'Americas');
INSERT INTO regions VALUES( 3, 'Asia');
INSERT INTO regions VALUES( 4, 'Middle East and Africa');
INSERT INTO regions VALUES( 5, 'Middle WEST and Africa');


===============

INSERT INTO countries VALUES( 'IT', 'Italy', 1);
INSERT INTO countries VALUES( 'JP', 'Japan', 3);
INSERT INTO countries VALUES( 'US', 'United States of America', 2);
INSERT INTO countries VALUES( 'CA', 'Canada', 2);
INSERT INTO countries VALUES( 'CN', 'China', 3);
INSERT INTO countries VALUES( 'IN', 'India', 3);
INSERT INTO countries VALUES( 'AU', 'Australia', 3);
INSERT INTO countries VALUES( 'ZW', 'Zimbabwe',4);


INSERT INTO countries VALUES( 'SG', 'Singapore', 3);
INSERT INTO countries VALUES( 'UK', 'United Kingdom', 1);
INSERT INTO countries VALUES( 'FR', 'France', 1);
INSERT INTO countries VALUES( 'DE', 'Germany', 1);
INSERT INTO countries VALUES( 'ZM', 'Zambia', 4);
INSERT INTO countries VALUES( 'EG', 'Egypt', 4);
INSERT INTO countries VALUES( 'BR', 'Brazil', 2);
INSERT INTO countries VALUES( 'CH', 'Switzerland', 1);


INSERT INTO countries VALUES( 'NL', 'Netherlands', 1);
INSERT INTO countries VALUES( 'MX', 'Mexico', 2);
INSERT INTO countries VALUES( 'KW', 'Kuwait', 4);
INSERT INTO countries VALUES( 'IL', 'Israel', 4);
INSERT INTO countries VALUES( 'DK', 'Denmark', 1);
INSERT INTO countries VALUES( 'HK', 'HongKong', 3);
INSERT INTO countries VALUES( 'NG', 'Nigeria', 4);
INSERT INTO countries VALUES( 'AR', 'Argentina', 2);
INSERT INTO countries VALUES( 'BE', 'Belgium', 1);




INSERT INTO locations VALUES( 1000, '1297 Via Cola di Rie', '00989', 'Roma', NULL, 'IT');
INSERT INTO locations VALUES( 1100, '93091 Calle della Testa', '10934', 'Venice', NULL, 'IT');
INSERT INTO locations VALUES( 1200, '2017 Shinjuku-ku', '1689', 'Tokyo', 'Tokyo Prefecture', 'JP');
INSERT INTO locations VALUES( 1300, '9450 Kamiya-cho', '6823', 'Hiroshima', NULL, 'JP');
INSERT INTO locations VALUES( 1400, '2014 Jabberwocky Rd', '26192', 'Southlake', 'Texas', 'US');
INSERT INTO locations VALUES( 1500, '2011 Interiors Blvd', '99236', 'South San Francisco', 'California', 'US');
INSERT INTO locations VALUES( 1600, '2007 Zagora St', '50090', 'South Brunswick', 'New Jersey', 'US');
INSERT INTO locations VALUES( 1700, '2004 Charade Rd', '98199', 'Seattle', 'Washington', 'US');
INSERT INTO locations VALUES( 1800, '147 Spadina Ave', 'M5V 2L7', 'Toronto', 'Ontario', 'CA');
INSERT INTO locations VALUES( 1900, '6092 Boxwood St', 'YSW 9T2', 'Whitehorse', 'Yukon', 'CA');

SELECT * FROM REGIONS;
SELECT * FROM COUNTRIES;
SELECT * FROM LOCATIONS;

--REGIONS WITH NO COUNTRY
SELECT region_name,COUNTRY_NAME
 FROM REGIONS r 
 LEFT JOIN COUNTRIES c 
 ON r.region_id= c.REGION_ID
 WHERE C.COUNTRY_NAME IS NULL
 
--COUNTRY NOT HAVING LOCATION

SELECT COUNTRY_NAME,CITY
FROM COUNTRIES c 
LEFT JOIN LOCATIONS l
ON c.COUNTRY_ID=l.COUNTRY_ID
WHERE l.CITY IS NULL
 
--REGION_NAMEWISE NO OF COUNTRIES

SELECT region_name,COUNT(C.COUNTRY_ID) AS [NO OF COUNTRY]
FROM REGIONS  R 
LEFT JOIN COUNTRIES C
ON R.region_id=C.REGION_ID
GROUP BY region_name


--COIUNTRYWISE NO OF LOCATION
SELECT COUNTRY_NAME,COUNT(L.LOCATION_ID) AS [NO OF LOCATION]
FROM COUNTRIES C
LEFT JOIN LOCATIONS L
ON C.COUNTRY_ID=L.COUNTRY_ID
GROUP BY COUNTRY_NAME

--REGIONWISE COUNTRYWISE NO OF LOCATION
SELECT region_name,COUNTRY_NAME,COUNT(L.LOCATION_ID)
FROM REGIONS R

LEFT JOIN (COUNTRIES C
LEFT JOIN LOCATIONS L
ON C.COUNTRY_ID=L.COUNTRY_ID)

ON R.region_id=C.REGION_ID
GROUP BY COUNTRY_NAME,region_name

--DISPLAY REGIONNAME COUNTRY LOCATION
SELECT R.region_name,C.COUNTRY_NAME,L.CITY
FROM REGIONS R 
JOIN( COUNTRIES C JOIN LOCATIONS L
ON C.COUNTRY_ID=L.COUNTRY_ID)
ON R.region_id=C.REGION_ID





