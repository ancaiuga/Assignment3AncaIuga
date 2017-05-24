CREATE DATABASE IF NOT EXISTS clinic;
use  clinic;

CREATE TABLE IF NOT EXISTS Users
(idUser int primary key ,
username varchar(45),
passwrd varchar(45),
userType int);

CREATE TABLE IF NOT EXISTS Patient
(idPatient int primary key ,
patientName varchar(45),
identityCardNumber varchar(45),
cnp varchar(45),
242626birthDate date,
address varchar(45));

CREATE TABLE IF NOT EXISTS Consultation 
(consultationDate datetime,
consultationHour int,
idDoctor int,
idPatient int,
details varchar(45),
FOREIGN KEY (idPatient) REFERENCES Patient(idPatient),
FOREIGN KEY (idDoctor) REFERENCES Users(idUser),
primary key (idPatient ,idDoctor,consultationDate, consultationHour));

