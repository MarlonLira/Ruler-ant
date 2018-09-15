namespace Ruler.Telas
{
    partial class FrmClientePesquisa
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.lbl_debito = new System.Windows.Forms.Label();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(389, 116);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 30);
            this.btn_voltar.TabIndex = 37;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click_1);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(69, 123);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(177, 21);
            this.btn_atualizar.TabIndex = 36;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(113, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 34;
            // 
            // txt_debito
            // 
            this.txt_debito.Location = new System.Drawing.Point(182, 97);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(100, 20);
            this.txt_debito.TabIndex = 33;
            // 
            // lbl_debito
            // 
            this.lbl_debito.AutoSize = true;
            this.lbl_debito.Location = new System.Drawing.Point(179, 81);
            this.lbl_debito.Name = "lbl_debito";
            this.lbl_debito.Size = new System.Drawing.Size(38, 13);
            this.lbl_debito.TabIndex = 32;
            this.lbl_debito.Text = "Debito";
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(40, 81);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_telefone.TabIndex = 31;
            this.lb_telefone.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nome";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(43, 97);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 29;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(43, 55);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(239, 20);
            this.txt_Nome.TabIndex = 28;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(282, 10);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(177, 39);
            this.btn_pesquisar.TabIndex = 27;
            this.btn_pesquisar.Text = "Pesquisar Todos";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 288);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // FrmClientePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 451);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_debito);
            this.Controls.Add(this.lbl_debito);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmClientePesquisa";
            this.Text = "FrmClientePesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.Label lbl_debito;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}