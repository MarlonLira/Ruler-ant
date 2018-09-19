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
    public partial class FrmPedido : Form
    {
        FrmInicio inicio;
        public FrmPedido(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }
    }
}
