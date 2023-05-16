


CREATE PROCEDURE Eliminar
    @idExamen int
AS
BEGIN
    DELETE FROM tblExamen
    WHERE idExamen = @idExamen
END

EXEC Eliminar 16