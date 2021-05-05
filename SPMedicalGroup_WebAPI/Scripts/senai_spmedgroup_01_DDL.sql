CREATE DATABASE SPMedicalGroup;
GO

USE SPMedicalGroup;
GO

CREATE TABLE tiposUsuarios
(
	idTipoUsuario INT PRIMARY KEY IDENTITY
	,nome		  VARCHAR(200) UNIQUE NOT NULL
);
GO

CREATE TABLE usuarios
(
	idUsuario	   INT PRIMARY KEY IDENTITY
	,idTipoUsuario INT FOREIGN KEY REFERENCES tiposUsuarios(idTipoUsuario)
	,nome		   VARCHAR(255) NOT NULL
	,email		   VARCHAR(255) NOT NULL
	,senha		   VARCHAR(100) NOT NULL
);
GO

CREATE TABLE pacientes
(
	idPaciente		INT PRIMARY KEY IDENTITY
	,idUsuario		INT FOREIGN KEY REFERENCES usuarios(idUsuario)
	,dataNascimento	DATE NOT NULL
	,telefone		CHAR(11) 
	,rg				CHAR(9) UNIQUE NOT NULL
	,cpf			CHAR(11) UNIQUE NOT NULL
	,endereco		VARCHAR(255) NOT NULL
);
GO

CREATE TABLE clinicas
(
	idClinica				INT PRIMARY KEY IDENTITY
	,endereco				VARCHAR(255) NOT NULL
	,horarioAbertura		TIME NOT NULL
	,horarioFechamento		TIME NOT NULL
	,cnpj					CHAR(14) UNIQUE NOT NULL
	,nomeFantasia			VARCHAR(255) NOT NULL
	,razaoSocial			VARCHAR(255) NOT NULL
);
GO

CREATE TABLE especialidades
(
	idEspecialidade	INT PRIMARY KEY IDENTITY
	,nome			VARCHAR(255) NOT NULL
);
GO

CREATE TABLE medicos
(
	idMedico		 INT PRIMARY KEY IDENTITY
	,idClinica	   	 INT FOREIGN KEY REFERENCES clinicas(idClinica)
	,idUsuario		 INT FOREIGN KEY REFERENCES usuarios(idUsuario)
	,idEspecialidade INT FOREIGN KEY REFERENCES especialidades(idEspecialidade)
	,crm			 CHAR(7) NOT NULL	 
);
GO

CREATE TABLE consultas
(
	idConsulta		INT PRIMARY KEY IDENTITY
	,idMedico		INT FOREIGN KEY REFERENCES medicos(idMedico)
	,idPaciente		INT FOREIGN KEY REFERENCES pacientes(idPaciente)
	,dataConsulta	DATETIME NOT NULL
	,situacao		VARCHAR(50) DEFAULT('agendada')
);
GO