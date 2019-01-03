
using Ruler.Persistence;

namespace Ruler.Model
{
     abstract class Estoque
    {

        public int Id_estoque { get; set; }
        public string Nome_produto { get; set; }
        public int Quantidade_produto { get; set; }
        public int Id_produto { get; set; }
        public ProdutoPst Produto { get; set; }

        public Estoque(){}

        public Estoque(int id_estoque)
        {
            this.Id_estoque = id_estoque;
        }

        public Estoque(string nome_produto)
        {
            this.Nome_produto = nome_produto;
        }

        public Estoque(int id_produto, int quantidade_produto)
        {
            this.Id_produto = id_produto;
            this.Quantidade_produto = quantidade_produto;
        }

        public Estoque(string nome_produto, int quantidade_produto, int id_produto)
        {
            this.Nome_produto = nome_produto;
            this.Quantidade_produto = quantidade_produto;
            this.Id_produto = id_produto;
        }

        public Estoque(int id_estoque, string nome_produto, int quantidade_produto, int id_produto)
        {
            this.Nome_produto = nome_produto;
            this.Quantidade_produto = quantidade_produto;
            this.Id_produto = id_produto;
            this.Id_estoque = id_estoque;
        }

        
    }
}
