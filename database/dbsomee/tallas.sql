/*tablas*/
create table tallasropa (
	idtallaropa int primary key identity,
	nombretalla varchar(50) not null,
	idcategoria int references categorias(idcategoria) not null,
	estado bit not null default 1,
)
go
insert into tallasropa (idcategoria, nombretalla) VALUES 
	(1, 'S'),
	(1, 'M'),
	(1, 'L'),
	(1, 'xl');
go
SELECT * FROM tallasropa
go
select idtallaropa, c.idcategoria, c.nombrecategoria, nombretalla from tallasropa tr
inner join categorias c on c.idcategoria = tr.idcategoria
go

/*procedimiento*/
create procedure spu_registrar_tallasropa(
	@nombretalla varchar(50),
	@idcategoria int,
	@resultado int output,
	@mensaje varchar(100) output
)as
begin
	set @resultado = 0
	begin
		insert into tallasropa(idcategoria, nombretalla) values (@idcategoria, @nombretalla)
		set @resultado = SCOPE_IDENTITY()
	end
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
		update tallasropa set
		idcategoria = @idcategoria,
		nombretalla = @nombretalla
		where idtallaropa = @idtallaropa
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