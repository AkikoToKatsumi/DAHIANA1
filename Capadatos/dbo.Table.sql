﻿CREATE TABLE [dbo].[Cargo]
(
	[IdCargo] INT NOT NULL PRIMARY KEY, 
    [Cargo] NCHAR(70) NOT NULL, 
    [Funciones] NVARCHAR(MAX) NULL, 
    [Estado] NVARCHAR(10) NOT NULL DEFAULT 'ACTIVO'
)
