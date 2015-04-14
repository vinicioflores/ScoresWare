CREATE PROCEDURE [dbo].[GetUsuarioID]
	-- Add the parameters for the stored procedure here
	@Username text, 
	@Password text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT id FROM dbo.Usuario WHERE (username LIKE @Username) AND (password LIKE @Password);
END
GO
