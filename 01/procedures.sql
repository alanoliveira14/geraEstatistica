----Procedures de insert-------

-------tecnico
use bdAgencia1
create proc insertTecnico
@nome		varchar(150),
@dtNasc		date,
@apelido	varchar(50),
@codPais	int
as begin
insert into tecnico
values (@nome, @dtNasc, @apelido, @codPais)
end

---clube
create proc insertClube
@nomeCompleto	varchar(100),
@alcunha		varchar(60),
@sigla			varchar(3),
@imagem			varchar(160),
@codTecnico		int,
@codPais		int,
@dataFundacao	date
as begin
	insert into clube
	values
	(
	@nomeCompleto, @alcunha, @sigla, @imagem, @codTecnico, 
	@codPais, @dataFundacao, 0, 0, 0
	)
end

---Time Adversario
create proc insertTimeAdv
@nomeComp		varchar(100),
@alcunha		varchar(60),
@sigla			varchar(3),
@imagem			varchar(160),
@codPais		int
as begin
	insert into timeAdversario
	values
	(
	@nomeComp, @alcunha, @sigla, @imagem, @codPais)
end


---jogador
create proc insertJogador
@nome		varchar(100),
@apelido	varchar(50),
@dataNascimento	date,
@pePredom	char(1),
@altura		int,
@peso		int,
@imagem		varchar(100),
@codClube	int,
@codPais	int,
@codPosicao	int
as begin
	insert into jogador
	values
	(
	@nome, @apelido, @dataNascimento, @pePredom,
	@altura, @peso, @imagem, @codClube, @codPais, @codPosicao
	)
end


---campeonato

create proc insertCampeonato
@nome		varchar(50),
@codModo	int
as begin
insert into campeonato
values
(@nome, @codModo)
end


-----estadio
create proc insertEstadio
@nome		varchar(50),
@codClube	int,
@imagem		varchar(100),
@codCidade	int
as begin
insert into estadio
values
(@nome, @codClube, @imagem, @codCidade)
end

---cidade
create proc insertCidade
@nomeCidade		varchar(50),
@codPais		int
as begin
insert into cidade
values
(@nomeCidade, @codPais)
end


---pais
create proc insertPais
@nomePais	varchar(30)
as begin
insert into pais
values
(@nomePais)
end


create proc insertPartida
@dataPartida		date,
@horario			time,
@situacao			varchar(15),
@codEstadio			int,
@codClube			int,
@codAdversario		int,
@codCampeonato		int,
@codRodada			int
as begin
insert into partida
values
(@dataPartida, @horario, @situacao, 
@codEstadio, @codClube, @codAdversario,
@codCampeonato, @codRodada)
end
--------------------------------------------------------------------------------------------------------
-------------TOP 10------------------
create proc ContaAcaoMundial
@codAcao	int,
@count		int = 0
	as begin
		create table #tmpJogador
		(codJogador int,
		qntd		int
		)
		while @count < (select COUNT(*) from jogador)
		begin
		insert into #tmpJogador values
		(@count, (select COUNT(*) from acaoPartida where codAcao = @codAcao and codJogador = @count))	
		set @count = @count + 1
		end		
		select top 15 jogador.apelido as 'Jogador' , #tmpJogador.qntd as 'Quantidade' from #tmpJogador inner join jogador on #tmpJogador.codJogador = jogador.codJogador group by apelido, qntd order by qntd desc
	end

ContaAcaoMundial 22
--------------------------------
select * from acao

create procedure contaAcaoRestritoTodos
@codAcao	int,
@codClube	int,
@codCampe   int,
@codJogador int = 0
as begin
		create table #tmpJogador
		(codJogador int,
		qntd		int
		)
		while @codJogador < (select COUNT(*) from jogador)
		begin
			insert into #tmpJogador values
			(@codJogador,
			(select COUNT(*) from acaoPartida inner join partida on acaoPartida.codPartida = partida.codPartida 
				where partida.codCampeonato = @codCampe
				and acaoPartida.codAcao = @codAcao
				and acaoPartida.codJogador = @codJogador
				and partida.codClube = @codClube
			))
		set @codJogador = @codJogador + 1
end
		select top 10 jogador.apelido as 'Jogador' , #tmpJogador.qntd as 'Quantidade' from #tmpJogador inner join jogador on #tmpJogador.codJogador = jogador.codJogador group by apelido, qntd order by qntd desc
end


-------------------------

create procedure contaAcaoRestritoCamp
@codAcao	int,
@codCampe   int,
@codJogador int = 0
as begin
		create table #tmpJogador
		(codJogador int,
		qntd		int
		)
		while @codJogador < (select COUNT(*) from jogador)
		begin
			insert into #tmpJogador values
			(@codJogador,
			(select COUNT(*) from acaoPartida inner join partida on acaoPartida.codPartida = partida.codPartida 
				where partida.codCampeonato = @codCampe
				and acaoPartida.codAcao = @codAcao
				and acaoPartida.codJogador = @codJogador
			))
		set @codJogador = @codJogador + 1
end
		select top 10 jogador.apelido as 'Jogador' , #tmpJogador.qntd as 'Quantidade' from #tmpJogador inner join jogador on #tmpJogador.codJogador = jogador.codJogador group by apelido, qntd order by qntd desc
end


----------------------------------------------------------

create procedure contaAcaoRestritoClube
@codAcao	int,
@codClube	int,
@codJogador int = 0
as begin
		create table #tmpJogador
		(codJogador int,
		qntd		int
		)
		while @codJogador < (select COUNT(*) from jogador)
		begin
			insert into #tmpJogador values
			(@codJogador,
			(select COUNT(*) from acaoPartida inner join partida on acaoPartida.codPartida = partida.codPartida 
				where acaoPartida.codAcao = @codAcao
				and acaoPartida.codJogador = @codJogador
				and partida.codClube = @codClube
			))
		set @codJogador = @codJogador + 1
end
		select top 10 jogador.apelido as 'Jogador' , #tmpJogador.qntd as 'Quantidade' from #tmpJogador inner join jogador on #tmpJogador.codJogador = jogador.codJogador group by apelido, qntd order by qntd desc
end

contaAcaoRestritoClube 1, 2


select * from clube