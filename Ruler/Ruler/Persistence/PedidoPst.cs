using Ruler.Dados;
using Ruler.Model;
using System;


namespace Ruler.Persistence
{
    class PedidoPst : Pedido, ConfigPst
    {
        public PedidoPst(){}

        public PedidoPst(int id, string produto, string id_produto, int quantidade_produto, double valor_produto, string cliente) :base(id, produto, id_produto, quantidade_produto, valor_produto, cliente){}

        public PedidoPst(string produto, string id_produto, int quantidade_produto, double valor_produto, string cliente, string data) : base(produto, id_produto, quantidade_produto, valor_produto, cliente, data){}


        public string Atualizar()
        {
            throw new NotImplementedException();
        }

        public string Cadastrar()
        {
           return "INSERT INTO Tbl_Pedido (cliente, produto, quantidade_produto, valor, data, id_produto) VALUES(" + "'" + Cliente + "'" + ", " + "'" + Produto + "'" + ", " + Quantidade_produto + ", "+ Valor_produto + ", " + "'" + Data + "'" + "," + Id_produto + ")"; 
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
