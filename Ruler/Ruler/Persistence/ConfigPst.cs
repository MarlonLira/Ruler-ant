using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruler.Persistence
{
    public abstract class ConfigPst
    {

        //public const string insert = "insert into  Tbl_Produto  (Nome, valor, valor_dolar) values(@name, @preco1, @preco2)";
        //public const string insert = "insert into"  +  Tbl +  "(" + coluna1, coluna2, coluna3  + ")" + "values(@name, @preco1, @preco2)";

        //public const string update = "update Tbl_Produto set nome=@nome,valor=@preco1,valor_dolar=@preco2 where id_produto=@id";
        //public const string delete;
       // public const string select = "select * from Tbl_Produto";
              

        public void inserir(string tbl, string coluna1, string coluna2, string coluna3)
        {
            string criarInsert = "insert into" +  tbl +  "(" + coluna1 + coluna2 + coluna3 + ")" +  "values (@name, @preco1, @preco2)";

        }

        public void atualizar()
        {

        }

        public void pesquisar()
        {

        }

        public void deletar()
        {

        }
    }
}
