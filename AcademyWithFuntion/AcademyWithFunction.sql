CREATE TABLE Groups (
  GroupID INT PRIMARY KEY IDENTITY(1,1),
  GroupName VARCHAR(10) NOT NULL UNIQUE,
  GroupRating INT NOT NULL,
  CourseYear INT NOT NULL
);

 

CREATE TABLE Departments(
    DepartmentsID INT PRIMARY KEY IDENTITY(1,1),
    Financing money NOT NULL CHECK(Financing > 0) DEFAULT 0,
    DepartmentsName NVARCHAR(100) NOT NULL UNIQUE
);

 

CREATE TABLE Faculties(
    FacultiesID INT PRIMARY KEY IDENTITY(1,1),
    Dean NVARCHAR(MAX) NOT NULL,
    FacultiesName NVARCHAR(100) NOT NULL UNIQUE
);

 

CREATE TABLE Teachers (
  TeacherID INT PRIMARY KEY IDENTITY(1,1),
  EmploymentDate DATE NOT NULL CHECK(EmploymentDate > '1990-01-01'),
  IsAssistant bit NOT NULL DEFAULT 0,
  IsProfessor bit NOT NULL DEFAULT 0,
  Position NVARCHAR(max) NOT NULL,
  FirstName VARCHAR(max) NOT NULL,
  LastName VARCHAR(max) NOT NULL,
  Premium money NOT NULL CHECK(Premium > 0) DEFAULT 0,
  Salary money CHECK(Salary >= 0)
);




--#1
--SELECT DepartmentsName, Financing , DepartmentsID FROM Departments;

 


--#2
--SELECT GroupName AS "Group Name", GroupRating AS "Group Rating"
--FROM Groups;

 


--#3
-- ñêàçàëè çàáèòü )))

 


--#4
--SELECT CONCAT('The dean of faculty ', FacultiesName, ' is ', Dean, '.') AS "Faculty Details"
--FROM Faculties;

 


--#5
--SELECT LastName
--FROM Teachers
--WHERE IsProfessor = 1 AND Salary > 1050;

 

--#6
--SELECT DepartmentsName
--FROM Departments
--WHERE Financing < 11000 OR Financing > 25000;

 

--#7
--SELECT FacultiesName
--FROM Faculties
--WHERE FacultiesName != 'Computer Science';

 

--#8
--SELECT FirstName , Position
--FROM Teachers
--WHERE IsProfessor = 0;

 

--#9
--SELECT LastName , Position , Salary , Premium
--FROM Teachers
--WHERE IsAssistant = 1 AND Premium BETWEEN 160 AND 550;

 

--#10
--SELECT LastName, Salary
--FROM Teachers
--WHERE IsAssistant = 1;

 

--#11
--SELECT LastName, Position
--FROM Teachers
--WHERE EmploymentDate < '2000-01-01';

 

--#12
--SELECT DepartmentsName AS "Name of Department"
--FROM Departments
--WHERE DepartmentsName < 'Software Development'
--ORDER BY DepartmentsName;

 

--#13
--SELECT LastName
--FROM Teachers
--WHERE IsAssistant = 1 AND Salary + Premium <= 1200;

 

--#14
--SELECT GroupName
--FROM Groups
--WHERE CourseYear = 5 AND GroupRating BETWEEN 2 AND 4;

 

--#15
--SELECT LastName
--FROM Teachers
--WHERE Salary < 550 OR Premium < 200;