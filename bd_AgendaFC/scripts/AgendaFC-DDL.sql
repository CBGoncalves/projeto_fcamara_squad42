--DDL (Data Definition Language) Projeto_FCamara
--Arquivo para criação e interação com os objetos do banco

-- Cria o banco de dados com o nome Projeto_FCamara
CREATE DATABASE AgendaFC
-- Comando GO responsavel por informar até onde deve ser processado com uma batch
GO

-- Define o banco de dados que será utilizado
USE AgendaFC
GO

-- Criação de tabelas
CREATE TABLE TipoUsuario (
	IdTipoUsuario INT PRIMARY KEY IDENTITY -- Indentifica o atributo como chave primaria
	,TituloTipoUsuario VARCHAR (50) NOT NULL UNIQUE -- Atributo do tipo texto com maximo de 50 caracteres, nao nulo e unico
);
GO

CREATE TABLE Usuario (
	IdUsuario INT PRIMARY KEY IDENTITY
	,NomeUsuario VARCHAR (50) NOT NULL
	,Email VARCHAR (50) NOT NULL UNIQUE
	,Senha VARCHAR (50) NOT NULL
	,IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario) -- Indentifica o atributo como chave estrangeira da tabela TipoUsuario
);
GO

CREATE TABLE TipoAgendamento (
	IdTipoAgendamento INT PRIMARY KEY IDENTITY
	,TituloTipoAgendamento VARCHAR (50) NOT NULL UNIQUE 
);
GO

CREATE TABLE Escritorio (
	IdEscritorio INT PRIMARY KEY IDENTITY
	,TituloEscritorio VARCHAR (50) NOT NULL
	,EnderecoEscritorio VARCHAR (250) NOT NULL UNIQUE
);
GO

CREATE TABLE Turno (
	IdTurno INT PRIMARY KEY IDENTITY
	,TituloTurno VARCHAR (50) NOT NULL UNIQUE
);
GO

CREATE TABLE Agendamento (
	IdAgendamento INT PRIMARY KEY IDENTITY
	,DataAgendamento DATE NOT NULL -- Atributo do tipo date para datas
	,IdUsuario INT FOREIGN KEY REFERENCES Usuario (IdUsuario)
	,IdTipoAgendamento INT FOREIGN KEY REFERENCES TipoAgendamento (IdTipoAgendamento)
	,IdEscritorio INT FOREIGN KEY REFERENCES Escritorio (IdEscritorio)
	,IdTurno INT FOREIGN KEY REFERENCES Turno (IdTurno)
);
GO

