create database Clientes

use Clientes

create table Cadastro(
	cpf varchar (11) primary key,
	usuario varchar (15),
	nomeCompleto varchar (100),
	telefone varchar (12),
	senha varchar (8),
	rg varchar(11)

);

create table ClientesUsuarios (
 	usuario varchar (10),
 	senha varchar (8)
);