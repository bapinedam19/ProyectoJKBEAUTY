create table Existencias(
Id_existencias int primary key,
ID_Producto int,
cantidad_existencias numeric(18),
cantidad_bodega numeric(18),
Cantidad_tienda numeric (18),
Constraint fk_producto FOREIGN KEY (Id_Producto) REFERENCES Productos(ID_Producto)
)