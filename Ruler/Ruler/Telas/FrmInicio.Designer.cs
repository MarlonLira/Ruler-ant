namespace Ruler.Telas
{
    partial class FrmInicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_pesquisar_pedidos = new System.Windows.Forms.Button();
            this.btn_cadastrar_pedidos = new System.Windows.Forms.Button();
            this.btn_pesquisar_estoque = new System.Windows.Forms.Button();
            this.btn_cadastro_estoque = new System.Windows.Forms.Button();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentacaoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_cliTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 459);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagina inicial";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_pesquisar_pedidos);
            this.groupBox4.Controls.Add(this.btn_cadastrar_pedidos);
            this.groupBox4.Controls.Add(this.btn_pesquisar_estoque);
            this.groupBox4.Controls.Add(this.btn_cadastro_estoque);
            this.groupBox4.Controls.Add(this.btn_estoque);
            this.groupBox4.Controls.Add(this.btn_vender);
            this.groupBox4.Location = new System.Drawing.Point(6, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(785, 264);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vendas";
            // 
            // btn_pesquisar_pedidos
            // 
            this.btn_pesquisar_pedidos.Location = new System.Drawing.Point(270, 153);
            this.btn_pesquisar_pedidos.Name = "btn_pesquisar_pedidos";
            this.btn_pesquisar_pedidos.Size = new System.Drawing.Size(75, 36);
            this.btn_pesquisar_pedidos.TabIndex = 25;
            this.btn_pesquisar_pedidos.Text = "Pesquisar";
            this.btn_pesquisar_pedidos.UseVisualStyleBackColor = true;
            this.btn_pesquisar_pedidos.Click += new System.EventHandler(this.btn_pesquisar_pedidos_Click);
            // 
            // btn_cadastrar_pedidos
            // 
            this.btn_cadastrar_pedidos.Location = new System.Drawing.Point(158, 153);
            this.btn_cadastrar_pedidos.Name = "btn_cadastrar_pedidos";
            this.btn_cadastrar_pedidos.Size = new System.Drawing.Size(75, 36);
            this.btn_cadastrar_pedidos.TabIndex = 24;
            this.btn_cadastrar_pedidos.Text = "Cadastrar";
            this.btn_cadastrar_pedidos.UseVisualStyleBackColor = true;
            this.btn_cadastrar_pedidos.Click += new System.EventHandler(this.btn_cadastrar_pedidos_Click);
            // 
            // btn_pesquisar_estoque
            // 
            this.btn_pesquisar_estoque.Location = new System.Drawing.Point(551, 153);
            this.btn_pesquisar_estoque.Name = "btn_pesquisar_estoque";
            this.btn_pesquisar_estoque.Size = new System.Drawing.Size(75, 36);
            this.btn_pesquisar_estoque.TabIndex = 23;
            this.btn_pesquisar_estoque.Text = "Pesquisar";
            this.btn_pesquisar_estoque.UseVisualStyleBackColor = true;
            this.btn_pesquisar_estoque.Click += new System.EventHandler(this.btn_pesquisar_estoque_Click);
            // 
            // btn_cadastro_estoque
            // 
            this.btn_cadastro_estoque.Location = new System.Drawing.Point(439, 153);
            this.btn_cadastro_estoque.Name = "btn_cadastro_estoque";
            this.btn_cadastro_estoque.Size = new System.Drawing.Size(75, 36);
            this.btn_cadastro_estoque.TabIndex = 22;
            this.btn_cadastro_estoque.Text = "Cadastrar";
            this.btn_cadastro_estoque.UseVisualStyleBackColor = true;
            this.btn_cadastro_estoque.Click += new System.EventHandler(this.btn_cadastro_estoque_Click);
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_estoque.Enabled = false;
            this.btn_estoque.FlatAppearance.BorderSize = 2;
            this.btn_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_estoque.Location = new System.Drawing.Point(422, 62);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(225, 140);
            this.btn_estoque.TabIndex = 21;
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_estoque.UseVisualStyleBackColor = false;
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vender.Enabled = false;
            this.btn_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_vender.Location = new System.Drawing.Point(138, 62);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(225, 140);
            this.btn_vender.TabIndex = 20;
            this.btn_vender.Text = "Pedidos";
            this.btn_vender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vender.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 74);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo ao Ruler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(6, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 54);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosTSMI,
            this.relatoriosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(18, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(327, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosTSMI
            // 
            this.produtosTSMI.Name = "produtosTSMI";
            this.produtosTSMI.Size = new System.Drawing.Size(67, 20);
            this.produtosTSMI.Text = "Produtos";
            this.produtosTSMI.Click += new System.EventHandler(this.produtosTSMI_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentacaoTSMI,
            this.comprasToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Enabled = false;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // movimentacaoTSMI
            // 
            this.movimentacaoTSMI.Name = "movimentacaoTSMI";
            this.movimentacaoTSMI.Size = new System.Drawing.Size(154, 22);
            this.movimentacaoTSMI.Text = "Movimentação";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrar_cliTSMI,
            this.pesquisarToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cadastrar_cliTSMI
            // 
            this.cadastrar_cliTSMI.Name = "cadastrar_cliTSMI";
            this.cadastrar_cliTSMI.Size = new System.Drawing.Size(124, 22);
            this.cadastrar_cliTSMI.Text = "Cadastrar";
            this.cadastrar_cliTSMI.Click += new System.EventHandler(this.cadastrar_cliTSMI_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.pesquisarToolStripMenuItem1_Click_1);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_pesquisar_pedidos;
        private System.Windows.Forms.Button btn_cadastrar_pedidos;
        private System.Windows.Forms.Button btn_pesquisar_estoque;
        private System.Windows.Forms.Button btn_cadastro_estoque;
        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosTSMI;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentacaoTSMI;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_cliTSMI;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
    }
}