namespace Ruler.Model
{
    abstract class Pagamento
    {
        public int Id_pagamento { get; set; }
        public string Cliente { get; set; }
        public int Id_cliente { get; set; }
        public double Valor { get; set; }
        public string Data_pagamento { get; set; }
        public string Tipo_pagamento { get; set; }
        public int Id_pedido { get; set; }

        public Pagamento(){}

        protected Pagamento(int id_pagamento, string cliente, int id_cliente, double valor, string data_pagamento, string tipo_pagamento, int id_pedido)
        {
            this.Id_pagamento = id_pagamento;
            this.Cliente = cliente;
            this.Id_cliente = id_cliente;
            this.Valor = valor;
            this.Data_pagamento = data_pagamento;
            this.Tipo_pagamento = tipo_pagamento;
            this.Id_pedido = id_pedido;
        }

        protected Pagamento(string cliente, int id_cliente, double valor, string data_pagamento, string tipo_pagamento, int id_pedido)
        { 
            this.Cliente = cliente;
            this.Id_cliente = id_cliente;
            this.Valor = valor;
            this.Data_pagamento = data_pagamento;
            this.Tipo_pagamento = tipo_pagamento;
            this.Id_pedido = id_pedido;
        }

        protected Pagamento(int id_cliente, double valor, string tipo_pagamento, int id_pedido)
        { 
            this.Id_cliente = id_cliente;
            this.Valor = valor;
            this.Tipo_pagamento = tipo_pagamento;
            this.Id_pedido = id_pedido;
        }

        
    }
}
