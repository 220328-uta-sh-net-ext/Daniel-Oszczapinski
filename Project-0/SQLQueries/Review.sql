DROP TABLE Review;
CREATE TABLE Review(
 ReviewId INT IDENTITY,
    Name NVARCHAR(100),
    UserName NVARCHAR(100),
    Note NVARCHAR(100),
    Rating FLOAT,
    CONSTRAINT PK_ReviewId PRIMARY KEY  (ReviewId)
)
SELECT * FROM Review

SELECT Rating FROM Review Where Rating IN (SELECT AVG(Rating) FROM Review GROUP BY Name) 
SELECT *
FROM Review
GROUP BY Name 
--HAVING AVG(Rating) AS Average (Select * FROM Review)

SELECT Name, Rating FROM Review UNION SELECT Name,  AVG(RATING) FROM Review GROUP BY Name
SELECT * FROM Review
UNION ALL
SELECT Name,Username,  AVG(Rating) as Average From Review GROUP BY Name, UserName

SELECT * FROM (SELECT * FROM Review) AS t1 
INNER JOIN (SELECT Name, AVG(Rating) as Average From Review GROUP BY Name) AS t2 ON t1.Name = t2.Name ORDER BY ReviewId ASC

--SELECT  DISTINCT on (Name) * FROM Review ORDER BY Name

SELECT MAX(ReviewId) AS id,
    Name,
    MAX(intrare) AS intrare,
    MAX(iesire) AS iesire,
    MAX(intrare-iesire) AS stoc,
    MAX(data) AS data
FROM Review
GROUP BY Name
ORDER BY Nume

SELECT  Note, Rating, AVG(Rating) AS Average FROM Review GROUP BY Note, Rating

-- This is the query that Groups all rows and returns Average
SELECT * FROM (SELECT * FROM Review) AS t1 
INNER JOIN (SELECT Name, AVG(Rating) as Average From Review GROUP BY Name) AS t2 
ON t1.Name = t2.Name ORDER BY ReviewId ASC

INSERT INTO dbo.Review  VALUES ('Ok', '3', '1' ) 
INSERT INTO dbo.Review  VALUES ('Nice place','4','2') 
INSERT INTO dbo.Review  VALUES ('Panda Expess', 'Red', 'I enjoyed the location but got the wrong item', '4' ) 
INSERT INTO dbo.Review  VALUES ('It was an alright experience', '3', '2' ) 

-- The script below is the current used table:
SELECT * FROM Review

CREATE TABLE Review(
 ReviewId INT IDENTITY,
    Note NVARCHAR(100),
    Rating FLOAT,
    RestId INT,
    CONSTRAINT PK_ReviewId PRIMARY KEY  (ReviewId),
    CONSTRAINT FK_RestaurantId FOREIGN KEY (RestId) REFERENCES Restaurant(RestId)
);

Select AVG(r.Rating) as Average ,rt.RestId from Review as r Right JOIN Restaurant as rt on r.RestId = rt.RestId GROUP BY rt.RestId Order by average desc
SELECT r.* , rt.Name from Review as r JOIN Restaurant as rt on r.RestId = rt.RestId Order by r.ReviewId desc

SELECT  Name,State,City, Address, ZipCode, AVG(Rating) AS Average FROM Review LEFT JOIN Restaurant ON Review.RestId = Restaurant.RestId GROUP BY Name,State, City,Address,ZipCode
