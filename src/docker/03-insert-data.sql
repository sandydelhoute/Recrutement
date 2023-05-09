USE [pokemons]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

USE [pokemons]
GO

INSERT INTO [dbo].[types]
           ([name])
     VALUES
           ('Feu')
GO
INSERT INTO [dbo].[types]
           ([name])
     VALUES
           ('Eau')
GO
INSERT INTO [dbo].[types]
           ([name])
     VALUES
           ('Pierre')
GO

INSERT INTO [dbo].[pokemons]
           ([name]
           ,[pictures]
           ,[types])
		   VALUES
           (
			'Dracofeu'
           ,'Dracofeu.png'
           ,1)
GO

INSERT INTO [dbo].[pokemons]
           ([name]
           ,[pictures]
           ,[types])
		   VALUES
           (
			'Dracofeu'
           ,'Dracofeu.png'
           ,1)
GO

USE [pokemons]
GO

INSERT INTO [dbo].[pokemons_types]
           ([idPokemons]
           ,[idTypes])
     VALUES
           (1
           ,1)
GO
