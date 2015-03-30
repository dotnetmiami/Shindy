CREATE TABLE [dbo].[Giveaway] (
    [GiveawayID]      INT             IDENTITY (100, 1) NOT NULL,
    [GiveawayName]    NVARCHAR (100)  NOT NULL,
    [Description]     NVARCHAR (4000) NULL,
    [EventID]         INT             NULL,
    [SponsorID]       INT             NULL,
    [PersonID]        INT             NULL,
    [CreatedDate]     DATETIME2 (7)   DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50)   NULL,
    [LastUpdatedDate] DATETIME2 (7)   DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50)   NULL,
    CONSTRAINT [pk_Giveaway__Giveaway_ID] PRIMARY KEY CLUSTERED ([GiveawayID] ASC),
    CONSTRAINT [FK_EventGiveaway] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([EventID]),
    CONSTRAINT [FK_PersonGiveaway] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID]),
    CONSTRAINT [FK_SponsorGiveaway] FOREIGN KEY ([SponsorID]) REFERENCES [dbo].[Sponsor] ([SponsorID])
);



