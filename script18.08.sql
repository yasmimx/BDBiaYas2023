create database dbAppBanco;
use dbAppBanco;

create table tbUsuario (
IdUsu int primary key auto_increment,
NomeUsu varchar(50) not null,
Cargo varchar(50) not null, 
DataNasc datetime
);

insert into tbUsuario(NomeUsu, Cargo, DataNasc)
values('mario', 'Ator', '2000/05/15'),
		('maria', 'Chefe', '2001/03/23');
        
        select * from tbUsuario;