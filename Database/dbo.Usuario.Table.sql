CREATE TABLE [dbo].[Usuario] (
    [id]       INT  NOT NULL,
    [username] TEXT NULL,
    [password] TEXT NULL,
    [type]     TEXT  NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([id] ASC)
);

