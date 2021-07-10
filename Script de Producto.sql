create database pruebasql

CREATE TABLE [dbo].[Producto](
	ID_Producto int PRIMARY KEY,
	[Id_marca] INT NULL,
	[Nombre_Producto] nvarchar(50) NULL,
	[Existencia] int NULL,
	[Precio_Actual] nvarchar (50) NULL,
	[Fecha_Vencimiento] nvarchar (50) NULL,
	
) ON [PRIMARY]
go

INSERT [dbo].[Producto] ([ID_Producto], [Id_marca], [Nombre_Producto], [Existencia],[Precio_Actual],[Fecha_Vencimiento]) VALUES (2, 30,'Victoria', 50, 1000, '2022/06/31')
INSERT [dbo].[Producto] ([ID_Producto], [Id_marca], [Nombre_Producto], [Existencia],[Precio_Actual],[Fecha_Vencimiento]) VALUES (3, 31,'Channel', 60, 2000, '2022/04/05')
INSERT [dbo].[Producto] ([ID_Producto], [Id_marca], [Nombre_Producto], [Existencia],[Precio_Actual],[Fecha_Vencimiento]) VALUES (4, 32,'Nivea', 100, 3000, '2022/07/20')
INSERT [dbo].[Producto] ([ID_Producto], [Id_marca], [Nombre_Producto], [Existencia],[Precio_Actual],[Fecha_Vencimiento]) VALUES (5, 33,'Victoria', 120, 4000, '2022/01/21')
INSERT [dbo].[Producto] ([ID_Producto], [Id_marca], [Nombre_Producto], [Existencia],[Precio_Actual],[Fecha_Vencimiento]) VALUES (6, 34,'Versage', 40, 5000, '2022/09/10')
INSERT [dbo].[Producto] ([ID_Producto], [Id_marca], [Nombre_Producto], [Existencia],[Precio_Actual],[Fecha_Vencimiento]) VALUES (7, 35,'Nivea', 100, 6000, '2022/08/14')
GO

select * from Producto
go