CREATE DATABASE BCStudent

ON
(NAME =StudentDataFile1,
 FILENAME = 'C:\SQLDATA\BCStudent\StudentDataFile1.mdf')

 LOG ON
 (NAME=StudentLogFile1,
 FILENAME = 'C:\SQLDATA\BCStudent\StudentLogFile1.ldf'
 );


 /*Creating Table*/
  USE BCStudent
  CREATE TABLE tblStudent
 (StuNr INT PRIMARY KEY,
 StdImg VARBINARY(max) NOT NULL,
 FirstName VARCHAR(25) NOT NULL,
 LastName VARCHAR(25) NOT NULL,
 DOB Date NOT NULL,
 Gender VARCHAR(25) NOT NULL,
 AdressLine1 VARCHAR(20) NOT NULL,
 AddressLine2 VARCHAR(20) NOT NULL,
 City VARCHAR(20) NOT NULL,
 Province VARCHAR(20) NOT NULL,
 PostalCode VARCHAR(4) NOT NULL
);

USE BCStudent
ALTER TABLE tblStudent
DROP COLUMN ModuleCode





USE BCStudent
CREATE TABLE Student_subject
(
ModuleCode VARCHAR(6) FOREIGN KEY  (ModuleCode) REFERENCES tblModule(ModuleCode) NOT NULL,
StuNr INT FOREIGN KEY (StuNr) REFERENCES tblStudent(StuNr) NOT NULL
PRIMARY KEY(ModuleCode,StuNr)
);



USE BCStudent
CREATE TABLE tblModule
(
ModuleCode VARCHAR(6) PRIMARY KEY NOT NULL,
ModName VARCHAR(50) NOT NULL,
ModDescription VARCHAR(50) NOT NULL,
Link VARCHAR(max) NOT NULL
);

GO
/*Adding  Student*/
CREATE PROCEDURE spAddStudent
(
	@StuNr INT,@StdImg VARBINARY(max),@name VARCHAR(20), @surname VARCHAR(20),@DOB Date,@Gender VARCHAR(20),@Addressline1 VARCHAR(20),@Addressline2 VARCHAR(20),@City VARCHAR(20),@Province VARCHAR(20),@PostalCode VARCHAR(4)
)
AS
BEGIN
	INSERT INTO tblStudent VALUES
	(@StuNr,@StdImg,@name, @surname,@DOB,@Gender,@Addressline1,@Addressline2,@City,@Province,@PostalCode)
 END


/*Update*/
GO
CREATE PROCEDURE spUpdateStudent
(
	@StuNr INT,@StdImg VARBINARY,@name VARCHAR(20), @surname VARCHAR(20),@DOB Date,@Gender VARCHAR(20),@Addressline1 VARCHAR(20),@Addressline2 VARCHAR(20),@City VARCHAR(20),@Province VARCHAR(20),@PostalCode VARCHAR(4)
)
AS
BEGIN
Update tblStudent SET
 StuNr =@StuNr,
 StdImg=@StdImg,
 FirstName=@name,
 LastName=@surname,
 DOB= @DOB,
 Gender= @Gender,
 AdressLine1=@Addressline1,
 AddressLine2=@Addressline2,
 City= @City,
 Province= @Province,
 PostalCode= @PostalCode
 WHERE StuNr =@StuNr
 END

/*Show All Students*/
GO
CREATE PROCEDURE spGETStudents
AS
BEGIN
   SELECT* FROM tblStudent
END

 /*Delete*/
 GO
CREATE PROCEDURE spDeleteStudent
(
	@StuNr INT
)
AS
BEGIN
DELETE FROM tblStudent
	WHERE StuNr = @StuNr
END

/*Search*/
GO
 CREATE PROCEDURE spSearchStudent
 (
 @StuNr INT
 )
 AS
 BEGIN
	SELECT* FROM tblStudent
	WHERE StuNr = @StuNr
END

/* SEARCH Particular student subjects*/
GO
 CREATE PROCEDURE spSearchStudentModules
 (
 @StuNr INT
 )
 AS
 BEGIN
	SELECT tblModule.* FROM tblModule 
	INNER JOIN Student_subject
	ON tblModule.ModuleCode = Student_subject.ModuleCode
	WHERE Student_subject.StuNr = @StuNr
END

GO
CREATE PROCEDURE spStudentModule
(
@StuId INT,@ModuleCode VARCHAR(6)
)
AS
BEGIN
INSERT INTO Student_subject VALUES
(@StuId,@ModuleCode)
END