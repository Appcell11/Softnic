--CREATE DATABASE Softnic;
--Use Softnic;
CREATE TABLE Estado(
id_Estado INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(20)
);

CREATE TABLE Descuento(
	id_descuento INT PRIMARY KEY IDENTITY,
	Cantidad FLOAT,
	id_Estado INT REFERENCES Estado(id_Estado),
	Nombre VARCHAR(20)
);

CREATE TABLE Rol(
id_Rol INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(30),
id_Estado INT REFERENCES Estado(id_Estado)
);
CREATE TABLE Sexo(
id_Sexo INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(20),
id_Estado INT REFERENCES Estado(id_Estado)
);
CREATE TABLE Pacientes(
id_Paciente INT PRIMARY KEY IDENTITY,
PrimerNombre VARCHAR(20),
SegundoNombre VARCHAR(20),
PrimerApellido VARCHAR(20),
SegundoApellido VARCHAR(20),
NumeroCedula VARCHAR(14),
FechaDeNacimiento DATE,
id_sexo INT REFERENCES Sexo(id_Sexo),
id_Estado INT REFERENCES Estado(id_Estado)
);


CREATE TABLE Examenes(
id_Examen INT PRIMARY KEY IDENTITY,
Nombre VARCHAR(150),
Precio MONEY,
id_Estado INT REFERENCES Estado(id_Estado)
);

CREATE TABLE DetalleRecibo(
id_Detalle INT PRIMARY KEY IDENTITY,
id_Recibo INT REFERENCES Recibo(id_Recibo),
id_Paciente INT REFERENCES Pacientes(id_Paciente),
id_Examen INT REFERENCES Examenes(id_Examen),
id_Estado INT REFERENCES Estado(id_Estado),
Importe MONEY,
Fecha DATETIME
);

CREATE TABLE Recibo(
id_Recibo INT PRIMARY KEY IDENTITY,
id_Paciente INT REFERENCES Pacientes(id_Paciente),
id_Estado INT REFERENCES Estado(id_Estado),
Importe MONEY,
Fecha DATETIME
);

--ALTER TABLE Recibo DROP COLUMN Descuento
--ALTER TABLE Recibo DROP COLUMN Saldo
--ALTER TABLE Recibo DROP COLUMN Total_Pagar
--ALTER TABLE Recibo DROP COLUMN id_Examen

CREATE TABLE Cierre_de_Caja(
id_cdcaja INT PRIMARY KEY IDENTITY,
Suma_Total INT,
Saldo_Total  INT,
Total_en_Caja INT,
id_Estado INT REFERENCES Estado(id_Estado),
Fecha DATETIME
);

CREATE TABLE Usuario(
id_Usuario INT PRIMARY KEY IDENTITY,
id_Rol INT REFERENCES Rol(id_Rol),
Nombre VARCHAR(80),
Contraseña VARCHAR(64),
id_Estado INT REFERENCES Estado(id_Estado)
);

