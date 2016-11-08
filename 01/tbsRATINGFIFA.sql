use bdAgencia1
go
CREATE TABLE Atributo
(
codAtributo		int,
atributo		varchar(15),
Constraint PK_Atributo primary key (codAtributo)
)
GO

CREATE TABLE RatingFIFA
(
codJogador		int,
codAtributo		int,
pontuacao		int
CONSTRAINT FK_RatingFIFA_Jogador	foreign key (codJogador)	references jogador	(codJogador),
Constraint fk_RatingFIFA_Atributo	foreign key (codAtributo)	references Atributo	(codAtributo)
)
go
INSERT INTO Atributo
VALUES
(01, 'PAC'),
(02, 'DRI'),
(03, 'SHO'),
(04, 'DEF'),
(05, 'PAS'),
(06, 'PHY')
GO
SELECT * FROM jogador WHERE nome LIKE '%mess%'

---Cristiano Ronaldo
INSERT INTO RatingFIFA
VALUES
(61, 01, 98),
(61, 02, 99),
(61, 03, 99),
(61, 04, 42),
(61, 05, 90),
(61, 06, 89)

---Lionel Messi
INSERT INTO RatingFIFA
VALUES
(10, 01, 97),
(10, 02, 99),
(10, 03, 96),
(10, 04, 41),
(10, 05, 94),
(10, 06, 74)

CREATE TABLE OverallFIFA
(
codJogador	int,
PAC			int,
DRI			int,
SHO			int,
DEF			int,
PAS			int,
PHY			int
Constraint fkOverallFifa_Jogador foreign key (codJogador) references jogador (codJogador)
)
go
select jogador.apelido, OverallFIFA.* from OverallFIFA 
inner join jogador on OverallFIFA.codJogador = jogador.codJogador
order by DRI desc
go
INSERT INTO OverallFIFA
VALUES
--(61, 93, 91, 93, 32, 81, 79),
(11, 90, 92, 80, 30, 72, 58)

use bdAgencia1
select 	jogador.apelido,
		Atributo.atributo,
		RatingFIFA.pontuacao from RatingFIFA
inner join jogador on RatingFIFA.codJogador = jogador.codJogador
inner join Atributo on RatingFIFA.codAtributo = atributo.codAtributo
where atributo.codAtributo = 01 and jogador.codClube = 1 order by RatingFIFA.pontuacao desc

go

create proc insertRating
@codJogador		int,
@PAC			int,
@DRI			int,
@SHO			int,
@DEF			int,
@PAS			int,
@PHY			int
AS
	BEGIN
	insert into RatingFIFA
	values
	(@codJogador, 01, @PAC),
	(@codJogador, 02, @DRI),
	(@codJogador, 03, @SHO),
	(@codJogador, 04, @DEF),
	(@codJogador, 05, @PAS),
	(@codJogador, 06, @PHY)
end
go
CREATE PROC insertOverallFIFA
@codJogador		int,
@PAC			int,
@DRI			int,
@SHO			int,
@DEF			int,
@PAS			int,
@PHY			int
AS
	BEGIN
	INSERT INTO OverallFIFA
	VALUES
	(@codJogador, @PAC, @DRI, @SHO, @DEF, @PAS, @PHY)
END