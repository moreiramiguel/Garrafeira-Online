create table Garrafeira(
	NIF				int,
	Mail			varchar(25)		NOT NULL,
	Telefone		int				NOT NULL,
	Nome			varchar(15)		NOT NULL
	primary key(NIF));

create table fornecedor_garrafeira(
	NIF				int,
	telefone		int,
	nome			varchar(15),
	primary key(NIF));


create table bebidas_alcoolicas(
	codigo			int,
	garrafeira_nif	int,
	marca			varchar(25),
	teor			float,
	iva				float,
	stock			int,
	litragem		float,
	primary key(codigo,garrafeira_nif),
	foreign key(garrafeira_nif) references garrafeira(NIF));

create table fornece_garrafeira(
	Garrafeira_NIF	int,
	Fornecedor_NIF	int,
	primary key(Garrafeira_NIF,Fornecedor_NIF),
	foreign key(Fornecedor_NIF) references fornecedor_garrafeira(NIF),
	foreign key(Garrafeira_NIF) references Garrafeira(NIF));

create table cliente_garrafeira(
	nome			varchar(25),
	NIF				int,
	mail			varchar(25),
	morada			varchar(30),
	metodo			varchar(15),
	primary key(NIF));

create table encomenda_garrafeira(
	numero			int,
	data			date,
	garrafeira_NIF	int,
	cliente_NIF		int,
	primary key(numero),
	foreign key(cliente_NIF) references cliente_garrafeira(NIF),
	foreign key(garrafeira_NIF) references Garrafeira(NIF));

create table cria(
	cliente_nif		int,
	numero_enc		int,
	primary key(cliente_nif, numero_enc),
	foreign key(cliente_nif) references cliente_garrafeira(NIF),
	foreign key(numero_enc) references encomenda_garrafeira(numero));

create table contem(
	quantidade		int,
	bebida_codigo	int,
	numero_enc		int,
	primary key(bebida_codigo,numero_enc),
	foreign key(bebida_codigo) references bebidas_alcoolicas(codigo),
	foreign key(numero_enc) references encomenda_garrafeira(numero));

create table tipo();

