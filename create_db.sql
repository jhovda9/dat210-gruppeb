create schema dat210_gruppe_b;

create table Informasjon(
	ID int primary key auto_increment,
	tag varchar(30),
    location varchar(15),
    dato date,
    album varchar(20),
    rating int,  
    hendelse varchar(30),
    thumbnail varbinary(10000)
); 
