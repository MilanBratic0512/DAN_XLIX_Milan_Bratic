--Creating database only if database is not created yet
IF DB_ID('Zadatak_49') IS NULL
CREATE DATABASE Zadatak_49
GO
USE Zadatak_49;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblOwner')
drop table tblOwner;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblManager')
drop table tblManager;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblEmployer')
drop table tblEmployer;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblAbsence')
drop table tblAbsence;

create table tblOwner(
OwnerID int identity (1,1) primary key,
FullName nvarchar,
DateOfBirth date,
Mail nvarchar,
Username nvarchar,
OwnerPassword nvarchar
)

create table tblManager(
ManagerID int identity (1,1) primary key,
FullName nvarchar,
DateOfBirth date,
Mail nvarchar,
Username nvarchar,
MannagerPassword nvarchar,
HotelFloor int,
Experience int,
ProfessionalQualifications nvarchar
)

create table tblEmployer(
EmployerID int identity (1,1) primary key,
FullName nvarchar,
DateOfBirth date,
Mail nvarchar,
Username nvarchar,
EmployerPassword nvarchar,
HotelFloor int,
Gender nvarchar,
Citizenship nvarchar,
Engagement nvarchar,
Salary decimal
)

create table tblAbsence(
AbsenceID int identity (1,1) primary key,
AbsenceStart date,
AbsenceEnd date,
Reason nvarchar,
EmployerID int FOREIGN KEY  REFERENCES tblEmployer(EmployerID)
)