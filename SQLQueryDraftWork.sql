USE [StudentDataBase]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[uspCreateDummyStudentData]

SELECT	@return_value as 'Return Value'

GO

UPDATE Student
SET StudentCity ='BRITAIN', StudentID=45671254
WHERE StudentID=45671254

EXEC uspCreateDummyStudentData
UPDATE Student
SET StudentFirstName ='t', 
StudentSurName ='t', 
StudentEmail ='t', 
StudentPhone ='t', 
StudentAddLin1 ='t', 
StudentAddLin2 ='t', 
StudentCity ='t', 
StudentCounty ='t', 
StudentLevel ='t', 
StudentCourse ='t', 
StudentID = 1234587
WHERE StudentID = 78451254

UPDATE Student
SET StudentEmail ='', 
StudentPhone ='', 
StudentAddLin1 ='', 
StudentAddLin2 ='', 
StudentCity ='', 
StudentCounty ='', 
StudentLevel ='', 
StudentID =45678333
WHERE StudentID =45678912

CREATE TRIGGER tr_DatabaseChanges
ON ALL SERVER
FOR SELECT * FROM Student,
AS 
BEGIN 
	Select EVENTDATA()
END

CREATE TRIGGER tr_StudentChanges
ON Student
FOR INSERT, UPDATE, DELETE
AS
BEGIN 
	Select EVENTDATA()
END

CREATE TABLE AdminStaff(
UserName VARCHAR(20) NOT NULL PRIMARY KEY,
Password VARCHAR(100),
IsAdmin BIT
)
GO

DELETE FROM Staff WHERE UserName=''
DELETE FROM Staff WHERE UserName='Test'

INSERT INTO Student Values('Max','Power','Max@DBS.com', '0894561245','54 Briarwood', 'StoneyBatter','Dublin 7','Dublin','UnderGraduate','Business', 78451254)

INSERT INTO AdminStaff VALUES ('Admin','Password',0)

INSERT INTO Student VALUES('John','Smith','John@DBS.com','4159879','45 Merrion Square','Dublin 2','Dublin 2','Dublin','UnderGraduate','Psychology',64888)

INSERT 

CREATE TABLE TableChanges(
EventType nvarchar(100),
SQLCommand nvarchar(200),
AuditDateTime datetime
)

CREATE TRigger 

 CREATE TRIGGER tr_StudentTableChanges
ON Student 
FOR INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @EventData XML 
	 SELECT @EventData = EVENTDATA()
    INSERT INTO TableChanges2
    (DatabaseName, TableName, EventType, LoginName,
     SQLCommand, AuditDateTime)
    VALUES
    (
	
         @EventData.value('(/EVENT_INSTANCE/DatabaseName)[1]', 'varchar(250)'),
         @EventData.value('(/EVENT_INSTANCE/ObjectName)[1]', 'varchar(250)'),
         @EventData.value('(/EVENT_INSTANCE/EventType)[1]', 'nvarchar(250)'),
         @EventData.value('(/EVENT_INSTANCE/LoginName)[1]', 'varchar(250)'),
         @EventData.value('(/EVENT_INSTANCE/TSQLCommand)[1]', 'nvarchar(2500)'),
         GetDate()
    )
END

Create TABLE TableChanges2 
( DatabaseName nvarchar(250),
TableName nvarchar(250), 
EventType nvarchar(250), 
LoginName nvarchar(250),
SQLCommand nvarchar(2500),
AuditDateTime datetime ) 

CREATE TABLE StudentLog
(


ModificationTimestamp datetime
)


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

INSERT INTO Student VALUES('John','Smith','John@DBS.com','4159879','45 Merrion Square','Dublin 2','Dublin 2','Dublin','UnderGraduate','Psychology',45645688)
INSERT INTO Student Values('Mary','Smith','Mary@DBS.com','0872146455','20 the Green','Rathmines', 'Dublin 10','Dublin','PostGraduate', 'Marketing', 45678912)
INSERT INTO Student Values('Max','Power','Max@DBS.com', '0894561245','54 Briarwood', 'StoneyBatter','Dublin 7','Dublin','UnderGraduate','Business', 78451254)

CREATE TABLE Staff(
UserName VARCHAR(20) NOT NULL PRIMARY KEY,
Password VARCHAR(100),
)

CREATE PROC uspGetStaffList
AS
SELECT * From Staff
GO

INSERT INTO Staff VALUES ('Seamas','Password')
INSERT INTO Staff VALUES('Administrator','RSAencryptedgoodness')
INSERT INTO Staff VALUES ('secure','swordfish')
INSERT INTO Staff VALUES ('Paul Laird','$ecure12£4')

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

/CREATE PROC uspCreateDummyStudentData
as
INSERT INTO Student VALUES('John','Smith','John@DBS.com','4159879','45 Merrion Square','Dublin 2','Dublin 2','Dublin','UnderGraduate','Psychology',45645688)
INSERT INTO Student Values('Mary','Smith','Mary@DBS.com','0872146455','20 the Green','Rathmines', 'Dublin 10','Dublin','PostGraduate', 'Marketing', 45678912)
INSERT INTO Student Values('Max','Power','Max@DBS.com', '0894561245','54 Briarwood', 'StoneyBatter','Dublin 7','Dublin','UnderGraduate','Business', 78451254)
INSERT INTO stude
GO*/



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
EXEC uspCreateStaff

CREATE PROC uspGetStaffList
AS
SELECT * From Staff
GO

EXEC uspGetStaffList

EXEC uspCreateStaff
CREATE PROC uspMakeDummyStaffData
AS
INSERT INTO Staff VALUES ('Seamas','Password')
INSERT INTO Staff VALUES('Administrator','RSAencryptedgoodness')
INSERT INTO Staff VALUES ('secure','swordfish')
INSERT INTO Staff VALUES ('Paul Laird','$ecure12£4')
GO


EXEC uspMakeDummyStaffData

DELETE FROM Student WHERE StudentID=12345678
