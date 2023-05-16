


CREATE PROCEDURE Actualizar
    @idExamen int,
    @Nombre varchar(255),
    @Descripcion varchar(255)
AS
BEGIN
    UPDATE tblExamen
    SET Nombre = @Nombre,
        Descripcion = @Descripcion	
    WHERE idExamen = @idExamen
END

EXEC Actualizar 19,'Jesus','Roberto'