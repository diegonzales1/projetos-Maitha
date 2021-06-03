use DB_BANK;

drop table tb_transacao;
drop table tb_conta_corrente;
drop table Clientes;

create table Clientes (
id INT IDENTITY(1,1) not null ,
nome varchar(80) not null,
data_nascimento date not null,
cpf varchar(15) not null,
telefone varchar(13) null,
ContaCorrenteId int not null,
foreign key (ContaCorrenteId) references ContaCorrentes(id)
);

--TB_PESSOA
insert into Clientes (nome, data_nascimento, cpf, telefone, ContaCorrenteId) values ('Fulano de Tal', '1995-12-25', '111.111.111-11', '00000-0000', 1);
insert into Clientes (nome, data_nascimento, cpf, telefone, ContaCorrenteId) values ('Laura Maria', '1980-1-15', '123.321.456-65', '12345-4321', 2);

create table ContaCorrentes (
id INT identity(1,1) PRIMARY KEY not null,
saldo decimal(18,2) null,
transacoesId INT not null,
foreign key (transacoesId) references Transacoes(id)
);

--TB_CONTA_CORRENTE
insert into ContaCorrentes (saldo, transacoesId) values (1500.00, 1);
insert into ContaCorrentes (saldo, transacoesId) values (500.00, 2);

create table Transacoes(
id INT identity(1,1) PRIMARY KEY not null,
descricao varchar(30) null, 
data_transicao date null
);


--TB_TRANSACAO
insert into Transacoes ( descricao, data_transicao) values ('Adicionar', getdate());
insert into Transacoes ( descricao, data_transicao) values ('Retirar', getdate());


----Mostra Dados
select * from Clientes;
select * from Conta_Corrente;
select * from Transacao;

----Insere Dados











