CREATE TABLE [dbo].[Event] (
    [EventID]         INT             IDENTITY (100, 1) NOT NULL,
    [Title]           NVARCHAR (250)  NULL,
    [Description]     NVARCHAR (4000) NULL,
    [StartDate]       DATETIME2 (0)   NOT NULL,
    [EndDate]         DATETIME2 (0)   NULL,
    [LocationID]      INT             NULL,
    [RegistrationURI] VARCHAR (2000)  NULL,
    [CreatedDate]     DATETIME2 (7)   DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50)   NULL,
    [LastUpdatedDate] DATETIME2 (7)   DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50)   NULL,
    CONSTRAINT [pk_Event__Event_ID] PRIMARY KEY CLUSTERED ([EventID] ASC),
    CONSTRAINT [FK_LocationEvent] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([LocationID])
);



