DROP DATABASE CursusAdmin
GO

CREATE DATABASE CursusAdmin
GO

USE [CursusAdmin]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[Cursus] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Titel] NVARCHAR (300) NULL,
    [Code]  NVARCHAR (10)  NULL,
    [Duur]  INT            NOT NULL
);
GO


CREATE TABLE [dbo].[CursusInstanties] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [StartDatum] DATETIME NOT NULL,
    [Cursus_Id]  INT      NULL
);
GO

SET IDENTITY_INSERT [dbo].[Cursus] ON
INSERT INTO [dbo].[Cursus] ([Id], [Titel], [Code], [Duur]) VALUES (1, N'C# Programming', N'CNETIN', 5)
INSERT INTO [dbo].[Cursus] ([Id], [Titel], [Code], [Duur]) VALUES (2, N'Azure  Developers', N'AZ204', 5)
INSERT INTO [dbo].[Cursus] ([Id], [Titel], [Code], [Duur]) VALUES (3, N'Azure Devops', N'AZ900', 4)
SET IDENTITY_INSERT [dbo].[Cursus] OFF

SET IDENTITY_INSERT [dbo].[CursusInstanties] ON
INSERT INTO [dbo].[CursusInstanties] ([Id], [StartDatum], [Cursus_Id]) VALUES (1, N'2020-06-29 00:00:00', 1)
INSERT INTO [dbo].[CursusInstanties] ([Id], [StartDatum], [Cursus_Id]) VALUES (2, N'2020-06-29 00:00:00', 2)
INSERT INTO [dbo].[CursusInstanties] ([Id], [StartDatum], [Cursus_Id]) VALUES (3, N'2020-07-29 00:00:00', 3)
INSERT INTO [dbo].[CursusInstanties] ([Id], [StartDatum], [Cursus_Id]) VALUES (4, N'2020-06-22 00:00:00', 1)
SET IDENTITY_INSERT [dbo].[CursusInstanties] OFF
