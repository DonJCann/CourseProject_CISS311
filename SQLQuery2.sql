USE master;

 

IF DB_ID(N'CourseProject_CISS_311') IS NOT NULL DROP DATABASE CourseProject_CISS_311;

CREATE DATABASE CourseProject_CISS_311;

GO

 

USE CourseProject_CISS_311;

GO

CREATE TABLE student

(

           studentId         INT NOT NULL IDENTITY,

           studentName NVARCHAR(100) NOT NULL,

           courseId NCHAR(5),

           CONSTRAINT pk_student PRIMARY KEY (studentId)

);

CREATE TABLE course

(

           courseId INT NOT NULL IDENTITY,

           courseName NVARCHAR(100) NOT NULL,

           studentId INT NOT NULL,

           CONSTRAINT pk_course PRIMARY KEY (courseId),

           CONSTRAINT fk_course_student FOREIGN KEY (studentId)

                  REFERENCES student(studentId)

);

// add student and course info