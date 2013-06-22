USE [Shindy]
GO

ALTER TABLE [dbo].[Session_Person] DROP CONSTRAINT [fk_Session_Person_Person_ID__Person_Person_ID]
GO

ALTER TABLE [dbo].[Session_Person] DROP CONSTRAINT [fk_Session_Person_Session_ID__Session_Session_ID]
GO

ALTER TABLE [dbo].[Session] DROP CONSTRAINT [fk_SessionSession_Type_ID__Session_Type_Session_Type_ID]
GO

ALTER TABLE [dbo].[Group_Person] DROP CONSTRAINT [fk_Group_Person_Person_ID__Person_Person_ID]
GO

ALTER TABLE [dbo].[Group_Person] DROP CONSTRAINT [fk_Group_Person_Group_ID__User_Group_Group_ID]
GO

ALTER TABLE [dbo].[Giveaway] DROP CONSTRAINT [fk_Giveaway_Event_ID__Event_Event_ID]
GO

ALTER TABLE [dbo].[Giveaway] DROP CONSTRAINT [fk_Giveaway_Person_ID__Person_ID]
GO

ALTER TABLE [dbo].[Giveaway] DROP CONSTRAINT [fk_Giveaway_Sponsor_ID__Sponsor_Sponsor_ID]
GO

ALTER TABLE [dbo].[Event_Sponsor] DROP CONSTRAINT [fk_Event_Sponsor_Event_ID__Event_Event_ID]
GO

ALTER TABLE [dbo].[Event_Sponsor] DROP CONSTRAINT [fk_Event_Sponsor_Sponsor_ID__Sponsor_Sponsor_ID]
GO

ALTER TABLE [dbo].[Event_Session] DROP CONSTRAINT [fk_Event_Session_Event_ID__Event_Event_ID]
GO

ALTER TABLE [dbo].[Event_Session] DROP CONSTRAINT [fk_Event_Session_Session_ID__Session_Session_ID]
GO

ALTER TABLE [dbo].[Event_Person] DROP CONSTRAINT [fk_Event_Person_Person_ID__Person_Person_ID]
GO

ALTER TABLE [dbo].[Event_Person] DROP CONSTRAINT [fk_Event_Person_Event_ID_Person_Person_ID]
GO

ALTER TABLE [dbo].[Event_Group] DROP CONSTRAINT [fk_Event_Group_Group_ID__User_Group_Group_ID]
GO

ALTER TABLE [dbo].[Event] DROP CONSTRAINT [fk_Event_Location_ID__Location_Location_ID]
GO

ALTER TABLE [dbo].[Event_Group] DROP CONSTRAINT [fk_Event_Group_Group_ID__Event_Event_ID]
GO

DROP TABLE [dbo].[Sponsor]
GO

DROP TABLE [dbo].[Session_Type]
GO

DROP TABLE [dbo].[Session_Person]
GO

DROP TABLE [dbo].[Session]
GO

DROP TABLE [dbo].[Person]
GO

DROP TABLE [dbo].[Location]
GO

DROP TABLE [dbo].[Group_Person]
GO

DROP TABLE [dbo].[Giveaway]
GO

DROP TABLE [dbo].[Event_Sponsor]
GO

DROP TABLE [dbo].[Event_Session]
GO

DROP TABLE [dbo].[Event_Person]
GO

DROP TABLE [dbo].[Event_Group]
GO

DROP TABLE [dbo].[Event]
GO

DROP TABLE [dbo].[User_Group]
GO

