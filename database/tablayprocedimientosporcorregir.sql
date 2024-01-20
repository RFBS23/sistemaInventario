create table productosropatienda(
	idproductotienda int primary key identity,
	idproducto int references productosropa(idproducto),
	cantidad int default 0 not null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select * from productosropatienda
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

/*
create table detalletienda(
	iddetalletienda int primary key identity,
	idproductotienda int references productosropatienda(idproductotienda),
	idproducto int references productosropa(idproducto),
	cantidad int default 0 not null,
	fecharegistro varchar(20)not null,
)
go
select * from detalletienda
go

/*Procedimientos*/
create type [dbo].[EdetalleTienda] as table (
	[idproducto] int null,
	[cantidad] int default 0 not null,
	[fecharegistro] datetime
)
go
*/

