USE [cliente]
GO

/****** Object:  Table [dbo].[Table_Cliente]    Script Date: 21/06/2021 9:38:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_Cliente](
	[Id_cliente] [nvarchar](50) NULL,
	[Primer_Nombre] [nvarchar](50) NULL,
	[Segundo_Nombre] [nvarchar](50) NULL,
	[Primer_Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL
) ON [PRIMARY]
GO



