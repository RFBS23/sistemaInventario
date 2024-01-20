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
