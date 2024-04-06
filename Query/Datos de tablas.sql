USE Softnic;

INSERT INTO Estado
VALUES ('Activo'),('Inactivo'),('Eliminado'),('Pendiente');
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
VALUES ('Norwing', 'Jordy', 'Silva', 'García', '1987-12-24', 4, 1, '3611101041004Y');
SELECT * FROM Pacientes;
--DELETE FROM Pacientes WHERE id_Paciente = 2
GO
INSERT INTO Examenes VALUES('Perfil Hepático',600,1),
			   ('Perfil Renal',50,1),
			   ('Prueba de Tiroides (TSH, T3, T4)',950,1),
			   ('Electrolitos (Sodio, Potasio, Cloro)',950,1),
			   ('Ácido Úrico',90,1),
			   ('Creatinina',90,1),
			   ('Urea',90,1),
			   ('Ferritina',200,1),
			   ('Vitamina B12',700,1),
			   ('Hemoglobina A1c',390,1),
			   ('Antígeno Prostático Específico (PSA)',750,1),
			   ('Perfil de Coagulación (Tiempo de Protrombina, Tiempo de Tromboplastina Parcial)',180,1),
			   ('Anticuerpos Antinucleares (ANA)',600,1),
			   ('Factor Reumatoide',600,1),
			   ('Inmunoglobulinas (IgG, IgM, IgA)',200,1),
			   ('Cortisol',150,1),
			   ('Prolactina',150,1),
			   ('Calcio',150,1),
			   ('Magnesio',150,1),
			   ('Amilasa',150,1),
			   ('Lipasa',150,1),
			   ('Glucosa',90,1),
			   ('Creatinina',90,1),
			   ('Ácido úrico',90,1),
			   ('Colesterol',90,1),
			   ('Proteínas totales',200,1),
			   ('Transaminasas (TGO y TGP)',180,1),
			   ('Fosfatasa alcalina',200,1),
			   ('Biometria Completa',100,1),
			   ('Recuento de plaquetas',80,1),
			   ('Hematocritos',50,1),
			   ('Examen General de Orina',80,1),
			   ('Examen General de Heces',80,1),
			   ('ASLO',90,1),
			   ('VSG',200,1),
			   ('VDRL',90,1),
			   ('VIH(Sida)',150,1),
			   ('Helicobacter',350,1),
			   ('Urocultivo',300,1),
			   ('Coprocultivo',300,1),
			   ('Exudados',150,1),
			   ('Hemogravindex',120,1),
			   ('Urogravindex',80,1),
			   ('Tipo y RH',150,1),
			   ('BAAR',150,1);
GO
--UPDATE Examenes SET id_Estado = 3
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