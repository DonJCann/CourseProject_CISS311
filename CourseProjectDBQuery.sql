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
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('103', 'Jorge Trejo', 'Math1');
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('104', 'Afaf Mahmood', 'English1');
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('105', 'Dylan Taylor', 'History1');
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('106', 'John Smith', 'History1');
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('107', 'Taylor Brown', 'Math1');
INSERT INTO student(studentId, studentName, coursesEnrolled) VALUES ('108', 'Larry Bash', 'English1');

INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1001', 'History1', 'Fall');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1002', 'Math1', 'Spring');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1003', 'English1', 'Winter');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1004', 'History2', 'Summer');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1005', 'History3', 'Fall');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1006', 'Math2', 'Spring');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1007', 'English2', 'Winter');
INSERT INTO courses(courseId, courseName, courseSemester) VALUES ('1008', 'Writting1', 'Summer');