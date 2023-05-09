USE [pokemons]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO 
------- pokemons -------
	CREATE TABLE [dbo].[pokemons](
		[id] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,
		[name] [nvarchar](1024) NOT NULL,
		[pictures] [nvarchar](1024) NULL,
		[types] [int] NOT NULL
	)
GO
------- pokemons types -------
	CREATE TABLE [dbo].[pokemons_types](
		[id] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,
		[idPokemons] [int] NOT NULL,
		[idTypes] [int] NOT NULL
	)
GO ------- types -------
	CREATE TABLE [dbo].[types](
		[id] [int] PRIMARY KEY IDENTITY(1, 1) NOT NULL,
		[name] [nvarchar](1024) NULL,
	)
GO
ALTER TABLE [dbo].[pokemons_types]
ADD CONSTRAINT [T_pokemon_id_FK] FOREIGN KEY([idPokemons]) REFERENCES [dbo].[pokemons] ([id])
ALTER TABLE [dbo].[pokemons_types]
ADD CONSTRAINT [T_types_id_FK] FOREIGN KEY([idTypes]) REFERENCES [dbo].[types] ([id])
GO