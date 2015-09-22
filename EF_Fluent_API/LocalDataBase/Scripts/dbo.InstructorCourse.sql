CREATE TABLE [dbo].[InstructorCourse]
(
	[InstructorID] INT NOT NULL, 
    [CourseID] INT NOT NULL, 
    CONSTRAINT [PK_instructorCourse] PRIMARY KEY ([InstructorID], [CourseID]), 
    CONSTRAINT [FK_instructorCourse_Instructor] FOREIGN KEY ([InstructorID]) REFERENCES [Instructor]([InstructorID]),
	CONSTRAINT [FK_instructorCourse_Course] FOREIGN KEY ([CourseID]) REFERENCES [Course]([CourseID])
)
