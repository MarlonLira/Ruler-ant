
namespace Ruler.Dados
{
    class Cliente
    {
        private string nome;
        private string telefone;
        private int id;
        private string debito;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Id { get => id; set => id = value; }
        public string Debito { get => debito; set => debito = value; }

        public Cliente(int id) { this.id = id; }

        public Cliente(int id, string nome, string telefone, string debito)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.id = id;
            this.debito = debito;
        }

        public Cliente(int id, string debito)
        {
            this.id = id;
            this.debito = debito;
        }

        public Cliente(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public Cliente(string nome, string telefone, string debito)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.debito = debito;
        }

        public Cliente() { }
                
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
