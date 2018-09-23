using Ruler.Persistence;
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

            btn_deletar.Enabled = false;
            btn_cadastrar.Enabled = true;
            btn_atualizar.Enabled = true;
            txt_id_produto.Enabled = false;

            
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
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_EstoqueTableAdapter.Fill(this.rulerDataSet.Tbl_Estoque);

            ChecarId(cbb_produto.Text);

            if (table.Rows.Count > 0)
            {
                aux = table.Rows[0]["id_produto"].ToString();
            }
            else { aux = ""; }

            txt_id_produto.Text = aux.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbb_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nud_quantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }

        public void ClearData()
        {
            cbb_produto.Text = "";
            txt_id_produto.Text = "";
            nud_quantidade.Text = "";
        }

        private void btn_voltar_Click_1(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        public void PesquisarObjeto()
        {
            EstoquePst estoque = new EstoquePst();
            DisplayData(estoque.Pesquisar());
        }

        public void CadastrarObjeto()
        {
            if (!string.IsNullOrEmpty(cbb_produto.Text) && !string.IsNullOrEmpty(nud_quantidade.Text))
            {

                EstoquePst estoque = new EstoquePst(cbb_produto.Text, int.Parse(nud_quantidade.Text), int.Parse(txt_id_produto.Text));
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
        }
        public void Checar(string objeto)
        {
            EstoquePst estoque = new EstoquePst();
            DisplayData(estoque.checar(objeto));
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

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            PesquisarObjeto();
        }

        private void cbb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChecarId(cbb_produto.Text);

            if (table.Rows.Count > 0)
            {
               aux = table.Rows[0]["id_produto"].ToString();
            }

            txt_id_produto.Text = aux.ToString();
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            CadastrarObjeto();
        }
    }
}
