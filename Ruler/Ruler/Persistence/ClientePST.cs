using Ruler.Dados;

namespace Ruler.Persistence
{
    class ClientePst : Cliente, ConfigPst
    {
        public ClientePst(string nome, string telefone, double debito) : base(nome, telefone, debito)
        {
        }

        public string Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public string Cadastrar()
        {
            return "INSERT INTO Tbl_Cliente (nome, telefone, debito) values(" + Nome + Telefone + Debito + ")";
        }

        public string Deletar()
        {
            throw new System.NotImplementedException();
        }

        public string Pesquisar()
        {
            return "SELECT * FROM Tbl_Cliente";
        }
    }
}
