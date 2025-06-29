
CREATE DATABASE student;
go
use student;
go 
CREATE TABLE mstudent(
id INT NOT NULL PRIMARY KEY,
name VARCHAR(100) NOT NULL,
gender VARCHAR(100) NOT NULL,
age INT NOT NULL
)
go 
CREATE TABLE course_student(
id_course INT PRIMARY KEY,
name_course VARCHAR(100),
date DATETIME ,
id INT,
CONSTRANINT  FK_course_student FORIENG KEY (id) REFERNTCES mstudent(id);

)
