CREATE TABLE [dbo].[Department]
(
	[DepartmentID] INT NOT NULL IDENTITY , 
    [Name] VARCHAR(MAX) NOT NULL, 
    [Budget] DECIMAL NOT NULL, 
    [StartDate] DATETIME NOT NULL, 
    [Administrator] INT NULL, 
    CONSTRAINT [PK_Department] PRIMARY KEY ([DepartmentID]) 
)
