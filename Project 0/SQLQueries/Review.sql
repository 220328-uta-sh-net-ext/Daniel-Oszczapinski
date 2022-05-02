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
INNER JOIN (SELECT Name, AVG(Rating) as Average From Review GROUP BY Name) AS t2 ON t1.Name = t2.Name ORDER BY ReviewId DESC

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

SELECT Name, UserName, Note, Rating, AVG(Rating) AS Average FROM Review GROUP BY Name, UserName, Note, Rating

INSERT INTO 