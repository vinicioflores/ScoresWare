DECLARE @tranName VARCHAR(20);
SELECT @tranName = 'Llenado de Usuarios';

BEGIN  TRANSACTION @tranName;

INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (0, N'vinicio', N'vfh1211', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (1, N'franco', N'fquiros', N'Profesor')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (2, N'jpr', N'jpr', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (3, N'ppc', N'ppc', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (4, N'dmc', N'dmc', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (5, N'eri', N'eri', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (6, N'jce', N'jce', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (7, N'cml', N'cml', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (8, N'lmc', N'lmc', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (9, N'flm', N'flm', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (10, N'avb', N'avb', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (11, N'pedrorh', N'pedrorh', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (12, N'pmm', N'pmm', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (13, N'jcp', N'jcp', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (14, N'jk', N'jk', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (15, N'rg3', N'rg3', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (16, N'hi', N'hi', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (17, N'lulu', N'lulu', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (19, N'suzaku', N'lancelot', N'Estudiante')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (21, N'adriana', N'adriana', N'Profesor')
INSERT INTO [dbo].[Usuario] ([id], [username], [password], [type]) VALUES (23, N'chigusa', N'chigusa', N'Profesor')

COMMIT TRANSACTION @tranName
GO