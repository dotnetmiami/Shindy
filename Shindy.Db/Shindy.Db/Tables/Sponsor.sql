CREATE TABLE [dbo].[Sponsor] (
    [SponsorID]       INT            IDENTITY (100, 1) NOT NULL,
    [SponsorName]     NVARCHAR (100) NOT NULL,
    [SponsorURI]      VARCHAR (2000) NULL,
    [ImageURI]        VARCHAR (2000) NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50)  NULL,
    [LastUpdatedDate] DATETIME2 (7)  DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50)  NULL,
    CONSTRAINT [pk_Sponsor__Sponsor_ID] PRIMARY KEY CLUSTERED ([SponsorID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Sponsor__Sponsor_Name]
    ON [dbo].[Sponsor]([SponsorName] ASC);

