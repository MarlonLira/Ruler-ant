using Ruler.Model;
using System;

namespace Ruler.Persistence
{
    class PedidoPst : Pedido, ConfigPst
    {
        int pagou;

        public int Pagou { get => pagou; set => pagou = value; }

        public PedidoPst(){}

        public PedidoPst(int id, string produto, string id_produto, int quantidade_produto, string valor_produto, string cliente) :base(id, produto, id_produto, quantidade_produto, valor_produto, cliente){}

        public PedidoPst(string produto, string id_produto, int quantidade_produto, string valor_produto, string cliente, string data, string tipo, int id_cliente, int dividir) : base(produto, id_produto, quantidade_produto, valor_produto, cliente, data, tipo, id_cliente, dividir){}


        public string Atualizar()
        {
            throw new NotImplementedException();
        }

        public string Cadastrar()
        {
            return "EXEC stp_vender " + Id_cliente + ", "+ " '" + Cliente + "'" + ", " + "'" + Produto + "'" + ", " + Quantidade_produto +", "+ Valor_produto +", "+ " '" + Data + "'" + ", " + "'" + Tipo + "'" + ", "+ Id_produto + ", " + Dividir + ", " + Pagou;
        }

        public string Deletar()
        {
            throw new NotImplementedException();
        }

        public string Pesquisar()
        {
            return "SELECT * FROM Tbl_Pedido";
        }

        public string checar(string objeto)
        {
            throw new NotImplementedException();
        }
    }
}
