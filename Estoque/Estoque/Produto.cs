using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Produto
    {
        public String nome;
        public double preco;
        public int quantidade;

        public double valorTotalEmEstoque()
        {
            return quantidade * preco;
        }

        public void entrada(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void saida(int quantidade)
        {
            if(this.quantidade >= quantidade)
            { 
             this.quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("QUANTIDADE INFORMADO É INVALIDA!");
            }
        }
        
    }
}
