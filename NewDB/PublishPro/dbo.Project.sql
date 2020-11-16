CREATE TABLE [dbo].[Project] (
    [ProjectId]        NCHAR (10)    NOT NULL,
    [ProjectTitle]     NVARCHAR (50) NOT NULL,
    [ProjectStartDate] DATETIME2 (7) NOT NULL,
    [Id] NCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

