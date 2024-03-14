USE Softnic
go
--SP para obtener los perfiles que se mostrarán en el Login
CREATE or ALTER PROC sp_ObtenerPerfiles
AS
BEGIN
	SELECT Nombre FROM Usuario;
END
EXEC sp_ObtenerPerfiles;
GO

--SP para agregar un nuevo perfil para iniciar sesión
CREATE OR ALTER PROC sp_AgregarPerfil(
	@Rol INT,
	@Nombre VARCHAR(80),
	@Contraseña VARCHAR(12)
)
AS
BEGIN
	IF(SELECT @Nombre FROM Usuario WHERE Nombre = @Nombre) = @Nombre
	BEGIN
		RETURN 0;
	END
	ELSE
	BEGIN
		INSERT INTO Usuario VALUES (@Rol, @Nombre, @Contraseña, 1);
		RETURN 1;
	END
END
GO
--SP para ver la información de los perfiles de usuarios
CREATE OR ALTER PROC sp_MostrarPerfiles
AS
BEGIN
	SELECT 
		id_Usuario AS ID,
		Rol.id_Rol AS Rol,
		Usuario.Nombre,
		Contraseña,
		Estado.id_Estado AS Estado
	FROM
		Usuario (NOLOCK)
		INNER JOIN Rol (NOLOCK) ON Usuario.id_Rol = Rol.id_Rol
		INNER JOIN Estado (NOLOCK) ON Usuario.id_Estado = Estado.id_Estado
END
------------------------------------------------------------------
--SP para validar contraseña
CREATE OR ALTER PROC sp_ValidarAcceso(
	@NombreUsuario VARCHAR(80),
	@Contrasena VARCHAR(12)
)
AS
BEGIN
	IF(SELECT Nombre FROM Usuario WHERE Nombre = @NombreUsuario) = @NombreUsuario
	BEGIN
		IF(SELECT Contraseña FROM Usuario WHERE Contraseña = @Contrasena) = @Contrasena
		BEGIN
			select '1';
		END
		ELSE
		BEGIN
			SELECT '0';
		END
	END
	ELSE
	BEGIN
		SELECT '0';
	END
END
-------------------------------------------------------
--SP para mostrar informacion de los examenes
CREATE OR ALTER PROC sp_MostrarExamenes
AS
BEGIN
	SELECT 
		id_Examen AS ID,
		Examenes.Nombre AS Examen,
		Precio,
		Estado.id_Estado AS Estado
	FROM
		Examenes (NOLOCK)
		INNER JOIN Estado (NOLOCK) ON Examenes.id_Estado = Estado.id_Estado
END