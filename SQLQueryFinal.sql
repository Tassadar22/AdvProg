CREATE PROC uspCreateStudent
AS
CREATE TABLE Student(
StudentFirstName VARCHAR(20), 
StudentSurName VARCHAR(20),
StudentEmail VARCHAR(50),
StudentPhone VARCHAR(20),
StudentAddLin1 VARCHAR(20),
StudentAddLin2 VARCHAR(20),
StudentCity VARCHAR(20),
StudentCounty VARCHAR (20),
StudentLevel VARCHAR(25),
StudentCourse VARCHAR(20),
StudentID INT NOT NULL PRIMARY KEY) 

EXEC uspCreateStudent

CREATE PROC uspCreateDummyStudentData
as
INSERT INTO Student VALUES('John','Smith','John@DBS.com','4159879','45 Merrion Square','Dublin 2','Dublin 2','Dublin','UnderGraduate','Psychology',45645688)
INSERT INTO Student Values('Mary','Smith','Mary@DBS.com','0872146455','20 the Green','Rathmines', 'Dublin 10','Dublin','PostGraduate', 'Marketing', 45678912)
INSERT INTO Student Values('Max','Power','Max@DBS.com', '0894561245','54 Briarwood', 'StoneyBatter','Dublin 7','Dublin','UnderGraduate','Business', 78451254)
GO

EXEC uspCreateDummyStudentData

CREATE PROC uspGetStudentList
AS
SELECT * FROM Student

EXEC uspGetStudentList
EXEC uspCreateStudent
EXEC uspCreateDummyStudentData

CREATE PROC uspCreateStaff
AS 
CREATE TABLE Staff(
UserName VARCHAR(20) NOT NULL PRIMARY KEY,
Password VARCHAR(100),

)
GO

CREATE PROC uspGetStaffList
AS
SELECT * From Staff
GO

EXEC uspGetStaffList

EXEC uspCreateStaff
CREATE PROC uspMakeDummyStaffData
AS
INSERT INTO Staff VALUES ('Seamas','Password')
INSERT INTO Staff VALUES ('Dhoot','Trumpet')
INSERT INTO Staff VALUES ('secure','swordfish')
INSERT INTO Staff VALUES ('Paul Laird','$ecure12£4')
GO



EXEC uspMakeDummyStaffData

DELETE FROM Student WHERE StudentID=12345678
