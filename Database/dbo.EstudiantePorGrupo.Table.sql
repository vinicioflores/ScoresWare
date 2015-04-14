CREATE TABLE [dbo].[EstudiantePorGrupo] (
    [id]       INT NOT NULL,
    [Estado]   INT NULL,
    [NotaAcum] INT NULL,
    [Grupo]    INT NULL,
    [evaluaciones] INT NOT NULL, 
    CONSTRAINT [PK_EstudiantePorGrupo] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EstudiantePorGrupo_EstadoEstudiantePorGrupo] FOREIGN KEY ([Estado]) REFERENCES [dbo].[EstadoEstudiantePorGrupo] ([id]),
    CONSTRAINT [FK_EstudiantePorGrupo_Grupos] FOREIGN KEY ([Grupo]) REFERENCES [dbo].[Grupos] ([id])
);

