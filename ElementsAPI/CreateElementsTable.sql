USE [Cougar_1]
GO

/****** Object:  Table [dbo].[Elements]    Script Date: 02/25/2018 16:30:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Elements](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AtomicNumber] [int] NOT NULL,
	[AtomicWeight] [real] NOT NULL,
	[Name] [nvarchar](128) NULL,
	[Symbol] [nvarchar](max) NULL,
	[MeltingPoint] [real] NOT NULL,
	[BoilingPoint] [real] NOT NULL,
	[Density] [real] NOT NULL,
	[EarthCrustPerCentage] [real] NOT NULL,
	[Discovered] [nvarchar](max) NULL,
	[Group] [int] NOT NULL,
	[ElectronConfiguration] [nvarchar](max) NULL,
	[IonizationEnergy] [real] NOT NULL,
 CONSTRAINT [PK_dbo.Elements] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE UNIQUE NONCLUSTERED INDEX [IX_Name] ON [dbo].[Elements] 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO


insert into Elements (AtomicNumber, AtomicWeight, Name, Symbol, MeltingPoint, BoilingPoint, Density, EarthCrustPerCentage, Discovered, [Group],
ElectronConfiguration, IonizationEnergy) values
(1, 1.008, 'Hydrogen','H',	-259.0,	+253.,0.09,0.14,'1776',1,'1s1', 13.60 )



