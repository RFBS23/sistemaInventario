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
	@codigo varchar(50),
	@nombre varchar(50),
	@descripcion varchar(50),
	@idcategoria int,
	@idtallaropa int,
	@stock int,
	@colores varchar(40),
	@numcaja varchar(50),
	@precioventa decimal(10,2),
	@temporada VARCHAR(60),
    @descuento INT = 0,
    @total DECIMAL(10, 2) = 0,
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 0
	if not exists (select * from productosropa where codigo = @codigo)
	begin
		insert into productosropa(codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, temporada, descuento, total) values
		(@codigo, @nombre, @descripcion, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa, @temporada, @descuento, @total)
		set @resultado = SCOPE_IDENTITY()
	end
	set @mensaje = 'El codigo ya se encuentra registrado en otra prenda'
end
go

/*
CREATE PROCEDURE spu_registrar_productoropa
    @codigo VARCHAR(50),
    @nombre VARCHAR(50),
    @descripcion VARCHAR(50),
    @idcategoria INT,
    @idtallaropa INT,
    @stock INT,
    @colores VARCHAR(40),
    @numcaja VARCHAR(50),
    @precioventa DECIMAL(10, 2),
    @temporada VARCHAR(60),
    @descuento INT = 0,
    @total DECIMAL(10, 2) = 0,
    @resultado INT OUTPUT,
    @mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    DECLARE @precioConDescuento DECIMAL(10, 2);

    SET @resultado = 0;
    SET @mensaje = '';

    IF NOT EXISTS (SELECT * FROM productosropa WHERE codigo = @codigo)
    BEGIN
        -- Calcula el nuevo precio con descuento
        SET @precioConDescuento = @precioventa - (@precioventa * @descuento / 100);

        -- Inserta el nuevo producto
        INSERT INTO productosropa (codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, temporada, descuento, total)
        VALUES (@codigo, @nombre, @descripcion, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa, @temporada, @descuento, @total);

        -- Obtiene el ID del producto insertado
        SET @resultado = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SET @mensaje = 'El código ya se encuentra registrado en otra prenda';
    END
END
GO
*/
/**/

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
	@temporada VARCHAR(60),
    @descuento INT = 0,
    @total DECIMAL(10, 2) = 0,
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
		precioventa = @precioventa,
		temporada = @temporada,
		descuento = @descuento,
		total = @total
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

/* ---------- PROCEDIMIENTOS PARA CLIENTE -----------------
create procedure spu_registrar_cliente(
	@documento varchar(50),
	@nombres varchar(50),
	@apellidos varchar(50),
	@correo varchar(50),
	@telefono varchar(9),
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
*/

/* ---------- PROCEDIMIENTOS PARA PROVEEDOR -----------------*/

create procedure spu_registrar_proveedores(
	@nombreproveedor varchar(225),
	@documento varchar(50),
	@direccion varchar(50),
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
		insert into proveedores(nombreproveedor, documento, direccion, correo, telefono) values (@nombreproveedor, @documento, @direccion, @correo, @telefono)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El numero de documento ya existe'
end
go

create procedure spu_editar_proveedores(
	@idproveedor int,
	@nombreproveedor varchar(225),
	@documento varchar(50),
	@direccion varchar(50),
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
		nombreproveedor = @nombreproveedor,
		documento = @documento,
		direccion = @direccion,
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
	begin
	 	delete top(1) from proveedores where idproveedor = @idproveedor
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

/*nuevo procedimiento */
create type [dbo].[EDetalle_Venta] as table(
	[idproducto] int null,
	[precioventa] decimal(10,2) null,
	[cantidad] int null,
	[subtotal] decimal(10,2) null
)
go

create procedure spu_registrar_venta
    @idusuario int,
    @tipodocumento varchar(50),
    @numerodocumento varchar(50),
    @documentocliente varchar(50),
    @nombrecliente varchar(100),
    @montopago decimal(10,2),
    @montocambio decimal(10,2),
    @montototal decimal(10,2),
    @detalleventa [EDetalle_Venta] readonly,
    @resultado bit OUTPUT,
    @mensaje varchar(100) OUTPUT
AS
BEGIN
    BEGIN TRY
        DECLARE @idventa int = 0
        SET @resultado = 1
        SET @mensaje = ''
        
        BEGIN TRANSACTION registro

        -- Insertar en la tabla ventas
        INSERT INTO ventas(idusuario, tipodocumento, numerodocumento, documentocliente, nombrecliente, montopago, montocambio, montototal)
        VALUES (@idusuario, @tipodocumento, @numerodocumento, @documentocliente, @nombrecliente, @montopago, @montocambio, @montototal)
        
        SET @idventa = SCOPE_IDENTITY()

        -- Insertar detalles de la venta en la tabla detalle_venta
        INSERT INTO detalle_venta(idventa, idproducto, precioventa, cantidad, subtotal)
        SELECT @idventa, idproducto, precioventa, cantidad, subtotal FROM @detalleventa

		COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
        SET @resultado = 0
        SET @mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registro
    END CATCH
END
GO

-- procedimiento venta tienda
create type [dbo].[EDetalle_VentaTienda] as table(
	[idproductotienda] int null,
	--[idproducto] int null,
	[precioventa] decimal(10,2) null,
	[cantidad] int null,
	[subtotal] decimal(10,2) null
)
go

create procedure spu_registrar_ventatienda
    @idusuario int,
    @tipodocumento varchar(50),
    @numerodocumento varchar(50),
    @documentocliente varchar(50),
    @nombrecliente varchar(100),
    @montopago decimal(10,2),
    @montocambio decimal(10,2),
    @montototal decimal(10,2),
    @detalleventatienda [EDetalle_VentaTienda] readonly,
    @resultado bit OUTPUT,
    @mensaje varchar(100) OUTPUT
AS
BEGIN
    BEGIN TRY
        DECLARE @idventatienda int = 0
        SET @resultado = 1
        SET @mensaje = ''
        
        BEGIN TRANSACTION registro

        -- Insertar en la tabla ventas
        INSERT INTO ventastienda(idusuario, tipodocumento, numerodocumento, documentocliente, nombrecliente, montopago, montocambio, montototal)
        VALUES (@idusuario, @tipodocumento, @numerodocumento, @documentocliente, @nombrecliente, @montopago, @montocambio, @montototal)
        
        SET @idventatienda = SCOPE_IDENTITY()

        -- Insertar detalles de la venta en la tabla detalle_venta
        INSERT INTO detalle_ventatienda(idventatienda, idproductotienda,  precioventa, cantidad, subtotal)
        SELECT @idventatienda, idproductotienda, precioventa, cantidad, subtotal FROM @detalleventatienda

		COMMIT TRANSACTION registro
    END TRY
    BEGIN CATCH
        SET @resultado = 0
        SET @mensaje = ERROR_MESSAGE()
        ROLLBACK TRANSACTION registro
    END CATCH
END
GO


/*reporte de venta*/
create procedure spu_reporte_venta(
	@fechainicio varchar(10),
	@fechafin varchar(10)
)
as
begin
set dateformat dmy;
select
convert(char(10), v.fecharegistro, 103)[FechaRegistro], v.tipodocumento, v.numerodocumento, v.montototal,
u.nombreusuario[UsuarioRegistro], v.documentocliente, v.nombrecliente,
p.codigo[CodigoProducto], p.nombre[NombreProducto], p.descuento[Descuento], ca.nombrecategoria[Categoria], dv.precioventa, dv.cantidad, dv.subtotal
from ventas v
inner join usuarios u on u.idusuario = v.idusuario
inner join detalle_venta dv on dv.idventa = v.idventa
inner join productosropa p on p.idproducto = dv.idproducto
inner join categorias ca on ca.idcategoria = p.idcategoria
where convert(date, v.fecharegistro) between @fechainicio and @fechafin
end