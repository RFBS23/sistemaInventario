DROP DATABASE IF EXISTS sistemainventario;
create database sistemainventario
go

use sistemainventario;
go

create table rol(
	idrol int primary key identity,
	nombrerol varchar(50) not null unique,
	fecharegistro datetime default getdate()
)
go
insert into rol (nombrerol) values 
	('administrador'),
	('almacen'),
	('vendedor')
select * from rol
go

create table permisos(
	idpermiso int primary key identity,
	idrol int references rol(idrol),
	nombremenu varchar(100),
	fecharegistro datetime default getdate()
)
go
insert into permisos (idrol,nombremenu) values
	(1, 'menuusuarios'),
	(1, 'menucategoria'),
	(1, 'menuproductos'),
	(1, 'menuclientes'),
	(1, 'menuproveedores'),
	(1, 'menuventas'),
	(1, 'menuingresotienda'),
	(1, 'menureportes'),
	(1, 'menunegocio'),
	(1, 'menuacercade')
go

insert into permisos (idrol,nombremenu) values
	(3, 'menuventas'),
	(3, 'menuingresotienda'),
	(3, 'menureportes'),
	(3, 'menunegocio')
go
select * from permisos
go

create table proveedores(
	idproveedor int primary key identity,
	nombreproveedor varchar(225),
	documento varchar(50), 
	direccion varchar(50), -- direccion
	correo varchar(50),
	telefono varchar(50),
	fecharegistro date default getdate()
)
go
insert into proveedores (nombreproveedor, documento, direccion, correo, telefono) values ('provedor prueba s.a.c', '123456789', '1234567898787', 'prueba@hotmailempresa.pe', '987654321')
select idproveedor, nombreproveedor, documento, direccion, correo, telefono from proveedores

/*clientes
create table clientes(
	idcliente int primary key identity,
	documento varchar(50) unique,
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	correo varchar(50),
	telefono char(9) unique,
	fecharegistro date default getdate()
)
go
insert into clientes (documento, nombres, apellidos, correo, telefono) values
	('12345678', 'tio nacho', 'soyuz', 'tionacho@soyuz.com', '987654321')
go
select idcliente, documento, nombres, apellidos, correo, telefono from clientes
go*/
/*fin clientes*/
/**/
create table clientes(
	idclienteweb int primary key identity,
	documento varchar(50) unique,
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	correo varchar(100),
	clave varchar(150),
	telefono char(9) unique,
	reestablecer bit default 1,	
	fecharegistro date default getdate()
)
go
/**/

create table usuarios(
	idusuario int primary key identity,
	documento varchar(50) unique not null,
	nombreusuario varchar(50) not null,
	correo varchar(100) not null,
	clave varchar(150) not null,
	reestablecer bit default 1,
	idrol int references rol(idrol),
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
insert into usuarios (documento, nombreusuario, correo, clave, idrol) values
	('12345678', 'pepe', 'pepe@hotmail.pe', '12345', 1),
	('12345688', 'pedro', 'pedro@gmail.com', '12345', 2)
select * from usuarios
go

create table categorias(
	idcategoria int primary key identity,
	nombrecategoria varchar(100) not null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select idcategoria, nombrecategoria, fecharegistro from categorias
go
insert into categorias (nombrecategoria) values
	('Caballero Adulto'),
	('Damas Juvenil'),
	('Dama Adulta'),
	('caballero Juvenil');
select * from categorias
go

create table tallasropa (
	idtallaropa int primary key identity,
	nombretalla varchar(50) not null,
	idcategoria int references categorias(idcategoria) not null,
	estado bit not null default 1,
)
go
insert into tallasropa (idcategoria, nombretalla) VALUES 
	(1, 'S'),
	(1, 'M'),
	(1, 'L'),
	(1, 'xl');
go
SELECT * FROM tallasropa
go
select idtallaropa, c.idcategoria, c.nombrecategoria, nombretalla from tallasropa tr
inner join categorias c on c.idcategoria = tr.idcategoria
go

create table productosropa(
	idproducto int primary key identity,
	rutaimagen varchar(100) null,
    nombreimagen varchar(100) null,
	codigo varchar(50) not null,
	nombre varchar(50) not null,
	descripcion varchar(50) not null,
	idcategoria int references categorias(idcategoria) not null,
	idtallaropa int references tallasropa(idtallaropa) not null,
	stock int default 0 not null,
	colores varchar(40) not null,
	numcaja varchar(50) not null,
	precioventa decimal(10,2) default 0 not null,
	temporada varchar(60) not null,
	descuento int default 0,
	total decimal(10,2) default 0 not null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
insert into productosropa (codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, temporada, descuento, total) values
('RTKDR19S233', 'romina', 'vestido', '3', '1', '7', 'marino', '0', '62.00', 'Verano-2023', '5', '58.9'),
('RTKDR19M233', 'romina', 'vestido', '3', '2', '7', 'marino', '0','62.00', 'Verano-2023', '5', '58.9'),
('RTKDR19L233',	'romina', 'vestido', '3', '3', '2', 'marino', '0', '62.00', 'Verano-2023', '5', '58.9'),

('RTKDL1S233', 'layka',	'polo', '3', '1', '11', 'blanco', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL1M233', 'layka',	'polo',	'3', '2', '16',	'blanco', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL1L233', 'layka',	'polo',	'3', '3', '6', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL10S233', 'layka', 'polo', '3', '1', '16', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL10M233', 'layka', 'polo', '3', '2', '12', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL10L233', 'layka', 'polo', '3', '3', '5', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),

('RTKDZ3S233', 'zelda', 'enterizo', '2', '1', '14', 'verde print', '0', '29.90', 'Verano-2023', '2', '29.30'),
('RTKDZ3M233', 'zelda', 'enterizo', '2', '2', '16', 'verde print', '0', '29.90', 'Verano-2023', '2', '29.30'),
('RTKDZ3L233', 'zelda', 'enterizo', '2', '3', '8', 'verde print', '0', '29.90', 'Verano-2023', '2', '29.30'),

('VESH30S23', 'hila', 'vestido', '3', '1', '18', 'vino', '0', '62.00', 'verano 2023', '20', '49.6');
select * from productosropa
go

select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, temporada, descuento, total, CONVERT(VARCHAR(10), p.fecharegistro, 120)AS fecharegistro_producto from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
go

delete from productosropa where idproducto = 11;

update productosropa set stock = stock + @cantidad where idproducto = @idproducto;
go
update productosropa set stock = stock - @cantidad where idproducto = @idproducto;
go

create table productosropatienda(
	idproductotienda int primary key identity,
	idusuario int references usuarios(idusuario),
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select * from productosropatienda
go

create table detalletienda(
	iddetalletienda int primary key identity,
	idproductotienda int references productosropatienda(idproductotienda),
	idproducto int references productosropa(idproducto),
	cantidad int default 0 not null,
	fecharegistro varchar(20)not null,
)
go
select * from detalletienda
go


UPDATE detalletienda
SET descuento = 8.75
WHERE iddetalletienda = 1;

SELECT dt.iddetalletienda, dt.idproductotienda, pr.idproducto, pr.codigo, pr.nombre, pr.descripcion, cat.idcategoria, cat.nombrecategoria, tr.idtallaropa, tr.nombretalla, dt.cantidad, pr.stock, pr.colores, pr.numcaja, pr.precioventa, pr.descuento, pr.estado AS estado_producto, CONVERT(VARCHAR(10), pr.fecharegistro, 120)AS fecharegistro_producto, convert(varchar(12), dt.fecharegistro, 120) AS fecharegistro_detalletienda FROM detalletienda dt
JOIN productosropa pr ON dt.idproducto = pr.idproducto
JOIN categorias cat ON pr.idcategoria = cat.idcategoria
JOIN tallasropa tr ON pr.idtallaropa = tr.idtallaropa;
select * from detalletienda
go

update detalletienda set cantidad = cantidad + @cantidad where iddetalletienda = @iddetalletienda;
go
update detalletienda set cantidad = cantidad - @cantidad where iddetalletienda = @iddetalletienda;
go
create table ventas(
	idventa int primary key identity,
	idusuario int references usuarios(idusuario),
	tipodocumento varchar(50),
	numerodocumento varchar(50),
	documentocliente varchar(50),
	nombrecliente varchar(100),
	montopago decimal(10,2),
	montocambio decimal(10,2),
	montototal decimal(10,2),
	fecharegistro datetime default getdate()
)
go
select * from ventas where numerodocumento = '00002'
go

create table detalle_venta(
	iddetalleventa int primary key identity,
	idventa int references ventas(idventa),
	idproducto int references productosropa(idproducto),
	precioventa decimal(10,2),
	cantidad int,
	subtotal decimal(10,2),
	fecharegistro datetime default getdate()
)
go
select * from detalle_venta
go

/*ventas tienda*/
create table ventastienda(
	idventatienda int primary key identity,
	idusuario int references usuarios(idusuario),
	tipodocumento varchar(50),
	numerodocumento varchar(50),
	documentocliente varchar(50),
	nombrecliente varchar(100),
	montopago decimal(10,2),
	montocambio decimal(10,2),
	montototal decimal(10,2),
	fecharegistro datetime default getdate()
)
go
select * from ventastienda where numerodocumento = '00001'
go

create table detalle_ventatienda(
	iddetalleventatienda int primary key identity,
	idventatienda int references ventastienda(idventatienda),
	idproducto int references productosropa(idproducto),
	idproductotienda int references productosropatienda(idproductotienda),
	precioventa decimal(10,2),
	cantidad int,
	subtotal decimal(10,2),
	fecharegistro datetime default getdate()
)
go
select * from detalle_ventatienda
go

create table negocios(
	idnegocio int primary key,
	nombre varchar(60),
	ruc varchar(60),
	direccion varchar(60),
	logo varbinary(max) NULL
)
go
select * from negocios
select logo from negocios where idnegocio = 1
select idnegocio, nombre, ruc, direccion, logo from negocios where idnegocio = 1

insert into negocios(idnegocio, nombre, ruc, direccion) values
(1, 'valiant company', '23345361513221', 'por ahi');
go

select v.idventa, u.nombreusuario, v.documentocliente, v.nombrecliente, v.tipodocumento,
v.numerodocumento, v.montopago, v.montocambio, v.montototal, convert(char(10), v.fecharegistro, 103)[FechaRegistro] from ventas v
inner join usuarios u on u.idusuario = v.idusuario
where v.numerodocumento = '00001'

select p.nombre + ' ' + p.descripcion + ' ' + p.colores + ' ' + tr.nombretalla as productos, p.descuento, dv.precioventa, dv.cantidad, dv.subtotal from detalle_venta dv
inner join productosropa p on p.idproducto = dv.idproducto
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
where dv.idventa = '00001'

select vt.idventatienda, u.nombreusuario, vt.documentocliente, vt.nombrecliente, vt.tipodocumento,
vt.numerodocumento, vt.montopago, vt.montocambio, vt.montototal, convert(char(10), vt.fecharegistro, 103)[FechaRegistro] from ventastienda vt
inner join usuarios u on u.idusuario = vt.idusuario
where vt.numerodocumento = '00005'

select p.nombre + ' ' + p.descripcion + ' ' + p.colores + ' ' + tr.nombretalla as productos, p.descuento, dvt.precioventa, dvt.cantidad, dvt.subtotal from detalle_ventatienda dvt
inner join productosropatienda pt on pt.idproductotienda = dvt.idproductotienda
inner join productosropa p on p.idproducto = dvt.idproducto
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
where dvt.idventatienda = '00005'


SELECT pt.idproductotienda, pt.idusuario, pt.estado AS estadoProductotienda, convert(char(10), pt.fecharegistro, 103) AS fecharegistroProductotienda,
dvt.precioventa, dvt.cantidad, dvt.subtotal, p.nombre AS nombreProducto, dt.cantidad AS cantidadDetalle,
dt.fecharegistro AS fecharegistroDetalletienda FROM detalle_ventatienda dvt
INNER JOIN productosropatienda pt ON pt.idproductotienda = dvt.idproductotienda
INNER JOIN detalletienda dt ON dt.idproductotienda = pt.idproductotienda
INNER JOIN productosropa p ON p.idproducto = dt.idproducto
WHERE dvt.idventatienda = '00005'