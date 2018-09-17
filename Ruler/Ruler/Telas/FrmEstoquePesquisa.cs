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
    public partial class FrmEstoquePesquisa : Form
    {
        private FrmInicio inicio;
        private Conexao con = new Conexao();
        
        public string select_produto = "";

        public FrmEstoquePesquisa(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        private void DisplayData()
        {
            con.openCon();
            DataTable dt = new DataTable();
            con.openAdpter(select_produto);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.closeCon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_real.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_dolar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_quantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            btn_atualizar.Enabled = true;
            select_produto = "select * from Tbl_Estoque";
            DisplayData();
        }

        private void btn_pesquisa_total_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            btn_atualizar.Enabled = false;
            select_produto = "select nome_produto as Nome_Produto, sum(valor_produto * quantidade_produto) as Total_Reais, sum(valor_produto_dolar * quantidade_produto) Total_Dolares , sum(quantidade_produto) as Quantidade_Total from Tbl_Estoque group by nome_produto";
            DisplayData();
        }
    }
}
