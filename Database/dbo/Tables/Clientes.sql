CREATE TABLE dbo.Clientes
(
	   ClientesId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Clientes PRIMARY KEY CLUSTERED(ClientesId)
	 , Nombre VARCHAR(250) NOT NULL
	 , Direccion VARCHAR(500) NOT NULL
	 , Telefono VARCHAR(500) NOT NULL
	 , AngeciasId INT NOT NULL 
		CONSTRAINT FK_Clientes_Angecias FOREIGN KEY(AngeciasId) REFERENCES dbo.Angecias(AngeciasId)
	 , Estado BIT
)
WITH (DATA_COMPRESSION = PAGE)
GO