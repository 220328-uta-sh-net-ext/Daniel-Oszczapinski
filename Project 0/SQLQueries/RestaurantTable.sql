DROP TABLE Restaurant
CREATE TABLE Restaurant(
 RestId INT IDENTITY,
    Name NVARCHAR(100),
    City NVARCHAR(100),
    State CHAR(10),
    CONSTRAINT PK_Restaurant PRIMARY KEY (RestId)
)
SELECT * FROM Restaurant