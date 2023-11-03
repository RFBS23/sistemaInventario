use sistemainventariodemo
go

create table rol(
	idrol int primary key identity,
	nombrerol varchar(50),
	fecharegistro datetime default getdate()
)
go
create table permisos(
	idpermiso int primary key identity,
	idrol int references rol(idrol),
	nombremenu varchar(100),
	fecharegistro datetime default getdate()
)
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

create table categorias(
	idcategoria int primary key identity,
	nombrecategoria varchar(100),
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select idcategoria, nombrecategoria, fecharegistro from categorias
go

create table tallasropa (
	idtallaropa int primary key identity,
	nombretalla varchar(50),
	idcategoria int references categorias(idcategoria) not null
)
go

create table productosropa(
	idproducto int primary key identity,
	imagenes varbinary(max) NULL,
	codigo varchar(50) not null,
	nombre varchar(50) not null,
	descripcion varchar(50) not null,
	ubiprod varchar(30) not null,
	idcategoria int references categorias(idcategoria) not null,
	idtallaropa int REFERENCES tallasropa(idtallaropa) not null,
	stock int default 0 not null,
	colores varchar(40) not null,
	numcaja varchar(50) not null,
	preciocompra decimal(10,2) default 0,
	precioventa decimal(10,2) default 0 not null,
	devolucion varchar(30) null,
	devoluciontalla varchar(10) null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select idproducto, codigo, nombre, descripcion, ubiprod, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, devolucion, devoluciontalla from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
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

/*procedimientos*/
create procedure spu_registrar_usuario(
	@documento varchar(20),
	@nombreusuario varchar(50),
	@correo varchar(100),
	@clave varchar(50),
	@idrol int,
	@idusuarioresultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @idusuarioresultado = 0
	set @mensaje = ''

	if not exists(select * from usuarios where documento = @documento)
	begin
		insert into usuarios(documento,nombreusuario,correo,clave,idrol) values
		(@documento,@nombreusuario,@correo,@clave,@idrol)
		set @idusuarioresultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'No se puede repetir el documento'
end
go

declare @idusuarioresultado int
declare @mensaje varchar(100)
exec spu_registrar_usuario '12345658', 'juan', 'jaun@hotmail.com', '12345', 2, @idusuarioresultado output, @mensaje output
select @idusuarioresultado
select @mensaje
go

create procedure spu_editar_usuario(
	@idusuario int,
	@documento varchar(50),
	@nombreusuario varchar(50),
	@correo varchar(100),
	@clave varchar(50),
	@idrol int,
	@respuesta bit output,
	@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from usuarios where documento = @documento and idusuario != @idusuario)
	begin
		update  usuarios set
		documento = @documento,
		nombreusuario = @nombreusuario,
		correo = @correo,
		clave = @clave,
		idrol = @idrol
		where idusuario = @idusuario
		set @respuesta = 1
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario'
end
go

declare @respuesta int
declare @mensaje varchar(100)
exec spu_editar_usuario 1,'12349958', 'josue', 'josue@gmail.com', '12345', 1, @respuesta output, @mensaje output
select @respuesta
select @mensaje
go
select * from usuarios
go

create proc spu_eliminar_usuario(
	@idusuario int,
	@respuesta bit output,
	@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''
	declare @pasoreglas bit = 1
	IF EXISTS (SELECT * FROM compras C 
	INNER JOIN usuarios U ON U.idusuario = C.idusuario
	WHERE U.idusuario = @idusuario
	)
	BEGIN
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n' 
	END
	IF EXISTS (SELECT * FROM ventas V
	INNER JOIN usuarios U ON U.idusuario = V.idusuario
	WHERE U.idusuario = @idusuario
	)
	BEGIN
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n' 
	END
	if(@pasoreglas = 1)
	begin
		delete from usuarios where idusuario = @idusuario
		set @respuesta = 1 
	end
end
go

/*categorias*/
create procedure spu_registrar_categoria(
	@nombrecategoria varchar(50),
	@resultado int output,
	@mensaje varchar(100) output
)as
begin
	set @resultado = 0
	if not exists (select * from categorias where nombrecategoria = @nombrecategoria)
	begin
		insert into categorias(nombrecategoria) values (@nombrecategoria)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'No se puede duplicar las categoria'
end
go

create procedure spu_editar_categoria(
	@idcategoria int,
	@nombrecategoria varchar(50),
	@resultado bit output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select * from categorias where nombrecategoria = @nombrecategoria and idcategoria != @idcategoria)
		update categorias set
		nombrecategoria = @nombrecategoria
		where idcategoria = @idcategoria
	else
	begin
		set @resultado = 0
		set @mensaje = 'No se puede repetir el nombre de la categoria'
	end
end
go

create procedure spu_eliminar_categoria(
	@idcategoria int,
	@resultado bit output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select *  from categorias c 
		inner join productosropa p on p.idcategoria = c.idcategoria 
		where c.idcategoria = @idcategoria)
	begin
		delete top(1) from categorias where idcategoria = @idcategoria
	end
	else
		begin
			set @resultado = 0
			set @mensaje = 'La categoria esta relacionada con productos'
		end
end
go

/*procediminetos de tallas*/
create procedure spu_registrar_tallasropa(
	@nombretalla varchar(50),
	@idcategoria int,
	@resultado int output,
	@mensaje varchar(100) output
)as
begin
	set @resultado = 0
	if not exists (select * from tallasropa where nombretalla = @nombretalla)
	begin
		insert into tallasropa(idcategoria, nombretalla) values (@idcategoria, @nombretalla)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'La talla ya se encuentra registrado'
end
go

create procedure spu_editar_tallasropa(
	@idtallaropa int,
	@idcategoria int,
	@nombretalla varchar(50),
	@resultado bit output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select * from tallasropa where nombretalla = @nombretalla and idtallaropa != @idtallaropa)
		update tallasropa set
		idcategoria = @idcategoria,
		nombretalla = @nombretalla
		where idtallaropa = @idtallaropa
	else
	begin
		set @resultado = 0
		set @mensaje = 'No se puede repetir la talla'
	end
end
go

create procedure spu_eliminar_tallasropa(
	@idtallaropa int,
	@resultado bit output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select *  from tallasropa tr 
		inner join productosropa pr on pr.idtallaropa = tr.idtallaropa
		where tr.idtallaropa = @idtallaropa)
	begin
		delete top(1) from tallasropa where idtallaropa = @idtallaropa
	end
	else
		begin
			set @resultado = 0
			set @mensaje = 'La Talla esta relacionada con uno de los productos y categorias'
		end
end
go
/*fin tallas*/

/*procedimineto de productos*/
create procedure spu_registrar_productoropa(
	-- @imagenes varchar(555),
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(50),
	@ubiprod varchar(30),
	@idcategoria int,
	@idtallaropa int,
	@stock int,
	@colores varchar(40),
	@numcaja varchar(50),
	@precioventa decimal(10,2),
	@devolucion varchar(30),
	@devoluciontalla varchar(10),
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 0
	-- if not exists (select * from productosropa where codigo = @codigo)
	begin
		insert into productosropa(/*imagenes,*/ codigo, nombre, descripcion, ubiprod, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, devolucion, devoluciontalla) values
		(/*@imagenes,*/ @codigo, @nombre, @descripcion, @ubiprod, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa, @devolucion, @devoluciontalla)
		set @resultado = SCOPE_IDENTITY()
	end
	-- set @mensaje = 'El codigo ya se encuentra registrado en otra prenda'
end
go

create procedure spu_editar_productoropa(
	@idproducto int,
	-- @imagenes varchar(555),
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(50),
	@ubiprod varchar(30),
	@idcategoria int,
	@idtallaropa int,
	@stock int,
	@colores varchar(40),
	@numcaja varchar(50),
	@precioventa decimal(10,2),
	@devolucion varchar(30),
	@devoluciontalla varchar(10),
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	-- if not exists (select * from productosropa where codigo = @Codigo and idproducto != @idproducto)
		update productosropa set
		/*imagenes = @imagenes,*/
		codigo = @codigo,
		nombre = @nombre,
		descripcion = @descripcion,
		ubiprod = @ubiprod,
		idcategoria = @idcategoria,
		idtallaropa = @idtallaropa,
		stock = @stock,
		colores = @colores,
		numcaja = @numcaja,
		precioventa = @precioventa,
		devolucion = @devolucion,
		devoluciontalla = @devoluciontalla
		where idproducto = @idproducto
	-- else
	/*
	begin
		set @resultado = 0
		set @mensaje = 'Ya existe un producto con el mismo codigo'
	end*/
end
go

create procedure spu_eliminar_productoropa(
	@idproducto int,
	@respuesta bit output,
	@mensaje varchar(100) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''
	declare @pasoreglas bit = 1
	if exists (select * from detalle_venta dv
	inner join productosropa p ON p.idproducto = dv.idproductos
	WHERE p.idproducto = @idproducto)
	BEGIN
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
	END
	if(@pasoreglas = 1)
	begin
		delete from productosropa where idproducto = @idproducto
		set @respuesta = 1
	end
end
go


/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------*/
create procedure spu_registrar_cliente(
	@documento varchar(50),
	@nombres varchar(50),
	@apellidos varchar(50),
	@correo varchar(50),
	@telefono varchar(20),
	@resultado int output,
	@mensaje varchar(500) output
)
as
begin
	set @resultado = 0
	declare @idpersona INT 
	if not exists (select * from clientes where documento = @documento)
	begin
		insert into clientes(documento,nombres, apellidos, correo, telefono) values
		(@documento, @nombres, @apellidos, @correo, @telefono)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El numero de documento ya existe'
end
go

create procedure spu_editar_clientes(
	@idcliente int,
	@documento varchar(50),
	@nombres varchar(50),
	@apellidos varchar(50),
	@correo varchar(50),
	@telefono varchar(20),
	@resultado bit output,
	@mensaje varchar(500) output
)
as
begin
	set @resultado = 1
	declare @idpersona int 
	if not exists (select * from clientes where documento = @documento and idcliente != @idcliente)
	begin
		update clientes set
		documento = @Documento,
		nombres = @nombres,
		apellidos = @apellidos,
		correo = @correo,
		telefono = @telefono
		where idcliente = @idcliente
	end
	else
	begin
		SET @resultado = 0
		set @mensaje = 'El numero de documento ya existe'
	end
end
go

/* ---------- PROCEDIMIENTOS PARA PROVEEDOR -----------------*/
create procedure spu_registrar_proveedores(
	@documento varchar(50),
	@razonsocial varchar(50),
	@correo varchar(50),
	@telefono varchar(50),
	@resultado int output,
	@mensaje varchar(500) output
)
as
begin
	set @resultado = 0
	declare @idpersona int 
	if not exists (select * from proveedores where documento = @documento)
	begin
		insert into proveedores(documento, razonsocial, correo, telefono) values (@documento, @razonsocial, @correo, @telefono)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El numero de documento ya existe'
end
go

create procedure spu_editar_proveedores(
	@idproveedor int,
	@documento varchar(50),
	@razonsocial varchar(50),
	@correo varchar(50),
	@telefono varchar(50),
	@resultado int output,
	@mensaje varchar(500) output
)
as
begin
	SET @resultado = 1
	DECLARE @idpersona INT 
	IF NOT EXISTS (select * from proveedores where documento = @documento and idproveedor != @idproveedor)
	begin
		update proveedores set
		documento = @documento,
		razonsocial = @razonsocial,
		correo = @correo,
		telefono = @telefono
		where idproveedor = @idproveedor
	end
	else
	begin
		SET @resultado = 0
		set @mensaje = 'El numero de documento ya existe'
	end
end
go

create procedure spu_eliminar_proveedores(
	@idproveedor int,
	@resultado bit output,
	@mensaje varchar(500) output
)
as
begin
	SET @resultado = 1
	IF NOT EXISTS (
	 select *  from proveedores p
	 inner join compras c on p.idproveedor = c.idproveedor
	 where p.idproveedor = @idproveedor
	)
	begin
	 delete top(1) from proveedores where idproveedor = @idproveedor
	end
	ELSE
	begin
		SET @resultado = 0
		set @mensaje = 'El proveedor se encuentara relacionado a una compra'
	end
end
go

/*insertciones*/
select p.idrol, p.nombremenu from permisos p
inner join rol r on r.idrol = p.idrol
inner join usuarios u on u.idrol = r.idrol
where u.idusuario = 2

insert into negocios(nombre,ruc,direccion,logo) values
	('Valent France', '20232023', 'por ahi', null)
go

insert into rol (nombrerol) values 
	('administrador'),
	('empleados')
select * from rol
go

insert into permisos (idrol,nombremenu) values
	(1, 'menuusuarios'),
	(1, 'menucategoria'),
	(1, 'menuproductos'),
	(1, 'menuventas'),
	(1, 'menuingreso'),
	(1, 'menuclientes'),
	(1, 'menuproveedores'),
	(1, 'menureportes'),
	(1, 'menuacercade'),
	(1, 'menunegocio')
go

insert into permisos (idrol, nombremenu) values
	(2, 'menuproductos'),
	(2, 'menuventas'),
	(2, 'menuingreso'),
	(2, 'menuclientes'),
	(2, 'menuproveedores'),
	(2, 'menuacercade')
go

insert into proveedores (documento, razonsocial, correo, telefono) values ('123456789', '1234567898787', 'prueba@hotmailempresa.pe', '987654321')
go

insert into clientes (documento, nombres, apellidos, correo, telefono) values
('12345678', 'tio nacho', 'soyuz', 'tionacho@soyuz.com', '987654321')
go

insert into usuarios (documento, nombreusuario, correo, clave, idrol) values
	('12345678', 'pepe', 'pepe@hotmail.pe', '12345', 1),
	('12345688', 'pedro', 'pedro@gmail.com', '12345', 2)
go

insert into categorias (nombrecategoria) values
	('categoria de prueba')
select * from categorias
go

insert into tallasropa (idcategoria, nombretalla) VALUES 
	(1, 'S');
go

insert into productosropa (codigo, nombre, descripcion, ubiprod, idcategoria, idtallaropa, stock, colores, numcaja, precioventa) values
('113221466', 'prueba1', 'hola mundgg', 'caja', 1, 1, '40', 'amarillo', 'caja 12', '150'),
('113221896', 'prueba2', 'hola mundo', 'caja', 1, 1, '30', 'azul', 'bolsa 15', '69');
select * from productosropa
go