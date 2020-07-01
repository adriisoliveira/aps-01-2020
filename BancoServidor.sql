create database APS_IPs

use APS_IPs

create table Ocorrencias (
	ClienteIp varchar (20),
	Chat varchar (5000)	
);

alter table Ocorrencias add Chat varchar (5000)

drop table Ocorrencias;

select Chat from Ocorrencias

delete from Ocorrencias

