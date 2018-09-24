using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmPedido : Form, ConfigFrm
    {
        Conexao con = new Conexao();
        private FrmInicio inicio;
        DataTable table;
        int aux = 1;
        


        public FrmPedido(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_pedido.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbb_produtos.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_quantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbb_cliente.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


        public void PesquisarObjeto()
        {
            PedidoPst pedido = new PedidoPst();
            DisplayData(pedido.Pesquisar());
        }

        public void CadastrarObjeto()
        {
            if (!string.IsNullOrEmpty(cbb_produtos.Text) && !string.IsNullOrEmpty(txt_quantidade.Text) && !string.IsNullOrEmpty(txt_valor.Text))
            {
                if (int.Parse(txt_quantidade.Text) <= int.Parse(txt_quant_estoque.Text)) {
                    PedidoPst pedido = new PedidoPst(cbb_produtos.Text, txt_id_produto.Text, int.Parse(txt_quantidade.Text), double.Parse(txt_valor.Text), cbb_cliente.Text, data_pedido.Text);

                    EstoquePst estoque = new EstoquePst(int.Parse(txt_id_produto.Text), int.Parse(txt_quant_estoque.Text));
                                       

                    con.openCon(pedido.Cadastrar());
                    con.openCon(estoque.AtualizarQuantidade(int.Parse(txt_quantidade.Text)));

                    if (cbb_venda.Text == "Conta")
                    {
                        ClientePst cliente = new ClientePst(int.Parse(txt_id_cliente.Text));
                        con.openCon(cliente.AtualizarDebito(double.Parse(txt_valor.Text)));
                    }

                    con.closeCon();
                    MessageBox.Show("Pedido Inserido com Sucesso");

                    ClearData();
                }
                else
                {
                    MessageBox.Show("Erro!, a quantidade informada não existe no estoque, Por favor, atualize o estoque antes da venda.");

                }
            }
        }

        public void AtualizarObjeto()
        {
            throw new NotImplementedException();
        }

        public void DeletarObjeto()
        {
            throw new NotImplementedException();
        }

        public void DisplayData(string script)
        {
            con.openCon();
            DataTable dt = new DataTable();
            table = new DataTable();
            con.openAdpter(script);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.adapt.Fill(table);
            con.closeCon();
        }

        public void ClearData()
        {
            cbb_produtos.Text = "";
            cbb_cliente.Text = "";
            txt_id_produto.Text = "";
            txt_quantidade.Text = "";
            txt_quant_estoque.Text = "";
            txt_id_pedido.Text = "";
            txt_id_produto.Text = "";
            txt_valor_u.Text = "";

        }

        public void ChecarId(string objeto)
        {
            ProdutoPst produto = new ProdutoPst();
            DisplayData(produto.checar(objeto));

            if (table.Rows.Count > 0)
            {
                txt_id_produto.Text = table.Rows[0]["id_produto"].ToString();
                txt_valor_u.Text = table.Rows[0]["valor"].ToString();

                EstoquePst estoque = new EstoquePst();
                DisplayData(estoque.checar(objeto));

                if (table.Rows.Count > 0) {
                    txt_quant_estoque.Text = table.Rows[0]["quantidade_produto"].ToString();

                    ClientePst cliente = new ClientePst();
                    DisplayData(cliente.Pesquisar());

                    if (table.Rows.Count > 0) { txt_id_cliente.Text = table.Rows[0]["id_cliente"].ToString(); }
                }

                PesquisarObjeto();
            }
        }

        public void Checar(string objeto)
        {
            PedidoPst pedido = new PedidoPst();
            DisplayData(pedido.checar(objeto));
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet1.Tbl_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ClienteTableAdapter.Fill(this.rulerDataSet1.Tbl_Cliente);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet1.Tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.rulerDataSet1.Tbl_Produto);

            ChecarId(cbb_produtos.Text);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_PedidoTableAdapter.Fill(this.rulerDataSet.Tbl_Pedido);
            calc();

            cbb_venda.Text = "Dinheiro";

        }

        private void cbb_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecarId(cbb_produtos.Text);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            PesquisarObjeto();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AtualizarObjeto();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DeletarObjeto();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void calc()
        {
            if (!string.IsNullOrEmpty(txt_quantidade.Text)) {  

            aux = int.Parse(txt_quantidade.Text);
            double valor = double.Parse(txt_valor_u.Text);
            double valorTotal = aux * valor;
            txt_valor.Text = valorTotal.ToString();

            }
            else {

                aux = 0;
                double valor = double.Parse(txt_valor_u.Text);
                double valorTotal = aux * valor;
                txt_valor.Text = valorTotal.ToString();

            }
            
        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        
    }
}
