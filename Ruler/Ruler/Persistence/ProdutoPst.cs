using Ruler.Dados;

namespace Ruler.Persistence
{
    class ProdutoPst : Produto
    {
        public ProdutoPst(string nome, double valor, int id, double valor_dolar) : base(nome, valor, id, valor_dolar)
        {
        }

        public string Deletar() { return ""; }
        public string Atualizar() { return ""; }
        public string Cadastrar() { return "INSERT INTO Tbl_Produto (nome, valor, valor_dolar) values(" + Nome + Valor + Valor_dolar + ")"; }
        public string Pesquisar() { return "SELECT * FROM Tbl_Produto"; } 
    }
}
