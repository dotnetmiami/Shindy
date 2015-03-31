CREATE TABLE [dbo].[Attendee] (
    [Attendee_ID]     INT           IDENTITY (100, 1) NOT NULL,
    [EventID]         INT           NOT NULL,
    [PersonID]        INT           NOT NULL,
    [CreatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50) NULL,
    [UpdatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50) NULL,
    CONSTRAINT [pk_Event_Person__Event_Persion_ID] PRIMARY KEY CLUSTERED ([Attendee_ID] ASC),
    CONSTRAINT [FK_EventAttendee] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([EventID]),
    CONSTRAINT [FK_PersonAttendee] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Event_Person__Event_ID_Person_ID]
    ON [dbo].[Attendee]([EventID] ASC, [PersonID] ASC);

