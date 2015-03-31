CREATE TABLE [dbo].[Organization] (
    [OrgID]           INT            IDENTITY (100, 1) NOT NULL,
    [OrgName]         NVARCHAR (100) NOT NULL,
    [OrgDescription]  VARCHAR (4000)  NULL,
    [OrgURI]          VARCHAR (2000)  NULL,
    [CreatedDate]     DATETIME2 (7)  DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50)  NULL,
    [UpdatedDate]     DATETIME2 (7)  DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50)  NULL,
    CONSTRAINT [pk_Group__Group_ID] PRIMARY KEY CLUSTERED ([OrgID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Group__Group_Name]
    ON [dbo].[Organization]([OrgName] ASC);

