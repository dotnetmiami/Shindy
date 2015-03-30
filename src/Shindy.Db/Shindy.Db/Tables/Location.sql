CREATE TABLE [dbo].[Location] (
    [LocationID]      INT            IDENTITY (100, 1) NOT NULL,
    [LocationName]    NVARCHAR (100) NOT NULL,
    [LocationURI]     VARCHAR (2000) NULL,
    [Street1]         VARCHAR (75)   NULL,
    [Street2]         VARCHAR (75)   NULL,
    [City]            VARCHAR (50)   NULL,
    [State]           VARCHAR (50)   NULL,
    [ZipCode]         VARCHAR (10)   NULL,
    [MapURI]          VARCHAR (2000) NULL,
    [Latitude]        NUMERIC (9, 6) NULL,
    [Longitude]       NUMERIC (9, 6) NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (sysdatetime()) NULL,
    [CreatedUser]     NVARCHAR (50)  NULL,
    [LastUpdatedDate] DATETIME2 (7)  DEFAULT (sysdatetime()) NOT NULL,
    [LastUpdatedUser] NVARCHAR (50)  NULL,
    CONSTRAINT [pk_Location__Location_ID] PRIMARY KEY CLUSTERED ([LocationID] ASC)
);

