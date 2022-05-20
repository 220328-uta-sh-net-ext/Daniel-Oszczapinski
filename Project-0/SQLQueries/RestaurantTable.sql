DROP TABLE Restaurant
CREATE TABLE Restaurant(
 RestId INT IDENTITY,
    Name NVARCHAR(100),
    City NVARCHAR(100),
    Address NVARCHAR(100),
    ZipCode NVARCHAR(100),
    State CHAR(100),
    CONSTRAINT PK_Restaurant PRIMARY KEY (RestId)
)
SELECT * FROM Restaurant

INSERT INTO Restaurant  VALUES ('Rest', 'Chicago', 'Street', '234212', 'Illinois' ) 
INSERT INTO dbo.Restaurant  VALUES ('Jiimy Johns', 'Salt Lake City', '54 Lane', '7645', 'Utah' ) 
INSERT INTO dbo.Restaurant  VALUES ('Panda Expess', 'Olympia', '54 Lane', '123453', 'Washington' ) 
INSERT INTO dbo.Restaurant  VALUES ('Pizza Hut', 'Phoenix', '3425 Lane', '652', 'Arizona' ) 

-- Current table used for project is below:
CREATE TABLE Restaurant(
 RestId INT IDENTITY,
    Name NVARCHAR(100) UNIQUE,
    City NVARCHAR(100),
    Address NVARCHAR(100),
    ZipCode NVARCHAR(100),
    State CHAR(100),
    CONSTRAINT PK_Restaurant PRIMARY KEY (RestId)
)
INSERT INTO Restaurant (Name, City, Address, ZipCode, State) VALUES ('Jim')
DELETE FROM Restaurant WHERE Name = 'Daniel'
SELECT * FROM Restaurant
