use ruler
select * from Tbl_Estoque

select nome_produto as Nome_Produto, sum(valor_produto * quantidade_produto) as Total_Reais, sum(valor_produto_dolar * quantidade_produto) Total_Dolares , sum(quantidade_produto) as Quantidade_Total
from Tbl_Estoque
group by nome_produto


drop table Tbl_Estoque

