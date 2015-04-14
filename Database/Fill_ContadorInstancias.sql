CREATE PROCEDURE [dbo].[Fill_ContadorInstancias]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[ContadorInstancias]
END
GO 

CREATE PROCEDURE [dbo].[Insert_ContadorInstancias]
	@IDINPUT int,
	@ContadorINPUT int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[ContadorInstancias](
			[id],[contador])

	VALUES (@IDINPUT, @ContadorINPUT)
END
GO

CREATE PROCEDURE [dbo].[Delete_ContadorInstancias]
	@IDINPUT int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM [dbo].[ContadorInstancias] WHERE id = @IDINPUT
END
GO

CREATE PROCEDURE [dbo].[Update_ContadorInstancias]
	@id int,
	@contador int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [dbo].[ContadorInstancias] SET id = @id
	UPDATE [dbo].[ContadorInstancias] SET contador = @contador
END
GO