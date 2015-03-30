CREATE TABLE [dbo].[Session] (
    [SessionID]       INT             IDENTITY (100, 1) NOT NULL,
    [Title]           NVARCHAR (100)  NOT NULL,
    [Abstract]        NVARCHAR (4000) NULL,
    [SessionTypeID]   INT             NOT NULL,
    [CreatedDate]     DATETIME2 (7)   DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50)   NULL,
    [LastUpdatedDate] DATETIME2 (7)   DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50)   NULL,
    CONSTRAINT [pk_Session__Session_ID] PRIMARY KEY CLUSTERED ([SessionID] ASC),
    CONSTRAINT [FK_SessionTypeSession] FOREIGN KEY ([SessionTypeID]) REFERENCES [dbo].[SessionType] ([SessionTypeID])
);



