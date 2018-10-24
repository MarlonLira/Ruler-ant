using Ruler.Persistence;
using System;

namespace Ruler.Model
{
    abstract class Compras
    {
        Int32 Id { get; set; }
        DateTime Data_Compra { get; set; }
        Int32 Quantidade_Produto { get; set; }
        ProdutoPst Produto { get; set; }
        FuncionarioPst Funcionario { get; set; }

        public Compras(DateTime data_Compra, int quantidade_Produto, ProdutoPst produto)
        {
            Data_Compra = data_Compra;
            Quantidade_Produto = quantidade_Produto;
            Produto = produto;
        }

    }
}
