CREATE TABLE [dbo].[Bug]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BugId] INT NOT NULL, 
    [BugDescription] NCHAR(10) NULL, 
    [TeamMember] NVARCHAR(50) NULL, 
    [BugPriority] NVARCHAR(50) NULL 
)
