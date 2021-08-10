CREATE TABLE [dbo].[CATEGORIAS] (
    [IdCategoria]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreCategoria] VARCHAR (50) NULL,
    CONSTRAINT [pk_IdCategoria] PRIMARY KEY CLUSTERED ([IdCategoria] ASC)
);

