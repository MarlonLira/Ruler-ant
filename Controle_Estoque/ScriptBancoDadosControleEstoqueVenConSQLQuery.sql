USE [ELTON_Simoes]
GO
/****** Object:  Table [dbo].[tblOperacao]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblOperacao](
	[IDOperacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblOperacao] PRIMARY KEY CLUSTERED 
(
	[IDOperacao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPessoaTipo]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoaTipo](
	[IDPessoaTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblPessoaTipo] PRIMARY KEY CLUSTERED 
(
	[IDPessoaTipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSituacao]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSituacao](
	[IDSituacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblSituacao] PRIMARY KEY CLUSTERED 
(
	[IDSituacao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProduto]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduto](
	[IDProduto] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblProduto] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoInserir]    Script Date: 07/30/2016 17:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoInserir]
	@Descricao AS VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			--Não inserir produto existente no banco
			IF(EXISTS(SELECT Descricao FROM tblProduto WHERE Descricao = @Descricao))
				RAISERROR('Produto já existente produto com essa descrição!', 14, 1);
				
			--1ºInserir na tabela tblProduto
			INSERT INTO tblProduto (Descricao)
			VALUES (@Descricao)
			
			SELECT @@IDENTITY AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoConsultarPorCodigoDescricao]    Script Date: 07/30/2016 17:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoConsultarPorCodigoDescricao]
	@IDProduto INT = NULL,
	@Descricao VARCHAR(100) = NULL
AS
BEGIN
	SELECT tblProduto.IDProduto, tblProduto.Descricao FROM tblProduto
	WHERE (@IDProduto IS NULL OR tblProduto.IDProduto = @IDProduto) AND
		(@Descricao IS NULL OR tblProduto.Descricao LIKE '%' + @Descricao + '%')
END
GO
/****** Object:  Table [dbo].[tblPreco]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPreco](
	[IDProduto] [int] NOT NULL,
	[IDPreco] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPreco] PRIMARY KEY CLUSTERED 
(
	[IDProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoa](
	[IDPessoa] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaTipo] [int] NOT NULL,
 CONSTRAINT [PK_tblPessoa] PRIMARY KEY CLUSTERED 
(
	[IDPessoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFornecedor](
	[IDPessoaFornecedor] [int] NOT NULL,
 CONSTRAINT [PK_tblFornecedor] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFornecedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFilial]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFilial](
	[IDPessoaFilial] [int] NOT NULL,
 CONSTRAINT [PK_tblFilial] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPedido]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedido](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[DataHora] [date] NOT NULL,
	[IDOperacao] [int] NOT NULL,
	[IDSituacao] [int] NOT NULL,
	[IDPessoaEmitente] [int] NOT NULL,
	[IDPessoaDestinatario] [int] NOT NULL,
 CONSTRAINT [PK_tblPedido] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPessoaJuridica]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoaJuridica](
	[IDPessoaJuridica] [int] NOT NULL,
	[NomeFantasia] [varchar](50) NOT NULL,
	[RazaoSocial] [varchar](50) NOT NULL,
	[CNPJ] [varchar](14) NOT NULL,
	[InscricaoEstadual] [varchar](50) NULL,
	[DataFundacao] [date] NOT NULL,
 CONSTRAINT [PK_iDPessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[IDPessoaJuridica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPessoaFisica]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPessoaFisica](
	[IDPessoaFisica] [int] NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[CPF] [varchar](11) NOT NULL,
	[RG] [varchar](20) NULL,
	[DataNascimento] [date] NOT NULL,
 CONSTRAINT [PK_tblPessoaFisica] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFisica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCliente](
	[IDPessoaCliente] [int] NOT NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[IDPessoaCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorInserir]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFornecedorInserir]
	@IDPessoaFornecedor AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			--Não inserir Fornecedor igual no banco
			IF(EXISTS(SELECT IDPessoaFornecedor FROM tblFornecedor WHERE IDPessoaFornecedor = @IDPessoaFornecedor))
				RAISERROR('Fornecedor já existente!', 14, 1);
				
			--1ºInserir na tabela tblFornecedor
			INSERT INTO tblFornecedor (IDPessoaFornecedor)
			VALUES (@IDPessoaFornecedor)
			
			SELECT @IDPessoaFornecedor AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaJuridicaInserir]    Script Date: 07/30/2016 17:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPessoaJuridicaInserir]
	@NomeFantasia AS VARCHAR(50),
	@RazaoSocial AS VARCHAR(50),
	@CNPJ AS VARCHAR(14),
	@InscricaoEstadual AS VARCHAR(20),
	@DataFundacao AS DATE
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			--Não inserir CNPJ igual no banco
			IF(EXISTS(SELECT IDPessoaJuridica FROM tblPessoaJuridica WHERE CNPJ = @CNPJ))
				RAISERROR('CNPJ já existente!', 14, 1);
				
			--1º Inserir na tabela tblPessoa
			INSERT INTO tblPessoa (IDPessoaTipo)
			VALUES (2);
			
			DECLARE @IDPessoa AS INT;
			SET @IDPessoa = @@IDENTITY
			
			--2ºInserir na tabela tblPessoaJuridica
			INSERT INTO tblPessoaJuridica
			(
				IDPessoaJuridica,
				NomeFantasia,
				RazaoSocial,
				CNPJ,
				InscricaoEstadual,
				DataFundacao
			)
			VALUES
			(
				@IDPessoa,
				@NomeFantasia,
				@RazaoSocial,
				@CNPJ,
				@InscricaoEstadual,
				@DataFundacao
			)
			
			SELECT @IDPessoa AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPessoaFisicaInserir]    Script Date: 07/30/2016 17:50:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPessoaFisicaInserir]
	@Nome AS VARCHAR(50),
	@CPF AS VARCHAR(11),
	@RG AS VARCHAR(20),
	@DataNascimento AS DATE
AS
BEGIN
--Exceção
--Transação
	BEGIN TRY
		BEGIN TRAN
		
			IF(EXISTS(SELECT IDPessoaFisica FROM tblPessoaFisica WHERE CPF = @CPF))
				RAISERROR('CPF já existe', 14, 1);
		
			DECLARE @IDPessoa INT;
			INSERT INTO tblPessoa (IDPessoaTipo) VALUES (1);
			SET @IDPessoa = @@IDENTITY;
			
			INSERT INTO tblPessoaFisica (IDPessoaFisica, Nome, CPF, RG, DataNascimento)
			VALUES (@IDPessoa, @Nome, @CPF, @RG, @DataNascimento);
			
			SELECT @IDPessoa AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspFilialInserir]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFilialInserir]
	@IDPessoaFilial AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			--Não inserir Filial igual no banco
			IF(EXISTS(SELECT IDPessoaFilial FROM tblFilial WHERE IDPessoaFilial = @IDPessoaFilial))
				RAISERROR('Filial já existente!', 14, 1);
				
			--1ºInserir na tabela tblFilial
			INSERT INTO tblFilial (IDPessoaFilial)
			VALUES (@IDPessoaFilial)
			
			SELECT @IDPessoaFilial AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteInserir]
	@IDPessoaCliente AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			--Não inserir cliente igual no banco
			IF(EXISTS(SELECT IDPessoaCliente FROM tblCliente WHERE IDPessoaCliente = @IDPessoaCliente))
				RAISERROR('Cliente já existente!', 14, 1);
				
			--1ºInserir na tabela tblCliente
			INSERT INTO tblCliente (IDPessoaCliente)
			VALUES (@IDPessoaCliente)
			
			SELECT @IDPessoaCliente AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  Table [dbo].[tblPedidoItem]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoItem](
	[IDPedido] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](18, 2) NOT NULL,
	[PercentualDesconto] [decimal](5, 2) NOT NULL,
	[ValorDesconto] [decimal](18, 2) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblItem] PRIMARY KEY CLUSTERED 
(
	[IDPedido] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEstoqueMovimentado]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEstoqueMovimentado](
	[IDEstoqueMovimentado] [int] IDENTITY(1,1) NOT NULL,
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[DataHora] [date] NOT NULL,
	[EntrouSaiu] [char](1) NOT NULL,
 CONSTRAINT [PK_tblEstoqueMovimentado] PRIMARY KEY CLUSTERED 
(
	[IDEstoqueMovimentado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoque](
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoque] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uvwPessoaFisicaJuridica]    Script Date: 07/30/2016 17:50:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uvwPessoaFisicaJuridica]
AS
	SELECT 
		tblPessoa.IDPessoa,
		tblPessoa.IDPessoaTipo,
		tblPessoaTipo.Descricao AS DescricaoTipo,
	CASE
		WHEN tblPessoa.IDPessoaTipo = 1 THEN tblPessoaFisica.CPF ELSE tblPessoaJuridica.CNPJ
	END AS CpfCnpj,
	CASE
		WHEN tblPessoa.IDPessoaTipo = 1 THEN tblPessoaFisica.Nome ELSE tblPessoaJuridica.NomeFantasia
	END AS Nome
	FROM
		tblPessoa
	JOIN
		tblPessoaTipo ON tblPessoa.IDPessoaTipo = tblPessoaTipo.IDPessoaTipo
	LEFT JOIN
		tblPessoaFisica ON tblPessoa.IDPessoa = tblPessoaFisica.IDPessoaFisica
	LEFT JOIN
		tblPessoaJuridica ON tblPessoa.IDPessoa = tblPessoaJuridica.IDPessoaJuridica
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoInserir]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPedidoInserir]
	@IDOperacao AS INT,
	@IDSituacao AS INT,
	@IDPessoaEmitente AS INT,
	@IDPessoaDestinatario AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			INSERT INTO tblPedido (DataHora, IDOperacao, IDSituacao, IDPessoaEmitente, IDPessoaDestinatario)
			VALUES (GETDATE(), @IDOperacao, @IDSituacao, @IDPessoaEmitente, @IDPessoaDestinatario)
			SELECT @@IDENTITY AS Retorno;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueConsultar]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueConsultar]
	@IDPessoaFilial INT,
	@IDProduto INT
AS
BEGIN
	SELECT
		tblEst.IDPessoaFilial,
		uvwPess.Nome AS NomeFilial,
		uvwPess.CpfCnpj AS CpfCnpjFilial,
		uvwPess.DescricaoTipo AS TipoFilial,
		tblEst.IDProduto,
		tblPro.Descricao AS DescricaoProduto,
		tblEst.Quantidade
	FROM tblEstoque AS tblEst 
	JOIN uvwPessoaFisicaJuridica AS uvwPess ON tblEst.IDPessoaFilial = uvwPess.IDPessoa
	JOIN tblProduto AS tblPro ON tblEst.IDProduto = tblPro.IDProduto
	WHERE tblEst.IDPessoaFilial = @IDPessoaFilial AND tblEst.IDProduto = @IDProduto
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoConsultarPorData]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPedidoConsultarPorData]
	@DataInicial DATE,
	@DataFinal DATE
AS
BEGIN
	SELECT
		tblPed.IDPedido,
		tblPed.DataHora,
		tblPed.IDOperacao,
		tblOpe.Descricao AS DescOperacao,
		tblPed.IDSituacao,
		tblSit.Descricao AS DescSituacao,
		tblPed.IDPessoaEmitente,
		uvwemit.Nome AS NomeEmitente,
		tblPed.IDPessoaDestinatario,
		uvwDest.Nome AS NomeDestinatario
	FROM tblPedido AS tblPed
	JOIN tblOperacao AS tblOpe ON tblPed.IDOperacao = tblOpe.IDOperacao
	JOIN tblSituacao AS tblSit ON tblPed.IDSituacao = tblSit.IDSituacao
	JOIN uvwPessoaFisicaJuridica AS uvwEmit ON tblPed.IDPessoaEmitente = uvwEmit.IDPessoa
	JOIN uvwPessoaFisicaJuridica AS uvwDest ON tblPed.IDPessoaDestinatario = uvwDest.IDPessoa
	--CAST Converter DataHora apesnas para Data eleimina Hora
	WHERE CAST(tblPed.DataHora AS DATE) BETWEEN @DataInicial AND @DataFinal
END
GO
/****** Object:  Table [dbo].[tblEstoqueReservado]    Script Date: 07/30/2016 17:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEstoqueReservado](
	[IDPessoaFilial] [int] NOT NULL,
	[IDProduto] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoqueReservado] PRIMARY KEY CLUSTERED 
(
	[IDPessoaFilial] ASC,
	[IDProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorNome]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteConsultarPorNome]
	@IDPessoaCliente INT = NULL,
	@Nome VARCHAR(50) = NULL
AS
BEGIN
	SELECT tblCliente.IDPessoaCliente, uvwPess.CpfCnpj, uvwPess.Nome, uvwPess.IDPessoaTipo, uvwPess.DescricaoTipo 
	FROM tblCliente JOIN uvwPessoaFisicaJuridica AS uvwPess ON tblCliente.IDPessoaCliente = uvwPess.IDPessoa
	WHERE (@IDPessoaCliente IS NULL OR tblCliente.IDPessoaCliente = @IDPessoaCliente) AND
		(@Nome IS NULL OR uvwPess.Nome LIKE '%' + @Nome + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[uspFilialConsultarPorNome]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFilialConsultarPorNome]
	@Nome VARCHAR(50)
AS
BEGIN
	SELECT 
		tblFil.IDPessoaFilial,
		uvwPes.CpfCnpj,
		uvwPes.Nome,
		uvwPes.DescricaoTipo
	FROM tblFilial AS tblFil JOIN uvwPessoaFisicaJuridica AS uvwPes
	ON tblFil.IDPessoaFilial = uvwPes.IDPessoa
	WHERE
		uvwPes.Nome LIKE '%' + @Nome + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[uspFilialConsultarPorCodigo]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFilialConsultarPorCodigo]
	@IDPessoaFilal INT
AS
BEGIN
	SELECT 
		tblFil.IDPessoaFilial,
		uvwPes.CpfCnpj,
		uvwPes.Nome,
		uvwPes.DescricaoTipo
	FROM tblFilial AS tblFil JOIN uvwPessoaFisicaJuridica AS uvwPes
	ON tblFil.IDPessoaFilial = uvwPes.IDPessoa
	WHERE
		tblFil.IDPessoaFilial = @IDPessoaFilal
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoItemInserir]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPedidoItemInserir]
	@IDPedido INT,
	@IDProduto INT,
	@Quantidade INT,
	@ValorUnitario DECIMAL(18, 2),
	@PercentualDesconto DECIMAL(5, 2),
	@ValorDesconto DECIMAL(18, 2),
	@ValorTotal DECIMAL(18, 2)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		
			IF(EXISTS(SELECT IDProduto FROM tblPedidoItem WHERE IDPedido = @IDPedido AND IDProduto = @IDProduto))
			BEGIN
				RAISERROR( 'Este produto já está no pedido!', 14, 1);
			END
			
			INSERT INTO tblPedidoItem(IDPedido, IDProduto, Quantidade, ValorUnitario, PercentualDesconto, ValorDesconto, ValorTotal)
			VALUES (@IDPedido, @IDProduto, @Quantidade, @ValorUnitario, @PercentualDesconto, @ValorDesconto, @ValorTotal)
			
			SELECT @IDProduto AS Retorno;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPedidoItemConsultar]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspPedidoItemConsultar]
	@IDPedido INT
AS
BEGIN
	SELECT
		tblPedidoItem.IDPedido,
		tblPedidoItem.IDProduto,
		tblProduto.Descricao AS DescProduto,
		tblPedidoItem.Quantidade,
		tblPedidoItem.ValorUnitario,
		tblPedidoItem.PercentualDesconto,
		tblPedidoItem.ValorDesconto,
		tblPedidoItem.ValorTotal
	FROM tblPedidoItem
	JOIN tblProduto ON tblPedidoItem.IDProduto = tblProduto.IDProduto
	WHERE tblPedidoItem.IDPedido = @IDPedido
END
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorConsultarPorCodigoNome]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFornecedorConsultarPorCodigoNome]
	@IDPessoaFornecedor INT = NULL,
	@Nome VARCHAR(50) = NULL
AS
BEGIN
	
	IF(@IDPessoaFornecedor IS NOT NULL)
	BEGIN
		SELECT
			tblFor.IDPessoaFornecedor,
			uvwPess.CpfCnpj,
			uvwPess.Nome,
			uvwPess.IDPessoaTipo,
			uvwPess.DescricaoTipo
		FROM tblFornecedor AS tblFor JOIN uvwPessoaFisicaJuridica AS uvwPess
		ON tblFor.IDPessoaFornecedor = uvwPess.IDPessoa
		WHERE tblFor.IDPessoaFornecedor = @IDPessoaFornecedor
	END
	ELSE BEGIN
		SELECT
			tblFor.IDPessoaFornecedor,
			uvwPess.CpfCnpj,
			uvwPess.Nome,
			uvwPess.IDPessoaTipo,
			uvwPess.DescricaoTipo
		FROM tblFornecedor AS tblFor JOIN uvwPessoaFisicaJuridica AS uvwPess
		ON tblFor.IDPessoaFornecedor = uvwPess.IDPessoa
		WHERE uvwPess.Nome LIKE '%' + @Nome + '%'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueManter]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueManter]
	@IDPessoaFilial INT,
	@IDProduto INT,
	@Quantidade INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			--Se existir alterar, se não insere
			IF(EXISTS(SELECT IDProduto FROM tblEstoque WHERE IDPessoaFilial = @IDPessoaFilial AND IDProduto = @IDProduto))
				BEGIN
					--Alterar
					UPDATE tblEstoque
					SET Quantidade += @Quantidade
					WHERE IDPessoaFilial = @IDPessoaFilial AND IDProduto = @IDProduto
				END
				ELSE
				BEGIN
					--Inserir
					INSERT INTO tblEstoque (IDPessoaFilial, IDProduto, Quantidade)
					VALUES (@IDPessoaFilial, @IDProduto, @Quantidade)
				END
				
				--Movimentação de Estoque
				DECLARE @EntrouSaiu CHAR(1);
				
				IF(@Quantidade < 0)
					SET @EntrouSaiu = 'S';
				ELSE
					SET @EntrouSaiu = 'E';
					
				INSERT INTO tblEstoqueMovimentado (IDPessoaFilial, IDProduto, Quantidade, DataHora, EntrouSaiu)
				VALUES (@IDPessoaFilial, @IDProduto, @Quantidade, GETDATE(), @EntrouSaiu)
				--Fim da Movimentação
				
				SELECT @IDProduto AS Retorno;
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueDisponivelConsultar]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueDisponivelConsultar]
	@IDPessoaFilial INT,
	@IDProduto INT
AS
BEGIN
	--Procedure usando variáveis
	DECLARE
		@NomeFilial VARCHAR(50),
		@CpfCnpjFilial VARCHAR(14),
		@TipoFilial VARCHAR(50),
		@DescricaoProduto VARCHAR(100),
		@Estoque INT,
		@EstoqueReservado INT,
		@EstoqueDisponivel INT
		
	SET @NomeFilial = ( SELECT Nome From uvwPessoaFisicaJuridica WHERE IDPessoa = @IDPessoaFilial);
	SET @CpfCnpjFilial = ( SELECT CpfCnpj From uvwPessoaFisicaJuridica WHERE IDPessoa = @IDPessoaFilial);
	SET @TipoFilial = ( SELECT DescricaoTipo From uvwPessoaFisicaJuridica WHERE IDPessoa = @IDPessoaFilial);
	SET @DescricaoProduto = ( SELECT Descricao From tblProduto WHERE IDProduto = @IDProduto);
	SET @Estoque = ( SELECT Quantidade From tblEstoque WHERE IDPessoaFilial = @IDPessoaFilial AND IDProduto = @IDProduto);
	SET @EstoqueReservado = ( SELECT Quantidade From tblEstoqueReservado WHERE IDPessoaFilial = @IDPessoaFilial AND IDProduto = @IDProduto);
	SET @EstoqueDisponivel = COALESCE(@Estoque, 0) - COALESCE(@EstoqueReservado, 0)
	
	SELECT
		@IDPessoaFilial AS IDPessoaFilial,
		@NomeFilial AS NomeFilial,
		@CpfCnpjFilial AS CpfCnpjFilial,
		@TipoFilial AS TipoFilial,
		@DescricaoProduto AS DescricaoProduto,
		@Estoque AS Estoque,
		@EstoqueReservado AS EstoqueReservado,
		@EstoqueDisponivel AS EstoqueDisponivel
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueReservadoManter]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueReservadoManter]
	@IDPessoaFilial INT,
	@IDProduto INT,
	@Quantidade INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF(EXISTS(SELECT IDProduto FROM tblEstoqueReservado
			WHERE IDPessoaFilial = @IDPessoaFilial AND IDProduto = @IDProduto))
			BEGIN
				--UPDATE
				UPDATE tblEstoqueReservado SET Quantidade += @Quantidade
				WHERE IDPessoaFilial = @IDPessoaFilial AND IDProduto = @IDProduto
			END
			ELSE
			BEGIN
				--INSERT
				INSERT INTO tblEstoqueReservado (IDPessoaFilial, IDProduto, Quantidade)
				VALUES (@IDPessoaFilial, @IDProduto, @Quantidade)
			END
			SELECT @IDProduto AS Retorno;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueReservadoConsultar]    Script Date: 07/30/2016 17:50:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueReservadoConsultar]
	@IDPessoaFilial INT,
	@IDProduto INT
AS
BEGIN
	SELECT
		tblEstRes.IDPessoaFilial,
		uvwPess.Nome AS NomeFilial,
		uvwPess.CpfCnpj AS TipoFilial,
		tblEstRes.IDProduto,
		tblPro.Descricao AS DescricaoProduto,
		tblEstRes.Quantidade
	FROM
		tblEstoqueReservado tblEstRes
	JOIN
		uvwPessoaFisicaJuridica AS uvwPess ON tblEstRes.IDPessoaFilial = uvwPess.IDPessoa
	JOIN
		tblProduto AS tblPro ON tblEstRes.IDProduto = tblPro.IDProduto
	WHERE tblEstRes.IDPessoaFilial = @IDPessoaFilial AND tblEstRes.IDProduto = @IDProduto
END
GO
/****** Object:  Default [DF_tblPedido_DataHora]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedido] ADD  CONSTRAINT [DF_tblPedido_DataHora]  DEFAULT (getdate()) FOR [DataHora]
GO
/****** Object:  ForeignKey [FK_tblCliente_tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblCliente]  WITH CHECK ADD  CONSTRAINT [FK_tblCliente_tblPessoa] FOREIGN KEY([IDPessoaCliente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblCliente] CHECK CONSTRAINT [FK_tblCliente_tblPessoa]
GO
/****** Object:  ForeignKey [FK_tblEstoque_tblFilial]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblFilial]
GO
/****** Object:  ForeignKey [FK_tblEstoque_tblProduto]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblProduto]
GO
/****** Object:  ForeignKey [FK_tblEstoqueMovimentado_tblFilial]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblEstoqueMovimentado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentado_tblFilial] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblFilial] ([IDPessoaFilial])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentado] CHECK CONSTRAINT [FK_tblEstoqueMovimentado_tblFilial]
GO
/****** Object:  ForeignKey [FK_tblEstoqueMovimentado_tblProduto]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblEstoqueMovimentado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueMovimentado_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblEstoqueMovimentado] CHECK CONSTRAINT [FK_tblEstoqueMovimentado_tblProduto]
GO
/****** Object:  ForeignKey [FK_tblEstoqueReservado_tblEstoque]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblEstoqueReservado]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoqueReservado_tblEstoque] FOREIGN KEY([IDPessoaFilial], [IDProduto])
REFERENCES [dbo].[tblEstoque] ([IDPessoaFilial], [IDProduto])
GO
ALTER TABLE [dbo].[tblEstoqueReservado] CHECK CONSTRAINT [FK_tblEstoqueReservado_tblEstoque]
GO
/****** Object:  ForeignKey [FK_tblFilial_tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblFilial]  WITH CHECK ADD  CONSTRAINT [FK_tblFilial_tblPessoa] FOREIGN KEY([IDPessoaFilial])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblFilial] CHECK CONSTRAINT [FK_tblFilial_tblPessoa]
GO
/****** Object:  ForeignKey [FK_tblFornecedor_tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblFornecedor]  WITH CHECK ADD  CONSTRAINT [FK_tblFornecedor_tblPessoa] FOREIGN KEY([IDPessoaFornecedor])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblFornecedor] CHECK CONSTRAINT [FK_tblFornecedor_tblPessoa]
GO
/****** Object:  ForeignKey [FK_tblPedido_tblOperacao]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblOperacao] FOREIGN KEY([IDOperacao])
REFERENCES [dbo].[tblOperacao] ([IDOperacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblOperacao]
GO
/****** Object:  ForeignKey [FK_tblPedido_tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoa] FOREIGN KEY([IDPessoaEmitente])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoa]
GO
/****** Object:  ForeignKey [FK_tblPedido_tblPessoaDestinatario]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoaDestinatario] FOREIGN KEY([IDPessoaDestinatario])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoaDestinatario]
GO
/****** Object:  ForeignKey [FK_tblPedido_tblSituacao]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblSituacao] FOREIGN KEY([IDSituacao])
REFERENCES [dbo].[tblSituacao] ([IDSituacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblSituacao]
GO
/****** Object:  ForeignKey [FK_tblItem_tblPedido]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_tblItem_tblPedido] FOREIGN KEY([IDPedido])
REFERENCES [dbo].[tblPedido] ([IDPedido])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_tblItem_tblPedido]
GO
/****** Object:  ForeignKey [FK_tblItem_tblProduto]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_tblItem_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPedidoItem] CHECK CONSTRAINT [FK_tblItem_tblProduto]
GO
/****** Object:  ForeignKey [FK_tblPessoa_tblPessoaTipo]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoa_tblPessoaTipo] FOREIGN KEY([IDPessoaTipo])
REFERENCES [dbo].[tblPessoaTipo] ([IDPessoaTipo])
GO
ALTER TABLE [dbo].[tblPessoa] CHECK CONSTRAINT [FK_tblPessoa_tblPessoaTipo]
GO
/****** Object:  ForeignKey [FK_tblPessoaFisica_tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoaFisica_tblPessoa] FOREIGN KEY([IDPessoaFisica])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaFisica] CHECK CONSTRAINT [FK_tblPessoaFisica_tblPessoa]
GO
/****** Object:  ForeignKey [FK_iDPessoaJuridica_tblPessoa]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_iDPessoaJuridica_tblPessoa] FOREIGN KEY([IDPessoaJuridica])
REFERENCES [dbo].[tblPessoa] ([IDPessoa])
GO
ALTER TABLE [dbo].[tblPessoaJuridica] CHECK CONSTRAINT [FK_iDPessoaJuridica_tblPessoa]
GO
/****** Object:  ForeignKey [FK_tblPreco_tblProduto]    Script Date: 07/30/2016 17:50:34 ******/
ALTER TABLE [dbo].[tblPreco]  WITH CHECK ADD  CONSTRAINT [FK_tblPreco_tblProduto] FOREIGN KEY([IDProduto])
REFERENCES [dbo].[tblProduto] ([IDProduto])
GO
ALTER TABLE [dbo].[tblPreco] CHECK CONSTRAINT [FK_tblPreco_tblProduto]
GO
