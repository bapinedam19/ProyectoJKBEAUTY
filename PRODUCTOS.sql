
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [nvarchar](50) NULL,
	[ID_Marca] [nchar](50) NULL,
	[Nombre_Producto] [nchar](70) NULL,
	[Existencia] [nchar](1) NULL,
	[Precio_Actual] [numeric](18, 0) NULL,
	[Fecha_Vencimiento] [datetime] NULL
) ON [PRIMARY]
GO
