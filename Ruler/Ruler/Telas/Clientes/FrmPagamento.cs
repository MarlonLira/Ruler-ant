using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmPagamento : Form, ConfigFrm
    {
        Conexao con = new Conexao();
        private FrmInicio inicio;
        DataTable table;
        private string aux;

        public FrmPagamento(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;

            
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ClienteTableAdapter.Fill(this.rulerDataSet.Tbl_Cliente);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);

            PesquisarObjeto("nome_cliente", cbb_cliente.Text);
        }

        public void AtualizarObjeto()
        {
            throw new NotImplementedException();
        }

        public void CadastrarObjeto()
        {
            if (!string.IsNullOrEmpty(cbb_cliente.Text) && !string.IsNullOrEmpty(txt_valor.Text))
            {

                PagamentoPst pagamento = new PagamentoPst(int.Parse(cbb_id_cliente.Text), double.Parse(txt_valor.Text), cbb_tipo_pagamento.Text, int.Parse(txt_id_pedido.Text));

                //Consultar Objeto
                Checar(txt_id_pedido.Text);
                if (table.Rows.Count > 0)
                {
                    aux = table.Rows[0]["pedido_id"].ToString();
                }
                else { aux = ""; }

                /*//Condição para não haver produtos iguais.
                if (aux == txt_id_pedido.Text)
                {
                    MessageBox.Show("Erro! Esse pagamento já foi efetuado. ");
                    ClearData();
                }
                else
                {*/
                    con.openCon(pagamento.Cadastrar());
                    con.closeCon();
                    MessageBox.Show("Pagamento feito com Sucesso!");
                //}

                ClearData();
                PesquisarObjeto();
            }
        }

        public void Checar(string objeto)
        {
            PagamentoPst pagamento = new PagamentoPst();
            DisplayData(pagamento.Pesquisar(int.Parse(objeto)));
        }

        public void ClearData()
        {
            txt_id.Text = "";
            txt_id_pedido.Text = "";
            txt_debito.Text = "";
            txt_valor.Text = "";
            cbb_cliente.Text = "";
            cbb_id_cliente.Text = "";
            cbb_tipo_pagamento.Text = "";
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
            if (string.IsNullOrEmpty(aux))
            {
              dataGridView1.DataSource = dt;
            }
            con.adapt.Fill(table);
            con.closeCon();
        }

        public void PesquisarObjeto()
        {
            PagamentoPst pagamento = new PagamentoPst();

            if (!string.IsNullOrEmpty(txt_id_pedido.Text))
            {
                DisplayData(pagamento.Pesquisar());
            }
            else if(!string.IsNullOrEmpty(txt_id.Text))
            {
                DisplayData(pagamento.Pesquisar("id_movimento", int.Parse(txt_id.Text)));
                if (table.Rows.Count > 0)
                {
                    cbb_cliente.Text = table.Rows[0]["nome_cliente"].ToString();
                    txt_debito.Text = table.Rows[0]["valor"].ToString();
                    txt_id_pedido.Text = table.Rows[0]["pedido_id"].ToString();

                }
                else
                {
                    MessageBox.Show("O id informado '" + txt_id.Text + "' não existe!");

                }
            }
        }

        public void PesquisarObjeto(string coluna, string objeto)
        {
            PagamentoPst pagamento = new PagamentoPst();
            if (aux == "cliente" || string.IsNullOrEmpty(aux))
            {
                aux = "procurar";
                ClientePst cliente = new ClientePst();
                DisplayData(cliente.checar(objeto));
                if (table.Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(table.Rows[0]["debito"].ToString()))
                    {
                        cbb_cliente.Text = table.Rows[0]["nome"].ToString();
                        txt_debito.Text = table.Rows[0]["debito"].ToString();
                        cbb_id_cliente.Text = table.Rows[0]["id_cliente"].ToString();
                    }
                    else
                    {
                        txt_debito.Text = "0";

                    }

                }
                aux = "";
            }
            else if (aux == "id")
            {
                aux = "";
                DisplayData(pagamento.Pesquisar(coluna, int.Parse(objeto)));

                if (table.Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(table.Rows[0]["id_movimento"].ToString()))
                    {
                        cbb_cliente.Text = table.Rows[0]["nome_cliente"].ToString();
                        cbb_id_cliente.Text = table.Rows[0]["id_cliente"].ToString();
                    }
                    else
                    {
                        txt_debito.Text = "0";

                    }
                }
            }
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) && string.IsNullOrEmpty(txt_id_pedido.Text))
            {
              PesquisarObjeto();
            }

            else if (string.IsNullOrEmpty(txt_id.Text))
            {
                PesquisarObjeto("pedido_id", txt_id_pedido.Text);
                aux = "id";
            }

            else if (!string.IsNullOrEmpty(cbb_cliente.Text))
            {
                PesquisarObjeto("nome_cliente", cbb_cliente.Text);
                aux = "cliente";
            }

            else
            {
                PesquisarObjeto("id_movimento", txt_id.Text);
                aux = "id";
            }
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AtualizarObjeto();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            DeletarObjeto();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cbb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            PesquisarObjeto("nome_cliente", cbb_cliente.Text);
            aux = "cliente";
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_pedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
