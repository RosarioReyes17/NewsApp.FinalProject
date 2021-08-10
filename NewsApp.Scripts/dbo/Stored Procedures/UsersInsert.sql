create procedure UsersInsert
	@nombreMostrar varchar(400),
	@nombreUsuario varchar(40),
	@clave varchar(400)

as begin

	set @clave = convert(
	varchar(max),hashbytes('SHA2_512', @clave),2)

	insert USUARIOS (NombreMostrar, NombreUsuario, Clave)
	values(
		@nombreMostrar, @nombreUsuario, @clave
	)

end