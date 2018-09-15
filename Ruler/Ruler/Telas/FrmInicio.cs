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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
                 
        private void cadastrarTSMI_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmCadastro cadastrar = new FrmCadastro();

            cadastrar.Show();
        }

        private void cadastrar_cliTSMI_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmClienteCadastro cadastrarCliente = new FrmClienteCadastro();

            cadastrarCliente.Show();
        }
        
        private void pesquisarTSMI_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmPesquisa pesquisa = new FrmPesquisa();

            pesquisa.Show();
        }

        private void pesquisarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;

            FrmClientePesquisa pesquisarCliente = new FrmClientePesquisa();

            pesquisarCliente.Show();
        }
    }
}
