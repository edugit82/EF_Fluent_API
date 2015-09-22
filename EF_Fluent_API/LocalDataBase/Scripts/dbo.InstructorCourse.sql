CREATE TABLE [dbo].[InstructorCourse] (
    [InstructorID]      INT NOT NULL,
    [CourseID]          INT NOT NULL,
    CONSTRAINT [FK_InstructorCourse_Instructor] FOREIGN KEY ([InstructorID]) REFERENCES [dbo].[Instructor] ([InstructorID]),
    CONSTRAINT [FK_InstructorCourse_Course] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Course] ([CourseID]), 
    CONSTRAINT [PK_InstructorCourse] PRIMARY KEY ([InstructorID],[CourseID])
);

