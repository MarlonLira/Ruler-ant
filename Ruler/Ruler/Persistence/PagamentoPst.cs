using Ruler.Model;
using System;

namespace Ruler.Persistence
{
    class PagamentoPst : Pagamento, ConfigPst
    {
        public PagamentoPst()
        {
        }

        public PagamentoPst(int id_cliente, double valor, string tipo_pagamento, int id_pedido) : base(id_cliente, valor, tipo_pagamento, id_pedido)
        {
        }

        public PagamentoPst(string cliente, int id_cliente, double valor, string data_pagamento, string tipo_pagamento, int id_pedido) : base(cliente, id_cliente, valor, data_pagamento, tipo_pagamento, id_pedido)
        {
        }

        public PagamentoPst(int id_pagamento, string cliente, int id_cliente, double valor, string data_pagamento, string tipo_pagamento, int id_pedido) : base(id_pagamento, cliente, id_cliente, valor, data_pagamento, tipo_pagamento, id_pedido)
        {
        }

        public string Atualizar()
        {
            throw new NotImplementedException();
        }

        public string Cadastrar()
        {
            return "EXEC stp_cliente_pagamento " + Id_cliente + ", "+  Valor + ", " + Id_pedido + ", " + " '" + Tipo_pagamento + "'";
        }

        public string checar(string objeto)
        {
            throw new NotImplementedException();
        }

        public string Deletar()
        {
            throw new NotImplementedException();
        }

        public string Pesquisar()
        {
            return "SELECT * FROM Tbl_movimento";
        }

        public string Pesquisar(int objeto)
        {
            return "SELECT * FROM Tbl_movimento WHERE pedido_id = " + objeto;
        }

        public string Pesquisar(string coluna, string objeto )
        {
            return "SELECT * FROM Tbl_movimento WHERE " + coluna + " = '" + objeto +"'" ;
        }

        public string Pesquisar(string coluna, int objeto)
        {
            return "SELECT * FROM Tbl_movimento WHERE " + coluna + " = '" + objeto + "'";
        }
    }
}
