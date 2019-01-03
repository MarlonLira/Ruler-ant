using Ruler.Persistence;
using System;

namespace Ruler.Model
{
    abstract class Movimento
    {
        DateTime Data_Venda { get; set; }
        DateTime Data_Entrega { get; set; }
        ClientePst Cliente { get; set; }
        FuncionarioPst Funcionario { get; set; }
        ProdutoPst Produto { get; set; }

        protected Movimento(DateTime data_Venda, DateTime data_Entrega, ClientePst cliente, FuncionarioPst funcionario, ProdutoPst produto)
        {
            Data_Venda = data_Venda;
            Data_Entrega = data_Entrega;
            Cliente = cliente;
            Funcionario = funcionario;
            Produto = produto;
        }
    }
}
