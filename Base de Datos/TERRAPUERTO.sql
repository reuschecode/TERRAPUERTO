USE TERRAPUERTO;

CREATE TABLE Cliente(
	dni char(8) primary key,
	nombres varchar(30),
	apellidoPaterno varchar(30),
	apellidoMaterno varchar(30),
	fechaNacimiento date,
);

CREATE TABLE Bus(
	idBus int identity(1,1) primary key,
	placa char(6),
	cantidadAsientos int,
	modelo varchar(10),
	servicio varchar(10),
);

CREATE TABLE Viaje(
	idViaje int identity(1,1) primary key,
	idBus int,
	fechaSalida date,
	fechaLlegada date,
	ciudadEmbarque varchar(20),
	ciudadDesembarque varchar(20),
	precio float,
	foreign key (idBus) references Bus(idBus)
);

CREATE TABLE Pasaje(
	idPasaje int identity(1,1) primary key,
	idCliente char(8),
	idViaje int,
	fecha date,
	precio float,
	numeroAsiento int,
	foreign key (idCliente) references Cliente(dni),
	foreign key (idViaje) references Viaje(idViaje)
);

insert into Bus(placa,cantidadAsientos,	modelo,	servicio) values ('T2G234', 60, 'Volvo', 'Cama');
insert into Bus(placa,cantidadAsientos,	modelo,	servicio) values ('BC8311', 40, 'Irizar', 'Vip');
insert into Bus(placa,cantidadAsientos,	modelo,	servicio) values ('FG3130', 30, 'Mercedes-B', 'Vip');
insert into Bus(placa,cantidadAsientos,	modelo,	servicio) values ('V2T594', 50, 'Hyundai', 'Cama');
insert into Bus(placa,cantidadAsientos,	modelo,	servicio) values ('L42337', 50, 'Mitsubishi', 'Semicama');
insert into Bus(placa,cantidadAsientos,	modelo,	servicio) values ('PEG274', 60, 'Hyundai', 'Cama');

insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (1, '05/10/2021', '05/10/2021', 'Trujillo', 'Lima', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (2, '06/10/2021', '06/10/2021', 'Trujillo', 'Chiclayo', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (3, '06/10/2021', '06/10/2021', 'Trujillo', 'Cajamarca', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (3, '06/10/2021', '07/10/2021', 'Cajamarca', 'Trujillo', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (1, '07/10/2021', '07/10/2021', 'Lima', 'Cuzco', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (2, '07/10/2021', '07/10/2021', 'Lima', 'Trujillo', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (4, '07/10/2021', '07/10/2021', 'Lima', 'Chiclayo', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (6, '07/10/2021', '08/10/2021', 'Lima', 'Cajamarca', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (5, '08/10/2021', '08/10/2021', 'Lima', 'Huanuco', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (5, '08/10/2021', '08/10/2021', 'Cajamarca', 'Lima', 50.40 );
insert into Viaje(idBus,fechaSalida, fechaLlegada, ciudadEmbarque, ciudadDesembarque, precio) values (5, '08/10/2021', '08/10/2021', 'Cajamarca', 'Chiclayo', 50.40 );

select * from Viaje
DBCC CHECKIDENT ('Viaje', RESEED, 0)  
delete from Viaje