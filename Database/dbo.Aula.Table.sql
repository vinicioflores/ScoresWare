USE [ScoresWarehouseDB]
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 22/03/2015 11:15:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[id] [int] NOT NULL,
	[Codigo] [text] NULL,
	[Cupo] [int] NULL,
 CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
