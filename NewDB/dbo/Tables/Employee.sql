CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [Role] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL 
)
