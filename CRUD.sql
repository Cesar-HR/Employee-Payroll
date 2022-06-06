CREATE DATABASE CRUD;

USE CRUD;

/*.: TABLE PERSON :.*/
CREATE TABLE Person(
	idPerson		int identity(1,1)	primary key,
	names			varchar(100)		not null,
	surname			varchar(100)		not null,
	dni				varchar(8)			not null,
	marital_status	varchar(100)		not null,
	home_address	varchar(100)		not null,
	date_birth		date				not null,
	age				int					not null
);

/*.: VALUES :.*/
INSERT INTO Person VALUES ('Jose','Humberto Lopez','98765432','single','Normalville, Pennsylvania(PA), 15469','2000-01-01',22);

/*.: QUERY :.*/
SELECT * FROM dbo.Person;