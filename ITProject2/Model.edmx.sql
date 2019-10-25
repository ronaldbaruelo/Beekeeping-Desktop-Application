
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/22/2018 17:23:48
-- Generated from EDMX file: C:\Users\snowhite\Desktop\IT Projet 2\ITProject2\ITProject2\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [IT Project Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_HarvestTable_HarvestTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HarvestTable] DROP CONSTRAINT [FK_HarvestTable_HarvestTable];
GO
IF OBJECT_ID(N'[dbo].[FK_HarvestTable_SiteTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HarvestTable] DROP CONSTRAINT [FK_HarvestTable_SiteTable];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ActivityTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActivityTable];
GO
IF OBJECT_ID(N'[dbo].[BeekeeperTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BeekeeperTable];
GO
IF OBJECT_ID(N'[dbo].[HarvestTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HarvestTable];
GO
IF OBJECT_ID(N'[dbo].[OrchardTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrchardTable];
GO
IF OBJECT_ID(N'[dbo].[SiteTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SiteTable];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[ModelStoreContainer].[user]', 'U') IS NOT NULL
    DROP TABLE [ModelStoreContainer].[user];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ActivityTables'
CREATE TABLE [dbo].[ActivityTables] (
    [ActivityID] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Sitename] nvarchar(50)  NOT NULL,
    [Description] nvarchar(50)  NOT NULL,
    [Initial] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'BeekeeperTables'
CREATE TABLE [dbo].[BeekeeperTables] (
    [ID] int  NOT NULL,
    [Firstname] nvarchar(50)  NOT NULL,
    [Lastname] nvarchar(50)  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [ContactEmergency] nvarchar(50)  NOT NULL,
    [Position] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'HarvestTables'
CREATE TABLE [dbo].[HarvestTables] (
    [HarvestID] int IDENTITY(1,1) NOT NULL,
    [SiteID] int  NOT NULL,
    [MafID] int  NOT NULL,
    [Type] nvarchar(50)  NOT NULL,
    [weight] int  NOT NULL,
    [BeekeeperInitial] nvarchar(50)  NOT NULL,
    [Date] datetime  NULL,
    [Area] varchar(50)  NULL
);
GO

-- Creating table 'OrchardTables'
CREATE TABLE [dbo].[OrchardTables] (
    [OrchardID] int IDENTITY(1,1) NOT NULL,
    [Orchardname] nvarchar(50)  NOT NULL,
    [Firstname] nvarchar(50)  NOT NULL,
    [Lastname] nvarchar(50)  NOT NULL,
    [Address] nvarchar(50)  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'SiteTables'
CREATE TABLE [dbo].[SiteTables] (
    [SiteID] int IDENTITY(1,1) NOT NULL,
    [MafID] int  NOT NULL,
    [Sitename] nvarchar(50)  NOT NULL,
    [Firstname] nvarchar(50)  NOT NULL,
    [Lastname] nvarchar(50)  NOT NULL,
    [Address] nvarchar(max)  NULL,
    [Phone] nvarchar(50)  NULL,
    [Latitude] nvarchar(50)  NOT NULL,
    [Longtitude] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'users'
CREATE TABLE [dbo].[users] (
    [username] nvarchar(50)  NOT NULL,
    [password] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ActivityID] in table 'ActivityTables'
ALTER TABLE [dbo].[ActivityTables]
ADD CONSTRAINT [PK_ActivityTables]
    PRIMARY KEY CLUSTERED ([ActivityID] ASC);
GO

-- Creating primary key on [ID] in table 'BeekeeperTables'
ALTER TABLE [dbo].[BeekeeperTables]
ADD CONSTRAINT [PK_BeekeeperTables]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [HarvestID] in table 'HarvestTables'
ALTER TABLE [dbo].[HarvestTables]
ADD CONSTRAINT [PK_HarvestTables]
    PRIMARY KEY CLUSTERED ([HarvestID] ASC);
GO

-- Creating primary key on [OrchardID] in table 'OrchardTables'
ALTER TABLE [dbo].[OrchardTables]
ADD CONSTRAINT [PK_OrchardTables]
    PRIMARY KEY CLUSTERED ([OrchardID] ASC);
GO

-- Creating primary key on [SiteID] in table 'SiteTables'
ALTER TABLE [dbo].[SiteTables]
ADD CONSTRAINT [PK_SiteTables]
    PRIMARY KEY CLUSTERED ([SiteID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [username] in table 'users'
ALTER TABLE [dbo].[users]
ADD CONSTRAINT [PK_users]
    PRIMARY KEY CLUSTERED ([username] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [HarvestID] in table 'HarvestTables'
ALTER TABLE [dbo].[HarvestTables]
ADD CONSTRAINT [FK_HarvestTable_HarvestTable]
    FOREIGN KEY ([HarvestID])
    REFERENCES [dbo].[HarvestTables]
        ([HarvestID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SiteID] in table 'HarvestTables'
ALTER TABLE [dbo].[HarvestTables]
ADD CONSTRAINT [FK_HarvestTable_SiteTable]
    FOREIGN KEY ([SiteID])
    REFERENCES [dbo].[SiteTables]
        ([SiteID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HarvestTable_SiteTable'
CREATE INDEX [IX_FK_HarvestTable_SiteTable]
ON [dbo].[HarvestTables]
    ([SiteID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------