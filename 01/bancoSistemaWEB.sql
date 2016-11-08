use bdAgencia1
go
create table usuarioWeb
(
codUsuario		int		identity(1,1),
nomeUser		varchar(50),
senha			varchar(20),
dtNasc			date,
email			varchar(50),
codTimeCoracao	int,
CPF				varchar(15)
Constraint pk_UsuarioWeb	primary key(codUsuario),
constraint fk_timeUsuario	foreign key(codTimeCoracao) references clube(codClube)
)

alter table usuarioWeb
alter column dtNasc varchar(10)

select
		clube.alcunha,
		clube.dataFundacao,
		clube.imagem,
		tecnico.nome as 'NomeTecnico',
		estadio.nome as 'NomeEstadio',
		pais.pais from clube 
inner join pais on pais.codPais = clube.codPais
inner join tecnico on tecnico.codTecnico = clube.codTecnico
inner join estadio on estadio.codClube = clube.codClube
where clube.codClube = 1
select * from usuarioWeb where email = 'felipecarlos771@gmail.com'

use bdagencia1
go
select * from cliente