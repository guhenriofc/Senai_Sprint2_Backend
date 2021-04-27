-- DQL 

use SENAI_HROADS_TARDE

-- Exerc�cio 5
UPDATE Classes
SET NomeClasse = 'Necromancer'
WHERE IdClasse = 5;

-- Exerc�cio 6
select * from Personagem

-- Exerc�cio 7
SELECT * FROM Classes;

-- Exerc�cio 8
select (NomeClasse) from Classes

-- Exerc�cio 9
SELECT * FROM Habilidades;

-- Exerc�cio 10
select count(Nome) from Habilidades;

-- Exerc�cio 11
SELECT IdHabilidade FROM Habilidades;

-- Exerc�cio 12
select * from Habilidades

-- Exerc�cio 13
SELECT Habilidades.Nome , TipoDeHabilidade.NomeTipo FROM Habilidades
LEFT JOIN TipoDeHabilidade
ON Habilidades.IdHabilidade = TipoDeHabilidade.IdTipoDeHabilidade;

-- Exerc�cio 14
select Personagem.NomePersonagem, Classes.NomeClasse from Personagem
left join Classes
on Classes.IdClasse = Personagem.IdPersonagem

-- Exerc�cio 15
SELECT Personagem.NomePersonagem , Classes.NomeClasse ,
Personagem.CapacidadeVida , Personagem.CapacidadeMana 
FROM Personagem
INNER JOIN Classes
ON Personagem.IdPersonagem = Classes.IdClasse;

-- Exerc�cio 16 
select Classes.NomeClasse, Habilidades.Nome from Classes 
full outer join ClassesHabilidades
on Classes.IdClasse= ClassesHabilidades.IdClasse
full outer join Habilidades
on ClassesHabilidades.IdHabilidade= Habilidades.IdHabilidade;

-- Exerc�cio 17
select Classes.NomeClasse, Habilidades.Nome from Habilidades
inner join ClassesHabilidades
on Habilidades.IdHabilidade = ClassesHabilidades.IdHabilidade
inner join Classes
on ClassesHabilidades.IdClasse = Classes.IdClasse

-- Exerc�cio 18 
select Classes.NomeClasse, Habilidades.Nome from Habilidades
left join ClassesHabilidades
on Habilidades.IdHabilidade = ClassesHabilidades.IdHabilidade
full outer join Classes
on ClassesHabilidades.IdClasse = Classes.IdClasse

SELECT * FROM Usuarios;
SELECT * FROM TipoUsuario;