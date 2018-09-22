using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();
 
                Console.WriteLine("CADASTRO DE PRODUTOS");
                Console.WriteLine();
                Console.WriteLine("NOME DO PRODUTO: ");
                x.nome = Console.ReadLine();
                Console.WriteLine("PREÇO DO PRODUTO: ");
                x.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("QUANTIDADE DO PRODUTO: ");
                x.quantidade = int.Parse(Console.ReadLine());
                            
                Console.WriteLine("PRODUTO: " + x.nome + " PREÇO: $" + x.preco.ToString("F2", CultureInfo.InvariantCulture) + " QUANTIDADE: " + x.quantidade + " VALOR TOTAL EM ESTOQUE: $" + x.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

                Console.ReadLine();

                Console.WriteLine("DIGITE QUANTOS PRODUTOS ENTRARAM: ");
                x.entrada(int.Parse(Console.ReadLine()));

                Console.WriteLine("PRODUTO: " + x.nome + " PREÇO: $" + x.preco.ToString("F2", CultureInfo.InvariantCulture) + " QUANTIDADE: " + x.quantidade + " VALOR TOTAL EM ESTOQUE: $" + x.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

                Console.ReadLine();

                Console.WriteLine("DIGITE QUANTOS PRODUTOS SAIRAM: ");
                x.saida(int.Parse(Console.ReadLine()));

                Console.WriteLine("PRODUTO: " + x.nome + " PREÇO: $" + x.preco.ToString("F2", CultureInfo.InvariantCulture) + " QUANTIDADE: " + x.quantidade + " VALOR TOTAL EM ESTOQUE: $" + x.valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

                Console.ReadLine();

            

        }
    }
}
