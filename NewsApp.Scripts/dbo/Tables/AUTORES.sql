CREATE TABLE [dbo].[AUTORES] (
    [IdAutor]        INT           IDENTITY (1, 1) NOT NULL,
    [NombreCompleto] VARCHAR (100) NULL,
    [IdUsuario]      INT           NULL,
    CONSTRAINT [Pk_IdAutor] PRIMARY KEY CLUSTERED ([IdAutor] ASC),
    CONSTRAINT [Fk_IdUsuarioAutor] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[USUARIOS] ([IdUsuario])
);

