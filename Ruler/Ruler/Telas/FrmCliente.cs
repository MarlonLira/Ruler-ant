using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace Ruler.Telas
{
    public partial class FrmCliente : Form, ConfigFrm
    {
        Conexao con = new Conexao();
        private FrmInicio inicio;
        DataTable table;
        private string aux;

        public FrmCliente(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;

            ClearData();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ClienteTableAdapter.Fill(this.rulerDataSet.Tbl_Cliente);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        public void PesquisarObjeto()
        {
            ClientePst cliente = new ClientePst();
            DisplayData(cliente.Pesquisar());
        }

        public void CadastrarObjeto()
        {
            if (!string.IsNullOrEmpty(txt_nome.Text))
            {
                if (string.IsNullOrEmpty(txt_debito.Text)) { txt_debito.Text = "0"; }
                if (string.IsNullOrEmpty(txt_telefone.Text)) { txt_telefone.Text = "0"; }

                ClientePst cliente = new ClientePst(txt_nome.Text, txt_telefone.Text, txt_debito.Text.Replace(",","."));

                //Consultar Objeto
                Checar(txt_nome.Text);
                if (table.Rows.Count > 0)
                {
                    aux = table.Rows[0]["nome"].ToString();
                }
                else { aux = ""; }

                //Condição para não haver produtos iguais.
                if (aux == txt_nome.Text)
                {
                    MessageBox.Show("Erro! O cliente já está cadastrado. ");
                    ClearData();
                }
                else
                {
                    con.openCon(cliente.Cadastrar());
                    con.closeCon();
                    MessageBox.Show("Cliente Inserido com Sucesso");
                }

                ClearData();
            }
        }

        public void AtualizarObjeto()
        {
            if (txt_nome.Text != "" && txt_id.Text != "")
            {
                ClientePst cliente = new ClientePst(int.Parse(txt_id.Text), txt_nome.Text, txt_telefone.Text, txt_debito.Text.Replace(",", "."));

                con.openCon(cliente.Atualizar());
                con.closeCon();

                MessageBox.Show("Cliente Atualizado com Sucesso");

                DisplayData(cliente.Pesquisar());
                ClearData();
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

        public void ClearData()
        {
            txt_nome.Text = "";
            txt_id.Text = "";
            txt_telefone.Text = "";
            txt_debito.Text = "";
        }

        public void Checar(string objeto)
        {
            ClientePst cliente = new ClientePst();
            DisplayData(cliente.checar(objeto));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_telefone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_debito.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
