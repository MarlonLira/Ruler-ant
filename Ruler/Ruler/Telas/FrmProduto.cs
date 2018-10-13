using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmProduto : Form, ConfigFrm
    {
        private FrmInicio inicio;
        private Conexao con = new Conexao();
        DataTable table;
        private string aux;


        public FrmProduto(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        public void Checar(string objeto)
        {
            ProdutoPst produto = new ProdutoPst();
            DisplayData(produto.checar(objeto));
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

        public void AtualizarObjeto()
        {
            if (txt_nome.Text != "" && txt_valor.Text != "")
            {
                ProdutoPst produto = new ProdutoPst(int.Parse(txt_id_produto.Text), txt_nome.Text, txt_valor.Text.Replace(",","."), txt_valor_dolar.Text.Replace(",","."));
                                
                con.openCon(produto.Atualizar());
                con.closeCon();
                MessageBox.Show("Produto Atualizado com Sucesso");
                            
                DisplayData(produto.Pesquisar());
                ClearData();
                this.tbl_ProdutoTableAdapter.Fill(this.rulerDataSet.Tbl_Produto);
            }
            else
            {
                MessageBox.Show("Erro! Por favor informe algum valor e os informe corretamente");
            }
        }

        public void CadastrarObjeto()
        {
            if (!string.IsNullOrEmpty(txt_nome.Text) && !string.IsNullOrEmpty(txt_valor.Text))
            {
                //Caso o valor em dolar não seja digitado atribui 0.
                if (string.IsNullOrEmpty(txt_valor_dolar.Text)) { txt_valor_dolar.Text = "0"; }

                ProdutoPst produto = new ProdutoPst(txt_nome.Text, txt_valor.Text.Replace(",","."), txt_valor_dolar.Text.Replace(",","."));

                //Consultar Objeto
                Checar(txt_nome.Text);
                if (table.Rows.Count < 0)
                {
                    aux = table.Rows[0]["nome"].ToString();
                }

                //Condição para não haver produtos iguais.
                if (aux == txt_nome.Text)
                {
                    MessageBox.Show("Erro! O produto já está cadastrado. ");
                    ClearData();
                }
                else
                {
                    con.openCon(produto.Cadastrar());
                    con.closeCon();
                    MessageBox.Show("Produto Inserido com Sucesso");
                }

                ClearData();
                PesquisarObjeto();

            }
            else
            {
                MessageBox.Show("Erro!, Produto ou valor não foram informados.");
            }
        }

        public void DeletarObjeto()
        {
            if (txt_id_produto.Text != "")
            {
                ProdutoPst produto = new ProdutoPst(int.Parse(txt_id_produto.Text));
                                
                con.openCon(produto.Deletar());
                con.closeCon();

                MessageBox.Show("Produto Apagado com Sucesso");
                
                DisplayData(produto.Pesquisar());
                ClearData();
            }
            else
            {
                MessageBox.Show("Erro! Por favor informe o ID corretamente");
            }
        }

        public void PesquisarObjeto()
        {
            ProdutoPst produto = new ProdutoPst();

            if (string.IsNullOrEmpty(txt_id_produto.Text))
            {
                DisplayData(produto.Pesquisar());
            }
            else
            {
                DisplayData(produto.PesquisarId(int.Parse(txt_id_produto.Text)));
                if (table.Rows.Count > 0)
                {
                    txt_nome.Text = table.Rows[0]["nome"].ToString();
                    txt_valor.Text = table.Rows[0]["valor"].ToString();
                    txt_valor_dolar.Text = table.Rows[0]["valor_dolar"].ToString();
                    aux = "";
                }
                else
                {
                    MessageBox.Show("Cliente com o id " + txt_id_produto.Text + " não existe!");
                    aux = "";
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            PesquisarObjeto();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_valor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_valor_dolar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        } 

        public void ClearData()
        {
            txt_nome.Text = "";
            txt_valor.Text = "";
            txt_valor_dolar.Text = "";
            txt_id_produto.Text = "";
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.rulerDataSet.Tbl_Produto);
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            DeletarObjeto();
        }


        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AtualizarObjeto();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_id_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_valor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_valor_dolar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

      
    }
}
