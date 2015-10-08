create schema dat210_gruppe_b;

create table Informasjon(
	ID int primary key not null auto_increment,
	tag varchar(max),
    by varchar(50),
    land varchar(50),
    dato date,
    album varchar(255),
    rating int,  
    hendelse varchar(255),
    thumbnail varbinary(10000)
    image longblob not null
); 
