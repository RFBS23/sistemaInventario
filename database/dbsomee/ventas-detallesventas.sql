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
select * from ventas where numerodocumento = '00002'
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
select * from detalle_venta
go


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