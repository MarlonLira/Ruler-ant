
using System.Configuration;
using System.Data.SqlClient;



namespace Ruler.Persistence
{
    class Conexao
    {
              
        // Conexão sql 
        public string createCon = ConfigurationManager.ConnectionStrings["Ruler.Properties.Settings.rulerConnectionString"].ConnectionString;
        
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter adapt;

        /*Conexão banco*/

        public void openCon()
        {
            con = new SqlConnection(createCon);
            con.Open();
        }

        public void openCon(string script)
        {
            con = new SqlConnection(createCon);
            cmd = new SqlCommand(script, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        

        public void openCon(string tabela ,string colun, string colun2)
        {
                     
            string insertAux = tabela;

            con = new SqlConnection(createCon);
            cmd = new SqlCommand(insertAux, con);

            
            cmd.Parameters.AddWithValue("@coluna1", colun);
            cmd.Parameters.AddWithValue("@coluna2", colun2);
            cmd.Parameters.AddWithValue("@coluna3", "0");
            

            con.Open();
            cmd.ExecuteNonQuery();

        }

        public void openCon(string tabela, string colun, string colun2, string colun3)
        {
            string insertAux = tabela;

            con = new SqlConnection(createCon);
            cmd = new SqlCommand(insertAux, con);

            cmd.Parameters.AddWithValue("@coluna1", colun);
            cmd.Parameters.AddWithValue("@coluna2", colun2);
            cmd.Parameters.AddWithValue("@coluna3", colun3);

            con.Open();
            cmd.ExecuteNonQuery();

        }

        public void openCon(string tabela, string colun, string colun2, string colun3, string colun4)
        {
            string insertAux = tabela;

            con = new SqlConnection(createCon);
            cmd = new SqlCommand(insertAux, con);

            cmd.Parameters.AddWithValue("@coluna1", colun);
            cmd.Parameters.AddWithValue("@coluna2", colun2);
            cmd.Parameters.AddWithValue("@coluna3", colun3);
            cmd.Parameters.AddWithValue("@coluna4", colun4);

            con.Open();
            cmd.ExecuteNonQuery();
            
        }

        public void openCon(string tabela, string colun, string colun2, string colun3, string colun4, string colun5)
        {
            string insertAux = tabela;

            con = new SqlConnection(createCon);
            cmd = new SqlCommand(insertAux, con);

            cmd.Parameters.AddWithValue("@coluna1", colun);
            cmd.Parameters.AddWithValue("@coluna2", colun2);
            cmd.Parameters.AddWithValue("@coluna3", colun3);
            cmd.Parameters.AddWithValue("@coluna4", colun4);
            cmd.Parameters.AddWithValue("@coluna5", colun5);

            con.Open();
            cmd.ExecuteNonQuery();

        }


        public void openAdpter(string tabela)
        {
            adapt = new SqlDataAdapter(tabela, con);
        }

        public void closeCon()
        {
            
            con.Close();
        }
    }
}
