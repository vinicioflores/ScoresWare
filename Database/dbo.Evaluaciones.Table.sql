CREATE TABLE [dbo].[Evaluaciones]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [evaluacionPorEstudiantePorGrupo] INT NULL, 
    [nombre] TEXT NULL, 
    [descripcion] TEXT NULL, 
    [nota] INT NULL
)
