/* Criando o banco de dados para usá-lo */
create database dbArriba;
use dbArriba;

/* Criando tabelas pro banco de dados */
create table tbLogin(
 Codigo int primary key auto_increment,
 Usuario varchar(50) not null,
 Senha varchar(50) not null
);

create  table tbFuncionario(
 CodFunc int auto_increment,
 foreign key (CodFunc) references tbLogin(Codigo),
 Nome varchar(50)
);

create table tbCliente(
CodigoCliente int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(80) not null,
Telefone varchar(15) not null,
Imagem varchar(100) not null
);

create table tbPedido(
CodigoPedido int primary key auto_increment,
ComidaSelecionada varchar(50),
ValorComida varchar(50),
ValorAcompanhamentos varchar(50),
ValorFinal varchar(30)
);

/* Inserindo dados no banco */
insert into tbLogin(Usuario,Senha)
values("Barbs","1111"),
("Kevin","2222"),
("Milito","3333"),
("Yas","4444");

/* Consultando tabelas banco de dados */
select * from tbLogin;
select * from tbFuncionario;
select * from tbCliente;
select * from tbPedido;
