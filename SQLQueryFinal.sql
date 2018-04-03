/*First CREATE Database called StudentDataBase 

then run these commands as separate command blocks*/

/* Command Block 1 */
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

/* Command Block 2 */
CREATE PROC uspGetStudentList
AS
SELECT * FROM Student

/* Command Block 3 */
CREATE TABLE Staff(
UserName VARCHAR(20) NOT NULL PRIMARY KEY,
Password VARCHAR(100),
)

/* Command Block 4 */
CREATE PROC uspGetStaffList
AS
SELECT * From Staff
GO
/* Command Block 5 */
INSERT INTO Staff VALUES ('Seamas','Password')
INSERT INTO Staff VALUES('Administrator','RSAencryptedgoodness')
INSERT INTO Staff VALUES('Arnie','John Kruger')
INSERT INTO Staff VALUES ('secure','swordfish')
INSERT INTO Staff VALUES ('Paul Laird','$ecure12£4')