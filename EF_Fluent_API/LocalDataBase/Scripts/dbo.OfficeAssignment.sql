CREATE TABLE [dbo].[OfficeAssignment] (
    [InstructorID] INT NOT NULL,
    [Location]     VARCHAR (MAX) NOT NULL,
    [Timestamp]    ROWVERSION    NOT NULL,
    PRIMARY KEY CLUSTERED ([InstructorID] ASC)
);

