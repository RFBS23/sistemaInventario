/*por ejecutar*/
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

-- procedimientos
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