CREATE TABLE [dbo].[Course]
(
	[CourseID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(MAX) NOT NULL, 
    [Credits] INT NOT NULL, 
    [DepartmentID] INT NOT NULL, 
    CONSTRAINT [FK_Course_DepartmentID] FOREIGN KEY ([DepartmentID]) REFERENCES [Department]([DepartmentID])
)
