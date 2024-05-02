CREATE DATABASE CAPAS_PRACTICA1
GO

USE CAPAS_PRACTICA1
GO

--Drop DATABASE CAPAS_PRACTICA1;*/

CREATE TABLE CLIENTES(
	ID_CLIENTE int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	NOMBRE varchar(80) NOT NULL,
	TELEFONO varchar(11) NULL,
	DIRECCION varchar(80) NULL,
)

CREATE TABLE ENCABEZADO_FACTURA(
	ID_FACTURA int IDENTITY NOT NULL PRIMARY KEY, 
	FECHA datetime NOT NULL, 
	ID_CLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(ID_CLIENTE), 
	SUBTOTAL DECIMAL NOT NULL, 
	IMPUESTO DECIMAL NOT NULL, 
	MONTO_DESCUENTO DECIMAL
)

CREATE TABLE PRODUCTOS(
	ID_PRODUCTO int IDENTITY NOT NULL PRIMARY KEY, 
	DESCRIPCION varchar(40) NOT NULL, 
	PRECIO_COMPRA varchar(40) NOT NULL, 
	PRECIO_VENTA varchar(40) NOT NULL, 
	GRAVADO varchar(40) NOT NULL
)

CREATE TABLE DETALLE_FACTURA(
	ID_FACTURA INT not null FOREIGN KEY REFERENCES ENCABEZADO_FACTURA(ID_FACTURA), 
	ID_PRODUCTO INT not null FOREIGN KEY REFERENCES PRODUCTOS(ID_PRODUCTO),
	CANTIDAD int NOT NULL
)

select * from clientes;
select * from PRODUCTOS;


CREATE PROCEDURE ELIMINAR
		@idcliente int,  --recibe un id
		@msj varchar(50) out   --devuelve un mensaje
AS BEGIN
if (not exists(select * from CLIENTES where ID_CLIENTE=@idcliente))
	begin
		set @msj='El cliente no existe'
		return 0
	end
else
	begin
		if(not existS(select * from ENCABEZADO_FACTURA where ID_CLIENTE = @IDCLIENTE))
			begin
				DELETE from CLIENTES where ID_CLIENTE = @idcliente
				set @msj='Cliente eliminado'
				return 1
			end
		else
		begin
			set @msj = 'No se puede eliminar, el Cliente tiene facturas.'
			return 0 
		end
end 
END
GO


--CREATE PROCEDURE ELIMINAR
--		@idcliente int,  --recibe un id
--		@msj varchar(50) out   --devuelve un mensaje
--AS BEGIN
--if (not exists(select * from CLIENTES where ID_CLIENTE=@idcliente))
--	begin
--		set @msj='El cliente no existe'
--		return 0
--	end
--else
--	begin
--		if(not existS(select * from ENCABEZADO_FACTURA where ID_CLIENTE = @IDCLIENTE))
--			begin
--				DELETE from CLIENTES where ID_CLIENTE = @idcliente
--				set @msj='Cliente eliminado'
--				return 1
--			end
--		else
--		begin
--			set @msj = 'No se puede eliminar, el Cliente tiene facturas.'
--			return 0 
--		end
--end 
--END
--G
INSERT INTO CLIENTES (NOMBRE, TELEFONO, DIRECCION)
VALUES ('Mariel','83912061','Palmares')