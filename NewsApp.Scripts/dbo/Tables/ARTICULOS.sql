CREATE TABLE [dbo].[ARTICULOS] (
    [IdArticulo]       INT           IDENTITY (1, 1) NOT NULL,
    [Titulo]           VARCHAR (MAX) NULL,
    [Descripcion]      VARCHAR (MAX) NULL,
    [ArticuloURL]      VARCHAR (MAX) NULL,
    [ImagenURL]        VARCHAR (MAX) NULL,
    [FechaPublicacion] DATE          NULL,
    [Contenido]        VARCHAR (MAX) NULL,
    [IdCategoria]      INT           NULL,
    [IdPais]           INT           NULL,
    [IdFuente]         INT           NULL,
    [IdAutor]          INT           NULL,
    CONSTRAINT [pk_IdArticulo] PRIMARY KEY CLUSTERED ([IdArticulo] ASC),
    CONSTRAINT [Fk_IdAutorArticulo] FOREIGN KEY ([IdAutor]) REFERENCES [dbo].[AUTORES] ([IdAutor]),
    CONSTRAINT [Fk_IdCategoria] FOREIGN KEY ([IdCategoria]) REFERENCES [dbo].[CATEGORIAS] ([IdCategoria]),
    CONSTRAINT [Fk_IdFuente] FOREIGN KEY ([IdFuente]) REFERENCES [dbo].[FUENTES] ([IdFuente]),
    CONSTRAINT [Fk_IdPais] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[PAISES] ([IdPais])
);

