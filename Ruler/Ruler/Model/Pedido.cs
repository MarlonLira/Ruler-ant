using Ruler.Dados;
using System;


namespace Ruler.Model
{
    class Pedido
    {
        private int id;
        private string produto;
        private string id_produto;
        private int quantidade_produto;
        private string valor_produto;
        private string data;
        private int id_cliente;
        private string cliente;
        private string tipo;
        private int dividir;

        public Pedido(){}

        public Pedido(int id, string produto, string id_produto, int quantidade_produto, string valor_produto, string cliente)
        {
            this.id = id;
            this.produto = produto;
            this.id_produto = id_produto;
            this.quantidade_produto = quantidade_produto;
            this.valor_produto = valor_produto;
            this.cliente = cliente;
        }

        public Pedido(string produto, string id_produto, int quantidade_produto, string valor_produto, string cliente, string data, string tipo, int id_cliente, int dividir)
        {
            this.produto = produto;
            this.id_produto = id_produto;
            this.quantidade_produto = quantidade_produto;
            this.valor_produto = valor_produto;
            this.cliente = cliente;
            this.data = data;
            this.tipo = tipo;
            this.id_cliente = id_cliente;
            this.dividir = dividir;
        }

        public int Id { get => id; set => id = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Id_produto { get => id_produto; set => id_produto = value; }
        public int Quantidade_produto { get => quantidade_produto; set => quantidade_produto = value; }
        public string Valor_produto { get => valor_produto; set => valor_produto = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Data { get => data; set => data = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Dividir { get => dividir; set => dividir = value; }
    }
}
