CREATE PROC uspCreateStudent1
AS
CREATE TABLE Student
(
StudentFirstName VARCHAR(10),
StudentSurName VARCHAR (20),
StudentEmail VARCHAR (50),
StudentPhone VARCHAR (15),
StudentAddLin1 VARCHAR (20),
StudentAddLin2 VARCHAR (20),
StudentCity VARCHAR (15),
StudentLevel VARCHAR (12),
StudentCourse VARCHAR (15),
StudentID INT,
)

EXEC uspCreateStudent1

