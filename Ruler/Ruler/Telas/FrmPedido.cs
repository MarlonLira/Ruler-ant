using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmPedido : Form
    {
        Conexao con = new Conexao();
        private FrmInicio inicio;
        private string procure;

        public FrmPedido(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        private void DisplayData()
        {
            con.openCon();
            DataTable dt = new DataTable();
            con.openAdpter(procure);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.closeCon();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbb_produtos.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_quantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbb_cliente.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            procure = "select * from Tbl_Pedido";
            DisplayData();
        }
    }
}
