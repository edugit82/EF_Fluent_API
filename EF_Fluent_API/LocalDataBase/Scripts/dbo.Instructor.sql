CREATE TABLE [dbo].[Instructor]
(
	[InstructorID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LastName] VARCHAR(MAX) NOT NULL, 
    [FirstName] VARCHAR(MAX) NOT NULL, 
    [HireDate] DATETIME NOT NULL
)
