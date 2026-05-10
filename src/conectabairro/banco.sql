
CREATE DATABASE YouMovies4;
GO

USE YouMovies4;
GO


CREATE TABLE Generos (
    Id      INT IDENTITY(1,1) PRIMARY KEY,
    Nome    NVARCHAR(100) NOT NULL
);
GO


CREATE TABLE Usuarios (
    Id              INT IDENTITY(1,1) PRIMARY KEY,
    Nome            NVARCHAR(150)   NOT NULL,
    Email           NVARCHAR(200)   NOT NULL UNIQUE,
    SenhaHash       NVARCHAR(256)   NOT NULL,
    DataNascimento  DATE            NOT NULL,
    DataCadastro    DATETIME        NOT NULL DEFAULT GETDATE()
);
GO


CREATE TABLE UsuarioGeneros (
    UsuarioId   INT NOT NULL REFERENCES Usuarios(Id) ON DELETE CASCADE,
    GeneroId    INT NOT NULL REFERENCES Generos(Id)  ON DELETE CASCADE,
    PRIMARY KEY (UsuarioId, GeneroId)
);
GO


INSERT INTO Generos (Nome) VALUES
    ('Ação'),
    ('Comédia'),
    ('Drama'),
    ('Terror'),
    ('Ficção Científica'),
    ('Romance'),
    ('Animação'),
    ('Documentário');
GO