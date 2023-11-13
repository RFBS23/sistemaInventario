use sistemainventariovf
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
	(1, 'menuconfiguracion'),
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
insert into clientes (documento, nombres, apellidos, correo, telefono) values ('12345678', 'tio nacho', 'soyuz', 'tionacho@soyuz.com', '987654321')
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
insert into tallasropa (idcategoria, nombretalla) VALUES 
	(1, 'S');
go
select * from tallasropa
go
select idtallaropa, c.idcategoria, c.nombrecategoria, nombretalla from tallasropa tr
inner join categorias c on c.idcategoria = tr.idcategoria
go

create table productosropa(
	idproducto int primary key identity,
	imagenes varbinary(max) NULL,
	codigo varchar(50) not null,
	nombre varchar(50) not null,
	descripcion varchar(50) not null,
	idcategoria int references categorias(idcategoria) not null,
	idtallaropa int references tallasropa(idtallaropa) not null,
	stock int default 0 not null,
	colores varchar(40) not null,
	numcaja varchar(50) not null,
	precioventa decimal(10,2) default 0 not null,
	devolucion varchar(30) null,
	devoluciontalla varchar(10) null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
insert into productosropa (codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa) values
('113221466', 'prueba1', 'hola mundgg', 1, 1, '40', 'amarillo', '12', '150');
select * from productosropa
go

select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, devolucion, devoluciontalla from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
go

create table productosropatienda(
	idproductotienda int primary key identity,
	idusuario int references usuarios(idusuario),
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go

select count(*) + 1 from productosropatienda

create table detalletienda(
	iddetalletienda int primary key identity,
	idproductotienda int references productosropatienda(idproductotienda),
	idproducto int references productosropa(idproducto),
	cantidad int default 0 not null,
	fecharegistro varchar(20)not null
)
go
SELECT dt.iddetalletienda, dt.idproductotienda, pr.idproducto, pr.codigo, pr.nombre, pr.descripcion, cat.idcategoria, cat.nombrecategoria, tr.idtallaropa, tr.nombretalla, pr.stock, pr.colores, pr.numcaja, pr.precioventa, pr.devolucion, pr.devoluciontalla, pr.estado AS estado_producto, CONVERT(VARCHAR(10), pr.fecharegistro, 120)AS fecharegistro_producto, dt.cantidad, convert(varchar(12), dt.fecharegistro, 120) AS fecharegistro_detalletienda FROM detalletienda dt
JOIN productosropa pr ON dt.idproducto = pr.idproducto
JOIN categorias cat ON pr.idcategoria = cat.idcategoria
JOIN tallasropa tr ON pr.idtallaropa = tr.idtallaropa;
select * from detalletienda
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
	idproducto int references productosropa(idproducto),
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

-- procedimientos almacenado

/*usuarios*/
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
	-- if not exists (select * from tallasropa where nombretalla = @nombretalla)
	begin
		insert into tallasropa(idcategoria, nombretalla) values (@idcategoria, @nombretalla)
		set @resultado = SCOPE_IDENTITY()
	end
	-- else
		-- set @mensaje = 'La talla ya se encuentra registrado'
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
	-- if not exists (select * from tallasropa where nombretalla = @nombretalla and idtallaropa != @idtallaropa)
		update tallasropa set
		idcategoria = @idcategoria,
		nombretalla = @nombretalla
		where idtallaropa = @idtallaropa
	-- else
	/*
	begin
		set @resultado = 0
		set @mensaje = 'No se puede repetir la talla'
	end*/
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

/*procedimineto de productos*/
create procedure spu_registrar_productoropa(
	-- @imagenes varchar(555),
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(50),
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
	if not exists (select * from productosropa where codigo = @codigo)
	begin
		insert into productosropa(/*imagenes,*/ codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, devolucion, devoluciontalla) values
		(/*@imagenes,*/ @codigo, @nombre, @descripcion, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa, @devolucion, @devoluciontalla)
		set @resultado = SCOPE_IDENTITY()
	end
	set @mensaje = 'El codigo ya se encuentra registrado en otra prenda'
end
go

create procedure spu_editar_productoropa(
	@idproducto int,
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(50),
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
	if not exists (select * from productosropa where codigo = @Codigo and idproducto != @idproducto)
		update productosropa set
		/*imagenes = @imagenes,*/
		codigo = @codigo,
		nombre = @nombre,
		descripcion = @descripcion,
		idcategoria = @idcategoria,
		idtallaropa = @idtallaropa,
		stock = @stock,
		colores = @colores,
		numcaja = @numcaja,
		precioventa = @precioventa,
		devolucion = @devolucion,
		devoluciontalla = @devoluciontalla
		where idproducto = @idproducto
	else	
	begin
		set @resultado = 0
		set @mensaje = 'Ya existe un producto con el mismo codigo'
	end
end
go

create procedure spu_eliminar_productoropa(
	@idproducto int,
	@respuesta bit output,
	@mensaje varchar(100) output
)
as
begin
    set @respuesta = 0;
    set @mensaje = '';
    declare @pasoreglas bit = 1;

    -- Verificar si el producto está relacionado a una venta en detalle_venta
    if exists (
            select *
            from detalle_venta dv
            inner join productosropa p on p.idproducto = dv.idproducto
            where p.idproducto = @idproducto
        )
    begin
        set @pasoreglas = 0;
        set @respuesta = 0;
        set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA';
    end

    -- Verificar si el producto está relacionado a la tabla detalletienda
    if exists (
            SELECT *
            FROM detalletienda dt
            WHERE dt.idproducto = @idproducto
        )
    begin
        set @pasoreglas = 0;
        set @respuesta = 0;
        set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra ubicado en la tienda';
    end

    if (@pasoreglas = 1)
    begin
        delete from productosropa where idproducto = @idproducto;
        set @respuesta = 1;
    end
end;
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
	set @resultado = 1
	if not exists (
		select *  from proveedores p
		inner join compras c on p.idproveedor = c.idproveedor
		where p.idproveedor = @idproveedor
	)
	begin
	 	delete top(1) from proveedores where idproveedor = @idproveedor
	end
	else
	begin
		set @resultado = 0
		set @mensaje = 'El proveedor se encuentara relacionado a una compra'
	end
end
go

create procedure ContarProductos
as
begin
    declare @TotalProductos int;

    select @TotalProductos = count(*) from productosropa;

    select @TotalProductos as 'TotalProductos';
end
go
exec ContarProductos;

create type [dbo].[EdetalleTienda] as table (
	[idproducto] int null,
	[cantidad] int default 0 not null,
	[fecharegistro] datetime
)
go

create procedure spu_registrar_productosropatienda(
    @idusuario int,
    @cantidad int,
    @fecharegistro varchar(20),
	@detalletienda [Edetalletienda] readonly,
    @resultado bit output,
    @mensaje varchar(100) output
)
as
begin
    begin try
		declare @idproductotienda int = 0
		set @resultado = 1
		set @mensaje = ''
		begin transaction registro
		insert into productosropatienda(idusuario)
		values (@idusuario)
		set @idproductotienda = SCOPE_IDENTITY()
		insert into detalletienda(idproductotienda, idproducto, cantidad, fecharegistro)
		select @idproductotienda, idproducto, cantidad, fecharegistro from @detalletienda

		update pr
		set pr.stock = pr.stock - dt.cantidad
		from productosropa pr
		inner join @detalletienda dt on dt.idproducto = pr.idproducto

		commit transaction registro
	end try
	begin catch
		set @resultado = 0
		set @mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
go

