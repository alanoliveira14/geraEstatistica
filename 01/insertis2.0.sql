use master
go
use bdAgencia1
go
insert into posicao (codPosicao, nomePosicao) values ('01', 'Goleiro')
insert into posicao (codPosicao, nomePosicao) values ('02', 'Zagueiro')
insert into posicao (codPosicao, nomePosicao) values ('03', 'Lateral Direito')
insert into posicao (codPosicao, nomePosicao) values ('04', 'Lateral Esquerdo')
insert into posicao (codPosicao, nomePosicao) values ('05', 'Volante')
insert into posicao (codPosicao, nomePosicao) values ('06', 'Meio Campista')
insert into posicao (codPosicao, nomePosicao) values ('07', 'Meio Armador')
insert into posicao (codPosicao, nomePosicao) values ('08', 'Meio Atacante')
insert into posicao (codPosicao, nomePosicao) values ('09', 'Meia Direita')
insert into posicao (codPosicao, nomePosicao) values ('10', 'Meia Esquerda')
insert into posicao (codPosicao, nomePosicao) values ('11', 'Segundo Atacante')
insert into posicao (codPosicao, nomePosicao) values ('12', 'Centroavante')
insert into posicao (codPosicao, nomePosicao) values ('13', 'Ponta Direita')
insert into posicao (codPosicao, nomePosicao) values ('14', 'Ponta Esquerda')
select * from posicao

insert into cidade
values
('Londres', 27),
('Barcelona', 18),
('Manchester', 27),
('Madrid', 18),
('Paris', 20)
select * from cidade

insert into pais 
Values
('Alemanha'), ('Argentina'), ('Austrália'),('Áustria'), ('Bélgica'), ('Brasil'),('Bósnia Herzegovina'), ('Camarões'), ('Chile'), ('Colômbia'),('Coréia do Sul'), ('Costa do Marfim'), ('Costa Rica'),
('Croácia'), ('Dinamarca'),('Equador'),('Escócia'), ('Espanha'), ('Estados Unidos'), ('França'),('Gabão'),('Gales'),('Gana'), ('Grécia'),('Holanda'),('Honduras'), ('Inglaterra'),('Irlanda'), ('Itália'), ('Japão'),
('México'),('Montenegro'),('Nigéria'),('Noruega'), ('Paraguai'),('Peru'),('Polonia' ),('Portugal'), ('República Tcheca'), ('Rússia'),('Sérvia'), ('Suécia'), ('Suiça'),('Turquia'),('Uruguai'), ('Venezuela')
select * from pais

select codPais, pais from pais order by pais asc

insert into tecnico
values
('José Mário dos Santos Mourinho Félix', '26/01/1963', 'José Mourinho', 22),
('Luís Enrique Martinez Garcia', '08/05/1970','Luis Enrique',12),
('Carlo Michelangelo Ancelotti','10/06/1959','Ancelotti',18),
('Laurent Blanc','1965-11-19','Blanc',20)
select * from tecnico

INSERT INTO [bdAgencia1].[dbo].[clube]
           ([nomeCompleto]
           ,[alcunha]
           ,[sigla]
           ,[imagem]
           ,[codTecnico]
           ,[codPais]
           ,[dataFundacao]
           ,[vitoria]
           ,[derrota]
           ,[empate])
values
('Fútbol Club Barcelona', 'Barcelona', 'BAR', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Barcelona.png', 2, 18,'29/11/1899', 0, 0, 0),
('Chelsea Football Club', 'Chelsea', 'CHE', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Chelsea.png', 1,27,'10/03/1905', 0, 0, 0),
('Paris Saint Germain Football Club','Paris Saint Germain','PSG','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\PSG.png',4,20,'1970-08-12', 0, 0, 0),
('Real Madrid Club de Fútbol', 'Real Madrid', 'RMA', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Madrid.png', 3, 18,'06/03/1902', 0, 0, 0)
select * from clube
SELECT * FROM timeAdversario

update timeAdversario set imagem = 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Barcelona.png' where codTimeAdversario =	1


insert into timeAdversario values
('Chelsea Football Club', 'Chelsea', 'CHE', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Chelsea.png',27),
('Paris Saint Germain Football Club','Paris Saint Germain','PSG','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\PSG.png',20),
('Real Madrid Club de Fútbol', 'Real Madrid', 'RMA', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Madrid.png',18)
select * from timeAdversario

insert into estadio
values
('Stamford Bridge', 2,'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\StamfordBridge.jpg', 1),
('Camp Nou', 1,'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\CampNou.jpg',2),
('Santiago Bernabeu', 3, 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Bernabeu.jpg',4),
('Parc des Princes', 4,'C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\ParcDesPrinces.jpg',5)
select * from estadio

---Barcelona
insert into jogador
values
('Marc-André Ter Stegen', 'Ter Stegen', '30/04/1992', 'D', '187', '85', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Stegen.jpg', 1, 1, 1),
('Gerar Piqué Bernabeu', 'Piqué',  '02/02/1987', 'D', '193', '85', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Pique.jpg', 1, 18, 2),
('Jérémy Mathieu', 'Mathieu',  '29/10/1983', 'D', '189', '84', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Mathieu.jpg', 1,20,2),
('Daniel Alves da Silva', 'Dani Alves',  '06/05/1984','D', '172', '70', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\DaniAlves.jpg', 1,6,3),
('Jordi Alba Ramos', 'Alba', '21/03/1989', 'D', '170', '68', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Alba.jpg', 1,18,4),
('Ivan Rakitic', 'Rakitic', '10/03/1988', 'D', '184', '78', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Rakitic.jpg', 1,14,5),
('Javier Alejandro Mascherano', 'Mascherano', '08/06/1984', 'D', '174', '73', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Mascherano.jpg', 1,2,5),
('Andrés Iniesta Luján', 'Iniesta', '11/05/1984', 'D', '171', '68','C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Iniesta.jpg', 1,18,6),
('Luis Alberto Suárez Díaz', 'Suárez',  '24/01/1987', 'D', '182', '85', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Suarez.jpg', 1,45,12),
('Lionel Andrés Messi', 'Messi',  '24/06/1987', 'E', '170','72','C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Messi.jpg', 1,2,11),
('Neymar da Silva Santos Júnior', 'Neymar',  '05/02/1992', 'D', '174', '68', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Neymar.jpg', 1,6,13),
('Martín Montoya Torralbo', ' Montoya', '14/04/1991', 'D', '174', '72', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Montoya.jpg', 1, 18, 3),
('Sergio Busquets Burgos', 'Busquets', '16/07/1988', 'D', '189', '76', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Busquets.jpg', 1, 18, 5),
('Xavier Hernández Creus', 'Xavi', '25/01/1980', 'D', '170', '67', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Xavi.jpg', 1, 18, 6),
('Pedro Eliezer Rodríguez Ledesma', 'Pedro', '28/07/1987', 'D', '167', '62', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Pedro.jpg', 1, 18, 11),
('Rafael Alcántara do Nascimento', 'Rafinha', '12/02/1993', 'E', '174', '71', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Rafinha.jpg', 1, 6, 7),
('Claudio Andrés Bravo Muñoz', 'Bravo', '13/04/1983', 'D', '184', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Bravo.jpg', 1, 9, 1),
('Marc Bartra Aregall', 'Bartra', '15/01/1991', 'D', '183', '74', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Bartra.jpg', 1, 18, 2),
('Douglas Pereira dos Santos', 'Douglas', '06/08/1990', 'D', '171', '67', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Douglas.jpg', 1, 6, 3),
('Sergi Roberto Carnicer', 'Sergi Roberto', '07/02/1992', 'D', '178', '71', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Sergi.jpg', 1, 18, 7),
('Adriano Correia Claro', 'Adriano', '26/10/1984', 'E', '173', '73', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Adriano.jpg', 1, 6, 4),
('Thomas Vermaelen', 'Vermaelen', '14/11/1985', 'E', '183', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Vermaelen.jpg', 1, 5, 2),
('Jordi Masip López', 'Masip', '03/01/1989', 'D', '179', '72', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Barcelona\Masip.jpg', 1, 18, 1)
select * from jogador inner join clube on jogador.codClube = clube.codClube

use bdAgencia1
---Chelsea
insert into jogador
values
('Petr Cech', 'Cech','20/05/1982', 'E','196', '90', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Cech.jpg', 2,39,1),
('Thibaut Nicolas Marc Courtois', 'Courtois', '11/05/1992', 'E', '199','91','C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Courtois.jpg', 2, 5, '1'),
('Gary James Cahill', 'Cahill', '19/12/1985','D', '193', '86', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Cahill.jpg', 2, 27,'2'),
('John George Terry', 'Terry', '07/12/1980','D', '187', '90', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Terry.jpg', 2, 27, '2'),
('Kurt Happy Zouma', 'Zouma', '27/10/1994', 'D', '190', '92', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Zouma.jpg', 2,20,2),
('Branislav Ivanovic', 'Ivanovic', '22/02/1984', 'D', '185', '91', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Ivanovic.jpg', 2, 41,'3'),
('César Azpilicueta Tanco', ' Azpilicueta',  '28/08/1989', 'D', ' 178', '75', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Azpilicueta.jpg', 2, 18, '4'),
('Filipe Luís Kasmirski', 'Filipe Luis', '09/08/1985', 'E', '188', '77', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\FilipeLuis.jpg', 2,6,4),
('Nemanja Matic', 'Matic', '01/08/1988','E', '194', '84', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Matic.jpg', 2, 41, '5'),
('Francesc Fàbregas i Soler', 'Cesc Fabregas','04/05/1987', 'D', '175', '74', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Fabregas.jpg', 2, 18, '6'),
('Ramires Santos do Nascimento', 'Ramires', ' 23/03/1987','D', '180', '70','C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Ramires.jpg', 2,6,6),
('Oscar dos Santos Emboaba Júnior', 'Oscar',  '09/09/1991', 'D', '179', '67', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Oscar.jpg', 2, 6, '7'),
('Juan Guillermo Cuadrado Bello', 'Cuadrado', '26/05/1988','D', '176','66','C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Cuadrado.jpg', 2,10,9),
('Willian Borges da Silva', 'Willian', '09/08/1988', 'D', '175', '75', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Willian.jpg', 2, 6, '9'),
('Eden Michael Hazard', 'Hazard', '07/01/1991', 'D', '173', '74', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Hazard.jpg', 2, 5, '10'),
('Didier Yves Drogba Tébily', 'Drogba','11/03/1978','D','189','91','C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Drogba.jpg', 2,12,12),
('Diego da Silva Costa', 'Diego Costa', '07/10/1988', 'D', '188', '85', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\DiegoCosta.jpg', 2,18, '12'),
('Loic Remy', 'Remy','02/01/1987', 'D','185', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Chelsea\Remy.jpg', 2,20,12)
select * from jogador where codClube = 2

----Real
insert into jogador
values
('Iker Casillas Fernández', 'Casillas', '20/05/1981', 'E', '185', '84', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Casillas.jpg', 3, 18, 1),
('Keylor Antonio Navas Gamboa', ' Keylor Navas', '15/12/1986', 'D', '185', '78', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Navas.jpg', 3, 13, 1),
('Fernando Pacheco Flores', 'Pacheco', '18/05/1992', 'D', '186', '81', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Pacheco.jpg', 3, 18, 1),
('Sergio Ramos García', 'Sergio Ramos', '30/03/1986', 'D', '183', '75', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\SergioRamos.jpg', 3, 18, 2),
('Képler Laveran Lima Ferreira', 'Pepe', '26/02/1983', 'D', '188', '81', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Pepe.jpg', 3, 38, 2),
('Raphaël Varane', 'Varane', '25/04/1993', 'D', '191', '78', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Varane.jpg', 3,20, 2),
('Álvaro Arbeloa Coca', 'Arbeloa',  '17/01/1983', 'D', '184', '79', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Arbeloa.jpg', 3, 18, 3),
('Daniel Carvajal Ramos', 'Carvajal', '11/01/1992', 'D', '173', '73', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Carvajal.jpg', 3,18,3),
('Fábio Alexandre da Silva Coentrão', ' Coentrão','11/03/1988', 'E', '179', '70','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Coentrao.jpg', 3,38, 4),
('Marcelo Vieira da Silva', 'Marcelo', '12/05/1988', 'E', '174', '75','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Marcelo.jpg', 3,6,4),
('José Fernández Iglesias', 'Nacho', '18/01/1990', 'E', '179', '75','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Nacho.jpg', 3,18,4),
('Sami Khedira', 'Khedira', '04/04/1987', 'D', '189', '85','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Khedira.jpg', 3,1,5),
('Toni Kroos', 'Kroos', '04/01/1990', 'D', '182', '78','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Kroos.jpg', 3,1,5),
('Lucas Silva Borges', 'Lucas Silva', '16/02/1993','D','182','80','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\LucasSilva.jpg', 3,6,5),
('Asier Illarramendi Andonegi', 'Illarra', '08/03/1990', 'D','179','76','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Illarra.jpg',3,18,6),
('Francisco Román Alarcón Suárez', 'Isco', '21/04/1992','D','176','74','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Isco.jpg',3,18,8),
('James David Rodríguez Rubio', 'James Rodríguez','12/07/1991', 'E', '180', '75','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\James.jpg',3,10,7),
('Gareth Frank Bale', 'Bale','16/07/1989','E','183','74','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Bale.jpg',3,22,13),
('Luka Modric', 'Modric', '09/09/1985', 'D','174', '65','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Modric.jpg', 3,14,6),
('Cristiano Ronaldo dos Santos Aveiro', 'Cristiano Ronaldo','05/02/1985','D','185','80','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\AFera.jpg',3,38,14),
('Karim Mostafa Benzema', 'Benzema', '19/12/1987', 'D','187','79','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Benzema.jpg',3,20,12),
('Jesé Rodríguez Ruiz', 'Jesé', '26/02/1993', 'D','178','73','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Jese.jpg',3,18,11),
('Javier Hernández', 'Chicharito', '01/06/1988', 'D','175','71','C:\Users\Dr. Carvalhaes\Pictures\TCC\Real\Chicharito.jpg',3,31,12)


----PSG
insert into jogador
values
('Salvatore Sirigu','Sirigu','1987-01-12','D','192','80','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Sirigu.jpg',4,29,1),
('Nicolas Douchez','Douchez','1980-04-22','D','186','81','C:\Users\Dr. Carvalhaes\Pictures\TCC\Douchez.jpg',4,20,1),
('Mike Maignan','Maignan','1995-07-03','D','187','80','C:\Users\Dr. Carvalhaes\Pictures\TCC\Maignan.jpg',4,20,1),
('Mory Diaw','Diaw','1993-06-22','D','195','95','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Diaw.jpg',4,20,1),
('David Luiz Moreira Marinho','David Luiz','1987-04-22','D','189','84','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\DavidLuiz.jpg',4,6,2),
('Thiago Emiliano da Silva','Thiago Silva','1984-09-22','D','183','79','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\ThiagoSilva.jpg',4,6,2),
('Marcos Aoás Corrêa','Marquinhos','1994-05-14','D','183','75','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Marquinhos.jpg',4,6,2),
('Zoumana Camara','Camara','1979-04-03','D','182','76','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Camara.jpg',4,20,2),
('Gregory Kurtley van der Wiel','Van Der Wiel','1988-02-03','D','181','69','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\VanDerWiel.jpg',4,25,3),
('Serge Aurier','Aurier','1992-12-24',	'D','176','76',	'C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Aurier.jpg',4,12,3),
('Maxwell Scherrer Cabelino Andrade','Maxwell','1981-08-27','E','176','73','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Maxwell.jpg',4,6,4),
('Lucas Digne','Digne','1993-07-20','E','178','74','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Digne.jpg',4	,20,4),
('Blaise Matuidi','Matuidi','1987-04-09','E','175','70','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Matuidi.jpg',4,20,5),
('Marco Verratti','Verratti','1992-11-05','D','165','60','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Verratti.jpg',4,29,5),
('Thiago Motta','Thiago Motta','1982-08-28','E','187','83','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\ThiagoMotta.jpg',4,29,5),
('Adrien Rabiot','Rabiot','1995-04-03','E','188','71','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Rabiot.jpg',4,20,5),
('Yohan Cabaye','Cabaye','1986-01-14','D','175','72','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Cabaye.jpg',4,20,6),
('Javier Matías Pastore','Pastore','1989-06-20','D','187','78','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Pastore.jpg',4,2,8),
('Edinson Roberto Cavani Gómez','Cavani','1987-02-14','D','184','71','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Cavani.jpg',4,45,12),
('Zlatan Ibrahimovic','Ibrahimovic','1981-10-03','D','195','95','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Zlatan.jpg',4,42,12),
('Jean Christophe Bahebeck','Bahebeck','1993-05-01','D','182','76','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Bahebeck.jpg',4,20,12),
('Lucas Rodrigues Moura da Silva','Lucas','1992-08-13','D','172','72','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Lucas.jpg',4,6,13),
('Ezequiel Iván Lavezzi','Lavezzi','1985-05-03','D','173','75','C:\Users\Dr. Carvalhaes\Pictures\TCC\PSG\Lavezzi.jpg',4,2,14)
select * from jogador order by codPosicao asc


----CITY

insert into jogador
values
('Richard Wright', 'Richard Wright', '05/11/1977', 'D', '188', '83', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Wright.jpg', 5, 27, 1),
('Eliaquim Hans Mangala', 'Mangala', '13/02/1991', 'E', '187', '78', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Mangala.jpg', 5,20,2),
('Dedryck Boyata', 'Boyata', '28/11/1990', 'D', '188', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Boyata.jpg', 5,5,2),
('Gaël Clichy', 'Clichy', '26/06/1985', 'E', '181', '72', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Clichy.jpg', 5,20,4),
('Scott Andrew Sinclair', 'Sinclair', '25/03/1989', 'D', '178', '68', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Sinclair.jpg', 5,27,11),
('Stevan Jovetic', 'Jovetic', '02/11/1989', 'D', '183', '76', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Jovetic.jpg', 5,32,12),
('Charles Joseph John Hart', 'Joe Hart', '19/04/1987', 'E', '196', '91', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Hart.jpg', 5,27,1),
('Bacary Sagna', 'Sagna', '14/02/1983', 'D', '176', '72', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Sagna.jpg', 5,20,3),
('Vicent Jean Mpoy Kompany', 'Kompany', '10/04/1986', 'D', '193', '83', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Kompany.jpg', 5,5,2),
('Martín Gastón Demichelis', 'Demichelis', '20/12/1980', 'D', '184', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Demichelis.jpg', 5,2,2),
('Aleksandar Kolarov', 'Kolarov', '10/11/1985', 'E', '187', '84', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Kolarov.jpg', 5,41,4),
('Gnégnéri Yaya Touré', 'Yaya Touré', '13/05/1983', 'D', '188', '90', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Touré.jpg', 5,12,5),
('Fernando Luiz Roza', ' Fernandinho', '04/05/1985', 'D', '176', '66', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Fernandinho.jpg', 5,6,5),
('Samir Nasri', 'Nasri', '26/06/1987', 'D', '177', '75', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Nasri.jpg', 5,20,8),
('James Philip Milner', 'Milner', '04/01/1986', 'D',  '175', '70', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Milner.jpg', 5,27,6),
('David Josué Jiménez Silva', 'David Silva', '08/01/1986', 'E',  '173', '67', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Silva.jpg', 5,18,7),
('Sergio Leonel Agüero Del Castillo ', 'Agüero', '02/06/1988', 'D',  '173', '77', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Aguero.jpg', 5,2,12),
('Wilfredo Daniel Caballero', 'Caballero', '28/09/1981', 'D',  '186', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Caballero.jpg', 5,2,1),
('Pablo Javier Zabaleta', 'Zabaleta', '16/01/1985', 'D',  '176', '76', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Zabaleta.jpg', 5,2,3),
('Fernando Francisco Reges', 'Fernando', '25/07/1987', 'D', '183', '74', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Fernando.jpg', 5,6,5),
('Jesús Navas González', 'Jesús Navas', '21/11/1985', 'D', '172', '64', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Navas.jpg', 5,18,9),
('Frank James Lampard Junior', 'Lampard', '20/06/1978', 'D', '184', '88', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Lampard.jpg', 5,27,7),
('Edin Dzeko', 'Dzeko', '17/03/1986', 'D', '193', '80', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Dzeko.jpg',5,7,12),
('Wilfried Guemiand Bony', 'Bony', '10/12/1988', 'D', '182', '86', 'C:\Users\Dr. Carvalhaes\Pictures\TCC\ManCity\Bony.jpg', 5,12,12)


insert into esqTatico
values
(1, '3-2-3-2'),
(2, '3-5-1-1'),
(3, '3-1-3-3'),
(4, '3-4-2-1'),
(5, '3-4-1-2'),
(6, '3-1-4-2'),
(7, '4-5-1'),
(8, '4-4-1-1'),
(9, '4-3-3'),
(10, '4-3-2-1'),
(11, '4-3-1-2'),
(12, '4-2-3-1'),
(13, '4-2-2-2'),
(14, '4-1-4-1'),
(15, '4-1-3-2'),
(16, '5-4-1'),
(17, '5-3-2'),
(18, '5-2-2-1'),
(19, '5-2-1-2')

insert into acao
values
(1, 'Gol'),
(2,'Chute'),
(3,'Chute à gol'),
(4,'Assistencia'),
(5,'Passe certo'),
(6,'Passe errado'),
(7,'Falta cometida'),
(8,'Falta sofrida'),
(9,'Cartão amarelo'),
(10,'Cartão vermelho'),
(11,'Lesao'),
(12,'Impedimento'),
(13,'Escanteio'),
(14,'Substituido'),
(15,'Penalti Sofrido'),
(16,'Penalti Cometido'),
(17,'Penalti Convertido'),
(18,'Penalti Perdido'),
(19,'Penalti Defendido'),
(20,'Defesa'),
(21,'Defesa Difícil'),
(22,'Desarme'),
(23,'Lançamento'),
(24,'Cruzamento'),
(25,'Gol Sofrido'),
(26,'Substituiu')
select * from acao

--insert into arbitro
--values
--('Arnaldo César Coelho'),
--('Leonardo Gaciba'),
--('Carlos Eugênio Simon'),
--('Heber Roberto Lopes')
--select * from arbitro

insert into estiloCampeonato
values
('Pontos Corridos'),
('Mata-Mata'),
('Misto')
select * from estiloCampeonato

insert into campeonato
values
('Liga BBVA - Espanhol', 01),
('Liga Bundesliga - Alemão', 01),
('UEFA Champions League', 3),
('BPL - Inglês', 01),
('Camp Brasileiro', 01)
select * from campeonato

insert into rodada
values
('Rodada 1', 01),
('Rodada 2', 01),
('Rodada 3', 01),
('Rodada 4', 01),
('Rodada 5', 01),
('Rodada 6', 01)
select * from rodada

insert into rodada
values
('Rodada 1', 2),
('Rodada 2', 2),
('Rodada 3', 2),
('Rodada 4', 2),
('Rodada 5', 2),
('Rodada 6', 2)
select * from rodada

insert into rodada
values
('Fase de Grupos - Rodada 1', 3),
('Fase de Grupos - Rodada 2', 3),
('Fase de Grupos - Rodada 3', 3),
('Fase de Grupos - Rodada 4', 3),
('Fase de Grupos - Rodada 5', 3),
('Fase de Grupos - Rodada 6', 3),
('Oitavas de Final', 3),
('Quartas de Final', 3),
('Semi Final', 3),
('Final', 3)
select * from rodada
select * from campeonato
select * from clube
insert into clubCamp
values
(1,1),
(1,4),
(3,1),
(3,2),
(3,3),
(3,4),
(4,2)
select clube.alcunha, campeonato.nome from ClubCamp inner join campeonato on ClubCamp.codCampeonato = campeonato.codCampeonato inner join clube on ClubCamp.codClube =clube.codClube

insert into advCamp
values
(1,1),	(1,4),
(3,1),	(3,2),	(3,3),	(3,4),
(4,2)

--------------------------------------------------------------------------------------------------------------------------------