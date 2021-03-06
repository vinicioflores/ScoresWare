USE [ScoresWarehouseDB]
GO
/****** Object:  Table [dbo].[Grupos]    Script Date: 22/03/2015 11:15:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupos](
	[id] [int] NOT NULL,
	[codigo] [int] NULL,
	[cupo] [int] NULL,
	[horario] [int] NULL,
	[profesor] [int] NULL,
	[periodo] [int] NULL,
	[curso] [int] NULL,
	[TipoEvalPorGrupo] [int] NULL,
 CONSTRAINT [PK_Grupos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Grupos]  WITH CHECK ADD  CONSTRAINT [FK_Grupos_Curso] FOREIGN KEY([curso])
REFERENCES [dbo].[Curso] ([id])
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_Curso]
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_EstudiantePorGrupo]
GO
ALTER TABLE [dbo].[Grupos]  WITH CHECK ADD  CONSTRAINT [FK_Grupos_Horario] FOREIGN KEY([horario])
REFERENCES [dbo].[Horario] ([id])
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_Horario]
GO
ALTER TABLE [dbo].[Grupos]  WITH CHECK ADD  CONSTRAINT [FK_Grupos_Periodo] FOREIGN KEY([periodo])
REFERENCES [dbo].[Periodo] ([id])
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_Periodo]
GO
ALTER TABLE [dbo].[Grupos]  WITH CHECK ADD  CONSTRAINT [FK_Grupos_Profesor] FOREIGN KEY([profesor])
REFERENCES [dbo].[Profesor] ([id])
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_Profesor]
GO
ALTER TABLE [dbo].[Grupos]  WITH CHECK ADD  CONSTRAINT [FK_Grupos_TipoEvaluacionPorGrupo] FOREIGN KEY([TipoEvalPorGrupo])
REFERENCES [dbo].[TipoEvaluacionPorGrupo] ([id])
GO
ALTER TABLE [dbo].[Grupos] CHECK CONSTRAINT [FK_Grupos_TipoEvaluacionPorGrupo]
GO
