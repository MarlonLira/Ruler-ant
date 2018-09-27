
namespace Ruler.Dados
{
    class Produto
    {
        private string nome;
        private string valor;
        private int id;
        private string valor_dolar;

        public string Nome { get => nome; set => nome = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Id { get => id; set => id = value; }
        public string Valor_dolar { get => valor_dolar; set => valor_dolar = value; }

        public Produto(int id, string nome, string valor, string valor_dolar)
        {
            this.nome = nome;
            this.valor = valor;
            this.id = id;
            this.valor_dolar = valor_dolar;
        }

        public Produto(int id)
        {
            this.id = id;
        }

        public Produto(string nome, string valor, string valor_dolar)
        {
            this.nome = nome;
            this.valor = valor;
            this.valor_dolar = valor_dolar;
        }
                

        public Produto() { }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
