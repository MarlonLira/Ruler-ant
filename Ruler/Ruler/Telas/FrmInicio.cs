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
            FrmCadastro cadastrar = new FrmCadastro(this);

            this.Hide();

            cadastrar.ShowDialog();
        }

        private void cadastrar_cliTSMI_Click(object sender, EventArgs e)
        {
            

            FrmClienteCadastro cadastrarCliente = new FrmClienteCadastro(this);
            this.Hide();

            cadastrarCliente.Show();
        }
        
        private void pesquisarTSMI_Click_1(object sender, EventArgs e)
        {
            
            FrmPesquisa pesquisa = new FrmPesquisa(this);
            this.Hide();

            pesquisa.Show();
        }

        private void pesquisarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmClientePesquisa pesquisarCliente = new FrmClientePesquisa(this);
            this.Hide();

            pesquisarCliente.Show();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque(this);
            this.Hide();

            estoque.Show();
        }

        private void btn_cadastro_estoque_Click(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque(this);
            this.Hide();

            estoque.Show();
        }

        private void btn_pesquisar_estoque_Click(object sender, EventArgs e)
        {
            FrmEstoquePesquisa estoquePesquisa = new FrmEstoquePesquisa(this);
            this.Hide();

            estoquePesquisa.Show();
        }
    }
}
