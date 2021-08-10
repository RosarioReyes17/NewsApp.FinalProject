CREATE TABLE [dbo].[PAISES] (
    [IdPais]     INT          IDENTITY (1, 1) NOT NULL,
    [NombrePais] VARCHAR (50) NULL,
    CONSTRAINT [pk_IdPais] PRIMARY KEY CLUSTERED ([IdPais] ASC)
);

