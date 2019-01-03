namespace Ruler.Dados
{
    class Produto
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public int Id { get; set; }
        public string Valor_dolar { get; set; }

        public Produto(int id, string nome, string valor, string valor_dolar)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Id = id;
            this.Valor_dolar = valor_dolar;
        }

        public Produto(int id)
        {
            this.Id = id;
        }

        public Produto(string nome, string valor, string valor_dolar)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Valor_dolar = valor_dolar;
        }

        public Produto() { }

    }
}
