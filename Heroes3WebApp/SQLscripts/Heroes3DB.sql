create database Heroes3DB;

GO

USE Heroes3DB

GO

create table [User](
Id int not null IDENTITY(1,1),
Username nvarchar(50) not null,
[Password] nvarchar(50) not null,
Email nvarchar(50) not null)

create table Landscapes(
Id int not null IDENTITY(1,1),
Name nvarchar(25),
CONSTRAINT PK_Landscape PRIMARY KEY (Id));

create table Towns(
Id int not null IDENTITY(1,1),
LandscapeId int not null,
Name nvarchar(25),
HeroClass_1 nvarchar(20),
HeroClass_2 nvarchar(20),
Discription nvarchar(1000),
Picture varbinary(max),
CONSTRAINT PK_Town PRIMARY KEY (Id)); 

create table Heroes(
Id int not null IDENTITY(1,1),
TownId int not null,
CostId int not null,
Name nvarchar(25),
[Type] int not null,
Picture varbinary(max),
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
Picture varbinary(max),
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
Damage nvarchar(10),
Speed int not null,
Level int not null,
Discription nvarchar(100),
Picture varbinary(max),
CONSTRAINT PK_Monster PRIMARY KEY(Id));

create table Buildings(
Id int not null IDENTITY(1,1),
TownId int not null,
CostId int not null,
Name nvarchar(25),
Discription nvarchar(100),
Picture varbinary(max),
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

INSERT INTO [dbo].[Towns] (LandscapeId, Name, HeroClass_1, HeroClass_2)
VALUES ('3', 'Castle', 'Knight', 'Cleric'), ('3', 'Rampart', 'Ranger', 'Druid'), ('4', 'Tower', 'Alchemist', 'Wizard'),
       ('8', 'Inferno', 'Demoniac', 'Heretic'), ('1', 'Necropolis', 'Death Knight', 'Necromancer'),('7', 'Dungeon', 'Overlord', 'Warlock'),
	   ('6', 'Stronghold', 'Barbarian', 'Battle Mage'), ('5', 'Fortress', 'Beastmaster', 'Witch'), 
	   ('9', 'Conflux', 'Planeswalker', 'Elementalist'), ('5','Cove', 'Captain', 'Navigator');

GO

INSERT INTO [dbo].[Costs] (Gold)
VALUES ('2500'), ('60'), ('75')

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

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Castle_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 1

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Rampart_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 2

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Tower_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 3

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Inferno_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 4


UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Necropolis_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 5

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Dungeon_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 6

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Stronghold_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 7

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Fortress_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 8

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Conflux_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 9

UPDATE [dbo].[Towns] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Cove_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 10

GO

ALTER TABLE [dbo].[Towns] 
ADD PictureName NVARCHAR(20) NULL;

GO

UPDATE [dbo].[Towns] 
SET PictureName = 'Castle_small.gif'
WHERE Id = 1

UPDATE [dbo].[Towns] 
SET PictureName = 'Rampart_small.gif'
WHERE Id = 2

UPDATE [dbo].[Towns] 
SET PictureName = 'Tower_small.gif'
WHERE Id = 3

UPDATE [dbo].[Towns] 
SET PictureName = 'Inferno_small.gif'
WHERE Id = 4

UPDATE [dbo].[Towns] 
SET PictureName = 'Necropolis_small.gif'
WHERE Id = 5

UPDATE [dbo].[Towns] 
SET PictureName = 'Dungeon_small.gif'
WHERE Id = 6

UPDATE [dbo].[Towns] 
SET PictureName = 'Stronghold_small.gif'
WHERE Id = 7

UPDATE [dbo].[Towns] 
SET PictureName = 'Fortress_small.gif'
WHERE Id = 8

UPDATE [dbo].[Towns] 
SET PictureName = 'Conflux_small.gif'
WHERE Id = 9

UPDATE [dbo].[Towns] 
SET PictureName = 'Cove_small.gif'
WHERE Id = 10

GO

ALTER TABLE [dbo].[Towns] 
ADD DetailPicture varbinary(max) null;

GO

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Castle_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 1

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Rampart_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 2

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Tower_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 3

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Inferno_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 4


UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Necropolis_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 5

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Dungeon_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 6

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Stronghold_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 7

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Fortress_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 8

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Conflux_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 9

UPDATE [dbo].[Towns] 
SET DetailPicture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\Adventure_Map_Cove_capitol.gif', SINGLE_BLOB) AS image)
WHERE Id = 10

UPDATE [dbo].[Towns]
set Discription = 'Castles are home to the Cleric and Knight hero classes. Castle armies are primarily composed of human men-at-arms, though these towns have also formed an alliance with the griffins and are under the protection of angels. With two types of ranged attack units and two flying unit types available, Castle-based armies are well equipped to quickly engage and defeat their enemies.'
where Id = 1

UPDATE [dbo].[Towns]
set Discription = 'The Druid and Ranger hero classes are native to Ramparts, which are built by creatures in allied defense of the unspoiled wilderness regions of Erathia. With two slow unit types, Dwarves and Dendroids, Rampart armies may be best suited to defensive tactics. Most of these creatures, however, have enemy hampering abilities that can be used to turn the tide against many opponents — especially those dependent on magical attacks.'
where Id = 2

UPDATE [dbo].[Towns]
set Discription = 'Wizards and Alchemists study their arcane craft in Towers. Tower populations are comprised of creatures bound into service by powerful magic, made on the spot, or allied with the town through ancient pacts. Tower armies have uniformly good morale and some of the best range attack units available'
where Id = 3

UPDATE [dbo].[Towns]
set Discription = 'Inferno towns can be found in Erathian regions blighted by the emergence of the underworld on the surface. Demoniac and Heretic heroes stand in uneasy alliance with these towns. Inferno armies have great hand-to-hand attack units and are only slightly hampered at the lower levels by a lack of flying units until the awesome, teleporting devil and arch devil units can be brought into play.'
where Id = 4

UPDATE [dbo].[Towns]
set Discription = 'Necropolis towns are overrun and ruled by undead creatures. They are the natural bases for the Necromancer and Death Knight hero types. Necropolis armies have many units with abilities to weaken their opponents. This quickly gives them an edge over equal or even more powerful enemy armies.'
where Id = 5

UPDATE [dbo].[Towns]
set Discription = 'Dungeons towns are built by Warlock and Overlord hero types to act as bases from which to wage campaigns of conquest for wealth and power. Similarly minded creatures are attracted as allies. Other Dungeon creatures are in thrall to their masters. Dungeon armies are possessed of a variety of long range attacks, have effective damage dealing troops, and have the ability to greatly disrupt the strategies of their enemies.'
where Id = 6

UPDATE [dbo].[Towns]
set Discription = 'Stronghold towns are built by alliances of tribes and are frequented by the Barbarian and Battle Mage hero types. Armies composed of Stronghold-based units have a balanced mix of ranged and hand-to-hand attackers. With the inclusion of the stronger units, these armies are particularly well-equipped to deal with attacks on other towns.'
where Id = 7

UPDATE [dbo].[Towns]
set Discription = 'Fortress towns are built at the edge of swamps and are often used as bases by the Beastmaster and Witch hero classes. Their armies are primarily made up of deadly creatures — born of the swamps, and then subdued and trained for warfare. While among them there is only one ranged attack creature, Fortress units are possessed of many special abilities to offset this deficiency.'
where Id = 8

UPDATE [dbo].[Towns]
set Discription = 'A Conflux is home to the Elementalist and Planeswalker. Composed primarily of elemental creatures, the Conflux also offers home to the Sprites and the elusive Phoenix. What makes Conflux towns unique is their emphasis on creatures of mid-range power. Generals continue to debate if this is the strategic strength or weakness of the town. Regardless, all agree it takes an astute commander to effectively lead a Conflux army.'
where Id = 9

UPDATE [dbo].[Towns]
set Discription = 'Cove is a neutral alignment town with the captain and navigator hero classes. Cove armies are composed of pirates, smugglers, and thieves, as well as those with whom they have forged alliances. Cove represents Regna.'
where Id = 10



UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Christian_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 1

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Adela_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 2

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Mephala_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 3

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Elleshar_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 4

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Fafner_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 5

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Solmyr_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 6

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Nymus_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 7

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Zydar_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 8

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Galthran_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 9

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Sandro_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 10

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Dace_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 11

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Deemer_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 12

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Tyraxor_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 13

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Dessa_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 14

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Tazar_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 15

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Mirlanda_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 16

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Monere_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 17

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Luna_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 18

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Illor_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 19

UPDATE [dbo].[Heroes] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\HeroIcon\Hero_Astra_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 20

INSERT INTO [dbo].[Monsters] (TownId, Name, HP, Attack, Defence, Damage, Speed, [Level], CostId)
VALUES ('1', 'Pikeman', '10', '4','5', '1-3', '4', '1', '2'),
	   ('1', 'Halberdier', '10', '6','5', '2-3', '5', '1', '3')

go

UPDATE [dbo].[Monsters] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\CreatureIcon\Creature_portrait_Pikeman_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 1

UPDATE [dbo].[Monsters] 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\D\VladWork\repository\Heroes3WebApp\Heroes3WebApp\Images\CreatureIcon\Creature_portrait_Halberdier_small.gif', SINGLE_BLOB) AS image)
WHERE Id = 2