namespace Ruler.Telas
{
    partial class FrmEstoquePesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dolar = new System.Windows.Forms.TextBox();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lb_real = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.txt_real = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_pesquisa_total = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(76, 173);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 70;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(394, 199);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 30);
            this.btn_voltar.TabIndex = 69;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(18, 199);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(177, 30);
            this.btn_atualizar.TabIndex = 68;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(73, 10);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 67;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(76, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 66;
            // 
            // txt_dolar
            // 
            this.txt_dolar.Enabled = false;
            this.txt_dolar.Location = new System.Drawing.Point(124, 120);
            this.txt_dolar.Name = "txt_dolar";
            this.txt_dolar.Size = new System.Drawing.Size(100, 20);
            this.txt_dolar.TabIndex = 65;
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(121, 104);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(40, 13);
            this.lbl_dolar.TabIndex = 64;
            this.lbl_dolar.Text = "Valor $";
            // 
            // lb_real
            // 
            this.lb_real.AutoSize = true;
            this.lb_real.Location = new System.Drawing.Point(15, 101);
            this.lb_real.Name = "lb_real";
            this.lb_real.Size = new System.Drawing.Size(48, 13);
            this.lb_real.TabIndex = 63;
            this.lb_real.Text = "Valor R$";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(38, 53);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_produto.TabIndex = 62;
            this.lbl_produto.Text = "Produto";
            // 
            // txt_real
            // 
            this.txt_real.Enabled = false;
            this.txt_real.Location = new System.Drawing.Point(18, 120);
            this.txt_real.Name = "txt_real";
            this.txt_real.Size = new System.Drawing.Size(100, 20);
            this.txt_real.TabIndex = 61;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(41, 69);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(170, 20);
            this.txt_Nome.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(446, 209);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(287, 19);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(177, 41);
            this.btn_pesquisar.TabIndex = 72;
            this.btn_pesquisar.Text = "Pesquisar Tudo";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_pesquisa_total
            // 
            this.btn_pesquisa_total.Location = new System.Drawing.Point(287, 87);
            this.btn_pesquisa_total.Name = "btn_pesquisa_total";
            this.btn_pesquisa_total.Size = new System.Drawing.Size(177, 41);
            this.btn_pesquisa_total.TabIndex = 73;
            this.btn_pesquisa_total.Text = "Pesquisar Total";
            this.btn_pesquisa_total.UseVisualStyleBackColor = true;
            this.btn_pesquisa_total.Click += new System.EventHandler(this.btn_pesquisa_total_Click);
            // 
            // FrmEstoquePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btn_pesquisa_total);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_dolar);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lb_real);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.txt_real);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEstoquePesquisa";
            this.Text = "FrmEstoquePesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_dolar;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lb_real;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.TextBox txt_real;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_pesquisa_total;
    }
}