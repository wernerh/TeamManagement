USE [TeamManagement]
GO

INSERT INTO [dbo].[BusinessUnitType]
           ([Name])
     VALUES
           ('Management'),
		   ('Rugby Team')
GO

INSERT INTO [dbo].[EmployeeType]
           ([Name])
     VALUES
           ('Management'),
		   ('Admin'),
		   ('Coach'),
		   ('Physiotherapist'),
		   ('Player')
GO


INSERT INTO [dbo].[BusinessUnitLocation]
           ([Name]
           ,[PhysicalLine1]
           ,[PhysicalLine2]
           ,[PhysicalTown]
           ,[PhysicalCode])
     VALUES
           ('Loftus Versfeld Stadium','416 Kirkness St','Arcadia,','Pretoria','0007'),
		   ('Ellis Park Stadium','S Park Ln','New Doornfontein','Johannesburg','2094'),
		   ('Toyota Stadium','Willows','','Bloemfontein','9320'),
		   ('Newlands Rugby Stadium','8 Boundary Rd','Newlands','Cape Town','7700'),
		   ('JONSSON KINGS PARK','Jacko Jackson Dr','Stamford Hill','Durban','4025')		 
GO

 DECLARE @BusinessUnitTypeId INT
 DECLARE @BusinessUnitLocationId INT

 SELECT @BusinessUnitTypeId = [Id]
	FROM [TeamManagement].[dbo].[BusinessUnitType]
	WHERE [Name] = 'Management'

 SELECT @BusinessUnitLocationId = [Id]
	FROM [TeamManagement].[dbo].[BusinessUnitLocation]
	WHERE [Name] = 'Loftus Versfeld Stadium'

INSERT INTO [dbo].[BusinessUnit]
           ([ParentBusinessUnitId]
           ,[BusinessUnitTypeId]
           ,[BusinessUnitLocationId]
           ,[Name])
     VALUES
           (null,
		   @BusinessUnitTypeId,
		   @BusinessUnitLocationId,
		   'Blue Bulls')		
GO

DECLARE @BusinessUnitTypeId INT
DECLARE @BusinessUnitLocationId INT
DECLARE @ParentBusinessUnitId INT

SELECT @BusinessUnitTypeId = [Id]
	FROM [TeamManagement].[dbo].[BusinessUnitType]
	WHERE [Name] = 'Rugby Team'

SELECT @BusinessUnitLocationId = [Id]
	FROM [TeamManagement].[dbo].[BusinessUnitLocation]
	WHERE [Name] = 'Loftus Versfeld Stadium'

SELECT @ParentBusinessUnitId = [Id]
	FROM [TeamManagement].[dbo].[BusinessUnit]
	WHERE [Name] = 'Blue Bulls'

INSERT INTO [dbo].[BusinessUnit]
           ([ParentBusinessUnitId]
           ,[BusinessUnitTypeId]
           ,[BusinessUnitLocationId]
           ,[Name])
     VALUES
           (@ParentBusinessUnitId,@BusinessUnitTypeId,@BusinessUnitLocationId,'Super Rugby'),
		   (@ParentBusinessUnitId,@BusinessUnitTypeId,@BusinessUnitLocationId,'Currie Cup'),
		   (@ParentBusinessUnitId,@BusinessUnitTypeId,@BusinessUnitLocationId,'Under 21'),
		   (@ParentBusinessUnitId,@BusinessUnitTypeId,@BusinessUnitLocationId,'Under 18')
GO


