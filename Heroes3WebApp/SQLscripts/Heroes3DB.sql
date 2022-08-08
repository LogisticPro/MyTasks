create database Heroes3DB;

GO

USE Heroes3DB

GO

create table Landscapes(
Id int not null IDENTITY(1,1),
Name nvarchar(25),
CONSTRAINT PK_Landscape PRIMARY KEY (Id));

create table Towns(
Id int not null IDENTITY(1,1),
LandscapeId int not null,
Name nvarchar(25),
Discription nvarchar(100),
Picture varbinary,
CONSTRAINT PK_Town PRIMARY KEY (Id)); 

create table Heroes(
Id int not null IDENTITY(1,1),
TownId int not null,
CostId int not null,
Name nvarchar(25),
[Type] int not null,
Picture varbinary,
CONSTRAINT PK_Hero PRIMARY KEY(Id));

create table HeroStats(
Id int not null IDENTITY(1,1),
TownId int not null,
HeroType int not null,
Attack int not null,
Defence int not null,
Spellpower int not null,
Knowledge int not null,
CONSTRAINT PK_HeroStats PRIMARY KEY(Id));

create table Spells(
Id int not null IDENTITY(1,1),
Name nvarchar(25),
Discription nvarchar(100),
Picture varbinary,
[Level] int not null,
CONSTRAINT PK_Spell PRIMARY KEY(Id));

create table Heroes_Spells(
Id int not null IDENTITY(1,1),
HeroId int not null,
SpellId int not null,
CONSTRAINT PK_Hero_Spell PRIMARY KEY(Id));

create table Monsters(
Id int not null IDENTITY(1,1),
TownId int null,
CostId int not null,
Name nvarchar(25),
HP int not null,
Attack int not null,
Defence int not null,
Damage int not null,
Speed int not null,
Discription nvarchar(100),
Picture varbinary,
CONSTRAINT PK_Monster PRIMARY KEY(Id));

create table Buildings(
Id int not null IDENTITY(1,1),
TownId int not null,
CostId int not null,
Name nvarchar(25),
Discription nvarchar(100),
Picture varbinary,
CONSTRAINT PK_Building PRIMARY KEY(Id));

create table Costs(
Id int not null IDENTITY(1,1),
Gold int not null,
Ore int null,
Wood int null,
Gem int null,
Crystal int null,
Mercury int null,
Sulfyr int null,
CONSTRAINT PK_Cost PRIMARY KEY(Id));

GO
----------------------------------------------------------------

ALTER TABLE [dbo].[Towns]
ADD CONSTRAINT FK_Town_LandscapeId FOREIGN KEY (LandscapeId)
REFERENCES Landscapes(Id);

ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT FK_Hero_CostId
FOREIGN KEY (CostId) REFERENCES Costs(Id);

ALTER TABLE [dbo].[Heroes]
ADD CONSTRAINT FK_Hero_TownId
FOREIGN KEY (TownId) REFERENCES Towns(Id);

ALTER TABLE [dbo].[HeroStats]
ADD CONSTRAINT FK_HeroStats_TownId
FOREIGN KEY (TownId) REFERENCES Towns(Id);

ALTER TABLE [dbo].[Heroes_Spells]
ADD CONSTRAINT FK_HeroSpell_HeroId
FOREIGN KEY (HeroId) REFERENCES Heroes(Id);

ALTER TABLE [dbo].[Heroes_Spells]
ADD CONSTRAINT FK_HeroSpell_SpellId
FOREIGN KEY (SpellId) REFERENCES Spells(Id);

ALTER TABLE [dbo].[Monsters]
ADD CONSTRAINT FK_Monster_TownId
FOREIGN KEY (TownId) REFERENCES Towns(Id);

ALTER TABLE [dbo].[Monsters]
ADD CONSTRAINT FK_Monster_CostId
FOREIGN KEY (CostId) REFERENCES Costs(Id);

ALTER TABLE [dbo].[Buildings]
ADD CONSTRAINT FK_Building_TownId
FOREIGN KEY (TownId) REFERENCES Towns(Id);

ALTER TABLE [dbo].[Buildings]
ADD CONSTRAINT FK_Building_CostId
FOREIGN KEY (CostId) REFERENCES Costs(Id);

GO
-----------------------------------------------------------------

INSERT INTO [dbo].[Landscapes] (Name)
VALUES ('Dirt'), ('Sand'), ('Grass'), ('Snow'), ('Swamp'), ('Rocks'), ('Dungeon terrain'), ('Lava'), ('Highlands'), ('Wastelands'), ('Water');

GO

INSERT INTO [dbo].[Towns] (LandscapeId, Name)
VALUES ('3', 'Castle'), ('3', 'Rampart'), ('4', 'Tower'), ('8', 'Inferno'), ('1', 'Necropolis'),
       ('7', 'Dungeon'), ('6', 'Stronghold'), ('5', 'Fortress'), ('9', 'Conflux'), ('5','Cove');

GO

INSERT INTO [dbo].[Costs] (Gold)
VALUES ('2500')

GO

INSERT INTO [dbo].[Heroes] (TownId, CostId, Name, [Type])
VALUES ('1', '1', 'Christian', '1'), ('1', '1', 'Adela', '2'),
       ('2', '1', 'Mephala', '1'), ('2', '1', 'Elleshar', '2'),
	   ('3', '1', 'Fafner', '1'), ('3', '1', 'Solmyr', '2'),
	   ('4', '1', 'Nymus', '1'), ('4', '1', 'Zydar', '2'),
	   ('5', '1', 'Galthran', '1'), ('5', '1', 'Sandro', '2'),
	   ('6', '1', 'Das', '1'), ('6', '1', 'Deemer', '2'),
	   ('7', '1', 'Tyraxor', '1'), ('7', '1', 'Dessa', '2'),
	   ('8', '1', 'Tazar', '1'), ('8', '1', 'Mirlanda', '2'),
	   ('9', '1', 'Monere', '1'), ('9', '1', 'Luna', '2'),
	   ('10', '1', 'Illor', '1'), ('10', '1', 'Astra', '2');	  

GO

INSERT INTO [dbo].[Spells] (Name, [Level])
VALUES ('Bless', '1'), ('Magic arrow', '1'), ('Slow', '1'),
	   ('Weakness', '2'), ('Lightning bolt', '2'), ('Blind', '2'),
	   ('Teleport', '3'), ('Fireball', '3'), ('Hypnotize', '3'),
	   ('Prayer', '4'), ('Meteor Shower', '4'), ('Berserk', '4'),
	   ('Magic Mirror', '5'), ('Implosion', '5'), ('Sacrifice', '5');