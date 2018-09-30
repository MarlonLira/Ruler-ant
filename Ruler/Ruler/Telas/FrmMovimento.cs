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
    public partial class FrmMovimento : Form
    {
        FrmInicio inicio;
        public FrmMovimento(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMovimento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);

        }

        private void lbl_voltar_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            inicio.Show();
            this.Close();
        }
    }
}
