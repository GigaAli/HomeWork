CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    GPA FLOAT,
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50),
    Difficulty INT,
    Credits INT
);

CREATE TABLE Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    CourseID INT,
    Grade FLOAT
);

INSERT INTO Students (StudentID, FirstName, LastName, Age, GPA)
VALUES
    (1, '����', '������', 20, 3.5),
    (2, '�����', '�������', 22, 3.8),
    (3, '���������', '�������', 21, 3.2),
    (4, '���������', '�������', 23, 3.9),
    (5, '�������', '�������', 20, 3.0);

INSERT INTO Courses (CourseID, CourseName, Difficulty, Credits)
VALUES
    (101, '����������', 4, 3),
    (102, '������', 3, 4),
    (103, '����������', 2, 3),
    (104, '�������', 2, 3),
    (105, '��������', 3, 4);

INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, Grade)
VALUES
    (1, 1, 101, 3.7),
    (2, 1, 102, 4.0),
    (3, 2, 101, 3.9),
    (4, 3, 103, 3.5),
    (5, 3, 105, 3.2),
    (6, 4, 102, 3.8),
    (7, 4, 104, 4.0),
    (8, 5, 105, 3.1),
    (9, 5, 101, 3.0);


--#1
--select AVG(Grade) from Enrollments where CourseID = 101;

--#2
--select MAX(Age) from Students where GPA > 3.5;

--#3
--select COUNT(CourseName) from Courses where difficulty > 3;

--#4
--select AVG(Credits) from Courses;

--#5
--select MAX(difficulty) from Courses;



