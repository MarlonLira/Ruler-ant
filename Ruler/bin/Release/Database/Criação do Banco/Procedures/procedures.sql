-- VENDER
EXEC stp_vender 4, 'LUCIANA', 'Q', 2, 1000, '29/09/2018', 'Dinheiro', 1, 1, 0

CREATE PROCEDURE stp_vender 
@id_cliente INT,
@cliente VARCHAR(50),
@produto VARCHAR(50),
@quantidade_produto INT,
@valor NUMERIC(7,2),
@data VARCHAR(50),
@tipo_venda VARCHAR(50),
@id_produto VARCHAR(50),
@dividir INT,
@pagou INT


AS

BEGIN

	INSERT INTO Tbl_Pedido (cliente, produto, quantidade_produto, valor, data, tipo_venda, id_produto)
	 VALUES (@cliente, @produto, @quantidade_produto, @valor, @data, @tipo_venda, @id_produto)

	 DECLARE @id_pedido INT = (SELECT SCOPE_IDENTITY())

 IF (@pagou = 0)
	 BEGIN

		EXEC stp_cliente_debito @id_cliente, @valor;
		

	 END
EXEC stp_movimento @id_cliente, @cliente, @produto, @quantidade_produto, @valor, @data, @tipo_venda, @id_produto, @dividir, @pagou, @id_pedido;

END


-- DEBITO
CREATE PROCEDURE stp_cliente_debito
@id_cliente INT,
@debito NUMERIC(7,2)


AS

BEGIN

DECLARE @aux NUMERIC(7, 20);

SELECT @aux = debito FROM Tbl_Cliente
WHERE id_cliente = @id_cliente

UPDATE Tbl_Cliente
SET debito = @aux + @debito
WHERE id_cliente = @id_cliente

END

-- MOVIMENTO

CREATE PROCEDURE stp_movimento
 
@id_cliente INT,
@cliente VARCHAR(50),
@produto VARCHAR(50),
@quantidade_produto INT,
@valor NUMERIC(7,2),
@data VARCHAR(50),
@tipo_venda VARCHAR(50),
@id_produto INT,
@dividir INT,
@pagou INT,
@id_pedido INT

AS

BEGIN
	DECLARE @situacao VARCHAR(50);

	IF(@pagou = 1)
		BEGIN
			SET @situacao = 'PAGO';
		END
	IF(@pagou = 0)
		BEGIN
			SET @situacao = 'A PAGAR'
		END
	

INSERT INTO Tbl_Movimento(tipo_movimento, id_cliente ,nome_cliente, id_produto, nome_produto, quantidade_produto, valor, parcelas, situacao, data_venda, pedido_id )
 VALUES (@tipo_venda, @id_cliente, @cliente, @id_produto, @produto, @quantidade_produto, @valor, @dividir, @situacao, @data, @id_pedido)
 
END

EXEC stp_cliente_pagamento 4, 200.00, 20, 'Dinheiro'
SELECT *FROM Tbl_Movimento
-- Cliente Pagamento
CREATE PROCEDURE stp_cliente_pagamento
@id_cliente INT,
@pagamento NUMERIC(7,2),
@id_pedido INT,
@tipo_pagamento VARCHAR(50)

AS

BEGIN
	DECLARE @debito NUMERIC(7, 2);
	DECLARE @cliente VARCHAR(50);

	SELECT @debito = C.[debito], @cliente = C.[nome] FROM Tbl_Cliente AS C
	WHERE id_cliente = @id_cliente

	IF(@debito >= @pagamento)
		BEGIN

			UPDATE Tbl_Cliente
			SET debito = debito - @pagamento
			WHERE id_cliente = @id_cliente

			EXEC stp_pagamento_incluir @cliente, @pagamento, @tipo_pagamento, @id_cliente, @id_pedido
			
		END;

	ELSE IF(@debito < @pagamento)
		BEGIN
			UPDATE Tbl_Cliente
			SET debito = 0
			WHERE id_cliente = @id_cliente

			EXEC stp_pagamento_incluir @cliente, @pagamento, @tipo_pagamento, @id_cliente, @id_pedido
		END;
END;

-- Pagamento incluir
CREATE PROCEDURE stp_pagamento_incluir
@cliente VARCHAR(50), 
@valor NUMERIC (7, 2),
@tipo_pagamento VARCHAR(50),
@id_cliente INT,
@id_pedido INT


AS

BEGIN


	DECLARE @produto VARCHAR(50);
	DECLARE @quantidade_produto INT;
	DECLARE @valor_pedido NUMERIC(7, 2);
	DECLARE @data_pedido VARCHAR(50);
	DECLARE @id_produto INT;
	DECLARE @data_pagamento VARCHAR(50) = CONVERT (VARCHAR, GETDATE(), 103);
	DECLARE @parcelas INT;

	SELECT @produto = P.[produto], @quantidade_produto = P.[quantidade_produto], @valor_pedido = P.[valor],
		   @data_pedido = P.[data], @id_produto = P.[id_produto], @parcelas = M.[parcelas] FROM Tbl_Pedido AS P
		   JOIN Tbl_Movimento AS M
		   ON P.[id_pedido] = M.[pedido_id]
	WHERE id_pedido = @id_pedido


	

	INSERT INTO Tbl_Pagamento(cliente, valor, data_pagamento, tipo_pagamento)
	VALUES (@cliente, @valor, @data_pagamento, @tipo_pagamento)

	EXEC stp_movimento @id_cliente, @cliente, @produto, @quantidade_produto, @valor, @data_pagamento, @tipo_pagamento, @id_produto, @parcelas, 1, @id_pedido
	
	
END;