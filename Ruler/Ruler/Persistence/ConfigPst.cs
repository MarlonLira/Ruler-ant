using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Persistence
{
    interface ConfigPst
    {
         string Deletar();
         string Atualizar();
         string Cadastrar();
         string Pesquisar();
         string checar(string objeto);
    }
}
