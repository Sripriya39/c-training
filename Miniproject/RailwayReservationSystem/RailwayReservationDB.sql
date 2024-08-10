create Database RailwayReservationDB

use RailwayReservationDB

create table Trains(
TrainNo int primary key, 
TrainName Varchar(50),
FromStation Varchar(50),
ToStation Varchar(50),
Price Decimal(10,2),
ClassofTravel Varchar(50),
TrainStatus Varchar(50),
SeatsAvailable int);

insert into Trains(TrainNo,TrainName,FromStation,ToStation,Price,ClassofTravel,TrainStatus,SeatsAvailable)
values(16526,'Kanyakumari Exp','Krpuram','Erode',350.00,'SL','Active',10),
(12084,'MV Jan shatabdi','coimbatore','Kumbakonam',135.00,'2s','Active',2),
(12679,'CBE Intercity','Chennai','Tirupur',635.00,'CC','Active',1),
(16382,'Cape pune Exp','Erode','Tirupathi',595.00,'3E','Active',12);

select * from Trains

Create table Users
(UserId int primary key ,
UserName Varchar(50),
Password Varchar(15),
Role Varchar(25));


insert into Users(UserId,UserName,Password,Role) values
(1,'admin','admin','Admin'),
(2,'sri','password','User'),
(3,'Vidhu','password','User'),
(4,'Karthi','password','User'),
(5,'Priya','password','User');

select * from users

create table Bookings
(BookingID int primary key,
UserID int Foreign key (UserId) References Users(UserId),
TrainNo int Foreign key (TrainNo) References Trains(TrainNo),
SeatsBooked int,
BookingDate Datetime);

create table Cancellations
(CancellationId int primary key,
BookingId int Foreign key (BookingId) references Bookings(BookingId),
CancelledSeats int,
CancellationDate Datetime);

create table WaitingList
(WaitingId int primary key,
UserID int Foreign key (UserId) References Users(UserId),
TrainNo int Foreign key (TrainNo) References Trains(TrainNo),
SeatsReqested int,
RequestDate Datetime);

select * from Trains
select * from bookings
select * from Cancellations
select * from users
select * from WaitingList




