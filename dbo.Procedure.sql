CREATE PROCEDURE [dbo].[GetUsuarioID]
	@Username text,
	@Password text
AS
	return SELECT id FROM dbo.Usuario WHERE (username LIKE @Username) AND (password LIKE @Password)
