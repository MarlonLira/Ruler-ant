using Ruler.Dados;
using System;


namespace Ruler.Model
{
    class Pedido
    {
        private int id_movimento;
        private Produto produto;
        private int quantidade_produto;
        private DateTime data_entrada;
        private DateTime data_saida;
        private Cliente cliente;

        public Pedido(int id_movimento, Produto produto, int quantidade_produto, DateTime data_entrada, DateTime data_saida, Cliente cliente)
        {
            this.id_movimento = id_movimento;
            this.produto = produto;
            this.quantidade_produto = quantidade_produto;
            this.data_entrada = data_entrada;
            this.data_saida = data_saida;
            this.cliente = cliente;
        }

        public Pedido(Produto produto, int quantidade_produto, DateTime data_saida, Cliente cliente)
        {
            this.produto = produto;
            this.quantidade_produto = quantidade_produto;
            this.data_saida = data_saida;
            this.cliente = cliente;
        }



        public int Id_movimento { get => id_movimento; set => id_movimento = value; }
        public int Quantidade_produto { get => quantidade_produto; set => quantidade_produto = value; }
        public DateTime Data_entrada { get => data_entrada; set => data_entrada = value; }
        public DateTime Data_saida { get => data_saida; set => data_saida = value; }
        internal Produto Produto { get => produto; set => produto = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
