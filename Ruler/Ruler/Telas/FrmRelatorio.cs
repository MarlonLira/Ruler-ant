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
    public partial class FrmRelatorio : Form
    {
        FrmInicio inicio;

        public FrmRelatorio(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {
            //inicio.Show();
            //this.Close();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_PedidoTableAdapter.Fill(this.rulerDataSet.Tbl_Pedido);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Cliente'. Você pode movê-la ou removê-la conforme necessário.
           // this.tbl_ClienteTableAdapter.Fill(this.rulerDataSet.Tbl_Cliente);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbl_ProdutoTableAdapter.Fill(this.rulerDataSet.Tbl_Produto);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);

        }

        private void pl_voltar_Paint(object sender, PaintEventArgs e)
        {
           // inicio.Show();
            //this.Close();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
