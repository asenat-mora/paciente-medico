create database DBU3AMR;
use DBU3AMR;

create table tbPaciente(
idPaciente int primary key NOT NULL AUTO_INCREMENT,
idEstadocivil int Not NULL ,
nombreCompleto varchar (80),
direccion varchar (100),
telefonoFijo varchar (10),
celular varchar (10),
edad int,
sexo char,
email varchar (50),
edoCivil varchar(15)
);

-- modificar estadocivil con su llave foranea
ALTER TABLE tbPaciente ADD idEstadocivil int Not NULL;
ALTER TABLE tbPaciente ADD FOREIGN KEY (idEstadocivil) REFERENCES tbEstadocivil(idEstadocivil);



create table tbMedico(
idMedico int primary key Not NULL AUTO_INCREMENT ,
nombreCompleto varchar (20),
cedula varchar (15),
especialidad varchar(20)
);

-- ALTER TABLE tbMedico MODIFY especialidad varchar(20); -- cambie el tipo de dato de especialidad, antes era int

create table tbPacienteMedico(
idMedico int,
idPaciente int,
foreign key (idMedico) references tbMedico (idMedico),
foreign key (idPaciente) references tbPaciente (idPaciente)
);

-- crear usuario
CREATE USER 'asenat'@'localhost' IDENTIFIED BY 'asenat';
-- asignar permisos
GRANT ALL PRIVILEGES ON * . * TO 'asenat'@'localhost';
-- Realice cambios
FLUSH PRIVILEGES;

-- Insertar registros en tbMedicos 


insert into tbMedico 
(`nombreCompleto`,`cedula`,`especialidad`) values 
('Carlos Alberto Lagun', 'C12345678', 'Cirugia General');

insert into tbMedico 
(`nombreCompleto`,`cedula`,`especialidad`) values 
('Nain Maldonado Guz', '23456789', 'Dermatología');

insert into tbMedico 
(`nombreCompleto`,`cedula`,`especialidad`) values 
('Edgar Cerón García', '87654321', 'Medicina General');

insert into tbMedico 
(`nombreCompleto`,`cedula`,`especialidad`) values 
('Rafael Arteaga Covar', '77744488',  'Medicina General');

insert into tbMedico 
(`nombreCompleto`,`cedula`,`especialidad`) values 
('Esther Gaitán Ortiz', '44991578',  'Medicina General');

select * from tbMedico;

-- Agregando una nueva tabla para estado civil 
create table tbEstadocivil(
idEstadocivil int primary key Not NULL AUTO_INCREMENT ,
edoCivil varchar (15)
);

-- agregando a la tabla EstadoCivil
insert into tbEstadocivil (edoCivil) values ('Soltero');
insert into tbEstadocivil (edoCivil) values ('Casado');
insert into tbEstadocivil (edoCivil) values ('Divorciado');
insert into tbEstadocivil (edoCivil) values ('Viudo');
insert into tbEstadocivil (edoCivil) values ('Concubinato');

select *from tbEstadocivil;


-- modificar estadocivil con su llave foranea
ALTER TABLE tbPaciente ADD idEstadocivil int Not NULL;
ALTER TABLE tbPaciente ADD FOREIGN KEY (idEstadocivil) REFERENCES tbEstadocivil(idEstadocivil);


-- modificar paciente con su llave foranea de medico
ALTER TABLE tbpaciente ADD idMedico int Not NULL;
ALTER TABLE tbpaciente ADD FOREIGN KEY (idMedico) REFERENCES tbmedico(idMedico);

SELECT * FROM dbu3amr.tbpaciente;


-- Probar consultas de pacientes por idMedico
Select * from tbPaciente WHERE idMedico = 3;
Select * from tbPaciente WHERE idMedico = 1

-- ------------------------------------------------------------------------




