CREATE TABLE [dbo].[Speaker] (
    [SessionPersonID] INT           IDENTITY (100, 1) NOT NULL,
    [SessionID]       INT           NOT NULL,
    [PersonID]        INT           NOT NULL,
    [CreatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50) NULL,
    [UpdatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50) NULL,
    CONSTRAINT [pk_Session_Person__Session_Person_ID] PRIMARY KEY CLUSTERED ([SessionPersonID] ASC),
    CONSTRAINT [FK_PersonSpeaker] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID]),
    CONSTRAINT [FK_SessionSpeaker] FOREIGN KEY ([SessionID]) REFERENCES [dbo].[Session] ([SessionID])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Session_Person__Session_ID_Person_ID]
    ON [dbo].[Speaker]([SessionID] ASC, [PersonID] ASC);

