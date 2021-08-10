create procedure UsersValidate
	@nombreUsuario varchar(40),
	@clave varchar(400)
as begin
	set @clave = convert(
	varchar(max),
	hashbytes('SHA2_512', @clave),2)

	select* from USUARIOS where NombreUsuario = @nombreUsuario
	and Clave = @clave
end