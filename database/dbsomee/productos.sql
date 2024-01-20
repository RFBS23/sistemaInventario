/*tablas*/
create table productosropa(
	idproducto int primary key identity,
	rutaimagen varchar(100) null,
    nombreimagen varchar(100) null,
	codigo varchar(50) not null,
	nombre varchar(50) not null,
	descripcion varchar(50) not null,
	idcategoria int references categorias(idcategoria) not null,
	idtallaropa int references tallasropa(idtallaropa) not null,
	stock int default 0 not null,
	colores varchar(40) not null,
	numcaja varchar(50) not null,
	precioventa decimal(10,2) default 0 not null,
	temporada varchar(60) not null,
	descuento int default 0,
	total decimal(10,2) default 0 not null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
insert into productosropa (codigo, nombre, descripcion, idcategoria, idtallaropa, stock, colores, numcaja, precioventa, temporada, descuento, total) values
('RTKDR19S233', 'romina', 'vestido', '3', '1', '7', 'marino', '0', '62.00', 'Verano-2023', '5', '58.9'),
('RTKDR19M233', 'romina', 'vestido', '3', '2', '7', 'marino', '0','62.00', 'Verano-2023', '5', '58.9'),
('RTKDR19L233',	'romina', 'vestido', '3', '3', '2', 'marino', '0', '62.00', 'Verano-2023', '5', '58.9'),

('RTKDL1S233', 'layka',	'polo', '3', '1', '11', 'blanco', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL1M233', 'layka',	'polo',	'3', '2', '16',	'blanco', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL1L233', 'layka',	'polo',	'3', '3', '6', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL10S233', 'layka', 'polo', '3', '1', '16', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL10M233', 'layka', 'polo', '3', '2', '12', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),
('RTKDL10L233', 'layka', 'polo', '3', '3', '5', 'negro', '0', '55.00', 'Verano-2023', '8', '50.6'),

('RTKDZ3S233', 'zelda', 'enterizo', '2', '1', '14', 'verde print', '0', '29.90', 'Verano-2023', '2', '29.30'),
('RTKDZ3M233', 'zelda', 'enterizo', '2', '2', '16', 'verde print', '0', '29.90', 'Verano-2023', '2', '29.30'),
('RTKDZ3L233', 'zelda', 'enterizo', '2', '3', '8', 'verde print', '0', '29.90', 'Verano-2023', '2', '29.30'),

('VESH30S23', 'hila', 'vestido', '3', '1', '18', 'vino', '0', '62.00', 'verano 2023', '20', '49.6');
select * from productosropa
go

select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, temporada, descuento, total, CONVERT(VARCHAR(10), p.fecharegistro, 120)AS fecharegistro_producto from productosropa p
inner join categorias c on c.idcategoria = p.idcategoria
inner join tallasropa tr on tr.idtallaropa = p.idtallaropa
go


/*procedimiento de productos*/
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
