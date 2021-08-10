CREATE TABLE [dbo].[FUENTES] (
    [IdFuente]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreFuente] VARCHAR (50) NULL,
    CONSTRAINT [pk_IdFuente] PRIMARY KEY CLUSTERED ([IdFuente] ASC)
);

