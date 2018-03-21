CREATE PROC uspCreateStudent
AS
CREATE TABLE Student(
StudentFirstName VARCHAR(10), 
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

INSERT INTO Student VALUES('John','Smith','John@DBS.com','4159879','45 Merrion Square','Dublin 2','Dublin','Dublin','UnderGraduate','Psychology',45645688)
INSERT INTO Student Values('Mary','Smith','Mary@DBS.com','0872146455','20 the Green','Rathmines', 'Dublin 10','Dublin','PostGraduate', 'Marketing', 45678912)
INSERT INTO Student Values('Max','Power','Max@DBS.com', '0894561245','54 Briarwood', 'StoneyBatter','Dublin 7','Dublin','UnderGraduate','Business', 78451254)

CREATE PROC uspCreateStaff
AS 
CREATE TABLE Staff(
UserName VARCHAR(20) NOT NULL PRIMARY KEY,
Password VARCHAR(100),
)
GO

EXEC uspCreateStaff


INSERT INTO Staff VALUES ('Seamas','Password')
INSERT INTO Staff VALUES ('Dhoot','Trumpet')


DELETE FROM Student WHERE StudentID=78451254