USE [PROVEEDORES]
GO

/****** Object:  Table [dbo].[proveedores]    Script Date: 9/6/2021 16:36:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[proveedores](
	[cod_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nom_proveedor] [nvarchar](80) NOT NULL,
	[direccion_proveedor] [nvarchar](80) NOT NULL,
	[tel_propietario] [int] NOT NULL,
	[correo_proveedor] [nvarchar](80) NULL,
	[productos_proveedor] [nvarchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

