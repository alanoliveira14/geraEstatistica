use master
go
drop database bdAgencia1
go
create database bdAgencia1
go
use bdAgencia1
go
create table login1
(
id		varchar(10) not null,
senha	varchar(20) not null
)

insert into login1 (id, senha) values ('admin', '123456')

CREATE TABLE [dbo].[funcionario](
	[codFunc] [int] IDENTITY(1,1) NOT NULL,
	[nomeFunc] [varchar](40) NULL,
	[CPF] [varchar](14) NULL,
	[sexo] [varchar](1) NULL,
	[dataNasci] [date] NULL,
	[salario] [money] NULL,
	[codCargo] [int] NULL,
	[CEP] [varchar](10) NULL,
	[numero] [int] NULL,
	[email] [varchar](40) NULL
)


CREATE TABLE [dbo].[cliente](
	[codCliente] [int] IDENTITY(1,1) NOT NULL,
	[clube] [varchar](40) NULL,
	[CNPJ] [varchar](18) NULL,
	[representante] [varchar](40) NULL,
	[sexo] [char](1) NULL,
	[CEP] [varchar](9) NULL,
	[numero] [int] NULL,
	[email] [varchar](40) NULL,
	[telefone] [varchar](14) NULL
)
go

alter table cliente 
add constraint pk_cliente primary key(codCliente) 

alter table funcionario
add constraint pk_func primary key(codFunc) 
--create table contas
--(
--codConta	int identity(1,1),
--descricao	varchar(50),
--valor		money,
--dtEmissao	date,
--dtValidade	date,
--dtPgto		date,
--codFunc		int,
--constraint	
--)

create table pais
(
codPais		int identity(1,1),
pais		varchar(30)
constraint pk_Pais primary key (codPais)
)

create table cidade
(
codCidade	int identity(1,1),
nomeCidade  varchar(30),
codPais		int,
constraint pk_cidade	primary key (codCidade),
constraint fkCidadePais foreign key (codPais) references pais(codPais)
)

create table estiloCampeonato
(
codModo			int not null identity(1,1),
modoDisputa		varchar(20)
constraint pkModo	primary key(codModo))

create table campeonato
(
codCampeonato	int not null identity(1,1),
nome			varchar(30),	
codModo				int
constraint pk_campeonato	primary key (codCampeonato),
constraint pkcodModoCamp	foreign key (codModo) references estiloCampeonato(codModo))

create  table rodada
(
codRodada	int not null identity(1,1),
rodada		varchar(40),
codCampeonato	int
constraint pkRodada		primary key (codRodada),
constraint fkCampRodada foreign key (codCampeonato) references campeonato(codCampeonato))

create table acao
(
codAcao			int not null,
nomeAcao		varchar(20),
constraint pk_acao primary key (codAcao))

create table tecnico
(
codTecnico		int not null identity(1,1),
nome			varchar(50),
dataNascimento	date,
apelido			varchar(30),
codPais			int,
constraint pk_tecnico	primary key (codTecnico),
constraint fk_tec_pais	foreign key (codPais)	references pais (codPais)
)

create table posicao
(
codPosicao		int not null,
nomePosicao		varchar(30),
constraint pk_posicao primary key (codPosicao)
)

create table clube
(
codClube		int not null identity(1,1),
nomeCompleto	varchar(50),
alcunha			varchar(40),
sigla			varchar(3),
imagem			varchar(100),
codTecnico		int not null,
codPais			int,
dataFundacao	date,
vitoria			int null, 
derrota			int null,
empate          int null,
constraint pk_clube			primary key (codClube),
constraint fk_Tecnico		foreign key (codTecnico) references tecnico (codTecnico),
constraint fk_clube_pais	foreign key (codPais)	 references pais	(codPais)
)


create table jogador
(
codJogador		int not null identity(1,1),
nome			varchar(100),
apelido			varchar(30),
dataNascimento	date,
pePredom		char(1),
altura			int,
peso			float,
imagem			varchar(100),
codClube		int,
codPais			int,
codPosicao		int not null,
constraint pk_jogador		primary key (codJogador),
constraint fk_posicao_jog	foreign key (codPosicao)	references posicao,
constraint pk_jog_pais		foreign key (codPais)		references pais  (codPais),
constraint fk_jogClube		foreign key (codClube)		references clube (codClube)
)

create table arbitro
(
codArbitro		int not null identity(1,1),
nomeArbitro		varchar(40),
constraint pk_arbitro primary key (codArbitro))

create table esqTatico
(
codEsqTatico	int not null,
varicaoEsqTatico varchar(30)
constraint pk_esqTatico primary key (codEsqTatico)
)

create table estadio
(
codEstadio		int not null identity(1,1),
nome			varchar(50),
codClube		int,
imagem			varchar(110),
codCidade		int
constraint pk_estadio		primary key (codEstadio),
constraint fk_esta_clube	foreign key (codClube)	references clube	(codClube),
constraint fk_esta_cidade	foreign key (codCidade) references cidade	(codCidade)
)

create table timeAdversario
(
codTimeAdversario	int not null identity(1,1),
nomeComp			varchar(50),
alcunha				varchar(30),
sigla				varchar(3),
imagem				varchar(100),
codPais				int,
constraint pk_codTimeAdversario		primary key (codTimeAdversario),
constraint fk_TimeAdv_Pais			foreign key (codPais) references pais (codPais)
)

create table partida
(
codPartida		int not null identity(1,1),
dataPartida		date,
horario			time,
situacao		varchar(10),
codEstadio		int not null,
codClube		int not null,
codAdversario	int not null,
--codArbitro		int not null,
codCampeonato	int not null,
codRodada		int not null,
constraint pk_partida		primary key (codPartida),
constraint fk_estadio		foreign key (codEstadio)	references estadio			(codEstadio),
constraint fk_partiClube	foreign key (codClube)		references clube			(codclube),
constraint fk_adversario	foreign key (codAdversario)	references timeAdversario	(codTimeAdversario),
--constraint fk_arbitro		foreign key (codArbitro)	references arbitro			(codArbitro),
constraint fk_campeonato	foreign key (codCampeonato) references campeonato		(codCampeonato),
constraint fk_Part_Rodada	foreign key (codRodada)		references rodada			(codRodada)
)

create table detalhePartida
(
--codDetalhe		int not null identity(1,1),
codPartida		int not null,
codAcao			int not null,
quantidade		int,
--constraint pk_detalhe	primary key (codDetalhe),
constraint fk_acao		foreign key (codAcao)		references acao (codAcao),
constraint fk_partida	foreign key (codPartida)	references partida (codPartida)
)

create table acaoPartida
(
codPartida		int not null,
codJogador		int not null,
codAcao			int not null,
tempo			time,
statusAcao		varchar(20) not null,
constraint fk_acaoPar_Par  foreign key (codPartida) references Partida	(codPartida),
constraint fk_acaoPar_Jog  foreign key (codJogador) references Jogador	(codJogador),
constraint fk_acaoPar_Acao foreign key (codAcao)	references Acao		(codAcao)
)

create table escalacao
(
codEscalacao	int not null identity(1,1),
codClube		int,
codEsqTatico	int,
codPartida		int
constraint pk_escalacao				primary key (codEscalacao),
constraint fk_clube					foreign key (codClube)		references clube		(codClube),
constraint fk_esqTaticoEscalacao	foreign key (codEsqTatico)	references esqTatico	(codEsqTatico),
constraint fk_esc_Part				foreign key (codPartida)	references partida		(codPartida)
)

create table relacionados
(
codEscalacao	int,
codJogador		int,
situacao		varchar(30),
obs				varchar(30) null,
constraint fk_rel_esc foreign key (codEscalacao)	references escalacao	(codEscalacao),
constraint fk_rel_jog foreign key (codJogador)		references jogador		(codJogador)
)

create table escalacaoAdv
(
codEscalacaoAdv		int not null identity(1,1),
codEsqTatico		int not null,
codTimeAdversario	int not null,
codPartida			int not null,
constraint pk_EscalacaoAdv		primary key (codEscalacaoAdv),
constraint fk_esqTatico			foreign key (codEsqTatico)		references esqTatico		(codEsqTatico),
constraint fk_timeAdversario	foreign key (codTimeAdversario) references timeAdversario	(codTimeAdversario),
constraint fkEscAdv_Partida		foreign key (codPartida)		references partida			(codPartida)
)

create table relacionadosAdv
(
codEscalacaoAdv		int,
codJogador			int,
situacao			varchar(10),
constraint fkRela_EscalaAdv		foreign key (codEscalacaoAdv)	references escalacaoAdv (codEscalacaoAdv),
constraint fkRela_Jogador		foreign key (codJogador)		references jogador		(codJogador)
)

create table jogEscalacao
(
codEscalacao	int not null,
codPosicao		int not null,
codJogador		int not null,
constraint fk_escalacao			foreign key (codEscalacao)	references escalacao	(codEscalacao),
constraint fk_posicao			foreign key (codPosicao)	references posicao		(codPosicao),
constraint fk_jogadorEscalacao	foreign key (codJogador)	references jogador		(codJogador)
)


create table ClubCamp
(
codCampeonato	int NOT NULL,
codClube		int NOT NULL,
constraint fkClubeCamp_Camp		foreign key (codCampeonato) references campeonato	(codCampeonato),
constraint fkClubeCamp_Clube	foreign key (codClube)		references clube		(codClube)
)

create table advCamp
(
codCampeonato		int,
codTimeAdversario	int,
constraint Camp_Advcamp foreign key (codCampeonato)		references campeonato		(codCampeonato),
constraint Adv_AdvCamp  foreign key (codTimeAdversario) references timeAdversario	(codTimeAdversario)
)

create table contas
(
	codConta			int identity(1,1),
	descricao			varchar(30),
	valor				money,
	dtEmissao			date,
	dtVencimento		date,
	pagara				varchar(30),
	codCliente			int,
	dtPagamento			date,
	codFuncionario		int,
	constraint FK_Cliente		foreign key (codCliente)		references cliente		(codCliente),
	constraint FK_Funcionario	foreign key	(codFuncionario)	references funcionario	(codFunc)
	) 