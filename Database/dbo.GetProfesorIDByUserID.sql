CREATE PROCEDURE [dbo].[GetProfesorIDByUserID]
	@userID int
AS
	SELECT id FROM [dbo].[Profesor] WHERE usuario = @userID
RETURN 0
