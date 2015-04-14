USE [ScoresWarehouseDB]
GO


INSERT INTO [dbo].[Estudiante]
			([id],[Nombre],
				[PrimerApellido],
				[SegundoApellido],
				[usuario],
				[email],
				[estudianteGrupo],
				[carnet])

VALUES (0, 'Vinicio', 'Flores', 'Hernandez', 0, 'vfloreshdz@gmail.com', 0, 2014072347),
		(1, 'Juan', 'Perez', 'Rodriguez', 1, 'jpr@tec.ac.cr', 0, 2015090786),
		(2, 'Pablo', 'Piedra', 'Calvo', 2, 'ppc@gmail.com', 0, 2012900456),
		(3, 'Daniel', 'Mata', 'Cerdas', 3, 'dmc@gmail.com', 0,2009001002),
		(4, 'Esteban', 'Rojas', 'Izaguirre', 4, 'eri@gmail.com', 0, 2008905654),
		(5, 'Jesus', 'Castro', 'Enriquez', 5, 'jce@gmail.com', 0, 2005590900),
		(6, 'Carlos', 'Mena', 'Lopez', 6, 'cml@gmail.com', 0, 2014073333),
		(7, 'Luis', 'Mejia', 'Campos', 7, 'lmc@gmail.com', 0, 2014098234),
		(8, 'Fernando', 'Luna', 'Montero', 8, 'flm@gmail.com', 0, 2015111222),
		(9, 'Adolfo', 'Vega', 'Barrantes', 9, 'avb@gmail.com', 0, 0),
		(10, 'Pedro', 'Ruiz', 'Hernandez', 10, 'pedrorh@gmail.com', 0, 0),
		(11, 'Paco', 'Monge', 'Monge', 11, 'pmm@gmail.com', 0, 0),
		(12, 'Juan', 'Chavarria', 'Palma', 12, 'jcp@gmail.com', 0, 0),
		(13, 'John', 'Kiyosaki', '', 13, 'jk@gmail.com', 0, 0),
		(14, 'Robert', 'Gates', 'III', 14, 'rg3@gmail.com', 0, 0),
		(15, 'Hiroshi', 'Ishiguro', '', 15, 'hi@gmail.com', 0, 0)
GO