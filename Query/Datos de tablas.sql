USE Softnic;

INSERT INTO Estado 
VALUES ('Activo'),('Inactivo'),('Eliminado');
SELECT * FROM Estado;
GO
INSERT INTO Rol
VALUES ('Administrador', 1), ('Encargado', 1);
SELECT * FROM Rol;
GO
INSERT INTO Sexo
VALUES ('Masculino', 1), ('Femenino', 1), ('No binario', 1), ('Terreneitor', 1);
SELECT * FROM Sexo;
GO
INSERT INTO Pacientes
VALUES ('Norwing', 'Jordy', 'Silva', 'Garc�a', '1987-12-24', 4, 1, '3611101041004Y');
SELECT * FROM Pacientes;
--DELETE FROM Pacientes WHERE id_Paciente = 2
GO
INSERT INTO Examenes
VALUES ('Sangre', 500, 1), ('Glucosa', 700, 1);
GO
--INSERT INTO Recibo
--VALUES (1, 1, 1, 500, 1, 500, 0, 07/03/2024);
--select * from Recibo
INSERT INTO Cierre_de_Caja
VALUES (500, 0, 500, 1, 07/03/2024);
GO
INSERT INTO Usuario
VALUES (1, 'Admin', '2db510f09acac9e13300eba51a2f4bb2ef9b2ce403c30d854cf39e48cbddf700', 1);
SELECT * FROM Usuario;
--DELETE FROM Usuario WHERE id_Usuario = 14
GO
INSERT INTO Descuento
VALUES (0.0, 1, '0%'), (0.10, 1, '10%'), (0.15, 1, '15%'), (0.20, 1, '20%');
SELECT * from Descuento