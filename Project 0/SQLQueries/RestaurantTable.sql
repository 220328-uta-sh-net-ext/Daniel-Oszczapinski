CREATE TABLE Restaurant(
 RestID INT IDENTITY,
    RestName NVARCHAR(100),
    Address NVARCHAR(100),
    Phone INT,
    CONSTRAINT PK_Restaurant PRIMARY KEY CLUSTERED (RestId)

)