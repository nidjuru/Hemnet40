--CREATE TABLE Coordinates (
--    CoordinateId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
--    longitude decimal(9,7) NOT NULL,
--    latitude decimal(9,7) NOT NULL,
--);
--insert into Coordinates(longitude, latitude)
--values (59.2189152,18.5057035)
--SELECT * FROM Coordinates
ALTER TABLE Objekt ADD 
CoordinatesID int FOREIGN KEY REFERENCES Persons(PersonID)
