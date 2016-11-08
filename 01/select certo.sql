use bdAgencia1

create proc seletarAcoesCarlos
@codPartida		int,
@codJogador		int,
@codAcao		int
as 
	begin

		create table #contagem
		(
		codPartida	int,
		codJogador	int,
		quantidade	int
		)

		while @codPartida <= (select Max(partida.codPartida) from partida
inner join escalacao on partida.codPartida = escalacao.codPartida
inner join relacionados on escalacao.codEscalacao = relacionados.codEscalacao
where relacionados.codJogador = @codJogador
)
		begin
			
			insert into #contagem values (@codPartida, @codJogador,(
			select	count(acao.codAcao) as 'Quantidade' from partida 
			inner join escalacao on partida.codPartida = escalacao.codPartida
			inner join relacionados on escalacao.codEscalacao = relacionados.codEscalacao
			inner join jogador on relacionados.codJogador = jogador.codJogador
			inner join acaoPartida on jogador.codJogador = acaoPartida.codJogador
			inner join acao on acaoPartida.codAcao = acao.codAcao
			where jogador.codJogador = @codJogador and partida.codPartida = @codPartida and acao.codAcao = @codAcao
			group by partida.codPartida,acao.nomeAcao
			)
		)
			set @codPartida = @codPartida + 1
		end
		
		select * from #contagem
	end


seletarAcoesCarlos 1,10, 5

select * from partida



select (partida.codPartida) from partida
inner join escalacao on partida.codPartida = escalacao.codPartida
inner join relacionados on escalacao.codEscalacao = relacionados.codEscalacao
where relacionados.codJogador = 10 order by partida.codPartida asc


select acaoPartida.codPartida,
		acao.nomeAcao,
		count(acaoPartida.codAcao) as 'Quantidade'
			from partida 
			inner join escalacao on partida.codPartida = escalacao.codPartida
			inner join relacionados on escalacao.codEscalacao = relacionados.codEscalacao
			inner join jogador on relacionados.codJogador = jogador.codJogador
			inner join acaoPartida on jogador.codJogador = acaoPartida.codJogador
			inner join acao on acaoPartida.codAcao = acao.codAcao
			where relacionados.codJogador = 10 and partida.codPartida = 18 and acaoPartida.codAcao = 5
			group by acaoPartida.codPartida, acao.nomeAcao order by acaoPartida.codPartida asc
			
			
select * from acaoPartida where codJogador = 10 and acaoPartida.codAcao = 1 order by codAcao asc