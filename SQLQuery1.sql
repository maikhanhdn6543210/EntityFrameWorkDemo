
CREATE TABLE Course (
	CourseId INT NOT NULL PRIMARY KEY ,
	Title VARCHAR(255),
	Credits DECIMAL
);


CREATE TABLE Student (
	Id INT NOT NULL PRIMARY KEY,
	Lastname VARCHAR(255),
	FirstMidName VARCHAR(255),
	EnrollmentDate DATE,
	
);

CREATE TABLE Enrollment (
	EnrollmentId INT NOT NULL PRIMARY KEY,
	CourseId INT,
	StudentId INT,
	Grande INT,	
	CONSTRAINT FK_Course FOREIGN KEY (StudentId)
    REFERENCES Student(Id),
	CONSTRAINT FK_Student FOREIGN KEY (EnrollmentId)
    REFERENCES Course(CourseId)

);


