using Ruler.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

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

        public void PesquisarObjeto()
        {
            try
            {
                ClientePst cliente = new ClientePst();
                if (string.IsNullOrEmpty(txt_id.Text))
                {
                    DisplayData(cliente.Pesquisar());
                }
                else
                {
                    DisplayData(cliente.PesquisarId(int.Parse(txt_id.Text)));
                    if (table.Rows.Count > 0)
                    {
                        txt_nome.Text = table.Rows[0]["nome"].ToString();
                        txt_telefone.Text = table.Rows[0]["telefone"].ToString();
                        txt_debito.Text = table.Rows[0]["debito"].ToString();
                        aux = "";
                    }
                    else
                    {
                        MessageBox.Show("Cliente com o id " + txt_id.Text + " não existe!");
                        aux = "";
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " A tentativa de pesquisa falhou!");
            }
        }

        public void CadastrarObjeto()
        {
            ClientePst cliente;
            try
            {
                if (!string.IsNullOrEmpty(txt_nome.Text))
                {
                    if (string.IsNullOrEmpty(txt_debito.Text)) { txt_debito.Text = "0"; }
                    if (string.IsNullOrEmpty(txt_telefone.Text)) { txt_telefone.Text = "0"; }

                    cliente = new ClientePst();

                    cliente.Nome = txt_nome.Text;
                    cliente.Telefone = txt_telefone.Text;
                    cliente.Debito = txt_debito.Text.Replace(",", ".");

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
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "A tentativa de Cadastro falhou");
            }

            ClearData();
            PesquisarObjeto();
        }

        public void AtualizarObjeto()
        {
            ClientePst cliente;
            try
            {
                if (txt_nome.Text != "" && txt_id.Text != "")
                {
                    cliente = new ClientePst();
                    cliente.Id = int.Parse(txt_id.Text);
                    cliente.Nome = txt_nome.Text;
                    cliente.Telefone = txt_telefone.Text;
                    cliente.Debito = txt_debito.Text.Replace(",", ".");

                    con.openCon(cliente.Atualizar());
                    con.closeCon();

                    MessageBox.Show("Cliente Atualizado com Sucesso");
                    DisplayData(cliente.Pesquisar());
                }
                else
                {
                    MessageBox.Show("Erro! Por favor verifique os valores informados");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " A tentativa de atualização falhou");
            }
            
            ClearData();
        }

        public void DeletarObjeto()
        {
            throw new NotImplementedException();
        }

        public void DisplayData(string script)
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
            try
            {
                ClientePst cliente = new ClientePst();
                DisplayData(cliente.checar(objeto));
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
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_telefone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_debito.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_pesquisar_id_Click(object sender, EventArgs e)
        {
            try
            {
                aux = "id";
                PesquisarObjeto();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
