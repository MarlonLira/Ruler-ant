using Ruler.Dados;
using Ruler.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmClienteCadastro : Form
    {
        Conexao con = new Conexao();
        Cliente cliente = new Cliente();

        public const string criarInsert = "insert into Tbl_Cliente (nome, telefone, debito) values(@coluna1,@coluna2, @coluna3)";

        public const string select_cliente = "select * from Tbl_Cliente";
        
        public FrmClienteCadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txt_Nome.Text) && !string.IsNullOrEmpty(txt_telefone.Text))
            {
                

                if (!string.IsNullOrEmpty(txt_debito.Text))
                {
                    
                    cliente = new Cliente(txt_Nome.Text, txt_telefone.Text, double.Parse(txt_debito.Text));

                    con.openCon(criarInsert, cliente.Nome, cliente.Telefone, cliente.Debito.ToString());
                    
                }
                else
                {
                    cliente = new Cliente(txt_Nome.Text, txt_telefone.Text);
                    con.openCon(criarInsert, cliente.Nome, cliente.Telefone);
                    

                }

                con.closeCon();
                MessageBox.Show("Cliente Inserido com sucesso");
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
            con.openCon();
            DataTable dt = new DataTable();
            con.openAdpter(select_cliente);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.closeCon();
        }
        //Clear Data  
        private void ClearData()
        {
            txt_Nome.Text = "";
            txt_telefone.Text = "";
            txt_debito.Text = "";
            txt_id.Text = "";
        }
         
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmInicio inicio = new FrmInicio();

            inicio.Show();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmClientePesquisa pesquisarCliente = new FrmClientePesquisa();

            pesquisarCliente.Show();
        }

        //dataGridView1 RowHeaderMouseClick Event 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_telefone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_debito.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
           /* if (txt_Nome.Text != "" && txt_telefone.Text != "")
            {
                cmd = new SqlCommand("update Tbl_Produto set nome=@nome,valor=@preco1,valor_dolar=@preco2 where id_produto=@id", con);
                con.Open();
                double preco1 = double.Parse(txt_telefone.Text);
                double preco2 = double.Parse(txt_debito.Text);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                cmd.Parameters.AddWithValue("@preco1", txt_telefone.Text);
                cmd.Parameters.AddWithValue("@preco2", txt_debito.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Atualizado!");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Erro!");
            }*/
        }
    }
}
