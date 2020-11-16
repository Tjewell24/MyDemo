CREATE TABLE [dbo].[Ticket] (
    [Id]                INT           NOT NULL,
    [TicketId]          NCHAR (10)    NOT NULL,
    [TicketDescription] NVARCHAR (50) NOT NULL,
    [TicketSubmitter]   NVARCHAR (50) NOT NULL,
    [TicketPriority]    INT           NOT NULL,
    [TicketStatus]      NVARCHAR (50) NOT NULL,
    [TicketCreatedOn]   DATETIME2 (7) NOT NULL,
    [TicketUpdatedOn]   DATETIME2 (7) NOT NULL,
    [TicketComment]     NVARCHAR (50) NOT NULL,
    [TicketTitle]       NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

