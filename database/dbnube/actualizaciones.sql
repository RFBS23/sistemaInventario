/*tablas*/



/*procedimiento almacenados*/
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


