/*
//////////////////////////////////////////////////////////////////////////
// Criacao...........: 02/2016
// Sistema...........: Loja Virtual
// Analistas.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Desenvolvedores...: Marilene Esquiavoni & Denny Paulista Azevedo Filho
// Copyright.........: Marilene Esquiavoni & Denny Paulista Azevedo Filho
//////////////////////////////////////////////////////////////////////////
*/

USE [Loja]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

/****** Object:  Table [dbo].[Cliente]  ******/
CREATE TABLE [dbo].[Cliente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](60) NOT NULL,
	[EMAIL] [nvarchar](60) NOT NULL,
	[Senha] [char](10) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[TipoVenda] ******/
CREATE TABLE [dbo].[TipoVenda](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TipoVenda] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Venda]  ******/
CREATE TABLE [dbo].[Venda]
	(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_TipoVenda] [int] NOT NULL,
	[DataVenda] [datetime] NOT NULL,
	[ValorTotal] [decimal](16, 2) NOT NULL,
	[Status] [char](1) NOT NULL
CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
	(
	[ID]
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Categoria] ******/
CREATE TABLE [dbo].[Categoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Fabricante] ******/
CREATE TABLE [dbo].[Fabricante](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK_Fabricante] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Produto]  ******/
CREATE TABLE [dbo].[Produto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](60) NOT NULL,
	[Descricao] [nvarchar](150) NOT NULL,
	[Valor] [decimal](16, 2) NOT NULL,
	[DataCadastro] [datetime] NOT NULL,
	[Foto] [nvarchar](50) NOT NULL,
	[Destaque] [char](1) NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[ID_Fabricante] [int] NOT NULL,
	[Garantia] [nvarchar](30) NOT NULL,
	[Foto2] [nvarchar](50) NOT NULL,
	[Foto3] [nvarchar](50) NOT NULL,
	[Foto4] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ItemVenda] ******/
CREATE TABLE [dbo].[ItemVenda](
	[ID_Venda] [int] NOT NULL,
	[ID_Produto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](16, 2) NOT NULL,
	[SubTotal] [decimal](16,2) NOT NULL,
 CONSTRAINT [PK_ItemVenda] PRIMARY KEY CLUSTERED 
(
	[ID_Venda] ASC,
	[ID_Produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Comentario]  ******/
CREATE TABLE [dbo].[Comentario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](60) NOT NULL,
	[EMail] [nvarchar](60) NOT NULL,
	[Descricao] [nvarchar](200) NOT NULL,
	[ID_Produto] [int] NOT NULL,
	[Nota] [int] NOT NULL,
 CONSTRAINT [PK_Comentario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Banner]   ******/
CREATE TABLE [dbo].[Banner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageUrl] [nvarchar](50) NOT NULL,
	[NavigateUrl] [nvarchar](100) NOT NULL,
	[AlternateText] [nvarchar](30) NOT NULL,
	[Impressions] [int] NOT NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Relacionamentos   ******/
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD  CONSTRAINT [FK_Comentario_Produto] FOREIGN KEY([ID_Produto])
REFERENCES [dbo].[Produto] ([ID])
GO

ALTER TABLE [dbo].[Comentario] CHECK CONSTRAINT [FK_Comentario_Produto]
GO

ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Produto] FOREIGN KEY([ID_Produto])
REFERENCES [dbo].[Produto] ([ID])
GO

ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Produto]
GO

ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Venda] FOREIGN KEY([ID_Venda])
REFERENCES [dbo].[Venda] ([ID])
GO

ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Venda]
GO

ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID])
GO

ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Categoria]
GO

ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Fabricante] FOREIGN KEY([ID_Fabricante])
REFERENCES [dbo].[Fabricante] ([ID])
GO

ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Fabricante]
GO

ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Cliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID])
GO

ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Cliente]
GO

ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_TipoVenda] FOREIGN KEY([ID_TipoVenda])
REFERENCES [dbo].[TipoVenda] ([ID])
GO

ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_TipoVenda]
GO