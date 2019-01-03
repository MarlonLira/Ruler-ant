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
        int pagou;

        #region Metodos
        public FrmPedido(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;

            data_pedido.Value = DateTime.Now.Date;

            if (cbb_venda.Text == "Cartão")
            {
                cbb_dividir.Enabled = true;
            }
            else
            {
                cbb_dividir.Enabled = false;
                cbb_juros.Enabled = false;
            }
            
        }
        
        public void PesquisarObjeto()
        {
            PedidoPst pedido = new PedidoPst();
            DisplayData(pedido.Pesquisar());
        }

        public void CadastrarObjeto()
        {
            PedidoPst pedido;
            EstoquePst estoque;
            try
            { 
                if (!string.IsNullOrEmpty(cbb_produtos.Text) && !string.IsNullOrEmpty(txt_quantidade.Text) && !string.IsNullOrEmpty(txt_valor.Text))
                {
                    if (int.Parse(txt_quantidade.Text) <= int.Parse(txt_quant_estoque.Text)) {

                        pedido = new PedidoPst();
                        pedido.Produto = cbb_produtos.Text;
                        pedido.Id_produto = txt_id_produto.Text;
                        pedido.Quantidade_produto = int.Parse(txt_quantidade.Text);
                        pedido.Valor_produto = txt_valor.Text.Replace(",", ".");
                        pedido.Cliente = cbb_cliente.Text;
                        pedido.Data = data_pedido.Text;
                        pedido.Tipo = cbb_venda.Text;
                        pedido.Id_cliente = int.Parse(txt_id_cliente.Text);
                        pedido.Dividir = int.Parse(cbb_dividir.Text);
                        pedido.Pagou = this.pagou;

                        estoque = new EstoquePst();
                        estoque.Id_produto = int.Parse(txt_id_produto.Text);
                        estoque.Quantidade_produto = int.Parse(txt_quant_estoque.Text);
                     
                        con.openCon(pedido.Cadastrar());
                        con.openCon(estoque.AtualizarQuantidade(int.Parse(txt_quantidade.Text)));

                        con.closeCon();
                        MessageBox.Show("Pedido Inserido com Sucesso");
                        
                        PesquisarObjeto();
                    }
                    else
                    {
                        MessageBox.Show("Erro!, a quantidade informada não existe no estoque, Por favor, atualize o estoque antes da venda.");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " A tentativa de cadastro falhou!");
            }
            ClearData();
        }

        public void AtualizarObjeto()
        {
            try
            {
                MessageBox.Show("Em desenvolvimento!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void DeletarObjeto()
        {
            try
            {
                MessageBox.Show("Em desenvolvimento!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
            cbb_dividir.Text = "";
            cbb_juros.Text = "";
        }

        public void ChecarId(string objeto)
        {
            try { 
                ProdutoPst produto = new ProdutoPst();
                DisplayData(produto.checar(objeto));

                if (table.Rows.Count > 0)
                {
                    txt_id_produto.Text = table.Rows[0]["id_produto"].ToString();
                    txt_valor_u.Text = table.Rows[0]["valor"].ToString();
                    calcularPreco();

                    EstoquePst estoque = new EstoquePst();
                    DisplayData(estoque.checar(objeto));

                    if (table.Rows.Count > 0) {
                        txt_quant_estoque.Text = table.Rows[0]["quantidade_produto"].ToString();

                        ClientePst cliente = new ClientePst();
                        DisplayData(cliente.checar(cbb_cliente.Text));

                        if (table.Rows.Count > 0) { txt_id_cliente.Text = table.Rows[0]["id_cliente"].ToString(); }
                    }

                    PesquisarObjeto();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " A tentativa de busca falhou!");
            }
        }

        public void Checar(string objeto)
        {
            try
            {
                PedidoPst pedido = new PedidoPst();
                DisplayData(pedido.checar(objeto));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'rulerDataSet1.Tbl_Cartao_Dividir'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_Cartao_DividirTableAdapter1.Fill(this.rulerDataSet1.Tbl_Cartao_Dividir);
                // TODO: esta linha de código carrega dados na tabela 'rulerDataSet1.Tbl_Cliente'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_ClienteTableAdapter1.Fill(this.rulerDataSet1.Tbl_Cliente);
                // TODO: esta linha de código carrega dados na tabela 'rulerDataSet1.Tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_ProdutoTableAdapter1.Fill(this.rulerDataSet1.Tbl_Produto);
                // TODO: esta linha de código carrega dados na tabela 'rulerDataSet1.Tbl_Pedido'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_PedidoTableAdapter1.Fill(this.rulerDataSet1.Tbl_Pedido);

                calcularPreco();
                cbb_venda.Text = "Dinheiro";
                ChecarId(cbb_produtos.Text);
                cbb_pagou.Text = "Não";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void calcularPreco()
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_quantidade.Text))
                {

                    aux = int.Parse(txt_quantidade.Text);
                    double valor = double.Parse(txt_valor_u.Text);
                    double valorTotal = aux * valor;

                    if (cbb_dividir.Enabled == true)
                    {
                        valorTotal = (valorTotal * (100 + double.Parse(cbb_juros.Text.Replace(".", ",")))) / 100;
                    }

                    txt_valor.Text = valorTotal.ToString();
                }
                else
                {
                    aux = 0;
                    double valor = 0;

                    if (!string.IsNullOrEmpty(txt_valor_u.Text))
                    {

                        valor = double.Parse(txt_valor_u.Text);
                    }

                    double valorTotal = aux * valor;
                    txt_valor.Text = valorTotal.ToString();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " A tentativa de calcular o preço falhou!");
            }
        }

        public void CalcularCartao()
        {
            try
            {
                if (cbb_dividir.Enabled == true)
                {
                    if (cbb_venda.Text == "Cartão")
                    {
                        string cartao = "SELECT * FROM Tbl_Cartao_Dividir WHERE id_cartao_dividir = " + int.Parse(cbb_dividir.Text);

                        table = new DataTable();
                        con.openAdpter(cartao);
                        con.adapt.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            cbb_dividir.Text = table.Rows[0]["id_cartao_dividir"].ToString();
                            cbb_juros.Text = table.Rows[0]["juros"].ToString();
                        }
                        calcularPreco();
                        con.closeCon();
                        table.Clear();
                    }
                }
                else
                {
                    ClearData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        #endregion

        private void cbb_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChecarId(cbb_produtos.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarObjeto();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                PesquisarObjeto();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarObjeto();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                DeletarObjeto();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                txt_id_pedido.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbb_produtos.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_quantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbb_cliente.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbb_venda.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                data_pedido.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            try
            { 
            cbb_dividir.Enabled = false;
            inicio.Show();
            this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            try
            { 
            calcularPreco();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            CalcularCartao();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cbb_venda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_venda.Text == "Cartão")
            {
                cbb_dividir.Enabled = true;
                CalcularCartao();
            }
            else
            {
                cbb_dividir.Enabled = false;
                cbb_juros.Enabled = false;
                ChecarId(cbb_produtos.Text);
            }
        }

        private void cbb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecarId(cbb_produtos.Text);
        }

        private void cbb_dividir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbb_dividir.Text)) { cbb_dividir.Text = "0"; } 
            if (int.Parse(cbb_dividir.Text) > 5  )
            {
                MessageBox.Show("Erro! O produto só pode ser divido em até 5 vezes");
            }
            else
            {
                CalcularCartao();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        
        private void cbb_pagou_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_pagou.Text == "Sim")
            {
                pagou = 1;
            }
            else
            {
                pagou = 0;
            }
        }

        private void cbb_produtos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ChecarId(cbb_produtos.Text);
        }
    }
}
