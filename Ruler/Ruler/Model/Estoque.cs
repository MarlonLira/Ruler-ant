
namespace Ruler.Model
{
    class Estoque
    {
        private int id_estoque;
        private string nome_produto;
        private int quantidade_produto;
        private int id_produto;
        
        public Estoque(){}

        public Estoque(int id_estoque)
        {
            this.id_estoque = id_estoque;
        }

        public Estoque(string nome_produto)
        {
            this.nome_produto = nome_produto;
        }

        public Estoque(int id_produto, int quantidade_produto)
        {
            this.id_produto = id_produto;
            this.quantidade_produto = quantidade_produto;
        }

        public Estoque(string nome_produto, int quantidade_produto, int id_produto)
        {
            this.nome_produto = nome_produto;
            this.quantidade_produto = quantidade_produto;
            this.id_produto = id_produto;
        }

        public Estoque(int id_estoque, string nome_produto, int quantidade_produto, int id_produto)
        {
            this.nome_produto = nome_produto;
            this.quantidade_produto = quantidade_produto;
            this.id_produto = id_produto;
            this.id_estoque = id_estoque;
        }

        public int Id_estoque { get => id_estoque; set => id_estoque = value; }
        public string Nome_produto { get => nome_produto; set => nome_produto = value; }
        public int Quantidade_produto { get => quantidade_produto; set => quantidade_produto = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
    }
}
