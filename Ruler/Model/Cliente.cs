namespace Ruler.Dados
{
    abstract class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Id { get; set; }
        public string Debito { get; set; }

        public Cliente(int id) { this.Id = id; }

        public Cliente(int id, string nome, string telefone, string debito)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Id = id;
            this.Debito = debito;
        }

        public Cliente(int id, string debito)
        {
            this.Id = id;
            this.Debito = debito;
        }

        public Cliente(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public Cliente(string nome, string telefone, string debito)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Debito = debito;
        }

        public Cliente(){}
    }
}
