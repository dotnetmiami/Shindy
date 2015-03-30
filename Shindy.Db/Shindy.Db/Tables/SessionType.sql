CREATE TABLE [dbo].[SessionType] (
    [SessionTypeID]   INT            IDENTITY (100, 1) NOT NULL,
    [SessionTypeName] NVARCHAR (100) NOT NULL,
    [Description]     VARCHAR (250)  NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50)  NULL,
    [LastUpdatedDate] DATETIME2 (7)  DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50)  NULL,
    CONSTRAINT [pk_Session_Type__Session_Type_ID] PRIMARY KEY CLUSTERED ([SessionTypeID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Session_Type__Session_Type_Name]
    ON [dbo].[SessionType]([SessionTypeName] ASC);

