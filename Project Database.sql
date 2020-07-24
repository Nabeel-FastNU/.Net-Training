create database DailyLife

use [DailyLife]

create table Person
(
	ID int IDENTITY, 
	Name varchar(max), 
	PhoneNo bigint check (len(PhoneNo) = 10),
	Designation varchar(max),
	primary key (ID)
)

create table _User 
(
	ID int, 
	EmailID varchar(max), 
	Password varchar(max), 
	Primary Key (ID), 
	Foreign Key (ID) references Person(ID) on delete cascade on update cascade
)

create table Document
(
	ID int, 
	Title varchar(max), 
	Description varchar(max), 
	Primary key (ID)
)

create table _Event
(
	ID int IDENTITY,
	Name varchar(max), 
	Location varchar(max), 
	StartDate DateTime, 
	EndDate DateTime, 
	Primary key (ID)
)

create table Meeting
(
	EventID int,
	PersonID int, 
	Foreign Key (EventID) references _Event, 
	Foreign Key (PersonID) references Person, 
	Primary key (EventID, PersonID)
)

Alter Table Meeting add constraint [Fk1_Cascade] foreign key (EventID)
references _Event(ID)
on delete cascade on update cascade 

Alter Table Meeting add constraint [Fk2_Cascade] foreign key (PersonID)
references Person(ID)
on delete cascade on update cascade 


create table Trip 
(
	EventID int,
	DocumentID int, 
	foreign key (EventID) references _Event(ID) on delete cascade on update cascade , 
	foreign key (DocumentID) references Document(ID) on delete cascade on update cascade , 
	primary key (EventID, DocumentID)
)

create table TripExpense
(
	EventID int,
	TripExpense int, 
	foreign key (EventID) references _Event(ID) on delete cascade on update cascade, 
	primary key (EventID)
)

create table GroupTrip
(
	EventID int,
	PersonID int, 
	foreign key (EventID) references TripExpense(EventID) on delete cascade on update cascade, 
	foreign key (PersonID) references Person(ID) on delete cascade on update cascade,
	primary key (EventID, PersonID)
)

insert into Person values 
('Nabeel', 3216549871, 'Client')

insert into _User values 
(2, 'nabeel@abc.com', '123123')

insert into _Event values
('Business Meeting 1', 'XYZ', '20200812 12:00:00 AM', '20200913 11:30:00 PM')
insert into _Event values
('Business Meeting 2', 'XYZ', '20200812 12:00:00 AM', '20200913 11:30:00 PM')

insert into Meeting values
(7, 3)

select* from Person
select* from _User
select* from Meeting
select* from Document
select* from _Event
select* from Trip
select* from TripExpense
select* from GroupTrip

delete from Person
where ID = 3

delete from Person
where ID = 1

--Update Person
--set ID = 1
--where ID = 2

