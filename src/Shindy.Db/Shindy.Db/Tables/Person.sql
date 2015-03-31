CREATE TABLE [dbo].[Person] (
    [PersonID]        INT             IDENTITY (100, 1) NOT NULL,
    [FirstName]       NVARCHAR (50)   NOT NULL,
    [LastName]        NVARCHAR (50)   NOT NULL,
    [EMail]           VARCHAR (320)   NULL,
    [MemberURI]       VARCHAR (2000)  NULL,
    [TwitterName]     VARCHAR (50)    NULL,
    [LinkedinURI]     VARCHAR (2000)  NULL,
    [Bio]             NVARCHAR (4000) NULL,
    [PhotoURI]        VARCHAR (2000)  NULL,
    [Zip]             VARCHAR (10)    NULL,
    [CreatedDate]     DATETIME2 (7)   DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50)   NULL,
    [UpdatedDate]     DATETIME2 (7)   DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50)   NULL,
    CONSTRAINT [pk_Person__Person_ID] PRIMARY KEY CLUSTERED ([PersonID] ASC)
);

