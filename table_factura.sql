-- 
CREATE TABLE Factura(
idfactura char(30) primary key,
impuesto  numeric(18,0) not null,
metodo_pago char(30) not null
);