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
	@resultado int output,
	@mensaje varchar(100) output
)as
begin
	set @resultado = 0
	if not exists (select * from tallasropa where nombretalla = @nombretalla)
	begin
		insert into tallasropa(nombretalla) values (@nombretalla)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'La talla ya se encuentra registrado'
end
go

create procedure spu_editar_tallasropa(
	@idtallaropa int,
	@nombretalla varchar(50),
	@resultado bit output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select * from tallasropa where nombretalla = @nombretalla and idtallaropa != @idtallaropa)
		update tallasropa set
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
			set @mensaje = 'La Talla esta relacionada con uno de los productos'
		end
end
go
/*fin tallas*/

/*procedimineto de productos*/
create procedure spu_registrar_productoropa(
	--@imagenes varbinary(max),
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
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 0
	if not exists (select * from productosropa where codigo = @codigo)
	begin
		insert into productosropa(/**imagenes,*/ codigo, nombre, descripcion, ubiprod, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, devolucion) values
		(/*@imagenes,*/ @codigo, @nombre, @descripcion, @ubiprod, @idcategoria, @idtallaropa, @stock, @colores, @numcaja, @precioventa, @devolucion)
		set @resultado = SCOPE_IDENTITY()
	end
	set @mensaje = 'El codigo ya se encuentra registrado en otra prenda'
end
go

create procedure spu_editar_productoropa(
	@idproducto int,
	-- @imagenes varbinary(max),
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
	@resultado int output,
	@mensaje varchar(100) output
)
as
begin
	set @resultado = 1
	if not exists (select * from productosropa where codigo = @Codigo and idproducto != @idproducto)
		update productosropa set
		-- imagenes = @imagenes,
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
		devolucion = @devolucion
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
create PROC sp_RegistrarProveedor(
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
	begin
		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) values (
		@Documento,@RazonSocial,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end
GO

create PROC sp_ModificarProveedor(
@IdProveedor int,
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		SET @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end
go

create procedure sp_EliminarProveedor(
@IdProveedor int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
	 select *  from PROVEEDOR p
	 inner join COMPRA c on p.IdProveedor = c.IdProveedor
	 where p.IdProveedor = @IdProveedor
	)
	begin
	 delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'El proveedor se encuentara relacionado a una compra'
	end
end
go

/* PROCESOS PARA REGISTRAR UNA COMPRA */

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
)
GO


CREATE PROCEDURE sp_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	begin try
		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into COMPRA(IdUsuario,IdProveedor,TipoDocumento,NumeroDocumento,MontoTotal)
		values(@IdUsuario,@IdProveedor,@TipoDocumento,@NumeroDocumento,@MontoTotal)

		set @idcompra = SCOPE_IDENTITY()

		insert into DETALLE_COMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
		select @idcompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra

		update p set p.Stock = p.Stock + dc.Cantidad, 
		p.PrecioCompra = dc.PrecioCompra,
		p.PrecioVenta = dc.PrecioVenta
		from PRODUCTO p
		inner join @DetalleCompra dc on dc.IdProducto= p.IdProducto

		commit transaction registro
	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end
GO

/* PROCESOS PARA REGISTRAR UNA VENTA */

CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[IdProducto] int NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[SubTotal] decimal(18,2) NULL
)
GO

select * from usuario
go

create procedure usp_RegistrarVenta(
@IdUsuario int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@DocumentoCliente varchar(500),
@NombreCliente varchar(500),
@MontoPago decimal(18,2),
@MontoCambio decimal(18,2),
@MontoTotal decimal(18,2),
@DetalleVenta [EDetalle_Venta] READONLY,                                      
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	
	begin try

		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin  transaction registro

		insert into VENTA(IdUsuario,TipoDocumento,NumeroDocumento,DocumentoCliente,NombreCliente,MontoPago,MontoCambio,MontoTotal)
		values(@IdUsuario,@TipoDocumento,@NumeroDocumento,@DocumentoCliente,@NombreCliente,@MontoPago,@MontoCambio,@MontoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into DETALLE_VENTA(IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal)
		select @idventa,IdProducto,PrecioVenta,Cantidad,SubTotal from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end

go


create PROC sp_ReporteCompras(
 @fechainicio varchar(10),
 @fechafin varchar(10),
 @idproveedor int
 )
  as
 begin

  SET DATEFORMAT dmy;
   select 
 convert(char(10),c.FechaRegistro,103)[FechaRegistro],c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,
 u.NombreCompleto[UsuarioRegistro],
 pr.Documento[DocumentoProveedor],pr.RazonSocial,
 p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]
 from COMPRA c
 inner join USUARIO u on u.IdUsuario = c.IdUsuario
 inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
 inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
 inner join PRODUCTO p on p.IdProducto = dc.IdProducto
 inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
 where CONVERT(date,c.FechaRegistro) between @fechainicio and @fechafin
 and pr.IdProveedor = iif(@idproveedor=0,pr.IdProveedor,@idproveedor)
 end

 go

 CREATE PROC sp_ReporteVentas(
 @fechainicio varchar(10),
 @fechafin varchar(10)
 )
 as
 begin
 SET DATEFORMAT dmy;  
 select 
 convert(char(10),v.FechaRegistro,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumento,v.MontoTotal,
 u.NombreCompleto[UsuarioRegistro],
 v.DocumentoCliente,v.NombreCliente,
 p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dv.PrecioVenta,dv.Cantidad,dv.SubTotal
 from VENTA v
 inner join USUARIO u on u.IdUsuario = v.IdUsuario
 inner join DETALLE_VENTA dv on dv.IdVenta = v.IdVenta
 inner join PRODUCTO p on p.IdProducto = dv.IdProducto
 inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
 where CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
end