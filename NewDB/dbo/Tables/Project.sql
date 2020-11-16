CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProjectId] NVARCHAR(50) NOT NULL, 
    [ProjectTitle] NVARCHAR(50) NOT NULL, 
    [ProjectStartDate] DATETIME2 NOT NULL
)
