use sistemainventario
go

insert into rol (nombrerol) values
	('empleados')
select * from rol
go

insert into usuarios (documento, nombreusuario, correo, clave, idrol) values
	('12345678', 'pepe', 'pepe@hotmail.pe', '12345', 1),
	('12345688', 'pedro', 'pedro@gmail.com', '12345', 2)
select * from usuarios
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

insert into permisos (idrol, nombremenu) values
	(2, 'menuproductos'),
	(2, 'menuventas'),
	(2, 'menuingreso'),
	(2, 'menuclientes'),
	(2, 'menuproveedores'),
	(2, 'menuacercade')
go
select * from permisos
go

select p.idrol, p.nombremenu from permisos p
inner join rol r on r.idrol = p.idrol
inner join usuarios u on u.idrol = r.idrol
where u.idusuario = 1

insert into negocios(nombre,ruc,direccion,logo) values
	('Valent France', '20232023', 'por ahi', null)
go

select * from negocios
go

select u.idusuario, u.documento, u.nombreusuario, u.correo, u.clave, u.estado, r.idrol, r.nombrerol from usuarios u
inner join rol r on r.idrol = u.idrol