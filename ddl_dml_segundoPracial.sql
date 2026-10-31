CREATE DATABASE Parcial2Mmc;
GO
USE master
GO
CREATE LOGIN usrparcial2 WITH PASSWORD = N'12345678',
    DEFAULT_DATABASE = Parcial2Mmc, 
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON;
GO
USE Parcial2Mmc;
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE [db_owner] ADD MEMBER usrparcial2
GO

DROP TABLE IF EXISTS HorarioPrograma;
DROP TABLE IF EXISTS Canal;

-- Canal

CREATE TABLE Canal (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    frecuencia VARCHAR(20) NOT NULL,
    
);
GO

--HorarioPrograma

CREATE TABLE HorarioPrograma (
    id INT IDENTITY(1,1) PRIMARY KEY,
    idCanal INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    horaInicio TIME NOT NULL,
    horaFin TIME NOT NULL,
    diaSemana VARCHAR(20) NOT NULL,
    conductorPrincipal VARCHAR(100) NOT NULL,
   

    CONSTRAINT FK_HorarioPrograma_Canal FOREIGN KEY (idCanal) REFERENCES Canal(id)
);
GO

--Auditoría y estado

ALTER TABLE Canal ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Canal ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Canal ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE HorarioPrograma ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE HorarioPrograma ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE HorarioPrograma ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

--Procedimiento de Almacenado Canal

DROP PROC IF EXISTS paCanalListar;
GO
CREATE PROC paCanalListar @parametro VARCHAR(50)
AS
    SELECT c.id, c.nombre, c.frecuencia, c.estado
    FROM Canal c
    WHERE c.estado = 1
      AND c.nombre + c.frecuencia
      LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY c.nombre;
GO

EXEC paCanalListar '5';

--Procedimiento de Almacenado HorarioPrograma

DROP PROC IF EXISTS paHorarioProgramaListar;
GO

CREATE PROC paHorarioProgramaListar @parametro VARCHAR(50)
AS
    SELECT
        hp.id,
        hp.idCanal,
        c.nombre AS canal,
        hp.titulo,
        hp.horaInicio,
        hp.horaFin,
        hp.diaSemana,
        hp.conductorPrincipal,
        hp.fechaRegistro,
        hp.usuarioRegistro,
        hp.estado
    FROM HorarioPrograma hp
    INNER JOIN Canal c ON c.id = hp.idCanal
    WHERE hp.estado = 1
      AND c.nombre + hp.titulo + hp.diaSemana +
          hp.conductorPrincipal +
          CONVERT(VARCHAR(5), hp.horaInicio, 108) +
          CONVERT(VARCHAR(5), hp.horaFin, 108)
          LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
    ORDER BY hp.titulo;
GO


EXEC paHorarioProgramaListar '15:00';

-- DML

INSERT INTO Canal (nombre, frecuencia)
VALUES
('ESPN', 'Canal 509'), --9
('ESPN 2', 'Canal 510'), --10
('FOX Sports', 'Canal 497'), --11
('D Sports', 'Canal 514'); --12

INSERT INTO HorarioPrograma (idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal)
VALUES
(1, 'ESPN Recuerdos', '09:00', '10:15', 'Lunes', 'Carlos Rojas'),
(3, 'Central Deportes', '12:00', '13:50', 'Lunes', 'Maria Perez'),
(2, 'Siempre Fútbol', '08:00', '09:00', 'Martes', 'Juan Lopez'),
(3, 'Deportes Extremos', '15:00', '16:00', 'Miercoles', 'Pedro Vargas'),
(4, 'Medio Campo', '12:00', '13:00', 'Jueves', 'Ana Flores'),
(4, 'Entrevistas Deportivas', '07:00', '08:30', 'Viernes', 'Laura Mendoza'),
(1, 'Domingo Deportivo', '07:00', '08:30', 'Domingo', 'Mauricio Casillas');

SELECT * FROM Canal;
SELECT * FROM HorarioPrograma;

SELECT
    id,idCanal, titulo, diaSemana, conductorPrincipal, usuarioRegistro, fechaRegistro, estado,
    CONVERT(VARCHAR(5), horaInicio, 108) AS horaInicio,
    CONVERT(VARCHAR(5), horaFin, 108) AS horaFin
FROM HorarioPrograma;

DELETE FROM HorarioPrograma;
DELETE FROM Canal;
DELETE FROM Canal WHERE id = 1;
DELETE FROM HorarioPrograma WHERE id = 1;