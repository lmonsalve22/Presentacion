CREATE TABLE [ADMIN].[ORIGENDATOS] (
    [ID]				FLOAT (53)    NOT NULL,
    [DESCRIPCION]		VARCHAR (250) NULL,
    [NOMBRE]			VARCHAR (250) NULL,
    [NOMBREARCHIVO]		VARCHAR (250) NULL,
    [TIPOENTIDAD]		VARCHAR (250) NULL,
    [ORGANISMO]			VARCHAR (250) NULL,
    [AUTOR]				VARCHAR (250) NULL,
    [LINK]				VARCHAR (250) NULL,
    [API]				VARCHAR (250) NULL,
    [LINKAPI]			VARCHAR (250) NULL,
    [APIPUBLICA]        VARCHAR (250) NULL,
    [TAG]				VARCHAR (250) NULL,
    [VOLUMETRIA]        FLOAT (53) NULL,
    [UNIDADVOLUMETRIA]  VARCHAR (250) NULL,
    [RUTANAVEGACION]	VARCHAR (250) NULL,
	[ENLACEDESCARGA]	VARCHAR (250) NULL,
	[OBSERVACIONES]		VARCHAR (250) NULL,
	[RUTACARPETA]		VARCHAR (250) NULL,
	[FECHACONSULTA]		DATETIME NULL,
	[FECHAINICIODATOS]	DATETIME NULL,
	[FECHAFINALDATOS]	DATETIME NULL,
    CONSTRAINT [ORIGENDATOS_PK] PRIMARY KEY CLUSTERED ([ID] ASC)
);