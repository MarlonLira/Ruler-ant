using Ruler.Dados;
using Ruler.Model;
using System;


namespace Ruler.Persistence
{
    class PedidoPst : Pedido
    {
        public PedidoPst(Produto produto, int quantidade_produto, DateTime data_saida, Cliente cliente) : base(produto, quantidade_produto, data_saida, cliente)
        {
        }

        public PedidoPst(int id_movimento, Produto produto, int quantidade_produto, DateTime data_entrada, DateTime data_saida, Cliente cliente) : base(id_movimento, produto, quantidade_produto, data_entrada, data_saida, cliente)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
