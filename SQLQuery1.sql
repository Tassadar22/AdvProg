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

CREATE TABLE AdminStaff(
UserName VARCHAR(20) NOT NULL PRIMARY KEY,
Password VARCHAR(100),
IsAdmin BIT
)
GO

INSERT INTO AdminStaff VALUES ('Admin','Password',0)