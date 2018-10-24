using Ruler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Persistence
{
    class FuncionarioPst : Funcionario, ConfigPst
    {
        public FuncionarioPst(string nome, string email, string cpf, string senha) : base(nome, email, cpf, senha)
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
