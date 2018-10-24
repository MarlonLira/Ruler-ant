namespace Ruler.Model
{
    class Pedido
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Id_produto { get; set; }
        public int Quantidade_produto { get; set; }
        public string Valor_produto { get; set; }
        public string Cliente { get; set; }
        public string Data { get; set; }
        public string Tipo { get; set; }
        public int Id_cliente { get; set; }
        public int Dividir { get; set; }

        public Pedido(){}

        public Pedido(int id, string produto, string id_produto, int quantidade_produto, string valor_produto, string cliente)
        {
            this.Id = id;
            this.Produto = produto;
            this.Id_produto = id_produto;
            this.Quantidade_produto = quantidade_produto;
            this.Valor_produto = valor_produto;
            this.Cliente = cliente;
        }

        public Pedido(string produto, string id_produto, int quantidade_produto, string valor_produto, string cliente, string data, string tipo, int id_cliente, int dividir)
        {
            this.Produto = produto;
            this.Id_produto = id_produto;
            this.Quantidade_produto = quantidade_produto;
            this.Valor_produto = valor_produto;
            this.Cliente = cliente;
            this.Data = data;
            this.Tipo = tipo;
            this.Id_cliente = id_cliente;
            this.Dividir = dividir;
        }

        
    }
}
