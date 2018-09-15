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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentacaoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrar_cliTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 45.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem Vindo ao Ruler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 40);
            this.panel2.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.produtosTSMI,
            this.relatoriosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Menu ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem2.Text = "-->";
            // 
            // produtosTSMI
            // 
            this.produtosTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTSMI,
            this.pesquisarTSMI});
            this.produtosTSMI.Name = "produtosTSMI";
            this.produtosTSMI.Size = new System.Drawing.Size(67, 20);
            this.produtosTSMI.Text = "Produtos";
            // 
            // cadastrarTSMI
            // 
            this.cadastrarTSMI.Name = "cadastrarTSMI";
            this.cadastrarTSMI.Size = new System.Drawing.Size(124, 22);
            this.cadastrarTSMI.Text = "Cadastrar";
            this.cadastrarTSMI.Click += new System.EventHandler(this.cadastrarTSMI_Click);
            // 
            // pesquisarTSMI
            // 
            this.pesquisarTSMI.Name = "pesquisarTSMI";
            this.pesquisarTSMI.Size = new System.Drawing.Size(124, 22);
            this.pesquisarTSMI.Text = "Pesquisar";
            this.pesquisarTSMI.Click += new System.EventHandler(this.pesquisarTSMI_Click_1);
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
            this.cadastrar_cliTSMI.Size = new System.Drawing.Size(180, 22);
            this.cadastrar_cliTSMI.Text = "Cadastrar";
            this.cadastrar_cliTSMI.Click += new System.EventHandler(this.cadastrar_cliTSMI_Click);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.pesquisarToolStripMenuItem1_Click_1);
            // 
            // btn_vender
            // 
            this.btn_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.Location = new System.Drawing.Point(138, 230);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(225, 140);
            this.btn_vender.TabIndex = 6;
            this.btn_vender.Text = "Vendas";
            this.btn_vender.UseVisualStyleBackColor = true;
            // 
            // btn_compras
            // 
            this.btn_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.Location = new System.Drawing.Point(422, 230);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(225, 140);
            this.btn_compras.TabIndex = 7;
            this.btn_compras.Text = "Compras";
            this.btn_compras.UseVisualStyleBackColor = true;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btn_compras);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produtosTSMI;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTSMI;
        private System.Windows.Forms.ToolStripMenuItem pesquisarTSMI;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentacaoTSMI;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrar_cliTSMI;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_compras;
    }
}