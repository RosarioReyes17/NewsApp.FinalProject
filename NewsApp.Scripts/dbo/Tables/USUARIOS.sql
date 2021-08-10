CREATE TABLE [dbo].[USUARIOS] (
    [IdUsuario]     INT           IDENTITY (1, 1) NOT NULL,
    [NombreMostrar] VARCHAR (400) NOT NULL,
    [NombreUsuario] VARCHAR (40)  NOT NULL,
    [Clave]         VARCHAR (400) NOT NULL,
    CONSTRAINT [Pk_IdUser] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

