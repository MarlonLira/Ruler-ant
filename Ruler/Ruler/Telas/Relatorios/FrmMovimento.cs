using System;
using System.Windows.Forms;

namespace Ruler.Telas
{
    public partial class FrmMovimento : Form, ConfigFrm
    {
        FrmInicio inicio;
        public FrmMovimento(FrmInicio frm)
        {
            InitializeComponent();
            inicio = frm;
        }

        private void FrmMovimento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Close();
        }

        private void FrmMovimento_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);
            // TODO: esta linha de código carrega dados na tabela 'rulerDataSet.Tbl_Movimento'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_MovimentoTableAdapter.Fill(this.rulerDataSet.Tbl_Movimento);

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

        }

        public void PesquisarObjeto()
        {
            throw new NotImplementedException();
        }

        public void CadastrarObjeto()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void ClearData()
        {
            throw new NotImplementedException();
        }

        public void Checar(string objeto)
        {
            throw new NotImplementedException();
        }
    }
}
