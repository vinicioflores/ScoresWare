USE [ScoresWarehouseDB]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 22/03/2015 11:15:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[id] [int] NOT NULL,
	[Nombre] [text] NULL,
	[PrimerApellido] [text] NULL,
	[SegundoApellido] [text] NULL,
	[usuario] [int] NOT NULL,
	[email] [text] NULL,
	[estudianteGrupo] [int] NOT NULL,
	[carnet] [int] NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_EstudiantePorGrupo] FOREIGN KEY([estudianteGrupo])
REFERENCES [dbo].[EstudiantePorGrupo] ([id])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_Estudiante_EstudiantePorGrupo]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_Estudiante_Usuario] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_Estudiante_Usuario]
GO
