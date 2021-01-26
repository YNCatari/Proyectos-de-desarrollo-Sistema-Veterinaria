CREATE DATABASE dbveterinaria;
USE dbveterinaria;

/***CREACION DE TABLAS***/
CREATE TABLE VettbCliente(
  	 dni varchar(8) NOT NULL,
  	 nombre varchar(50) NOT NULL,
  	 apellido varchar(50) NOT NULL,
  	 telefono varchar(12) NOT NULL,
  	 email varchar(100) NOT NULL,
  	 direccion varchar(50) NOT NULL,
 	 PRIMARY KEY (dni)
);

CREATE TABLE VettbEmpleado(
	codigo varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	apellido varchar(50) NOT NULL,
	direccion varchar(100) NOT NULL,
	email varchar(100),
	cargo varchar(50) NOT NULL,
	clave varchar(8) NOT NULL,
	estado varchar(8) NOT NULL,
	PRIMARY KEY (codigo)
); 

CREATE TABLE VettbMascota(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	especie varchar(50) NOT NULL,
	raza varchar(50) NOT NULL,
	peso varchar(12) NOT NULL,
	sexo varchar(6) NOT NULL,
	nacimiento date,
	estado varchar(8) NOT NULL,
 	CONSTRAINT `FK_Cliente_Mascota` FOREIGN KEY (dni) REFERENCES VettbCliente (dni)
);

CREATE TABLE VettbServicio(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	vacuna varchar(50) NOT NULL,
	detalle varchar(100),
	fecha date,
	precio double,
 	CONSTRAINT `FK_Cliente_Servicio` FOREIGN KEY (dni) REFERENCES VettbCliente (dni)
);

CREATE TABLE VettbMantenimiento(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	servicio varchar(50) NOT NULL,
	detalle varchar(100),
	fecha date,
	precio double,
 	CONSTRAINT `FK_Cliente_Mantenimiento` FOREIGN KEY (dni) REFERENCES VettbCliente (dni)
);

CREATE TABLE VettbTratamiento(
	dni varchar(8) NOT NULL,
	nombre varchar(50) NOT NULL,
	tratamiento varchar(50) NOT NULL,
	detalle varchar(100),
	receta varchar(100),
	fecha date,
	cita date,
	precio double,
 	CONSTRAINT `FK_Cliente_Tratamiento` FOREIGN KEY (dni) REFERENCES VettbCliente(dni)
);

CREATE TABLE VettbAgenda(
	codigo int(8) NOT NULL AUTO_INCREMENT,
  	dni varchar(8) NOT NULL,
  	nombre varchar(50) NOT NULL,
  	telefono varchar(12) NOT NULL,
  	direccion varchar(50),
	fecha date,
	hora varchar(8),
	actividad varchar(100),
	PRIMARY KEY (codigo),
 	CONSTRAINT `FK_Cliente_Agenda` FOREIGN KEY (dni) REFERENCES VettbCliente(dni)
);


/***INSERTAR DATOS****/

INSERT INTO `VettbCliente` (`dni`, `nombre`, `apellido`, `telefono`, `email`, `direccion`) 
VALUES 	('00454545', 'Ximena Carolina', 'Ortiz Lozada', '410202', 'xime@hotmail.com', 'Calle 2 de mayo nro 869'),
			('45120152', 'Joselin Almendra', 'Herrera Lopez', '409645', 'josy_almendra@gmail.com', 'Av. Cultura nro 145'),
			('47120158', 'Rosa Lisset', 'Jahuira Arias', '410202', 'rosa20@yahoo.com', 'Asociacion Leoncio prado nro 42');
INSERT INTO `VettbEmpleado` (`codigo`, `nombre`, `apellido`, `direccion`, `email`, `cargo`, `clave`, `estado`) 
VALUES 	('1001', 'Juan', 'Rodriguez Mamani', 'Calle arica nro 1055', 'juan@upt.edu.pe', 'Administrador', '123456', 'Activo'),
			('1002', 'Yofer', 'Catari Cabrera', 'Av. Leguia  nro 8455', 'yofer@gmail.com', 'Vendedor', '123456', 'Activo'),
			('1003', 'Adnner', 'Esperilla', 'Urbanización Tacna nro 823', 'addner@hotmail.com', 'Medico', '123456', 'Activo');
INSERT INTO `VettbMascota` (`dni`, `nombre`, `especie`, `raza`, `peso`, `sexo`, `nacimiento`, `estado`)
VALUES	('00454545', 'Sparky', 'Perro', 'Labrador', '35', 'Macho', STR_TO_DATE('03/04/2015', '%d/%m/%Y'), 'Activo'),
			('00454545', 'Lacy', 'Perro', 'Shih Tzu', '8', 'Hembra', STR_TO_DATE('28/12/2016', '%d/%m/%Y'), 'Activo') ,
			('47120158', 'Bobby', 'Perro', 'Rottweiler', '24', 'Macho', STR_TO_DATE('30/08/2012', '%d/%m/%Y'), 'Inactivo'); 
INSERT INTO `VettbServicio` (`dni`, `nombre`, `vacuna`, `detalle`, `fecha`, `precio`)
VALUES	('00454545', 'Sparky', 'Desparasitario', 'Se le aplico una vacuna desparacitaria', STR_TO_DATE('03/06/2018', '%d/%m/%Y'), '25.50'),
			('00454545', 'Lacy', 'Antirrabica', 'Se le aplico una vacuna contra la rabia', STR_TO_DATE('10/06/2018', '%d/%m/%Y'), '20.50');
INSERT INTO `VettbMantenimiento` (`dni`, `nombre`, `servicio`, `detalle`, `fecha`, `precio`)
VALUES	('00454545', 'Sparky', 'Baño desinfectante', 'Se le realizo el aseo habitual de la semana', STR_TO_DATE('03/06/2018', '%d/%m/%Y'), '20.60'),
			('00454545', 'Lacy', 'Peinado y cepillado', 'Se peino y cepillo todo su pelaje', STR_TO_DATE('10/06/2018', '%d/%m/%Y'), '20.40');
INSERT INTO `VettbTratamiento` (`dni`, `nombre`, `tratamiento`, `detalle`, `receta`, `fecha`, `cita`, `precio`)
VALUES	('00454545', 'Sparky', 'Spa', 'Tratamiento masajeador con la finalidad de reducir el estres de la mascota', 'Evitar Alimentos altos en grasas', STR_TO_DATE('03/06/2018', '%d/%m/%Y'), STR_TO_DATE('03/07/2018', '%d/%m/%Y'), '30.80'),
			('00454545', 'Lacy', 'Aromaterapia', 'Baño con aceites naturales para descongestionar las fosas nasales y reducir el estres ', 'Evitar exponer a la mascota al exterior por 1 semana', STR_TO_DATE('10/06/2018', '%d/%m/%Y'), STR_TO_DATE('03/07/2018', '%d/%m/%Y'), '25.50');
INSERT INTO `VettbAgenda` (`dni`, `nombre`, `telefono`, `direccion`, `fecha`, `hora`, `actividad`)
VALUES	('00454545', 'Ximena Carolina', '410202', 'Calle 2 de mayo nro 869', STR_TO_DATE('25/06/2018', '%d/%m/%Y'), '15:30', 'Servicio de Vacunacion y de Limpieza'),
 			('45120152', 'Joselin Almendra', '410202', 'Av. Cultura nro 145', STR_TO_DATE('12/07/2018', '%d/%m/%Y'), '16:00', 'Servicio de Limpieza');



/***PROCEDIMIENTOS ALMACENADOS***/

/***VALIDAR LOGIN***/
DELIMITER //
CREATE PROCEDURE `VetUSP_S_ValidarLogin`(
	pcodemp varchar(8),
	pclaemp varchar(8),
	pestemp varchar(8)
)
BEGIN
	select * from VettbEmpleado
where
	codigo = pcodemp and clave = pclaemp and estado = pestemp;
COMMIT;
END//
DELIMITER ;


/***ELIMINAR CARGO (Solo referencial)***/
DELIMITER //
CREATE  PROCEDURE `VetUSP_D_EliminarCliente`(
	pdnicli varchar(8)
)
BEGIN
	delete from VettbCliente 
where 
	dni = pdnicli;
COMMIT;
END//
DELIMITER ;
	

/***AGREGAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarCliente`(
	pdnicli varchar(8),
	pnomcli varchar(50),
	papecli varchar(50),
	ptelcli varchar(12),
	pemacli varchar(100),
	pdircli varchar(50)

)
BEGIN
insert into VettbCliente(dni, nombre, apellido, telefono, email, direccion) 
values(pdnicli, pnomcli, papecli, ptelcli, pemacli, pdircli);
COMMIT;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarEmpleado`(
	pcodemp varchar(8),
	pnomemp varchar(50),
	papeemp varchar(50),
	pdiremp varchar(100),
	pemaemp varchar(100),
	pcaremp varchar(50),
	pclaemp varchar(8),
	pestemp varchar(8)
)
BEGIN
insert into VettbEmpleado(codigo, nombre, apellido, direccion, email, cargo, clave, estado) 
values(pcodemp, pnomemp, papeemp, pdiremp, pemaemp, pcaremp, pclaemp, pestemp);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarMascota`(
	pdnimas varchar(8),
	pnommas varchar(50),
	pespmas varchar(50),
	prazmas varchar(50),
	ppesmas varchar(12),
	psexmas varchar(6),
	pnacmas date,
	pestmas varchar(8)
)
BEGIN
insert into VettbMascota(dni, nombre, especie, raza, peso, sexo, nacimiento, estado) 
values(pdnimas, pnommas, pespmas, prazmas, ppesmas, psexmas, pnacmas, pestmas);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarServicio`(
	pdniser varchar(8),
	pnomser varchar(50),
	pvacser varchar(50),
	pdetser varchar(100),
	pfecser date,
	ppreser double
)
BEGIN
insert into VettbServicio(dni, nombre, vacuna, detalle, fecha, precio) 
values(pdniser, pnomser, pvacser, pdetser, pfecser, ppreser);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarMantenimiento`(
	pdniman varchar(8),
	pnomman varchar(50),
	pserman varchar(50),
	pdetman varchar(100),
	pfecman date,
	ppreman double
)
BEGIN
insert into VettbMantenimiento(dni, nombre, servicio, detalle, fecha, precio) 
values(pdniman, pnomman, pserman, pdetman, pfecman, ppreman);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarTratamiento`(
	pdnitra varchar(8),
	pnomtra varchar(50),
	ptratra varchar(50),
	pdettra varchar(100),
	prectra varchar(100),
	pfectra date,
	pcittra date,
	ppretra double
)
BEGIN
insert into VettbTratamiento(dni, nombre, tratamiento, detalle, receta, fecha, cita, precio) 
values(pdnitra, pnomtra, ptratra, pdettra, prectra, pfectra, pcittra, ppretra);
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_I_AgregarAgenda`(
  	pcodreg int(8),
	pdnireg varchar(8),
  	pnomreg varchar(50),
  	ptelreg varchar(12),
  	pdirreg varchar(50),
	pfecreg date,
	phorreg varchar(8),
	pactreg varchar(100)
)
BEGIN
insert into VettbAgenda(codigo, dni, nombre, telefono, direccion, fecha, hora, actividad) 
values(pcodreg, pdnireg, pnomreg, ptelreg, pdirreg, pfecreg, phorreg, pactreg);
COMMIT;
END//
DELIMITER ;

/***ACTUALIZAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarCliente`(
	pdnicli varchar(8),
	pnomcli varchar(50),
	papecli varchar(50),
	ptelcli varchar(12),
	pemacli varchar(100),
	pdircli varchar(50)
)
BEGIN
update VettbCliente set 
	dni = pdnicli,
	nombre = pnomcli,
	apellido = papecli,
	telefono = ptelcli,
	email = pemacli,
	direccion = pdircli
where
	dni = pdnicli;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarEmpleado`(
	pcodemp varchar(8),
	pnomemp varchar(50),
	papeemp varchar(50),
	pdiremp varchar(100),
	pemaemp varchar(100),
	pcaremp varchar(50),
	pclaemp varchar(8),
	pestemp varchar(8)
)
BEGIN
update VettbEmpleado set 
	nombre = pnomemp,
	apellido = papeemp,
	direccion = pdiremp,
	email = pemaemp,
	cargo = pcaremp,
	clave = pclaemp,
	estado = pestemp
where
	codigo = pcodemp;
COMMIT;
END//
DELIMITER ;


DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarMascota`(
	pdnimas varchar(8),
	pnommas varchar(50),
	pespmas varchar(50),
	prazmas varchar(50),
	ppesmas varchar(12),
	psexmas varchar(6),
	pnacmas date,
	pestmas varchar(8)
)
BEGIN
update VettbMascota set
	especie = pespmas,
	raza = prazmas,
	peso = ppesmas,
	sexo = psexmas,
	nacimiento = pnacmas,
	estado = pestmas
where
	dni = pdnimas and nombre = pnommas;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarServicio`(
	pdniser varchar(8),
	pnomser varchar(50),
	pvacser varchar(50),
	pdetser varchar(100),
	pfecser date,
	ppreser double
)
BEGIN
update VettbServicio set
	vacuna = pvacser,
	detalle = pdetser,
	fecha = pfecser,
	precio = ppreser
where
	dni = pdniser and nombre = pnomser;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarMantenimiento`(
	pdniman varchar(8),
	pnomman varchar(50),
	pserman varchar(50),
	pdetman varchar(100),
	pfecman date,
	ppreman double
)
BEGIN
update VettbMantenimiento set 
	servicio = pserman,
	detalle = pdetman,
	fecha = pfecman,
	precio = ppreman
where
	dni = pdniman and nombre = pnomman;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarTratamiento`(
	pdnitra varchar(8),
	pnomtra varchar(50),
	ptratra varchar(50),
	pdettra varchar(100),
	prectra varchar(100),
	pfectra date,
	pcittra date,
	ppretra double
)
BEGIN
update VettbTratamiento set
	tratamiento = ptratra,
	detalle = pdettra,
	receta = prectra,
	fecha = pfectra,
	cita = pcittra,
	precio = ppretra
where
	dni = pdnitra and nombre = pnomtra;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_U_ActualizarAgenda`(
	pcodreg int(8),
	pdnireg varchar(8),
  	pnomreg varchar(50),
  	ptelreg varchar(12),
  	pdirreg varchar(50),
	pfecreg date,
	phorreg varchar(8),
	pactreg varchar(100)
)
BEGIN
update VettbAgenda set 
  	nombre = pnomreg,
  	telefono = ptelreg,
  	direccion = pdirreg,
	fecha = pfecreg,
	hora = phorreg,
	actividad = pactreg
where
	dni = pdnireg and codigo = pcodreg;
COMMIT;
END//
DELIMITER ;


/***BUSCAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarCliente`(
	pdnicli varchar(8)
)
BEGIN
	select * from VettbCliente
where
	dni = pdnicli;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarEmpleado`(
	pcodemp varchar(8)
)
BEGIN
	select * from VettbEmpleado
where
	codigo = pcodemp;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMascota`(
	pdnimas varchar(8)
)
BEGIN
	select * from VettbMascota
where
	dni = pdnimas;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMascotaConDni`(
	pdnimas varchar(8),
	pnommas varchar(50)
)
BEGIN
	select * from VettbMascota
where
	dni = pdnimas and nombre = pnommas;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarServicio`(
	pdniser varchar(8),
	pnomser varchar(50)
)
BEGIN
	select * from VettbServicio
where
	dni = pdniser and nombre = pnomser;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_SumarServicioFecha`(
	pfecini date,
	pfecfin date
)
BEGIN
	select sum(precio) from VettbServicio
where
	fecha between pfecini and pfecfin;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarServicioConDni`(
	pdniser varchar(8)
)
BEGIN
	select * from VettbServicio
where
	dni = pdniser;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMantenimiento`(
	pdniman varchar(8),
	pnomman varchar(50)
)
BEGIN
	select * from VettbMantenimiento
where
	dni = pdniman and nombre = pnomman;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarMantenimientoConDni`(
	pdniman varchar(8)
)
BEGIN
	select * from VettbMantenimiento
where
	dni = pdniman;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_SumarMantenimientoFecha`(
	pfecini date,
	pfecfin date
)
BEGIN
	select sum(precio) from VettbMantenimiento
where
	fecha between pfecini and pfecfin;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarTratamiento`(
	pdnitra varchar(8),
	pnomtra varchar(50)
)
BEGIN
	select * from VettbTratamiento
where
	dni = pdnitra and nombre = pnomtra;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarTratamientoConDni`(
	pdnitra varchar(8)
)
BEGIN
	select * from VettbTratamiento
where
	dni = pdnitra;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_SumarTratamientoFecha`(
	pfecini date,
	pfecfin date
)
BEGIN
	select sum(precio) from VettbTratamiento
where
	fecha between pfecini and pfecfin;
COMMIT;
END//

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarAgenda`(
	pfecreg date
)
BEGIN
	select * from VettbAgenda
where
	fecha = pfecreg;
COMMIT;
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_BuscarAgendaConDni`(
	pdniage varchar(8)
)
BEGIN
	select * from VettbAgenda
where
	dni = pdniage;
COMMIT;
END//
DELIMITER ;

/***LISTAR***/

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarCliente`()
	select * from VettbCliente
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarEmpleado`()
	select * from VettbEmpleado
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarMascota`()
	select * from VettbMascota
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarServicio`()
	select * from VettbServicio
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarMantenimiento`()
	select * from VettbMantenimiento
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarTratamiento`()
	select * from VettbTratamiento
END//
DELIMITER ;

DELIMITER //
CREATE  PROCEDURE `VetUSP_S_ListarAgenda`()
	select * from VettbAgenda
END//
DELIMITER ;