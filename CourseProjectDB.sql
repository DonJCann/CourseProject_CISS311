USE master;

CREATE DATABASE CourseProjectDB;
GO

USE COurseProjectDB;
GO

CREATE TABLE student
(
	studentId	INT NOT NULL,
	studentName NVARCHAR(100) NOT NULL,
	coursesEnrolled NVARCHAR(100),
	CONSTRAINT pk_student PRIMARY KEY (studentId)
);

CREATE TABLE courses
(
	courseId INT NOT NULL, 
	courseName NVARCHAR(100) NOT NULL,
	courseSemester NVARCHAR(100),
	constraint pk_course PRIMARY KEY (courseId)
);

INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('101', 'Don Cann', 'Math1');
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('102', 'Dan King', 'English1');

INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1001', 'History1', 'Fall');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1002', 'Math1', 'Spring');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1003', 'English1', 'Winter');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1004', 'History3', 'Summer');