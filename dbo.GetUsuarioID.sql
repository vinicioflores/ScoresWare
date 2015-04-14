CREATE PROCEDURE [dbo].[GetUsuarioID]
	@Username text,
	@Password text
AS
	SELECT id FROM dbo.Usuario WHERE (username LIKE @Username) AND (password LIKE @Password)
	GO
