
create table pedidos(
Id_Pedido  int primary key,
Estado_pedido varchar(50),
Fecha_envio datetime,
Fecha_pedido datetime,
Fecha_entrega datetime,
Destinatario  varchar (50),
Direccion varchar (50)
)
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (1,'Cancelado','2021/02/13','2021/02/05','2021/02/15','Juanjo Molina','B° Morazan')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (2,'Proceso','2021/07/02','2021/06/30','2021/07/03','Gabriela Ramirez','B° Tamarindo')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (3,'Cancelado','2021/07/03','2021/07/01','2021/07/05','Michelle Brand','Col. Miraflores')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (4,'Proceso','2021/07/02','2021/06/28','2021/07/05','Estefania Giron','Col. Satelite')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (5,'Cancelado','2021/06/29','2021/07/01','2021/07/03','Juanjo Molina','B° Morazan')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (6,'Proceso','2021/07/10','2021/07/05','2021/07/12','Angie Ordoñez','B° La esperanza')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (7,'Cancelado','2021/07/13','2021/07/08','2021/07/16','Nicole Ramirez','B° La libertad')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (8,'Proceso','2021/07/15','2021/07/16','2021/07/17','Maria Alvarez','B° Morazan')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (9,'Cancelado','2021/07/12','2021/07/15','2021/07/17','Dariela Baquedano','Col. Las brisas')
INSERT[dbo].[pedidos]  ([Id_Pedido], [Estado_pedido], [Fecha_envio], [Fecha_pedido],[Fecha_entrega],[Destinatario],[Direccion]) VALUES (10,'Cancelado','2021/07/13','2021/07/15','2021/07/16','Sandra Montalvan','B° Los mangos')