CREATE TABLE [dbo].[Project] (
    [Id]               INT      IDENTITY (1, 1)     NOT NULL,
    [ProjectId]        NVARCHAR (50) NOT NULL,
    [ProjectTitle]     NVARCHAR (50) NOT NULL,
    [ProjectStartDate] DATETIME2 (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

