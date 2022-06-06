CREATE DATABASE maintenance;

USE maintenance;

/*.: TABLA PERSONA :.*/
CREATE TABLE Persona(
	idPersona			int identity(1,1) primary key,
	nombre				varchar(100) not null,
	apellidop			varchar(100) not null,
	apellidom			varchar(100) not null,
	dni					varchar(8)	 not null,
	estado_civil		varchar(100) not null,
	direccion			varchar(200) not null,
	fecha_nacimiento	date		 not null,
	edad				int			 not null
)

/*.: VALORES :.*/
INSERT INTO dbo.Persona VALUES ('Jose','Humberto','Padilla','87654321','soltero','Av. Las Lomas de Carabayllo','2000-01-01',22);
INSERT INTO dbo.Persona VALUES ('Sofia','Margarina','Curay','12345678','casado','Av. San Juan de Lurigancho','2000-01-01',22);
INSERT INTO dbo.Persona VALUES ('Marcos','Aliaga','De La Torre','11223344','divorciado','Av. Puente Piedra','2000-01-01',22);
INSERT INTO dbo.Persona VALUES ('Maria','Maldini','Lopez','75486213','viuda','Av. Barranco del Sur','2000-01-01',22);

/*.: CONSULTA :.*/
SELECT 
	idPersona 'ID', nombre 'Nombre', apellidop 'Apellido Paterno', apellidom 'Apellido Materno', 
	dni 'DNI', estado_civil 'Estado Civil', fecha_nacimiento 'Fecha de Nacimiento', edad 'Edad'
FROM 
	dbo.Persona;