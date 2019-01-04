using Ruler.Persistence;
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
            try
            {
                inicio.Show();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
            
        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_ProdutoTableAdapter.Fill(this.rulerDataSet.Tbl_Produto);
                // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Estoque'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_EstoqueTableAdapter.Fill(this.rulerDataSet.Tbl_Estoque);

                ChecarId(cbb_produto.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
            try
            {
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void CadastrarObjeto()
        {
            EstoquePst estoque;
            try
            {
                if (!string.IsNullOrEmpty(cbb_produto.Text) && !string.IsNullOrEmpty(txt_quantidade.Text))
                {
                    estoque = new EstoquePst();
                    estoque.Nome_produto = cbb_produto.Text;
                    estoque.Quantidade_produto = int.Parse(txt_quantidade.Text);
                    estoque.Id_produto = int.Parse(txt_id_produto.Text);

                    //Consultar Objeto
                    Checar(cbb_produto.Text);
                    if (table.Rows.Count > 0)
                    {
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void ChecarId(string objeto)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void Checar(string objeto)
        {
            try
            {
                EstoquePst estoque = new EstoquePst();
                DisplayData(estoque.checar(objeto));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void AtualizarObjeto()
        {
            EstoquePst estoque;
            try
            {
                if (cbb_produto.Text != "" && txt_id_produto.Text != "")
                {
                    estoque = new EstoquePst();
                    estoque.Nome_produto = cbb_produto.Text;
                    estoque.Quantidade_produto = int.Parse(txt_quantidade.Text);
                    estoque.Id_produto = int.Parse(txt_id_produto.Text);

                    con.openCon(estoque.Atualizar());
                    con.closeCon();

                    MessageBox.Show("Estoque Atualizado com Sucesso");

                    DisplayData(estoque.Pesquisar());
                    PesquisarObjeto();
                }
                else
                {
                    MessageBox.Show("Erro! Por favor verifique os valores informados");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            ClearData();
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
            try
            {
                PesquisarObjeto();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cbb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChecarId(cbb_produto.Text);
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

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                ClearData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
