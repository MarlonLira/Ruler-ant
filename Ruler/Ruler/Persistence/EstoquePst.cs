using Ruler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Persistence
{
    class EstoquePst : Estoque
    {

        public EstoquePst(string nome_produto, double valor_produto, double valor_produto_dolar) :base(nome_produto, valor_produto, valor_produto_dolar){ }

        public EstoquePst(string nome_produto, double valor_produto, double valor_produto_dolar, int quantidade_produto, int id_produto) : base(nome_produto, valor_produto, valor_produto_dolar, quantidade_produto, id_produto) { }

        public string inserir()
        {
            return "insert into Tbl_Estoque";
        }

        public string buscar()
        {

            return "select *from Tbl_Estoque";

        }
        
        public string atualizar()
        {
            // return "update Tbl_Estoque set nome=@nome,valor=@preco1,valor_dolar=@preco2 where id_produto=@id";
            return "";
        }

        public void deletar()
        {

        }
    }
}
