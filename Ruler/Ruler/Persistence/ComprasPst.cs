using Ruler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Persistence
{
    class ComprasPst : Compras, ConfigPst
    {
        public ComprasPst(DateTime data_Compra, int quantidade_Produto, ProdutoPst produto) : base(data_Compra, quantidade_Produto, produto)
        {
        }

        public string Atualizar()
        {
            throw new NotImplementedException();
        }

        public string Cadastrar()
        {
            throw new NotImplementedException();
        }

        public string checar(string objeto)
        {
            throw new NotImplementedException();
        }

        public string Deletar()
        {
            throw new NotImplementedException();
        }

        public string Pesquisar()
        {
            throw new NotImplementedException();
        }
    }
}
