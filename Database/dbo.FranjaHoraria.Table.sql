USE [ScoresWarehouseDB]
GO
/****** Object:  Table [dbo].[FranjaHoraria]    Script Date: 22/03/2015 11:15:26 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FranjaHoraria](
	[id] [int] NOT NULL,
	[nombre] [text] NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_FranjaHoraria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
