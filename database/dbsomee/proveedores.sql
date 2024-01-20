/*tablas*/
create table proveedores(
	idproveedor int primary key identity,
	nombreproveedor varchar(225),
	documento varchar(50), 
	direccion varchar(50), -- direccion
	correo varchar(50),
	telefono varchar(50),
	fecharegistro date default getdate()
)
go
insert into proveedores (nombreproveedor, documento, direccion, correo, telefono) values ('provedor prueba s.a.c', '123456789', '1234567898787', 'prueba@hotmailempresa.pe', '987654321')
select idproveedor, nombreproveedor, documento, direccion, correo, telefono from proveedores

/*procedimiento*/
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