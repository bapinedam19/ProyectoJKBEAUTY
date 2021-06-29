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
PrecioUnidad Float,
Cantidad smallint,
Descuento FLOAT,
Constraint fk_Id_Pedido foreign key (Id_Pedido) references pedidos(Id_Pedido)
)

CREATE TABLE proveedores(
cod_proveedor int IDENTITY(1,1) not null PRIMARY KEY,
nom_proveedor nvarchar(80) not null,
direccion_proveedor nvarchar(80) not null,
tel_propietario int not null,
correo_proveedor nvarchar(80),
productos_proveedor nvarchar(80),
Id_Pedido  int,
)

CREATE TABLE [dbo].[Marca](
	Id_marca [int] PRIMARY KEY,
	Descripcion [nvarchar](50) NULL,
	Nombre_Marca [nvarchar](50) NULL,
	cod_proveedor int,
	Constraint fk_cod_proveedor foreign key (cod_proveedor) references proveedores(cod_proveedor)
)

CREATE TABLE [dbo].[Table_Cliente](
	[Id_cliente] [nvarchar](50) PRIMARY KEY,
	[Primer_Nombre] [nvarchar](50) NULL,
	[Segundo_Nombre] [nvarchar](50) NULL,
	[Primer_Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Correo] [nvarchar](50) NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[Empleados](
	IDEmpleado [nvarchar](50)  PRIMARY KEY,
	Primer_Nombre [nvarchar](50) NULL,
	Segundo_Nombre [nvarchar](50) NULL,
	Primer_Apellido [nvarchar](50) NULL,
	Usuario [nvarchar](150) NULL,
	Contraseña [nvarchar](25) NULL,
)

CREATE TABLE Factura(
ID_Factura int primary key,
IDEmpleado [nvarchar](50) NULL,
Id_cliente  [nvarchar](50),
impuesto  numeric(18,0) not null,
metodo_pago char(30) not NULL,
Constraint fk_IDEmpleado foreign key (IDEmpleado) references Empleados(IDEmpleado),
Constraint fk_Id_cliente foreign key (Id_cliente) references Table_Cliente(Id_cliente)
)

CREATE TABLE [dbo].[Productos](
	ID_Producto [int] PRIMARY KEY,
	[Id_marca] [INT] NULL,
	[Nombre_Producto] [nchar](70) NULL,
	[Existencia] [INT] NULL,
	[Precio_Actual] [FLOAT] NULL,
	[Fecha_Vencimiento] [datetime] NULL,
	Constraint fk_Id_marca foreign key (Id_marca) references Marca(Id_marca)
) ON [PRIMARY]

Create table Detalle_Factura(
Id_detalle_factura int primary key,
ID_Factura int,
ID_Producto int,
Descripcion varchar (50),
Cantidad int,
Precio_Venta FLOAT,
Constraint fk_Id_Producto foreign key (ID_Producto) references Productos(ID_Producto),
Constraint fk_ID_Factura foreign key (ID_Factura) references Factura(ID_Factura),
)

