CREATE PROCEDURE Insertar
    
    @Name varchar(255),
    @Description varchar(255)
AS
BEGIN
    INSERT INTO tblExamen (Nombre, Descripcion)
    VALUES (@Name, @Description)
END

EXEC Insertar 'Pedro','Alumno'
