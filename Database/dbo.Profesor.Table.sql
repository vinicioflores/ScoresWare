CREATE TABLE [dbo].[Profesor] (
    [id]              INT  NOT NULL,
    [Nombre]          TEXT NULL,
    [PrimerApellido]  TEXT NULL,
    [SegundoApellido] TEXT NULL,
    [usuario]         INT  NOT NULL,
    [codigo] INT NULL, 
    CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Profesor_Usuario] FOREIGN KEY ([usuario]) REFERENCES [dbo].[Usuario] ([id])
);

