--DQL (Data Query Language) Projeto_FCamara
--Arquivo para consulta das tabelas e dados do banco

-- Define o banco de dados que será utilizado
USE Projeto_FCamara
GO

--LISTAR TODOS OS TIPOS DE USUARIOS CADASTRADOS
SELECT * FROM TipoUsuario
GO

--LISTAR TODOS OS USUARIOS CADASTRADOS
SELECT * FROM Usuario
GO

--LISTAR TODAS AS INSTITUIÇÕES CADASTRADAS
SELECT * FROM TipoAgendamento
GO

--LISTAR TODOS OS TIPOS DE EVENTOS 
SELECT * FROM Escritorio
GO

--LISTAR TODOS OS EVENTOS
SELECT * FROM Turno
GO

--LISTAR APENAS OS EVENTOS QUE SÃO PUBLICOS
SELECT * FROM Agendamento
GO