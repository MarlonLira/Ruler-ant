using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Ruler.Telas;

namespace Ruler
{
    public partial class FrmPesquisa : Form
    {
        public const string select_produto = "select * from Tbl_Produto";
        public const string insert_produto = "insert into Tbl_Produto(Nome, valor, valor_dolar) values(@name, @preco1, @preco2)";

        /*public const string update;
        public const string delete;*/
        


        // Conexão sql 
        public string createCon = ConfigurationManager.ConnectionStrings["Ruler.Properties.Settings.rulerConnectionString"].ConnectionString;


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;

        int ID = 0;
        public FrmPesquisa()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            con = new SqlConnection(createCon);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(select_produto, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        
        //dataGridView1 RowHeaderMouseClick Event  
        /*private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_preco2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }*/

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_preco2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_preco1.Text != "")
            {
                cmd = new SqlCommand("update Tbl_Produto set nome=@nome,valor=@preco1,valor_dolar=@preco2 where id_produto=@id", con);
                con.Open();
                double preco1 = double.Parse(txt_preco1.Text);
                double preco2 = double.Parse(txt_preco2.Text);
                cmd.Parameters.AddWithValue("@id", txt_Id.Text);
                cmd.Parameters.AddWithValue("@nome", txt_Name.Text);
                cmd.Parameters.AddWithValue("@preco1", preco1);
                cmd.Parameters.AddWithValue("@preco2", preco2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Atualizado!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_preco1.Text = "";
            txt_preco2.Text = "";
            txt_Id.Text = "";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmInicio inicio = new FrmInicio();

            inicio.Show();
        }
    }
}
