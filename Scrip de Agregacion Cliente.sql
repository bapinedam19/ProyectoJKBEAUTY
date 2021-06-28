USE [JKBeauty]
GO
/****** Object:  Table [dbo].[Table_Cliente]    Script Date: 24/06/2021 10:45:14 ******/
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
INSERT [dbo].[Table_Cliente] ([Id_cliente], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Direccion], [Telefono], [Correo]) VALUES (N'a01', N'Byron', N'Alberto', N'Pineda', N'Oropendolas Santa Cruz de Yojoa', N'97886394', N'byron9466@gmail.com')
GO
INSERT [dbo].[Table_Cliente] ([Id_cliente], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Direccion], [Telefono], [Correo]) VALUES (N'a02', N'Soany', N'Lorena', N'Pineda', N'Yojoa Santa Cruz de Yojoa', N'97942394', N'lorena@gmail.com')
GO
INSERT [dbo].[Table_Cliente] ([Id_cliente], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Direccion], [Telefono], [Correo]) VALUES (N'a03', N'Martha', N'Suyapa', N'Mejia', N'Campo Barranco', N'94810091', N'Marthasuyapa@gmail.com')
GO
INSERT [dbo].[Table_Cliente] ([Id_cliente], [Primer_Nombre], [Segundo_Nombre], [Primer_Apellido], [Direccion], [Telefono], [Correo]) VALUES (N'b01', N'Ildefonso', N'', N'Pineda', N'San Francisco de Yojoa', N'99667686', N'ildefonso57@gmail.com')
GO
