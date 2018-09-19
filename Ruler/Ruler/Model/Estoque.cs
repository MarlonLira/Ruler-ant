
namespace Ruler.Model
{
    class Estoque
    {
        private int id_estoque;
        private string nome_produto;
        private double valor_produto;
        private double valor_produto_dolar;
        private int quantidade_produto;
        private int id_produto;

        public Estoque(string nome_produto, double valor_produto, double valor_produto_dolar)
        {
            this.nome_produto = nome_produto;
            this.valor_produto = valor_produto;
            this.valor_produto_dolar = valor_produto_dolar;
        }

        public Estoque(string nome_produto, double valor_produto, double valor_produto_dolar, int quantidade_produto, int id_produto)
        {
            this.nome_produto = nome_produto;
            this.valor_produto = valor_produto;
            this.valor_produto_dolar = valor_produto_dolar;
            this.quantidade_produto = quantidade_produto;
            this.id_produto = id_produto;
        }

        public int Id_estoque { get => id_estoque; set => id_estoque = value; }
        public string Nome_produto { get => nome_produto; set => nome_produto = value; }
        public double Valor_produto { get => valor_produto; set => valor_produto = value; }
        public double Valor_produto_dolar { get => valor_produto_dolar; set => valor_produto_dolar = value; }
        public int Quantidade_produto { get => quantidade_produto; set => quantidade_produto = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
    }
}
