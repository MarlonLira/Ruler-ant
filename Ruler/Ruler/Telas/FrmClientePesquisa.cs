using Ruler.Dados;
using Ruler.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmClientePesquisa : Form
    {

        private FrmInicio inicio;

        public const string criarUpdate = "update Tbl_Cliente set nome = @coluna1, telefone = @coluna2, debito = @coluna3 where id_Cliente = @coluna4";
        
        public const string select_cliente = "select * from Tbl_Cliente";

        Conexao con = new Conexao();
        Cliente cliente;


        public FrmClientePesquisa(FrmInicio frm)
        {
            inicio = frm;
            InitializeComponent();
        }

        private void DisplayData()
        {
            con.openCon();
            DataTable dt = new DataTable();
            con.openAdpter(select_cliente);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.closeCon();
        }
          
        
        private void ClearData()
        {
            txt_Nome.Text = "";
            txt_telefone.Text = "";
            txt_debito.Text = "";
            txt_id.Text = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_telefone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_debito.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_pesquisar_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btn_atualizar_Click_1(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" && txt_telefone.Text != "")
            {
                cliente = new Cliente(txt_Nome.Text, txt_telefone.Text, int.Parse(txt_id.Text), double.Parse(txt_debito.Text));


                con.openCon(criarUpdate, cliente.Nome, cliente.Telefone, cliente.Debito.ToString(), cliente.Id.ToString());

                MessageBox.Show("Produto Atualizado!");


                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void btn_voltar_Click_1(object sender, EventArgs e)
        {         
            inicio.Show();
            this.Close();
        }
    }
}
