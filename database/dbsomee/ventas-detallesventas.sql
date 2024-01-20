/*tablas*/
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
select * from ventas where numerodocumento = '00001'
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

select v.idventa, u.nombreusuario, v.documentocliente, v.nombrecliente, v.tipodocumento,
v.numerodocumento, v.montopago, v.montocambio, v.montototal, convert(char(10), v.fecharegistro, 103)[FechaRegistro] from ventas v
inner join usuarios u on u.idusuario = v.idusuario
where v.numerodocumento = '00001'

select p.nombre + ' ' + p.descripcion + ' ' + p.colores + ' ' + tr.nombretalla as productos, p.descuento, dv.precioventa, dv.cantidad, dv.subtotal from detalle_venta dv
inner join productosropa p on p.idproducto = dv.idproducto
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
where dv.idventa = '00001'


/*procediminetos*/
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
