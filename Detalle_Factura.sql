
Create table Detalle_Factura(
Id_detalle_factura int primary key,
Descripcion varchar (50),
Cantidad int,
Precio_Venta numeric (18),
Id_Factura int,
Id_Producto int,
Constraint fk_Id_Factura foreign key (Id_Factura) references factura(Id_Factura),
Constraint fk_Id_Producto foreign key (Id_Producto) references Producto(Id_Producto)

)