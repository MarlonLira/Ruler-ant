use ruler

select * from Tbl_Produto
select * from Tbl_Movimento
select * from Tbl_Estoque
select * from Tbl_Cliente

delete Tbl_Produto where id_produto = 1

truncate Table Tbl_Produto
drop Table Tbl_Movimento

ALTER TABLE Tbl_Produto ALTER COLUMN valor numeric(7,2);

ALTER TABLE Tbl_Produto ALTER COLUMN valor_dolar numeric(7,2);

ALTER TABLE Tbl_Movimento    
ADD CONSTRAINT id_Cliente FOREIGN KEY (id_Cliente)     
    REFERENCES Tbl_Cliente (id_Cliente)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE 