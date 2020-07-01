create database Clientes

use Clientes

create table Cadastro(
	cpf varchar (11) primary key,
	usuario varchar (10),
	nomeCompleto varchar (50),
	telefone varchar (12),
	senha varchar (8)

);

create table ClientesUsuarios (
 Usuario varchar (10),
 Senha varchar (8)
);