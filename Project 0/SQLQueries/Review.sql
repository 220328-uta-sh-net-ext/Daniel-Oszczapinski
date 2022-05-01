DROP TABLE Review;
CREATE TABLE Review(
 ReviewId INT IDENTITY,
    Name NVARCHAR(100),
    Note NVARCHAR(100),
    Rating int,
    CONSTRAINT PK_ReviewId PRIMARY KEY  (ReviewId)
)
SELECT * FROM Review