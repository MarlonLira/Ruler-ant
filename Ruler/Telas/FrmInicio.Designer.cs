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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_estoque = new System.Windows.Forms.Button();
            this.btn_compras = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_cadastrar_produtos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentacaoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 459);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagina inicial";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.btn_estoque);
            this.groupBox3.Controls.Add(this.btn_compras);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(567, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 370);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meu Negócio";
            // 
            // btn_estoque
            // 
            this.btn_estoque.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estoque.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_estoque.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_estoque.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_estoque.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_estoque.Location = new System.Drawing.Point(3, 103);
            this.btn_estoque.Name = "btn_estoque";
            this.btn_estoque.Size = new System.Drawing.Size(266, 87);
            this.btn_estoque.TabIndex = 24;
            this.btn_estoque.Text = "Estoque";
            this.btn_estoque.UseVisualStyleBackColor = false;
            this.btn_estoque.Click += new System.EventHandler(this.btn_estoque_Click_1);
            // 
            // btn_compras
            // 
            this.btn_compras.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_compras.Enabled = false;
            this.btn_compras.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_compras.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_compras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_compras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_compras.Location = new System.Drawing.Point(3, 16);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(266, 87);
            this.btn_compras.TabIndex = 22;
            this.btn_compras.Text = "+ Compras";
            this.btn_compras.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Controls.Add(this.btn_cadastrar_produtos);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(289, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 370);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produtos";
            // 
            // btn_cadastrar_produtos
            // 
            this.btn_cadastrar_produtos.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cadastrar_produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar_produtos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cadastrar_produtos.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cadastrar_produtos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cadastrar_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cadastrar_produtos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cadastrar_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_produtos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastrar_produtos.Location = new System.Drawing.Point(3, 16);
            this.btn_cadastrar_produtos.Name = "btn_cadastrar_produtos";
            this.btn_cadastrar_produtos.Size = new System.Drawing.Size(266, 87);
            this.btn_cadastrar_produtos.TabIndex = 23;
            this.btn_cadastrar_produtos.Text = "Cadastro";
            this.btn_cadastrar_produtos.UseVisualStyleBackColor = false;
            this.btn_cadastrar_produtos.Click += new System.EventHandler(this.btn_cadastrar_produtos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.btn_pagar);
            this.groupBox4.Controls.Add(this.btn_vender);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(11, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 370);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vendas/Clientes";
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_pagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pagar.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_pagar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pagar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_pagar.Location = new System.Drawing.Point(3, 103);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(266, 87);
            this.btn_pagar.TabIndex = 28;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_vender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vender.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_vender.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vender.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vender.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_vender.Location = new System.Drawing.Point(3, 16);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(266, 87);
            this.btn_vender.TabIndex = 27;
            this.btn_vender.Text = "+ Vendas";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 54);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosTSMI,
            this.relatoriosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(18, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(207, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosTSMI
            // 
            this.produtosTSMI.BackColor = System.Drawing.Color.Gainsboro;
            this.produtosTSMI.Name = "produtosTSMI";
            this.produtosTSMI.Size = new System.Drawing.Size(67, 20);
            this.produtosTSMI.Text = "Produtos";
            this.produtosTSMI.Click += new System.EventHandler(this.produtosTSMI_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentacaoTSMI,
            this.comprasToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // movimentacaoTSMI
            // 
            this.movimentacaoTSMI.Name = "movimentacaoTSMI";
            this.movimentacaoTSMI.Size = new System.Drawing.Size(154, 22);
            this.movimentacaoTSMI.Text = "Movimentação";
            this.movimentacaoTSMI.Click += new System.EventHandler(this.movimentacaoTSMI_Click);
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
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(851, 461);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosTSMI;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentacaoTSMI;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_cadastrar_produtos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_estoque;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_pagar;
    }
}