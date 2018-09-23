using Ruler.Model;

namespace Ruler.Persistence
{
    class EstoquePst : Estoque, ConfigPst
    {
        public EstoquePst() { }

        public EstoquePst(string nome_produto, int quantidade_produto, int id_produto) : base(nome_produto, quantidade_produto, id_produto) { }
        
        public string Deletar() { return "DELETE Tbl_Estoque WHERE id_estoque = " + Id_estoque; }

        public string Atualizar() { return "UPDATE Tbl_Estoque SET nome_produto = " + "'" + Nome_produto + "'" + ", quantidade_produto = " + Quantidade_produto + " , id_produto = " + Id_produto + " where id_estoque = " + Id_estoque; }

        public string Cadastrar() { return "INSERT INTO Tbl_Estoque (nome_produto, quantidade_produto, id_produto) VALUES (" + "'" + Nome_produto + "'" + ", " + Quantidade_produto + ", " + Id_produto + ")"; }

        public string Pesquisar() { return "SELECT * FROM Tbl_Estoque"; }

        public string checar(string objeto) { return "SELECT * FROM Tbl_Estoque WHERE nome_produto = " + "'" + objeto + "'"; }
    }
}
