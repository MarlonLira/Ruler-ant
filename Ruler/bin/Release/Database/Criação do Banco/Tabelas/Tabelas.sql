DROP DATABASE ruler;

create database ruler;

use ruler;

create table Tbl_Produto(
	id_produto INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) not null,
	valor numeric(7,2) not null,
	valor_dolar numeric(7,2)
);

 
create table Tbl_Movimento(
	id_movimento INT IDENTITY(1,1) PRIMARY KEY,
	tipo_movimento VARCHAR(50),
	id_cliente INT,
	nome_cliente VARCHAR(50),
	id_produto INT, 
	nome_produto VARCHAR(50),
	quantidade_produto INT,
	valor NUMERIC(7,2),
	parcelas INT,
	situacao VARCHAR(50),
	data_venda VARCHAR(50) ,
	data_entrega VARCHAR(50),
	pedido_id VARCHAR(50)
);

create table Tbl_Estoque(
	id_estoque INT IDENTITY(1,1) PRIMARY KEY,
	nome_produto VARCHAR(50) not null,
	quantidade_produto int,
	id_produto int not null
	
);

create table Tbl_Cliente(
	id_cliente INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(50) not null,
	telefone VARCHAR(50),
	debito numeric(7,2)
);

create table Tbl_Pedido(
	id_pedido INT IDENTITY(1,1) PRIMARY KEY,
	cliente VARCHAR(50) NOT NULL,
	produto VARCHAR(50) NOT NULL,
	quantidade_produto INT NOT NULL,
	valor numeric(7,2) NOT NULL,
	data VARCHAR(50),
	tipo_venda VARCHAR(50),
	id_produto VARCHAR(50) NOT NULL
);

create table Tbl_Cartao_Dividir(
	id_cartao_dividir INT IDENTITY(1,1) PRIMARY KEY,
	juros numeric(7,2) NOT NULL
);

INSERT INTO Tbl_Cartao_Dividir (juros) VALUES (3.19);
INSERT INTO Tbl_Cartao_Dividir (juros) VALUES (7.51);
INSERT INTO Tbl_Cartao_Dividir (juros) VALUES (8.89);
INSERT INTO Tbl_Cartao_Dividir (juros) VALUES (10.24);
INSERT INTO Tbl_Cartao_Dividir (juros) VALUES (11.57);


create table Tbl_Pagamento(
	id_pagamento INT IDENTITY(1,1) PRIMARY KEY,
	cliente VARCHAR(50),
	id_cliente INT,
	valor NUMERIC(7, 2), 
	data_pagamento VARCHAR(50), 
	tipo_pagamento VARCHAR(50), 
	id_pedido INT 
	
);
