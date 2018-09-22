using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Dados
{
    class Produto
    {
        private string nome;
        private double valor;
        private int id;
        private double valor_dolar;

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Id { get => id; set => id = value; }
        public double Valor_dolar { get => valor_dolar; set => valor_dolar = value; }

        public Produto(string nome, double valor, int id, double valor_dolar)
        {
            this.nome = nome;
            this.valor = valor;
            this.id = id;
            this.valor_dolar = valor_dolar;
        }
              

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
