create database sistemainventario
go

use sistemainventario;
go

create table rol(
	idrol int primary key identity,
	nombrerol varchar(50),
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
select * from permisos
go

create table proveedores(
	idproveedor int primary key identity,
	documento varchar(50),
	razonsocial varchar(50),
	correo varchar(50),
	telefono varchar(50),
	estado bit,
	fecharegistro date default getdate()
)
go
insert into proveedores (documento, razonsocial, correo, telefono) values ('123456789', '1234567898787', 'prueba@hotmailempresa.pe', '987654321')
select idproveedor, documento, razonsocial, correo, telefono from proveedores
go

create table clientes(
	idcliente int primary key identity,
	documento varchar(50),
	nombres varchar(50),
	apellidos varchar(50),
	correo varchar(50),
	telefono char(9),
	estado bit,
	fecharegistro date default getdate()
)
go
insert into clientes (documento, nombres, apellidos, correo, telefono) values
('12345678', 'tio nacho', 'soyuz', 'tionacho@soyuz.com', '987654321')
go
select idcliente, documento, nombres, apellidos, correo, telefono from clientes
go

create table usuarios(
	idusuario int primary key identity,
	documento varchar(50),
	nombreusuario varchar(50),
	correo varchar(50),
	clave varchar(50),
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
	nombrecategoria varchar(100),
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select idcategoria, nombrecategoria, fecharegistro from categorias
go
insert into categorias (nombrecategoria) values
	('categoria de prueba')
select * from categorias
go

create table tallasropa (
	idtallaropa int primary key identity,
	nombretalla varchar(50),
	idcategoria int references categorias(idcategoria) not null,
	estado bit not null default 1,
)
go
-- alter table tallasropa add idcategoria int references categorias(idcategoria) not null;
insert into tallasropa (idcategoria, nombretalla) VALUES 
	(1, 'S');
go
SELECT * FROM tallasropa
go
select idtallaropa, c.idcategoria, c.nombrecategoria, nombretalla from tallasropa tr
inner join categorias c on c.idcategoria = tr.idcategoria
go
-- select idtallaropa, nombretalla from tallasropa where idcategoria = @idcategoria

create table productosropa(
	idproducto int primary key identity,
	imagenes varbinary(max) NULL,
	codigo varchar(50) not null,
	nombre varchar(50) not null,
	descripcion varchar(50) not null,
	ubiprod varchar(30) not null,
	idcategoria int references categorias(idcategoria) not null,
	idtallaropa int references tallasropa(idtallaropa) not null,
	stock int default 0 not null,
	colores varchar(40) not null,
	numcaja varchar(50) not null,
	-- preciocompra decimal(10,2) default 0,
	precioventa decimal(10,2) default 0 not null,
	devolucion varchar(30) null,
	devoluciontalla varchar(10) null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
-- alter table productosropa add imagenes varbinary(max) NULL;
-- alter table productosropa add devoluciontalla varchar(10) null;
-- alter table productosropa add ubicacionprod varchar(30) not null;
-- alter table productosropa drop COLUMN idubiprod;
-- alter table productosropa add numcaja varchar(50);

insert into productosropa (codigo, nombre, descripcion, ubiprod, idcategoria, idtallaropa, stock, colores, numcaja, precioventa) values
('113221466', 'prueba1', 'hola mundgg', 'caja', 1, 1, '40', 'amarillo', 'caja 12', '150'),
('113221896', 'prueba2', 'hola mundo', 'caja', 1, 1, '30', 'azul', 'bolsa 15', '69');
select * from productosropa
go

select idproducto, codigo, nombre, descripcion, ubiprod, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, devolucion, devoluciontalla from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
go

create table productosropatienda(
	idproductotienda int primary key identity,
	idproductos int references productosropa(idproducto) not null,
	stock int default 0 not null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go

create table compras(
	idcompra int primary key identity,
	idusuario int references usuarios(idusuario),
	idproveedor int references proveedores(idproveedor),
	tipodocumento varchar(50),
	numerodocumento varchar(50),
	montototal decimal(10,2),
	fecharegistro datetime default getdate()
)
go
select * from compras
go

create table detalle_compra(
	iddetallecompra int primary key identity,
	idcompra int references compras(idcompra),
	idproducto int references productosropa(idproducto),
	preciocompra decimal(10,2) default 0,
	precioventa decimal(10,2) default 0,
	cantidad int,
	montototal decimal(10,2),
	fecharegistro datetime default getdate()
)
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

create table detalle_venta(
	iddetalleventa int primary key identity,
	idventa int references ventas(idventa),
	idproductos int references productosropa(idproducto),
	precioventa decimal(10,2),
	cantidad int,
	subtotal decimal(10,2),
	fecharegistro datetime default getdate()
)
go

create table negocios(
	idnegocio int primary key identity,
	nombre varchar(60),
	ruc varchar(60),
	direccion varchar(60),
	logo varbinary(max) NULL
)
go

