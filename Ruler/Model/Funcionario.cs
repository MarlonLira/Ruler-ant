using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Model
{
    class Funcionario
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Cpf { get; set; }
        public String Senha { get; set; }

        public Funcionario(string nome, string email, string cpf, string senha)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Senha = senha;
        }
    }
}
