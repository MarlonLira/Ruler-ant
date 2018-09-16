using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ruler.Telas;

namespace Ruler
{
    public partial class FrmCadastro : Form
    {
        private FrmInicio inicio;
        public const string insert_produto = "insert into Tbl_Produto(Nome, valor, valor_dolar) values(@name, @preco1, @preco2)";

        /*public const string update;
        public const string delete;*/
        public const string select_produto = "select * from Tbl_Produto";


        // Conexão sql 
        public string createCon = ConfigurationManager.ConnectionStrings["Ruler.Properties.Settings.rulerConnectionString"].ConnectionString;


        SqlConnection con;  
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public FrmCadastro(FrmInicio frm)
        {
            inicio = frm;
            InitializeComponent();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrEmpty(txt_Name.Text) && !string.IsNullOrEmpty(txt_preco1.Text))
                {


                    con = new SqlConnection(createCon);
                    cmd = new SqlCommand(insert_produto, con);
                    

                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@preco1", txt_preco1.Text);

                    if (!string.IsNullOrEmpty(txt_preco2.Text))
                    {

                        cmd.Parameters.AddWithValue("@preco2", txt_preco2.Text);
                    }
                    else
                    {

                    cmd.Parameters.AddWithValue("@preco2", "");

                    }

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produto Inserido com sucesso");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(select_produto, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txt_Name.Text = "";
            txt_preco1.Text = "";
            txt_preco2.Text = "";
            ID = 0;
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_preco2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmPesquisa pesquisa = new FrmPesquisa(inicio);
                      
            pesquisa.Show();


        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }
    }
}
