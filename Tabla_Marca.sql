USE [DESARROLLO_DE_SOFTWARE]
GO

/****** Object:  Table [dbo].[Tabla_Marca]    Script Date: 26/05/21 06:52:41 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tabla_Marca](
	[Id_marca] [numeric](18, 0) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Nombre_Marca] [nvarchar](50) NULL,
	[Id_Proveedor] [numeric](18, 0) NULL
) ON [PRIMARY]

GO

