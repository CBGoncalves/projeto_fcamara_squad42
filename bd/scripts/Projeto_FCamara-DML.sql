-- DML (Data Manipulation Language) 
-- Arquivo para manipulação e adição de dados

USE Projeto_FCamara
GO

INSERT INTO TipoUsuario (TituloTipoUsuario) -- comando para inserir dados ns tabelas de acordo com os atributos
VALUES ('Administrador'), -- comando para definir os valores a serem adicionados
	   ('Consultor');
GO

INSERT INTO Usuario (NomeUsuario,Email,Senha,IdTipoUsuario)
VALUES ('Carlos Eduardo','carlos@gmail.com','carlos1243',2), -- chaves estrangeiras não precisam de aspas simples ''
	   ('Anderson Nuccitelli','anderson@gmail.com','anderson2243',2),
	   ('Júlia Caroline Geib','julia@gmail.com','julia3143',1),
	   ('Esther Wyse de Lucena','esther@gmail.com','esther4243',2);
GO

INSERT INTO TipoAgendamento (TituloTipoAgendamento)
VALUES ('Mesa'),
	   ('Sala de Reunião');
GO

INSERT INTO Escritorio (TituloEscritorio,EnderecoEscritorio)
VALUES ('São Paulo','R. Bela Cintra, 986 - 2° andar'),
	   ('Santos','Prç. dos Expedicionários, 19');
GO

INSERT INTO Turno (TituloTurno)
VALUES ('Manhã'),
	   ('Tarde');
GO

INSERT INTO Agendamento (DataAgendamento,IdUsuario,IdTipoAgendamento,IdEscritorio,IdTurno)
VALUES ('2021-09-10',1,1,1,1),
	   ('2021-09-13',4,2,1,2),
	   ('2021-10-10',2,1,2,1),
	   ('2021-10-09',1,2,1,2);
GO
