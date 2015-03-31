CREATE TABLE [dbo].[EventSession] (
    [EventSessionID]  INT           IDENTITY (100, 1) NOT NULL,
    [EventID]         INT           NOT NULL,
    [SessionID]       INT           NOT NULL,
    [CreatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50) NULL,
    [UpdatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50) NULL,
    CONSTRAINT [pk_Event_Session__Event_Session_ID] PRIMARY KEY CLUSTERED ([EventSessionID] ASC),
    CONSTRAINT [FK_EventEventSession] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([EventID]),
    CONSTRAINT [FK_SessionEventSession] FOREIGN KEY ([SessionID]) REFERENCES [dbo].[Session] ([SessionID])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Event_Session__Event_ID_Session_ID]
    ON [dbo].[EventSession]([EventID] ASC, [SessionID] ASC);

