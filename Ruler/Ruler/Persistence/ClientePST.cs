using Ruler.Dados;

namespace Ruler.Persistence
{
    class ClientePst : Cliente, ConfigPst
    {
        public ClientePst(int id, string nome, string telefone, string debito) : base(id, nome, telefone, debito) { }
        public ClientePst(string nome, string telefone, string debito) : base(nome, telefone, debito){}
        public ClientePst(int id) : base(id) {}
        public ClientePst(){}

        public string Deletar() { return "DELETE Tbl_Cliente WHERE id_cliente = " + Id; }

        public string Atualizar() { return "UPDATE Tbl_Cliente SET nome = " + "'" + Nome + "'" + ", telefone = " + Telefone + " , debito = " +  Debito + " where id_cliente = " + Id; }

        public string AtualizarDebito(string valor) { return "UPDATE Tbl_Cliente SET debito = debito + " + valor + " WHERE id_cliente = " + Id; }

        public string Cadastrar(){
            return "INSERT INTO Tbl_Cliente (nome, telefone, debito) VALUES (" + "'" + Nome + "'" + ", "+  Telefone + ", " + Debito + ")";}

        public string Pesquisar() { return "SELECT * FROM Tbl_Cliente"; }

        public string checar(string objeto) { return "SELECT * FROM Tbl_Cliente WHERE nome = " + "'" + objeto + "'"; }

        public string PesquisarId(int objeto) { return "SELECT * FROM Tbl_Cliente WHERE id_cliente = "  + objeto; }
    }
}
