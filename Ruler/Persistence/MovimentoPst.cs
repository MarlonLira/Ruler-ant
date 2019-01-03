using Ruler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Persistence
{
    class MovimentoPst : Movimento, ConfigPst
    {
        protected MovimentoPst(DateTime data_Venda, DateTime data_Entrega, ClientePst cliente, FuncionarioPst funcionario, ProdutoPst produto) : base(data_Venda, data_Entrega, cliente, funcionario, produto)
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
