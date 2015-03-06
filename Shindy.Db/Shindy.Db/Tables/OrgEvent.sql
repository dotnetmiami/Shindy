CREATE TABLE [dbo].[OrgEvent] (
    [OrgEventID]      INT           IDENTITY (100, 1) NOT NULL,
    [OrgID]           INT           NOT NULL,
    [EventID]         INT           NOT NULL,
    [CreatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50) NULL,
    [LastUpdatedDate] DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50) NULL,
    CONSTRAINT [pk_Event_Group__Event_Group_ID] PRIMARY KEY CLUSTERED ([OrgEventID] ASC),
    CONSTRAINT [FK_EventOrgEvent] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([EventID]),
    CONSTRAINT [FK_OrganizationOrgEvent] FOREIGN KEY ([OrgID]) REFERENCES [dbo].[Organization] ([OrgID])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Event_Group__Event_ID_Group_ID]
    ON [dbo].[OrgEvent]([EventID] ASC, [OrgID] ASC);

