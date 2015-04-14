USE [ScoresWarehouseDB]
GO

INSERT INTO [dbo].[EstadoEstudiantePorGrupo]
           ([id]
           ,[estadoNombre]
           ,[Descripcion])
     VALUES
           (0,'NR','No retirado'),
		   (1,'RS','Retiro'),
		   (2,'RI','Retiro')
GO


