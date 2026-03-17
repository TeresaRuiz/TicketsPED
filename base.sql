IF EXISTS (SELECT name FROM sys.databases WHERE name = 'BD_Tickets')
BEGIN
    DROP DATABASE BD_Tickets;
END
GO

CREATE DATABASE BD_Tickets;
GO

USE BD_Tickets;
GO

CREATE TABLE Roles (
    IdRol INT IDENTITY PRIMARY KEY,
    NombreRol VARCHAR(50) NOT NULL
);

CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Usuario VARCHAR(50) UNIQUE NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    Contrasena VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL,
    FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
);

CREATE TABLE Estados (
    IdEstado INT IDENTITY PRIMARY KEY,
    NombreEstado VARCHAR(50) NOT NULL
);

CREATE TABLE Prioridades (
    IdPrioridad INT IDENTITY PRIMARY KEY,
    NombrePrioridad VARCHAR(50) NOT NULL
);

CREATE TABLE Tickets (
    IdTicket INT IDENTITY PRIMARY KEY,
    IdUsuario INT NOT NULL,
    Titulo VARCHAR(100) NOT NULL,
    Descripcion VARCHAR(255),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    IdEstado INT NOT NULL,
    IdPrioridadUsuario INT NOT NULL,
    IdPrioridadReal INT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario),
    FOREIGN KEY (IdEstado) REFERENCES Estados(IdEstado),
    FOREIGN KEY (IdPrioridadUsuario) REFERENCES Prioridades(IdPrioridad),
    FOREIGN KEY (IdPrioridadReal) REFERENCES Prioridades(IdPrioridad)
);

CREATE TABLE HistorialCambios (
    IdHistorial INT IDENTITY PRIMARY KEY,
    IdTicket INT NOT NULL,
    IdAdmin INT NOT NULL,
    FechaCambio DATETIME DEFAULT GETDATE(),
    CampoModificado VARCHAR(50),
    ValorAnterior VARCHAR(100),
    ValorNuevo VARCHAR(100),
    FOREIGN KEY (IdTicket) REFERENCES Tickets(IdTicket),
    FOREIGN KEY (IdAdmin) REFERENCES Usuarios(IdUsuario)
);

INSERT INTO Roles (NombreRol) VALUES ('Admin');
INSERT INTO Roles (NombreRol) VALUES ('Cliente');

INSERT INTO Estados (NombreEstado) VALUES ('Abierto');
INSERT INTO Estados (NombreEstado) VALUES ('En proceso');
INSERT INTO Estados (NombreEstado) VALUES ('Cerrado');

INSERT INTO Prioridades (NombrePrioridad) VALUES ('Baja');
INSERT INTO Prioridades (NombrePrioridad) VALUES ('Media');
INSERT INTO Prioridades (NombrePrioridad) VALUES ('Alta');
