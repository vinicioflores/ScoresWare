CREATE TABLE [dbo].[TiposEvaluacion] (
    [id]             INT  NOT NULL,
    [Nombre]         TEXT NULL,
    [tipoEvPorGrupo] INT  NOT NULL,
    CONSTRAINT [PK_TiposEvaluacion] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TiposEvaluacion_TipoEvaluacionPorGrupo] FOREIGN KEY ([tipoEvPorGrupo]) REFERENCES [dbo].[TipoEvaluacionPorGrupo] ([id])
);

