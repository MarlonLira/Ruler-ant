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
    public partial class FrmEstoque : Form
    {
        DataTable aux = new DataTable(); 
        Conexao con = new Conexao();
        private FrmInicio inicio;
        private EstoquePst estoque;

        public const string select_produto_nome = "select * from Tbl_Produto";

        public const string criarInsert = "insert into Tbl_Estoque (nome_produto, valor_produto, valor_produto_dolar, quantidade_produto, id_produto) values(@coluna1, @coluna2, @coluna3, @coluna4, @coluna5)";


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
                


        private void data()
        {

            
        }

        

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            con.openCon();
            DataTable dt = new DataTable();
            con.openAdpter(select_produto_nome);
            con.adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.closeCon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_real.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_dolar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Nome.Text) && !string.IsNullOrEmpty(txt_quantidade.Text))
            {

                estoque = new EstoquePst(txt_Nome.Text, double.Parse(txt_real.Text), double.Parse(txt_dolar.Text), int.Parse(txt_quantidade.Text), int.Parse(txt_id.Text));

                con.openCon(criarInsert, estoque.Nome_produto, estoque.Valor_produto.ToString(), estoque.Valor_produto_dolar.ToString(), estoque.Quantidade_produto.ToString(), estoque.Id_produto.ToString());

                con.closeCon();
                MessageBox.Show("Produto Inserido no estoque com sucesso");
                data();
                ClearData();
            }
            else { MessageBox.Show("Erro!, Produto ou quantidades não foram informados."); }
        }

        private void ClearData()
        {
            txt_Nome.Text = "";
            txt_real.Text = "";
            txt_dolar.Text = "";
            txt_id.Text = "";
            txt_quantidade.Text = "";
        }

        
    }
}
