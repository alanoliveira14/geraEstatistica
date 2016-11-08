use bdAgencia1

select * from esqTatico
select * from jogador where codClube = 1
update jogador set codClube = 1 where codClube = 0
select imagem from clube where codClube = 1


select imagem from jogador
select * from relacionados
select * from escalacao


select imagem from jogador 
inner join relacionados on jogador.codJogador = relacionados.codJogador
inner join posicao on jogador.codPosicao = posicao.codPosicao
where posicao.codPosicao = 1 and relacionados.situacao = 'Titular'
and codEscalacao = (select MAX(codEscalacao) from escalacao)


select imagem from jogador 
inner join relacionados on jogador.codJogador = relacionados.codJogador
where relacionados.situacao = 'Titular'
and codEscalacao = (select MAX(codEscalacao) from escalacao)

select * from acao

select * from acaoPartida

insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao)
values
((select MAX(codPartida) from partida),
(select codjogador from jogador where imagem = 'C:\Users\Dr. Carvalhaes\Pictures\TCC\BayernMunich\manuel2.jpg'),1, '11:11' ,'Confirmada')


select codjogador from jogador where imagem = 'C:\Users\Dr. Carvalhaes\Pictures\TCC\BayernMunich\manuel2.jpg'

insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Stegen.jpg'),3,' : 7', 'Confirmada')

select * from jogador

use bdAgencia1
select imagem from jogador 
inner join relacionados on jogador.codJogador = relacionados.codJogador 
where relacionados.situacao = 'Titular' and codEscalacao = (select MAX(codEscalacao) from escalacao)
and jogador.codJogador = 29

select * from escalacao
select * from relacionados

select imagem from jogador 
inner join relacionados on jogador.codJogador = relacionados.codJogador 
inner join posicao on jogador.codPosicao = posicao.codPosicao where posicao.codPosicao = 1 
and relacionados.situacao = 'Titular' and codEscalacao = (select MAX(codEscalacao) from escalacao)

use bdagencia1
select imagem from jogador
inner join relacionados on jogador.codJogador = relacionados.codJogador
where relacionados.situacao = 'Titular' and codEscalacao = (select MAX(codEscalacao) from escalacao)
and jogador.codPosicao <> 1

select imagem from jogador inner join relacionados on jogador.codJogador = relacionados.codJogador where relacionados.situacao = 'Titular' and codEscalacao = (select MAX(codEscalacao) from escalacao) and jogador.codPosicao <> 1 and jogador.codJogador = 33

select * from jogador
select * from acaoPartida
insert into acaoPartida 
values
((select MAX(codPartida) from partida), 36, 3, '11:11', 'Confirmada')


select imagem from jogador 
inner join relacionados on jogador.codJogador = relacionados.codJogador 
where relacionados.situacao = 'Titular' and 
codEscalacao = (select MAX(codEscalacao) from escalacao) 
and jogador.codPosicao <> 1 and jogador.codJogador = 2

select * from jogador where apelido = 'Messi'
go
select * from acao
select * from acaoPartida
select COUNT(codAcao) from acaoPartida where codAcao = 3 and codJogador = 36


select jogador.apelido, acao.nomeAcao, acaoPartida.tempo from acaoPartida inner join jogador 
on jogador.codJogador = acaoPartida.codJogador
inner join acao on acaoPartida.codAcao = acao.codAcao
where acaoPartida.codPartida = (select MAX(codPartida) from partida)
group by acaoPartida.tempo, jogador.apelido, acao.nomeAcao


select COUNT(codAcao) from acaoPartida where codAcao = 3 and codPartida = (select MAX(codPartida) from partida)

select COUNT(codJogador) from relacionados
where codJogador = 11 and situacao = 'Titular'

select COUNT(*) as Media from acaoPartida where codAcao = 3 / (select COUNT(codJogador) from relacionados where codJogador = 11 and situacao = 'Titular' or situacao = 'Substituido') and codJogador = 11

select * from timeAdversario

select *, estadio.nome, pais.pais, tecnico.apelido as 'nomeTecnico' from clube inner join estadio on estadio.codClube = clube.codClube inner join pais on clube.codPais = pais.codPais inner join tecnico on tecnico.codTecnico = clube.codTecnico where clube.codClube = 3
select * from pais where codPais = 15
use bdAgencia1

select COUNT(codAcao) as 'Gols' from acaoPartida where codAcao = 5 and codPartida = (select MAX(codPartida) from partida)

select * from acao where codAcao = 5
select COUNT(*) from acaoPartida where codAcao = 5 and codJogador = 45

select* from acaoPartida order by codJogador asc

select top 10 * from jogador order by datediff(day,dataNascimento,GETDATE()) desc 

select* from acao

select * from jogador where codPais = 1 and codPosicao = 1

--Qntd de Jogos do Atleta
select COUNT(*) from relacionados where codJogador = 11 and (situacao = 'Titular' or situacao = 'Reserva')

select COUNT(*) as Passes from acaoPartida where (codAcao = 5  or codAcao = 6) and codJogador = 11

select COUNT(*) as Passes from acaoPartida where (codAcao = 6) and codJogador = 11

select COUNT(*) as Passes from acaoPartida where (codAcao = 5) and codJogador = 11


-----------Consulta Partida--------------------------


select * from partida where dataPartida = '28/04/2015'

select * from partida where codCampeonato = 2

select * from partida where codRodada = 3

select * from partida where codAdversario = 1

select * from partida where dataPartida = 12/12/2000 and codCampeonato = 2

-----------Consulta de Jogador por nº de Acao--------------------------
select * from acaoPartida where codAcao = 2

select SUM(codAcao) from acaoPartida where codAcao = 2 order by (select COUNT(*) from jogador)  desc

select COUNT(*) as Passes from acaoPartida where (codAcao = 5  or codAcao = 6) and codJogador = 11


-----------Consulta para carregar a listBox das ações do aovivo--------------------------
use bdAgencia1
go
select top 10 jogador.apelido, acao.nomeAcao, acaoPartida.tempo from acaoPartida inner join jogador on acaoPartida.codJogador = jogador.codJogador inner join acao on acaoPartida.codAcao = acao.codAcao

select imagem from jogador inner join relacionados on jogador.codJogador = relacionados.codJogador where relacionados.situacao = 'Reserva' and codEscalacao = (select MAX(codEscalacao) from escalacao) and jogador.codPosicao <> 1 and jogador.codJogador = 15




---------------------------------------------------------------------------------------------------------------------

select jogador.apelido, acao.nomeAcao, acaoPartida.tempo from acaoPartida 
inner join jogador on acaoPartida.codJogador = jogador.codJogador 
inner join acao on acaoPartida.codAcao = acao.codAcao
where acaoPartida.codPartida = (select MAX(codPartida) from partida) order by tempo desc
select * from jogador where codJogador = 10

select * from acaoPartida where (codAcao = 5 or codAcao = 6) and codJogador = 10
go

select COUNT(*) from acaoPartida where (codAcao = 5 or codAcao = 6) and codJogador = 10 and codPartida = 1

select COUNT(*) from acaoPartida where (codAcao = 5) and codJogador = 10 and codPartida = 18

select * from pais order by pais asc
select codClube, alcunha from clube
select codCampeonato, nome from campeonato

select COUNT(*) as Passes from acaoPartida where (codAcao = 5  or codAcao = 6) and codJogador = 10

-------------------------------------------------------------------------------------------------------------------

select clube.alcunha from clubCamp
inner join clube on ClubCamp.codClube = clube.codClube
inner join campeonato on ClubCamp.codCampeonato = campeonato.codCampeonato where campeonato.codCampeonato = 3

-------------------------------------------------------------------------------------------------------------------
--Consulta Partida

select	partida.dataPartida,
		partida.horario,
		clube.alcunha,
		clube.imagem,
		estadio.nome,
		timeAdversario.alcunha,
		timeAdversario.imagem,
		campeonato.nome,
		rodada.rodada
		from partida 
inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario
inner join clube on clube.codClube = partida.codClube
inner join estadio on partida.codEstadio = estadio.codEstadio
inner join campeonato on partida.codCampeonato = campeonato.codCampeonato
inner join rodada on partida.codRodada = rodada.codRodada
where codPartida = 4

--Contagem das Acoes em det. Paartida
select	COUNT(acaoPartida.codAcao)
		from acaoPartida
inner join acao on acaoPartida.codAcao = acao.codAcao
where codPartida = 18 and acaoPartida.codAcao = 5
group by acao.nomeAcao, acaoPartida.codAcao
order by acaoPartida.codAcao asc

-------
select jogador.apelido,
	   acao.nomeAcao,
	   acaoPartida.tempo 
	   from acaoPartida 
inner join jogador on acaoPartida.codJogador = jogador.codJogador 
inner join acao on acaoPartida.codAcao = acao.codAcao 
--gol, cartao A, V, subst
where acaoPartida.codPartida = 18 and (acaoPartida.codAcao = 1 or acaoPartida.codAcao = 9 or acaoPartida.codAcao = 10)
order by tempo desc
select * from acao

select * from clube inner join ClubCamp on clube.codClube = ClubCamp.codClube where clubCamp.codCampeonato = 1

select * from clube inner join advCamp on advCamp.codTimeAdversario = timeAdversario.codTimeAdversario where advCamp.codCampeonato = 1
select * from advCamp inner join timeAdversario on advCamp.codTimeAdversario = timeAdversario.codTimeAdversario where advCamp.codCampeonato = 1
select * from timeAdversario
select * from advCamp
sp_help advcamp
select jogador.apelido, acao.nomeAcao, acaoPartida.tempo from acaoPartida inner join jogador on acaoPartida.codJogador = jogador.codJogador inner join acao on acaoPartida.codAcao = acao.codAcao where(acaoPartida.codPartida = 18 And (acaoPartida.codAcao = 1 Or acaoPartida.codAcao = 9 Or acaoPartida.codAcao = 10)) order by tempo asc


--------------------------------------------------------------------------
---GRÁFICOS----
----ta errado
select	acaoPartida.codPartida,
		acao.nomeAcao,
		COUNT(acaoPartida.codAcao) as 'Quantidade'
		from partida
		inner join escalacao on partida.codPartida = escalacao.codPartida
		inner join relacionados on escalacao.codEscalacao = relacionados.codEscalacao
		inner join jogador on jogador.codJogador = relacionados.codJogador
		inner join acaoPartida on jogador.codJogador = acaoPartida.codJogador
		inner join acao on acao.codAcao = acaoPartida.codAcao
		where acaoPartida.codJogador = 11 and acaoPartida.codAcao = 1
		group by acaoPartida.codPartida, acao.nomeAcao
		
sp_help jogador
-----------------------------------------------------------------------------------
--VIT por ESQ TATICO
select * from partida where partida.codClube = 2

select * from escalacao where codEsqTatico = 9

select * from acaoPartida

