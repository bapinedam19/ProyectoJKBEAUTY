USE [DESARROLLO_DE_SOFTWARE]
GO

/****** Object:  Table [dbo].[Tabla_cliente]    Script Date: 26/05/21 06:44:24 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tabla_cliente](
	[Id_cliente] [numeric](18, 0) NULL,
	[Primer_Nombre] [nvarchar](50) NULL,
	[Segundo_Nombre] [nvarchar](50) NULL,
	[Primer_Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [numeric](18, 0) NULL,
	[Correo] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

