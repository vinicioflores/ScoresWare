CREATE TABLE [dbo].[TipoEvaluacionPorGrupo] (
    [id]                     INT NOT NULL,
    [Porcentaje]             INT NULL,
    [TipoContadorInstancias] BIT NULL,
    [FK_ContadorInstancia] INT NULL, 
    [tipoEvaluacion] INT NULL, 
    CONSTRAINT [PK_TipoEvaluacionPorGrupo] PRIMARY KEY CLUSTERED ([id] ASC)
);

