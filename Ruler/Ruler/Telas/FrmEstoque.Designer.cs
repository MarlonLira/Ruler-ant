namespace Ruler.Telas
{
    partial class FrmEstoque
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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dolar = new System.Windows.Forms.TextBox();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lb_real = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.txt_real = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.date_entrada = new System.Windows.Forms.DateTimePicker();
            this.cb_produtos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calendar_Entrada = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(205, 205);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(70, 30);
            this.btn_voltar.TabIndex = 49;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(12, 205);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(177, 30);
            this.btn_cadastrar.TabIndex = 48;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(67, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 47;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(70, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 46;
            // 
            // txt_dolar
            // 
            this.txt_dolar.Enabled = false;
            this.txt_dolar.Location = new System.Drawing.Point(118, 126);
            this.txt_dolar.Name = "txt_dolar";
            this.txt_dolar.Size = new System.Drawing.Size(100, 20);
            this.txt_dolar.TabIndex = 45;
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(115, 110);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(40, 13);
            this.lbl_dolar.TabIndex = 44;
            this.lbl_dolar.Text = "Valor $";
            // 
            // lb_real
            // 
            this.lb_real.AutoSize = true;
            this.lb_real.Location = new System.Drawing.Point(9, 107);
            this.lb_real.Name = "lb_real";
            this.lb_real.Size = new System.Drawing.Size(48, 13);
            this.lb_real.TabIndex = 43;
            this.lb_real.Text = "Valor R$";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(32, 59);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_produto.TabIndex = 42;
            this.lbl_produto.Text = "Produto";
            // 
            // txt_real
            // 
            this.txt_real.Enabled = false;
            this.txt_real.Location = new System.Drawing.Point(12, 126);
            this.txt_real.Name = "txt_real";
            this.txt_real.Size = new System.Drawing.Size(100, 20);
            this.txt_real.TabIndex = 41;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Enabled = false;
            this.txt_Nome.Location = new System.Drawing.Point(35, 75);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(170, 20);
            this.txt_Nome.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(446, 209);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Data";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(70, 179);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 50;
            // 
            // date_entrada
            // 
            this.date_entrada.Location = new System.Drawing.Point(554, 265);
            this.date_entrada.Name = "date_entrada";
            this.date_entrada.Size = new System.Drawing.Size(226, 20);
            this.date_entrada.TabIndex = 54;
            this.date_entrada.Visible = false;
            // 
            // cb_produtos
            // 
            this.cb_produtos.Enabled = false;
            this.cb_produtos.FormattingEnabled = true;
            this.cb_produtos.Location = new System.Drawing.Point(606, 89);
            this.cb_produtos.Name = "cb_produtos";
            this.cb_produtos.Size = new System.Drawing.Size(121, 21);
            this.cb_produtos.TabIndex = 55;
            this.cb_produtos.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(603, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Produtos";
            this.label3.Visible = false;
            // 
            // calendar_Entrada
            // 
            this.calendar_Entrada.Enabled = false;
            this.calendar_Entrada.Location = new System.Drawing.Point(231, 14);
            this.calendar_Entrada.Name = "calendar_Entrada";
            this.calendar_Entrada.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 58;
            this.label4.Text = "Selecione um dos produtos\r\ncadastrados abaixo\r\n\r\n";
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calendar_Entrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_produtos);
            this.Controls.Add(this.date_entrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_dolar);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lb_real);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.txt_real);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_dolar;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lb_real;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.TextBox txt_real;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.DateTimePicker date_entrada;
        private System.Windows.Forms.ComboBox cb_produtos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendar_Entrada;
        private System.Windows.Forms.Label label4;
    }
}