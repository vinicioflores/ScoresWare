CREATE PROCEDURE [dbo].[FillGruposByProfesor]
	@FK_Profesor int
AS
	SELECT id, codigo, cupo, horario, profesor, periodo, curso, TipoEvalPorGrupo FROM [dbo].[Grupos] WHERE profesor = @FK_Profesor
RETURN 0
