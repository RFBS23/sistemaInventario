/*tablas*/
create table categorias(
	idcategoria int primary key identity,
	nombrecategoria varchar(100) not null,
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
select idcategoria, nombrecategoria, fecharegistro from categorias
go
insert into categorias (nombrecategoria) values
	('Caballero Adulto'),
	('Damas Juvenil'),
	('Dama Adulta'),
	('caballero Juvenil');
select * from categorias
go


/*procedimientos*/
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