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
insert into rol (nombrerol) values ('administrador')
select * from rol
go

create table permisos(
	idpermiso int primary key identity,
	idrol int references rol(idrol),
	nombremenu varchar(100),
	fecharegistro datetime default getdate()
)
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
select * from clientes
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

create table productos(
	idproducto int primary key identity,
	codigo varchar(50),
	nombre varchar(50),
	descripcion varchar(50),
	idcategoria int references categorias(idcategoria),
	tallaxs int not null default 0,
	tallas int not null default 0,
	tallam int not null default 0,
	tallal int not null default 0,
	tallaxl int not null default 0,
	tallaxxl int not null default 0,
	total int default 0,
	colores varchar(40),
	preciocompra decimal(10,2) default 0,
	precioventa decimal(10,2) default 0,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
-- alter table productos alter column stock varchar(100) not null default 0;
insert into productos(codigo, nombre, descripcion, idcategoria, tallaxs, tallas, tallam, tallal, tallaxl, tallaxxl, colores, precioventa) values
('113221466', 'prueba3', 'hola mundgg', 1, '10', '12', '50', '40', '70', '40', 'amarillo', '150'),
('113221896', 'prueba2', 'hola mundo', 1, '10', '1', '5', '0', '7', '30', 'azul', '69');
select * from productos
go

select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tallaxs, tallas, tallam, tallal, tallaxl, tallaxxl, colores, precioventa from productos p
inner join categorias c on c.idcategoria = p.idcategoria
go

/**/
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
	idproducto int references productos(idproducto),
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
	idproductos int references productos(idproducto),
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

