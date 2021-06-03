use ApiBanco;

drop table tb_transacao;
drop table tb_conta_corrente;
drop table tb_pessoa;

create table Cliente (
id INT IDENTITY(1,1) PRIMARY KEY not null ,
nome varchar(80) not null,
data_nascimento date not null,
cpf varchar(15) not null,
telefone varchar(13) null
);

create table Conta_Corrente (
id INT identity(1,1) PRIMARY KEY not null,
saldo decimal(18,2) null,
codigo_cliente INT not null,
foreign key (codigo_cliente) references Cliente(id)
);

create table Transacao(
id INT identity(1,1) not null,
descricao varchar(30) not null, 
data_transicao date not null,
codigo_conta_corrente int not null,
foreign key (codigo_conta_corrente) references Conta_Corrente(id)
);

----Mostra Dados
select * from Cliente;
select * from Conta_Corrente;
select * from Transacao;

--Mostra tabela Pessoa com Saldo
select p.nome as NOME, p.data_nascimento as NASCIMENTO, p.cpf as CPF, p.telefone as TELEFONE, c.saldo as SALDO
from Conta_Corrente c
cross join Cliente p
where p.id = c.codigo_cliente;

--Mostra Tabela Pessoa com Saldo e as Transações feitas
select p.nome as NOME, p.data_nascimento as NASCIMENTO, p.cpf as CPF, p.telefone as TELEFONE, c.saldo as SALDO, 
t.descricao as DESCRICAO, t.data_transicao as DATA_TRANSIÇÃO 
from Conta_Corrente c
cross join Cliente p, Transacao t
where p.id = c.codigo_cliente and c.id = t.codigo_conta_corrente;

----Insere Dados

--TB_PESSOA
insert into Cliente(nome, data_nascimento, cpf, telefone) values ('Fulano de Tal', '1995-12-25', '111.111.111-11', '00000-0000');
insert into Cliente (nome, data_nascimento, cpf, telefone) values ('Laura Maria', '1980-1-15', '123.321.456-65', '12345-4321');

--TB_CONTA_CORRENTE
insert into Conta_Corrente (codigo_cliente, saldo) values (1, 1500.00);
insert into Conta_Corrente (codigo_cliente, saldo) values (2, 500.00);

--TB_TRANSACAO
insert into Transacao ( descricao, data_transicao, codigo_conta_corrente) values ('Adicionar', getdate(), 1);
insert into Transacao ( descricao, data_transicao, codigo_conta_corrente) values ('Retirar', getdate(), 1);







