USE Softnic
go
--SP para obtener los perfiles que se mostrarán en el Login
CREATE or ALTER PROC sp_ObtenerPerfiles
AS
BEGIN
	SELECT Nombre FROM Usuario WHERE Usuario.id_Estado = 1;
END
--EXEC sp_ObtenerPerfiles;
GO

SELECT * FROM Usuario

GO

--SP para agregar un nuevo perfil para iniciar sesión
CREATE OR ALTER PROC sp_AgregarPerfil(
	@Rol INT,
	@Nombre VARCHAR(80),
	@Contraseña VARCHAR(64)
)
AS
BEGIN
	IF(SELECT @Nombre FROM Usuario WHERE Nombre = @Nombre AND id_Estado = 1) = @Nombre
	BEGIN
		SELECT '0';
	END
	ELSE
	BEGIN
		INSERT INTO Usuario VALUES (@Rol, @Nombre, @Contraseña, 1);
		SELECT '1';
	END
END
GO
---------------------------------------------------------------
--SP Para modificar los perfiles de usuario

CREATE OR ALTER PROC sp_ModificarPerfiles(
	@Id INT,
	@Rol INT,
	@Nombre VARCHAR(80),
	@Contraseña VARCHAR(64)
)
AS
BEGIN
	IF(SELECT @Id FROM Usuario WHERE id_Usuario = @Id) = @Id
	BEGIN
		UPDATE Usuario SET id_Rol = @Rol WHERE id_Usuario = @Id;
		UPDATE Usuario SET Nombre = @Nombre WHERE id_Usuario = @Id;
		UPDATE Usuario SET Contraseña = @Contraseña WHERE id_Usuario = @Id;
		SELECT '1';
	END
	ELSE
	BEGIN
		SELECT '0';
	END
END
GO
---------------------------------------------------------------
---SP para eliminar los perfiles de usuario-------------------

CREATE OR ALTER PROC sp_EliminarPerfiles(
	@Id INT
)
AS
BEGIN
	IF(SELECT @Id FROM Usuario WHERE id_Usuario = @Id) = @Id
	BEGIN
		IF(SELECT COUNT(*) AS TOTAL FROM Usuario WHERE id_Estado = 1) <= 1
		BEGIN
			--La contraseña es Administrador.---No olvidar el punto---
			SELECT '0';
		END
		ELSE
		BEGIN
			UPDATE Usuario SET id_Estado = 3 WHERE id_Usuario = @Id;
			SELECT '1';
		END
	END
	ELSE
	BEGIN
		SELECT '0';
	END
END
GO

--SP para ver la información de los perfiles de usuarios
CREATE OR ALTER PROC sp_MostrarPerfiles
AS
BEGIN
	SELECT 
		id_Usuario AS ID,
		Rol.Nombre AS Rol,
		Usuario.Nombre,
		Estado.Nombre AS Estado
	FROM
		Usuario (NOLOCK)
		INNER JOIN Rol (NOLOCK) ON Usuario.id_Rol = Rol.id_Rol
		INNER JOIN Estado (NOLOCK) ON Usuario.id_Estado = Estado.id_Estado
	WHERE Usuario.id_Estado != 3
END
GO

--EXEC sp_MostrarPerfiles
--SELECT 
--		id_Usuario AS ID,
--		Rol.Nombre AS Rol,
--		Usuario.Nombre,
--		Estado.Nombre AS Estado
--	FROM
--		Usuario (NOLOCK)
--		INNER JOIN Rol (NOLOCK) ON Usuario.id_Rol = Rol.id_Rol
--		INNER JOIN Estado (NOLOCK) ON Usuario.id_Estado = Estado.id_Estado
-----------------------------------------------------------------



------------------------------------------------------------------
--SP para validar contraseña
CREATE OR ALTER PROC sp_ValidarAcceso(
	@NombreUsuario VARCHAR(80),
	@Contrasena VARCHAR(64)
)
AS
BEGIN
	IF(SELECT Nombre FROM Usuario WHERE Nombre = @NombreUsuario AND id_Estado = 1) = @NombreUsuario
	BEGIN
		IF(SELECT Contraseña FROM Usuario WHERE Contraseña = @Contrasena AND id_Estado = 1) = @Contrasena
		BEGIN
			IF (SELECT id_Rol FROM Usuario WHERE Nombre = @NombreUsuario AND id_Estado = 1) = 1
			BEGIN
				SELECT 'Admin'
			END
			ELSE
			BEGIN
				select '1';
			END
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
GO

-------------------------------------------------------
--SP para mostrar informacion de los examenes
CREATE OR ALTER PROC sp_MostrarExamenes
AS
BEGIN
	SELECT 
		id_Examen AS ID,
		Examenes.Nombre AS Examen,
		Precio,
		Estado.Nombre AS Estado
	FROM
		Examenes (NOLOCK)
		INNER JOIN Estado (NOLOCK) ON Examenes.id_Estado = Estado.id_Estado
END
--exec sp_MostrarExamenes
GO
---------------------------------------------------------------
--SP para mostrar informacion de los Pacientes
CREATE OR ALTER PROC sp_MostrarClientes
AS
BEGIN
	SELECT 
		id_Paciente AS ID,
		PrimerNombre,
		SegundoNombre,
		PrimerApellido,
		SegundoApellido,
		FechaDeNacimiento,
		Sexo.Nombre AS Sexo,
		Estado.Nombre AS Estado
	FROM
		Pacientes (NOLOCK)
		INNER JOIN Estado (NOLOCK) ON Pacientes.id_Estado = Estado.id_Estado
		INNER JOIN Sexo (NOLOCK) ON Pacientes.id_sexo = Sexo.id_Sexo
END
exec sp_MostrarClientes
GO
-------------------------------------------------
--SP para mostrar los descuentos disponibles-----
CREATE OR ALTER PROC sp_MostrarDescuentos
AS
BEGIN
	SELECT 
		Descuento.id_descuento,
		Descuento.Nombre,
		Descuento.Cantidad,
		Estado.Nombre AS Estado
	FROM
		Descuento (NOLOCK)
		INNER JOIN Estado (NOLOCK) ON Descuento.id_Estado = Estado.id_Estado
END
GO

--EXEC sp_MostrarDescuentos
------------------------------------------
--SP para mostrar los roles

CREATE OR ALTER PROC sp_MostrarRoles
AS
BEGIN
	SELECT 
		Rol.id_Rol,
		Rol.Nombre,
		Estado.Nombre AS Estado
	FROM
		Rol (NOLOCK)
		INNER JOIN Estado (NOLOCK) ON Rol.id_Estado = Estado.id_Estado
END
GO
EXEC sp_MostrarRoles
GO
------------------------------------------------
--SP para mostrar información del recibo-------
CREATE OR ALTER PROC sp_informacionRecibo
(
	@id_Recibo INT
)
AS
BEGIN
	SELECT
		id_Recibo AS Recibo,
		Pacientes.PrimerNombre AS Nombre,
		Pacientes.PrimerApellido AS Apellido,
		Examenes.Nombre AS Examen,
		Importe,
		Descuento.Nombre AS Descuento,
		Total_Pagar,
		Saldo,
		Fecha,
		Estado.Nombre AS Estado
	FROM Recibo
	INNER JOIN Pacientes ON Recibo.id_Paciente = Pacientes.id_Paciente
	INNER JOIN Examenes ON Recibo.id_Examen = Examenes.id_Examen
	INNER JOIN Descuento ON Recibo.Descuento = Descuento.id_descuento
	INNER JOIN Estado ON Recibo.id_Estado = Estado.id_Estado
	WHERE Recibo.id_Estado = 1 AND Recibo.id_Recibo = @id_Recibo
END


---------------------------------------------------------------
---------------------------------------------------------------
--SP para mostrar datos de los clientes

CREATE OR ALTER PROC sp_MostrarClientes
AS
BEGIN
	SELECT
	id_Paciente AS ID,
	PrimerNombre AS 'Primer Nombre',
	SegundoNombre AS 'Segundo Nombre',
	PrimerApellido AS 'Primer Apellido',
	SegundoApellido AS 'Segundo Apellido',
	NumeroCedula AS 'Número de cédula',
	FechaDeNacimiento AS 'Fecha de nacimiento',
	Sexo.Nombre AS Sexo
	FROM Pacientes
	INNER JOIN Sexo ON Sexo.id_Sexo = Pacientes.id_sexo
	WHERE Pacientes.id_Estado = 1
END

EXEC sp_MostrarClientes
--DELETE FROM Pacientes WHERE id_Paciente != 3
---------------------------------------------------------------

--SP para agregar un nuevo cliente
CREATE OR ALTER PROC sp_AgregarCliente(
	@PrimerNombre VARCHAR(20),
	@SegundoNombre VARCHAR(20),
	@PrimerApellido VARCHAR(20),
	@SegundoApellido VARCHAR(20),
	@Nacimiento DATE,
	@id_Sexo INT,
	@NumeroCedula VARCHAR(14)
)
AS
BEGIN
	IF(
	SELECT NumeroCedula FROM Pacientes
	WHERE NumeroCedula = @NumeroCedula
	AND id_Estado = 1) = @NumeroCedula
	BEGIN
		SELECT '0';
	END
	ELSE
	BEGIN
		INSERT INTO Pacientes VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Nacimiento, @id_Sexo, 1, @NumeroCedula);
		SELECT '1';
	END
END
GO

--select * from Pacientes
---------------------------------------------------------------
--SP Para modificar los clientes

CREATE OR ALTER PROC sp_ModificarCliente(
	@Id_Paciente int,
	@PrimerNombre VARCHAR(20),
	@SegundoNombre VARCHAR(20),
	@PrimerApellido VARCHAR(20),
	@SegundoApellido VARCHAR(20),
	@Nacimiento DATE,
	@id_Sexo INT,
	@NumeroCedula VARCHAR(14)
)
AS
BEGIN
	IF(SELECT id_Paciente FROM Pacientes WHERE id_Paciente = @Id_Paciente) = @Id_Paciente
	BEGIN
		UPDATE Pacientes SET PrimerNombre = @PrimerNombre WHERE id_Paciente = @Id_Paciente;
		UPDATE Pacientes SET SegundoNombre = @SegundoNombre WHERE id_Paciente = @Id_Paciente;
		UPDATE Pacientes SET PrimerApellido = @PrimerApellido WHERE id_Paciente = @Id_Paciente;
		UPDATE Pacientes SET SegundoApellido = @SegundoApellido WHERE id_Paciente = @Id_Paciente;
		UPDATE Pacientes SET FechaDeNacimiento = @Nacimiento WHERE id_Paciente = @Id_Paciente;
		UPDATE Pacientes SET id_sexo = @id_Sexo WHERE id_Paciente = @Id_Paciente;
		UPDATE Pacientes SET @NumeroCedula = @NumeroCedula WHERE id_Paciente = @Id_Paciente;

		SELECT '1';
	END
	ELSE
	BEGIN
		SELECT '0';
	END
END
GO
---------------------------------------------------------------
---SP para eliminar los cliente-------------------

CREATE OR ALTER PROC sp_EliminarCliente(
	@Id INT
)
AS
BEGIN
	IF(SELECT @Id FROM Pacientes WHERE id_Paciente = @Id) = @Id
	BEGIN
		IF(SELECT COUNT(*) AS TOTAL FROM Usuario WHERE id_Estado = 1) <= 0
		BEGIN
			SELECT '0';
		END
		ELSE
		BEGIN
			UPDATE Pacientes SET id_Estado = 3 WHERE id_Paciente = @Id;
			SELECT '1';
		END
	END
	ELSE
	BEGIN
		SELECT '0';
	END
END
GO

---------------------------------------------------------
---SP PARA BUSCAR LOS CLIENTES
CREATE OR ALTER PROC sp_BuscarCliente (
	@ValorBuscar VARCHAR(50)
)
AS
BEGIN
	SELECT
	id_Paciente AS ID,
	PrimerNombre AS 'Primer Nombre',
	SegundoNombre AS 'Segundo Nombre',
	PrimerApellido AS 'Primer Apellido',
	SegundoApellido AS 'Segundo Apellido',
	NumeroCedula AS 'Número de cédula',
	FechaDeNacimiento AS 'Fecha de nacimiento',
	Sexo.Nombre AS Sexo
	FROM Pacientes
	INNER JOIN Sexo ON Sexo.id_Sexo = Pacientes.id_sexo
	WHERE 
	Pacientes.id_Estado = 1
	AND id_Paciente like CONCAT('%',@ValorBuscar, '%')
	OR PrimerNombre like CONCAT('%',@ValorBuscar, '%') AND Pacientes.id_Estado = 1
	OR SegundoNombre like CONCAT('%',@ValorBuscar, '%') AND Pacientes.id_Estado = 1
	OR PrimerApellido like CONCAT('%',@ValorBuscar, '%') AND Pacientes.id_Estado = 1
	OR SegundoApellido like CONCAT('%',@ValorBuscar, '%') AND Pacientes.id_Estado = 1
	OR NumeroCedula like CONCAT('%',@ValorBuscar, '%') AND Pacientes.id_Estado = 1
END
go
---------------------------------------------------------
---SP para mostrar los sexos en el cmb
CREATE OR ALTER PROC sp_MostrarSexos
AS
BEGIN
	SELECT 
		Nombre
	FROM
		Sexo
END
GO
---------------------------------------------------
--SP PARA OBTENER EL ULTIMO RECIBO

CREATE OR ALTER PROC sp_UltimoRecibo
AS
BEGIN
	select top 1 id_Recibo + 1 from Recibo order by id_Recibo desc
END
go
-----------------------------------------

-------------------------------------------------------
---SP PARA AÑADIR LOS DETALLES AL RECIBO-----
select * from detalleRecibo where id_Recibo = 5
go
CREATE OR ALTER PROC sp_AgregarDetalleRecibo(
	@id_Recibo INT,
	@id_Paciente INT,
	@id_Examen INT,
	@id_Estado INT,
	@Importe MONEY,
	@Fecha DATETIME
)
AS
BEGIN
	INSERT INTO DetalleRecibo VALUES (@id_Recibo, @id_Paciente, @id_Examen, @id_Estado, @Importe, @Fecha);
	SELECT '1';
END
GO
-------------------------------------------------------------
-----SP PARA ELIMINAR DETALLES AL RECIBO------------------
CREATE OR ALTER PROC sp_EliminarDetalleRecibo(
	@Id INT
)
AS
BEGIN
	IF(SELECT @Id FROM DetalleRecibo WHERE id_Detalle = @Id) = @Id
	BEGIN
		UPDATE DetalleRecibo SET id_Estado = 3 WHERE id_Detalle = @Id;
		SELECT '1';
	END
	ELSE
	BEGIN
		SELECT '0';
	END
END
GO

