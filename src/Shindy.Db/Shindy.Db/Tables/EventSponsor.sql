CREATE TABLE [dbo].[EventSponsor] (
    [EventSponsorID]  INT           IDENTITY (100, 1) NOT NULL,
    [EventID]         INT           NOT NULL,
    [SponsorID]       INT           NOT NULL,
    [CreatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50) NULL,
    [UpdatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50) NULL,
    CONSTRAINT [pk_Event_Sponsor__Event_Sponsor_ID] PRIMARY KEY CLUSTERED ([EventSponsorID] ASC),
    CONSTRAINT [FK_EventEventSponsor] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([EventID]),
    CONSTRAINT [FK_SponsorEventSponsor] FOREIGN KEY ([SponsorID]) REFERENCES [dbo].[Sponsor] ([SponsorID])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Event_Sponsor__Event_ID_Sponsor_ID]
    ON [dbo].[EventSponsor]([EventID] ASC, [SponsorID] ASC);

