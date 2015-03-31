CREATE TABLE [dbo].[Member] (
    [MemberID]        INT           IDENTITY (100, 1) NOT NULL,
    [OrgID]           INT           NOT NULL,
    [PersonID]        INT           NOT NULL,
    [CreatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [CreatedUser]     NVARCHAR (50) NULL,
    [UpdatedDate]     DATETIME2 (7) DEFAULT (sysdatetime()) NOT NULL,
    [UpdatedUser]     NVARCHAR (50) NULL,
    CONSTRAINT [pk_Group_Person__Group_Person_ID] PRIMARY KEY CLUSTERED ([MemberID] ASC),
    CONSTRAINT [FK_OrganizationMember] FOREIGN KEY ([OrgID]) REFERENCES [dbo].[Organization] ([OrgID]),
    CONSTRAINT [FK_PersonMember] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID])
);




GO
CREATE UNIQUE NONCLUSTERED INDEX [ak_Group_Person__Group_ID_Person_ID]
    ON [dbo].[Member]([OrgID] ASC, [PersonID] ASC);

