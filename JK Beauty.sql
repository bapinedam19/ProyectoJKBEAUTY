CREATE DATABASE JKBeauty

create table pedidos(
Id_Pedido  int primary key,
Estado_pedido varchar(50),
Fecha_envio datetime,
Fecha_pedido datetime,
Fecha_entrega datetime,
Destinatario  varchar (50),
Direccion varchar (50)
)

create table detallepedido(
Id_Detallepedido int primary key,
Id_Pedido  int,
Id_Producto nvarchar (50),
PrecioUnidad money,
Cantidad smallint,
Descuento FLOAT,
)

CREATE TABLE proveedores(
cod_proveedor int IDENTITY(1,1) not null PRIMARY KEY,
nom_proveedor nvarchar(80) not null,
direccion_proveedor nvarchar(80) not null,
tel_propietario int not null,
correo_proveedor nvarchar(80),
productos_proveedor nvarchar(80),
Id_Pedido  int,
Constraint fk_Id_Pedido foreign key (Id_Pedido) references pedidos(Id_Pedido)
)

CREATE TABLE [dbo].[Marca](
	Id_marca [numeric](18, 0) PRIMARY KEY,
	Descripcion [nvarchar](50) NULL,
	Nombre_Marca [nvarchar](50) NULL,
	cod_proveedor int,
	Constraint fk_cod_proveedor foreign key (cod_proveedor) references proveedores(cod_proveedor)
)

CREATE TABLE [dbo].[cliente](
	[Id_cliente] [numeric](18, 0) NULL,
	[Primer_Nombre] [nvarchar](50) NULL,
	[Segundo_Nombre] [nvarchar](50) NULL,
	[Primer_Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [numeric](18, 0) NULL,
	[Correo] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

Create table Detalle_Factura(
Id_detalle_factura int primary key,
Id_Factura int,
Id_Producto int,
Descripcion varchar (50),
Cantidad int,
Precio_Venta numeric (18),
)

CREATE TABLE [dbo].[Productos](
	ID_Producto [nvarchar](50),
	[Id_marca] [numeric] NULL,
	[Nombre_Producto] [nchar](70) NULL,
	[Existencia] [nchar](1) NULL,
	[Precio_Actual] [numeric](18, 0) NULL,
	[Fecha_Vencimiento] [datetime] NULL,
	Constraint fk_Id_marca foreign key (Id_marca) references Marca(Id_marca)
) ON [PRIMARY]

CREATE TABLE [dbo].[Empleados](
	IDEmpleado [nvarchar](50)  PRIMARY KEY,
	Primer_Nombre [nvarchar](50) NULL,
	Segundo_Nombre [nvarchar](50) NULL,
	Primer_Apellido [nvarchar](50) NULL,
	Usuario [nvarchar](150) NULL,
	Contraseña [nvarchar](25) NULL
)

CREATE TABLE Factura(
idfactura char(30) primary key,
IDEmpleado [nvarchar](50) NULL,
Id_cliente [numeric](18, 0) NULL,
impuesto  numeric(18,0) not null,
metodo_pago char(30) not NULL
)