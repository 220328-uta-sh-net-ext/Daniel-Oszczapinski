DROP TABLE newUser;
CREATE TABLE newUser(
 UserId INT IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Password CHAR(1000),
    CONSTRAINT PK_User PRIMARY KEY  (UserId)
)
SELECT * FROM newUser

INSERT INTO dbo.newUser  VALUES ('Fred Growing', 'Fred@yahoo,com', 'Trend' ) 
INSERT INTO dbo.newUser  VALUES ('Kim Sun', 'Kim@gmail.com', 'notToday123') 
INSERT INTO dbo.newUser  VALUES ('Erick Wool', 'Erick@aol.com', 'MyPass12' ) 
INSERT INTO dbo.newUser  VALUES ('Zac Forest', 'Zac@yahoo.com', 'WeAre9' ) 