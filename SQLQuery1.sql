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

INSERT INTO Student VALUES
(
'John',
'Smith',
'John@DBS.com',
'4159879',
'45 Merrion Square',
'Dublin 2',
'Dublin',
'UnderGraduate',
'Psychology',
45645688
)
INSERT INTO Student Values
(
'Mary','Smith','Mary@DBS.com','0872146455',
'20 the Green','Rathmines','Dublin 6','PostGraduate','Marketing',45678912)
INSERT INTO Student Values
(
'Max','Power','Max@DBS.com','0894561245',
'54 Briarwood','StoneyBatter','Dublin 7','UnderGraduate','Business',78451254)

SELECT * FROM Student