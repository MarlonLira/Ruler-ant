using Ruler.Dados;
using System.Collections;
using System.Linq;

namespace Ruler.Persistence
{
    class ProdutoPst : Produto, ConfigPst
    {
        public ProdutoPst(string nome, string valor, string valor_dolar) : base(nome, valor, valor_dolar){}
        public ProdutoPst(int id, string nome, string valor, string valor_dolar) : base(id, nome, valor, valor_dolar){}
        public ProdutoPst(int id) : base(id){}

        public ProdutoPst(){}


        public string Deletar() { return "DELETE Tbl_Produto WHERE id_produto = " + Id; }

        public string Atualizar() { return "UPDATE Tbl_Produto SET nome = " + "'" + Nome + "'" + ", valor = " + Valor + " , valor_dolar = " + Valor_dolar + " where id_produto = " + Id; }

        public string Cadastrar()
        {
            return "INSERT INTO Tbl_Produto (nome, valor, valor_dolar) VALUES (" + "'" + Nome + "'" + ", " + Valor + ", " + Valor_dolar + ")"; 
        }
        public string Pesquisar() { return "SELECT * FROM Tbl_Produto"; }

        public string checar(string objeto) { return "SELECT * FROM Tbl_Produto WHERE nome = " + "'" + objeto + "'"; }
    }
}
