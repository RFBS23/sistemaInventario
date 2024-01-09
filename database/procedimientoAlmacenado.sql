use sistemainventario
go

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
		insert into usuarios(documento, nombreusuario, correo, clave, idrol) values
		(@documento, @nombreusuario, @correo, @clave, @idrol)
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
	IF EXISTS (SELECT * FROM productosropatienda prt 
	INNER JOIN usuarios U ON U.idusuario = prt.idusuario
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
/*fin tallas*/

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
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 0
	if not exists (select * from productosropa where codigo = @codigo)
	begin
		insert into productosropa(codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa) values
		(@codigo, @nombre, @descripcion, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa)
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
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select * from productosropa where codigo = @Codigo and idproducto != @idproducto)
		update productosropa set
		codigo = @codigo,
		nombre = @nombre,
		descripcion = @descripcion,
		idcategoria = @idcategoria,
		idtallaropa = @idtallaropa,
		stock = @stock,
		colores = @colores,
		numcaja = @numcaja,
		precioventa = @precioventa
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

