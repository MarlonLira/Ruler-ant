using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Dados
{
    class Produto
    {
        private string nome { get; set; }
        private double valor { get; set; }
        private int id { get; set; }
        private double valor_dolar { get; set; }

        public Produto(string nome, double valor, int id, double valor_dolar)
        {
            this.nome = nome;
            this.valor = valor;
            this.id = id;
            this.valor_dolar = valor_dolar;
        }
    }
}
