create database StockPlatformDB;

go

use StockPlatformDB

go

create table Author(
Id int not null identity(1,1),
FirstName nvarchar(30) not null,
LastName nvarchar(30) not null,
Nickname nvarchar(30) not null,
DateOfBirth datetime,
DateOfRegistration datetime,
constraint PK_Author primary key(Id));

create table Photo(
Id int not null identity(1,1),
Name nvarchar(30) not null,
Picture varbinary(max), 
Link nvarchar(max),
OriginalLength int not null,
OriginalWidth int not null,
DateOfCreation datetime,
AuthorId int not null,
Cost nvarchar(10) not null,
NumberOfSales int,
Raiting int,
constraint PK_Photo primary key(Id));

alter table Photo
add constraint FK_Photo_AuthorId foreign key(AuthorId)
references Author(Id);

create table [Text](
Id int not null identity(1,1),
Name nvarchar(30) not null,
[Text] nvarchar(max),
DateOfCreation datetime,
Cost nvarchar(10) not null,
AuthorId int not null,
NumberOfSales int,
Raiting int,
constraint PK_Text primary key(Id));

alter table [Text]
add constraint FK_Text_AuthorId foreign key(AuthorId)
references Author(Id);

go

insert into Author(FirstName, LastName, Nickname, DateOfBirth, DateOfRegistration)
values ('Vasiliy', 'Pupkin', 'VPupkin123', 1983-12-8, 2020-9-15),
	   ('Jasmine', 'Hudjes', 'JH419', 1992-4-19, 2021-2-7),
	   ('Alex', 'Grecka', 'GreeAlex', 2002-11-13, 2021-7-25),
	   ('Elle', 'Voteman', 'ElVote', 1999-1-10, 2022-6-28);

insert into Photo(Name, OriginalLength, OriginalWidth, DateOfCreation, AuthorId, Cost, NumberOfSales)
values ('Nichose meme', '400', '400', 2020-9-23, 1, '12$', '13'),
	   ('Whiskas', '511', '340', 2021-3-2, 2, '7.50$', '24'),
	   ('Doggy dog', '800', '533', 2021-9-15, 3, '10$', '18'),
	   ('Not a pigeon', '269', '187', 2022-7-6, 4, '4.99$', '9');

insert into [Text](Name, [Text], DateOfCreation, Cost, AuthorId, NumberOfSales)
values ('Homeless frog','The homeless Frog sang - croaked, Sadly sang and at the same time cried. The Frog cried a whole pond. Since then, frogs have been living in it.',
	    2021-2-14, '15$', '1', '124'),
		('Eternal summer','If summer were eternal, everything would burn. If autumn were eternal, everything would be damp. In the eternal winter, everything would be frozen. Eternal spring is another matter.',
	    2021-7-16, '13.50$', '1', '106'),
		('Smart man','I don’t know what to write, I don’t know - I can’t stand girls and women, I respect only the soul, the feeling, And I sincerely love the mind...',
	    2022-5-4, '9.99$', '1', '233'),
		('Good purchase','To the city, to the city for the pig. I go on foot. I return home Riding a pig.',
	    2021-3-10, '5$', '1', '47');