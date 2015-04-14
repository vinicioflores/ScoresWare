CREATE TABLE [dbo].[RubrosEvaluaciones]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [FK_Evaluacion] INT NULL, 
    [descripcion] TEXT NULL, 
    [valor] INT NULL
)
