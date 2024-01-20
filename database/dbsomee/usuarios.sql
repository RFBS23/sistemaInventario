/*tablas*/
create table usuarios(
	idusuario int primary key identity,
	documento varchar(50) unique not null,
	nombres varchar(100) null,
	apellidos varchar(100) null,
	nombreusuario varchar(50) not null,
	correo varchar(100) not null,
	clave varchar(150) not null,
	reestablecer bit default 1,
	idrol int references rol(idrol),
	estado bit not null default 1,
	fecharegistro datetime default getdate()
)
go
insert into usuarios (documento, nombres, apellidos, nombreusuario, correo, clave, idrol) values
	('12345678', 'lucas', 'pelucas', 'pepe', 'pepe@hotmail.pe', '12345', 1),
	('12345688', 'pedro', 'pedron', 'pedrito', 'pedro@gmail.com', '12345', 2)
select * from usuarios
go
select u.idusuario, u.documento, u.nombres, u.apellidos, u.nombreusuario, u.correo, u.clave, u.estado, r.idrol, r.nombrerol from usuarios u
inner join rol r on r.idrol = u.idrol

ALTER TABLE usuarios
ALTER COLUMN nombres varchar(100) NULL;

ALTER TABLE usuarios
ALTER COLUMN apellidos varchar(100) NULL;

/*procedimientos*/
create procedure spu_registrar_usuario(
	@documento varchar(20),
	@nombres varchar(100),
	@apellidos varchar(100),
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
		insert into usuarios(documento, nombres, apellidos, nombreusuario, correo, clave, idrol) values
		(@documento, @nombres, @apellidos, @nombreusuario, @correo, @clave, @idrol)
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
	@nombres varchar(100),
	@apellidos varchar(100),	
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
		nombres = @nombres,
		apellidos = @apellidos,
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
