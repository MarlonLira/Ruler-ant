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


        private void btn_pesquisar_pedidos_Click(object sender, EventArgs e)
        {
            FrmPedido pedido = new FrmPedido(this);
            this.Hide();
            pedido.Show();

        }

        private void btn_cadastrar_pedidos_Click(object sender, EventArgs e)
        {
            FrmPedido pedido = new FrmPedido(this);
            this.Hide();
            pedido.Show();
        }

        private void produtosTSMI_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto(this);
            this.Hide();
            produto.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente(this);
            this.Hide();
            cliente.Show();
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            FrmPedido pedido = new FrmPedido(this);
            this.Hide();
            pedido.Show();
        }

        private void btn_estoque_Click_1(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque(this);
            this.Hide();
            estoque.Show();
        }
    }
}
