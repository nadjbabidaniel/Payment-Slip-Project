
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/16/2016 22:08:53
-- Generated from EDMX file: C:\Users\DanielN\Desktop\OTPREMNICA_SECOND_TIME\OTPREMNICA\ModelFirstUplatnica\UplatnicaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OtpremnicaDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SifarnikPartnerOtpremnica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Otpremnicas] DROP CONSTRAINT [FK_SifarnikPartnerOtpremnica];
GO
IF OBJECT_ID(N'[dbo].[FK_ListaRobeSifarnikRobe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ListaRobes] DROP CONSTRAINT [FK_ListaRobeSifarnikRobe];
GO
IF OBJECT_ID(N'[dbo].[FK_ListaRobeOtpremnica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ListaRobes] DROP CONSTRAINT [FK_ListaRobeOtpremnica];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SifarnikPartners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SifarnikPartners];
GO
IF OBJECT_ID(N'[dbo].[Otpremnicas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Otpremnicas];
GO
IF OBJECT_ID(N'[dbo].[SifarnikRobes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SifarnikRobes];
GO
IF OBJECT_ID(N'[dbo].[ListaRobes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ListaRobes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SifarnikPartners'
CREATE TABLE [dbo].[SifarnikPartners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SifraPartnera] int  NOT NULL,
    [NazivPartnera] nvarchar(max)  NOT NULL,
    [Mesto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Otpremnicas'
CREATE TABLE [dbo].[Otpremnicas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [BrojOtpremnice] nvarchar(max)  NOT NULL,
    [SifarnikPartnerId] int  NOT NULL
);
GO

-- Creating table 'SifarnikRobes'
CREATE TABLE [dbo].[SifarnikRobes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SifraRobe] int  NOT NULL,
    [NazivRobe] nvarchar(max)  NOT NULL,
    [JedinicaMere] nvarchar(max)  NOT NULL,
    [JedinicnaCena] float  NOT NULL
);
GO

-- Creating table 'ListaRobes'
CREATE TABLE [dbo].[ListaRobes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KolicinaRobe] float  NOT NULL,
    [NovaCenaRobe] float  NOT NULL,
    [UkupnaCenaRobe] float  NOT NULL,
    [SifarnikRobeId] int  NOT NULL,
    [OtpremnicaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SifarnikPartners'
ALTER TABLE [dbo].[SifarnikPartners]
ADD CONSTRAINT [PK_SifarnikPartners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Otpremnicas'
ALTER TABLE [dbo].[Otpremnicas]
ADD CONSTRAINT [PK_Otpremnicas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SifarnikRobes'
ALTER TABLE [dbo].[SifarnikRobes]
ADD CONSTRAINT [PK_SifarnikRobes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ListaRobes'
ALTER TABLE [dbo].[ListaRobes]
ADD CONSTRAINT [PK_ListaRobes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SifarnikPartnerId] in table 'Otpremnicas'
ALTER TABLE [dbo].[Otpremnicas]
ADD CONSTRAINT [FK_SifarnikPartnerOtpremnica]
    FOREIGN KEY ([SifarnikPartnerId])
    REFERENCES [dbo].[SifarnikPartners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SifarnikPartnerOtpremnica'
CREATE INDEX [IX_FK_SifarnikPartnerOtpremnica]
ON [dbo].[Otpremnicas]
    ([SifarnikPartnerId]);
GO

-- Creating foreign key on [SifarnikRobeId] in table 'ListaRobes'
ALTER TABLE [dbo].[ListaRobes]
ADD CONSTRAINT [FK_ListaRobeSifarnikRobe]
    FOREIGN KEY ([SifarnikRobeId])
    REFERENCES [dbo].[SifarnikRobes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ListaRobeSifarnikRobe'
CREATE INDEX [IX_FK_ListaRobeSifarnikRobe]
ON [dbo].[ListaRobes]
    ([SifarnikRobeId]);
GO

-- Creating foreign key on [OtpremnicaId] in table 'ListaRobes'
ALTER TABLE [dbo].[ListaRobes]
ADD CONSTRAINT [FK_ListaRobeOtpremnica]
    FOREIGN KEY ([OtpremnicaId])
    REFERENCES [dbo].[Otpremnicas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ListaRobeOtpremnica'
CREATE INDEX [IX_FK_ListaRobeOtpremnica]
ON [dbo].[ListaRobes]
    ([OtpremnicaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------