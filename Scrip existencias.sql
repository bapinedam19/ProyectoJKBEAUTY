create table Existencias(
Id_existencias int primary key,
ID_Producto int,
cantidad_existencias int Null,
cantidad_bodega int Null,
Cantidad_tienda int Null,
Constraint fk_producto FOREIGN KEY (Id_Producto) REFERENCES Producto(ID_Producto)
)

INSERT [dbo].[Existencias] ([Id_existencias], [ID_Producto], [cantidad_existencias], [cantidad_bodega],[Cantidad_tienda]) VALUES (1, 2, 50,30,20)
INSERT [dbo].[Existencias] ([Id_existencias], [ID_Producto], [cantidad_existencias], [cantidad_bodega],[Cantidad_tienda]) VALUES (2, 3, 60,30,30)
INSERT [dbo].[Existencias] ([Id_existencias], [ID_Producto], [cantidad_existencias], [cantidad_bodega],[Cantidad_tienda]) VALUES (3, 4,100, 50,50)
INSERT [dbo].[Existencias] ([Id_existencias], [ID_Producto], [cantidad_existencias], [cantidad_bodega],[Cantidad_tienda]) VALUES (4, 5,120,60,60)
INSERT [dbo].[Existencias] ([Id_existencias], [ID_Producto], [cantidad_existencias], [cantidad_bodega],[Cantidad_tienda]) VALUES (5, 6, 40,15,25)
INSERT [dbo].[Existencias] ([Id_existencias], [ID_Producto], [cantidad_existencias], [cantidad_bodega],[Cantidad_tienda]) VALUES (6, 7,100,50,50)