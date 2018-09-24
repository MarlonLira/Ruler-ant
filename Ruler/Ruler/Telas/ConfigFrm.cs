using Ruler.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Telas
{
    interface ConfigFrm
    {
        void PesquisarObjeto();
        void CadastrarObjeto();
        void AtualizarObjeto();
        void DeletarObjeto();
        void DisplayData(string script);
        void ClearData();
        void Checar(string objeto);
    }
}
