USE Softnic
go
--SP para obtener los perfiles que se mostrar�n en el Login
CREATE or ALTER PROC sp_ObtenerPerfiles
AS
BEGIN
	SELECT Nombre FROM Usuario;
END
EXEC sp_ObtenerPerfiles;
GO

--SP para agregar un nuevo perfil para iniciar sesi�n
CREATE OR ALTER PROC sp_AgregarPerfil(
	@Rol INT,
	@Nombre VARCHAR(80),
	@Contrase�a VARCHAR(12)
)
AS
BEGIN
	IF(SELECT @Nombre FROM Usuario WHERE Nombre = @Nombre) = @Nombre
	BEGIN
		RETURN 0;
	END
	ELSE
	BEGIN
		INSERT INTO Usuario VALUES (@Rol, @Nombre, @Contrase�a, 1);
		RETURN 1;
	END
END
GO
--SP para ver la informaci�n de los perfiles de usuarios
CREATE OR ALTER PROC sp_MostrarPerfiles
AS
BEGIN
	SELECT 
		id_Usuario AS ID,
		Rol.id_Rol AS Rol,
		Usuario.Nombre,
		Contrase�a,
		Estado.id_Estado AS Estado
	FROM
		Usuario (NOLOCK)
		INNER JOIN Rol (NOLOCK) ON Usuario.id_Rol = Rol.id_Rol
		INNER JOIN Estado (NOLOCK) ON Usuario.id_Estado = Estado.id_Estado
END
------------------------------------------------------------------
--SP para validar contrase�a
CREATE OR ALTER PROC sp_ValidarAcceso(
	@NombreUsuario VARCHAR(80),
	@Contrasena VARCHAR(12)
)
AS
BEGIN
	IF(SELECT Nombre FROM Usuario WHERE Nombre = @NombreUsuario) = @NombreUsuario
	BEGIN
		IF(SELECT Contrase�a FROM Usuario WHERE Contrase�a = @Contrasena) = @Contrasena
		BEGIN
			RETURN 1;
		END
		ELSE
		BEGIN
			RETURN 0;
		END
	END
	ELSE
	BEGIN
		RETURN 0;
	END
END