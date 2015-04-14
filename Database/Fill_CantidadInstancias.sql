CREATE PROCEDURE [dbo].[Fill_CantidadInstancias]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[CantidadInstancias]
END
GO 

CREATE PROCEDURE [dbo].[Insert_CantidadInstancias]
	@IDINPUT int,
	@CANTIDADINPUT int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[CantidadInstancias](
			[id],[cantidad])

	VALUES (@IDINPUT, @CANTIDADINPUT)
END
GO

CREATE PROCEDURE [dbo].[Delete_CantidadInstancias]
	@IDINPUT int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[CantidadInstancias] WHERE id = @IDINPUT
END
GO


CREATE PROCEDURE [dbo].[Update_CantidadInstancias]
	@id int,
	@cantidad int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[CantidadInstancias] SET id = @id
	UPDATE [dbo].[CantidadInstancias] SET cantidad = @cantidad
END
GO