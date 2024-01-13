CREATE TABLE Faculties (
	id int primary key IDENTITY(1,1),
	[Name] nvarchar(max) NOT NULL
);
 
CREATE TABLE [Subject] (
	id int primary key IDENTITY(1,1),
	[Name] nvarchar(max) NOT NULL
 
);
 
CREATE TABLE Department(
	id int primary key IDENTITY(1,1),
	[Name] nvarchar(max) NOT NULL,
	Financing money NOT NULL DEFAULT 0 CHECK(Financing > 0),
	FacultiesId int NOT NULL foreign key references Faculties(id)
);
CREATE TABLE Teachers(
	id int primary key IDENTITY(1,1),
	[Name] nvarchar(max) NOT NULL,
	Surname nvarchar(max) NOT NULL,
	Salary money NOT NULL CHECK(Salary > 0),
	DepartmentId int NOT NULL foreign key references Department(id)

);
 
 
CREATE TABLE Groups(
	id int primary key IDENTITY(1,1),
	[Name] nvarchar(max) NOT NULL,
	CourseYear int NOT NULL CHECK(CourseYear > 1 AND CourseYear < 5),
	DepartmentId int foreign key references Department(id),
);
 
CREATE TABLE Lectures(
	id int primary key IDENTITY(1,1),
	DayOfWeak int  NOT NULL CHECK(DayOfWeak >= 1 AND DayOfWeak <= 7),
	LectureRoom nvarchar(max) NOT NULL,
	SubjectId int foreign key references [Subject](id),
	TeacherId int foreign key references Teachers(id)
);
 
CREATE TABLE GroupLectures(
	id int primary key IDENTITY(1,1),
	GroupId int foreign key references Groups(id),
	LecturesId int foreign key references Lectures(id)
);
 
 
 
INSERT INTO Faculties ([Name]) VALUES ('Engineering');
INSERT INTO Faculties ([Name]) VALUES ('Science');
 
INSERT INTO [Subject] ([Name]) VALUES ('Mathematics');
INSERT INTO [Subject] ([Name]) VALUES ('Physics');
 
INSERT INTO Teachers ([Name], Surname, Salary, DepartmentId) VALUES ('Dave', 'McQueen', 50000, 1);
INSERT INTO Teachers ([Name], Surname, Salary, DepartmentId) VALUES ('Jane', 'Smith', 60000, 1);
INSERT INTO Teachers ([Name], Surname, Salary, DepartmentId) VALUES ('Jake', 'Underhill', 60000, 1);

 
INSERT INTO Department ([Name], Financing, FacultiesId) VALUES ('Computer Science', 100000, 1);
INSERT INTO Department ([Name], Financing, FacultiesId) VALUES ('Mechanical Engineering', 80000, 1);
 
 
INSERT INTO Groups ([Name], CourseYear, DepartmentId) VALUES ('CS101', 2, 1);
INSERT INTO Groups ([Name], CourseYear, DepartmentId) VALUES ('ME201', 2, 1);
INSERT INTO Groups ([Name], CourseYear, DepartmentId) VALUES ('ME2011', 3, 2);

 
INSERT INTO Lectures (DayOfWeak, LectureRoom, SubjectId, TeacherId) VALUES (1, 'Room 101', 1, 3);
INSERT INTO Lectures (DayOfWeak, LectureRoom, SubjectId, TeacherId) VALUES (2, 'Room 201', 2, 3);
INSERT INTO Lectures (DayOfWeak, LectureRoom, SubjectId, TeacherId) VALUES (2, 'D201', 2 , 4);


 
select * from Lectures;
 
INSERT INTO GroupLectures (GroupId, LecturesId) VALUES (1, 9);
INSERT INTO GroupLectures (GroupId, LecturesId) VALUES (2, 10);
 
 
 --1#
--SELECT COUNT(Teachers.id) AS TeacherCount
--FROM Teachers
--inner join Department ON Teachers.DepartmentId = Department.id
--inner join Faculties ON Department.FacultiesId = Faculties.id
--WHERE Department.[Name] = 'Computer Science';

--2#
--SELECT COUNT(*) AS LectureCount
--FROM Lectures
--WHERE TeacherId = 7;


--3#
--SELECT COUNT(SubjectId) AS LectureCount
--FROM Lectures
--WHERE LectureRoom = 'D201';


--4#
--SELECT LectureRoom,
--COUNT(id) AS LectureCount
--FROM Lectures
--GROUP BY LectureRoom;

--5#

--6#
--SELECT AVG(Salary) AS AverageSalary
--FROM Teachers
--WHERE DepartmentId = 1;

--7#

--8#
--SELECT AVG(Financing) AS AverageFunding
--FROM Department;


--9#
--SELECT id AS TeacherId,
--    [Name] + ' ' + Surname AS FullName,
--    (
--        SELECT COUNT(SubjectId)
--        FROM Lectures 
--        WHERE TeacherId = id
--    ) as [Count]
--FROM Teachers;


--10#
--SELECT id,
--    (
--        SELECT COUNT(id)
--        FROM Lectures 
--        WHERE DayOfWeak = id
--    ) as [Count]
--FROM Lectures;

