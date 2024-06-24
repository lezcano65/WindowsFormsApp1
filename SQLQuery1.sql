USE [QUERY_DEMO]
GO

/****** Object:  Table [dbo].[Productos]    Script Date: 24/6/2024 19:58:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Productos](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[NombreP] [nvarchar](255) NOT NULL,
	[Habilitado] [bit] NULL,
	[CategoriaFk] [int] NULL,
	[CantidadP] [int] NULL,
	[CategoriaFkNavigationCategoriaId] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([CategoriaFk])
REFERENCES [dbo].[Categorias] ([CategoriaId])
GO

ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([CategoriaFk])
REFERENCES [dbo].[Categorias] ([CategoriaId])
GO




