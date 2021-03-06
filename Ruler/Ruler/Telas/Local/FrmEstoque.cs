﻿using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmEstoque : Form, ConfigFrm
    {
        
        Conexao con = new Conexao();
        private FrmInicio inicio;
        DataTable table;
        private string aux;

        public FrmEstoque(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }
            
        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.rulerDataSet.Tbl_Produto);

            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_EstoqueTableAdapter.Fill(this.rulerDataSet.Tbl_Estoque);

            ChecarId(cbb_produto.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbb_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_quantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        public void ClearData()
        {
            cbb_produto.Text = "";
            txt_id_produto.Text = "";
            txt_id_estoque.Text = "";
            txt_quantidade.Text = "";
        }

        
        public void PesquisarObjeto()
        {
            EstoquePst estoque = new EstoquePst();
            

            if (string.IsNullOrEmpty(txt_id_estoque.Text))
            {
                DisplayData(estoque.Pesquisar());
            }
            else
            {
                DisplayData(estoque.PesquisarId(int.Parse(txt_id_estoque.Text)));
                if (table.Rows.Count > 0)
                {
                    cbb_produto.Text = table.Rows[0]["nome_produto"].ToString();
                    txt_quantidade.Text = table.Rows[0]["quantidade_produto"].ToString();
                    txt_id_produto.Text = table.Rows[0]["id_produto"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("O id informado '" + txt_id_produto.Text + "' não existe!");
                    
                }
            }
        }

        public void CadastrarObjeto()
        {
            if (!string.IsNullOrEmpty(cbb_produto.Text) && !string.IsNullOrEmpty(txt_quantidade.Text))
            {

                EstoquePst estoque = new EstoquePst(cbb_produto.Text, int.Parse(txt_quantidade.Text), int.Parse(txt_id_produto.Text));
                //Consultar Objeto
                Checar(cbb_produto.Text);
                if (table.Rows.Count > 0) {
                    aux = table.Rows[0]["nome_produto"].ToString();
                }
                else { aux = ""; }
                //Condição para não haver produtos iguais.
                if (aux == cbb_produto.Text)
                {
                    MessageBox.Show("Erro! O produto já está cadastrado no estoque. ");
                    ClearData();
                }
                else
                {
                    con.openCon(estoque.Cadastrar());
                    con.closeCon();
                    MessageBox.Show("Produto Inserido com Sucesso");
                }

                ClearData();
                PesquisarObjeto();

            }
            else
            {
                MessageBox.Show("Erro!,.");
            }
        }

        public void ChecarId(string objeto)
        {
            ProdutoPst produto = new ProdutoPst();
            DisplayData(produto.checar(objeto));

            if (table.Rows.Count > 0)
            {
                txt_id_produto.Text = table.Rows[0]["id_produto"].ToString();

                Checar(cbb_produto.Text);

                if (table.Rows.Count > 0)
                {
                    txt_id_estoque.Text = table.Rows[0]["id_estoque"].ToString();
                    txt_quantidade.Text = table.Rows[0]["quantidade_produto"].ToString();
                }
            }
        }

        public void Checar(string objeto)
        {
            EstoquePst estoque = new EstoquePst();
            DisplayData(estoque.checar(objeto));
        }

        public void AtualizarObjeto()
        {
            if (cbb_produto.Text != "" && txt_id_produto.Text != "")
            {
                EstoquePst estoque = new EstoquePst(int.Parse(txt_id_estoque.Text), cbb_produto.Text, int.Parse(txt_quantidade.Text), int.Parse(txt_id_produto.Text));

                con.openCon(estoque.Atualizar());
                con.closeCon();
                
                MessageBox.Show("Estoque Atualizado com Sucesso");

                DisplayData(estoque.Pesquisar());
                ClearData();
                PesquisarObjeto();
            }
            else
            {
                MessageBox.Show("Erro! Por favor verifique os valores informados");
            }
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

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            PesquisarObjeto();
        }

        private void cbb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecarId(cbb_produto.Text);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AtualizarObjeto();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
