USE [ScoresWarehouseDB]
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 22/03/2015 11:15:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario](
	[id] [int] NOT NULL,
	[franja] [int] NULL,
	[aula] [int] NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Horario]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Aula] FOREIGN KEY([aula])
REFERENCES [dbo].[Aula] ([id])
GO
ALTER TABLE [dbo].[Horario] CHECK CONSTRAINT [FK_Horario_Aula]
GO
ALTER TABLE [dbo].[Horario]  WITH CHECK ADD  CONSTRAINT [FK_Horario_FranjaHoraria] FOREIGN KEY([franja])
REFERENCES [dbo].[FranjaHoraria] ([id])
GO
ALTER TABLE [dbo].[Horario] CHECK CONSTRAINT [FK_Horario_FranjaHoraria]
GO
