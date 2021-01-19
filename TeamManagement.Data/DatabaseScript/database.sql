IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [BusinessUnit] (
    [Id] int NOT NULL IDENTITY,
    [ParentBusinessUnitId] int NOT NULL,
    [BusinessUnitTypeId] int NOT NULL,
    [LocationId] int NOT NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_BusinessUnit] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [BusinessUnitLocation] (
    [Id] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [PhysicalLine1] nvarchar(max) NULL,
    [PhysicalLine2] nvarchar(max) NULL,
    [PhysicalTown] nvarchar(max) NULL,
    [PhysicalCode] nvarchar(max) NULL,
    CONSTRAINT [PK_BusinessUnitLocation] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [BusinessUnitType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_BusinessUnitType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Employee] (
    [Id] int NOT NULL IDENTITY,
    [EmployeeTypeId] int NOT NULL,
    [BusinessUnitId] int NOT NULL,
    [PlayerDataId] int NOT NULL,
    [Initials] nvarchar(max) NULL,
    [Firstnames] nvarchar(max) NULL,
    [Surname] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [CellNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EmployeeType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_EmployeeType] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PlayerData] (
    [Id] int NOT NULL IDENTITY,
    [Age] int NOT NULL,
    [Height] float NOT NULL,
    [Weight] float NOT NULL,
    CONSTRAINT [PK_PlayerData] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210119212650_MyFirstMigration', N'5.0.2');
GO

COMMIT;
GO

