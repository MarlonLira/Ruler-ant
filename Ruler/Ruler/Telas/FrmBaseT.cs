using System;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmBaseT : Form
    {
        //private FrmInicio inicio;
        //private DataTable table = new DataTable();
        //private Conexao con = new Conexao();

        //private string procure = "";

        public FrmBaseT()
        {
            InitializeComponent();
            
        }

        public void CadastrarObjeto()
        {

        }

        public void PesquisarObjeto()
        {
            DisplayData();
        }

        public void AtualizarObjeto()
        {

        }

        public void ApagarObjeto()
        {

        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            PesquisarObjeto();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            ApagarObjeto();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AtualizarObjeto();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            //inicio.Show();
            //this.Close();
        }

        private void ClearData()
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();*/

        }

        private void DisplayData()
        {
            /*con.openCon();
            DataTable dt = new DataTable();
            con.openAdpter(procure);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.closeCon();*/
        }
    }
}
