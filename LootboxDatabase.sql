use master 
GO

DROP DATABASE IF EXISTS LootboxDB

CREATE DATABASE LootboxDB
GO


use LootboxDB

GO

CREATE TABLE Lootboxes
	(
		LootboxID					int				PRIMARY KEY IDENTITY
	  , LootboxTheme				varchar(30)		NOT NULL
	  , LootboxName					varchar(50)		NOT NULL
	  , LootboxContents				varchar(150)	NOT NULL
	  , LootboxDescription			varchar(100)	NOT NULL
	  , LootboxPrice				smallmoney		NOT NULL
	)