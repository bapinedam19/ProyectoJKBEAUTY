USE [JKBeauty]
GO

INSERT INTO [dbo].[proveedores]
           ([cod_proveedor]
           ,[nom_proveedor]
           ,[direccion_proveedor]
           ,[tel_propietario]
           ,[correo_proveedor]
           ,[productos_proveedor])
     VALUES
           ( '4' , 'byron', 'choloma,san pedro', '98543245', 'bPMEJIA@gmail.com', ' Shampoo'),

		   ('5', 'josue', 'cortes', '95434565', 'Jgonzales@gmail.com', 'crema corporal'),

		   ('7', 'jancarlos', 'santa barbara' , '97837895', 'Jmurrilocom' , 'crema facial'),

		   ('9' , 'carlos', 'tegucigalpa', '90484645' , 'ccruz@gmail.com', 'jabon rostro'),

		   ('10', 'jared', 'copan', '90483505', 'Jurbina@gmail.com', 'mascarillas rostro')

GO


