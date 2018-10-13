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
            this.components = new System.ComponentModel.Container();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_EstoqueTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_EstoqueTableAdapter();
            this.tblEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet = new Ruler.rulerDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_produto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_estoque = new System.Windows.Forms.TextBox();
            this.txt_id_produto = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProdutoTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id Produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 300;
            // 
            // idestoqueDataGridViewTextBoxColumn
            // 
            this.idestoqueDataGridViewTextBoxColumn.DataPropertyName = "id_estoque";
            this.idestoqueDataGridViewTextBoxColumn.HeaderText = "Id Estoque";
            this.idestoqueDataGridViewTextBoxColumn.Name = "idestoqueDataGridViewTextBoxColumn";
            this.idestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idestoqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbl_EstoqueTableAdapter
            // 
            this.tbl_EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tblEstoqueBindingSource
            // 
            this.tblEstoqueBindingSource.DataMember = "Tbl_Estoque";
            this.tblEstoqueBindingSource.DataSource = this.rulerDataSet;
            // 
            // rulerDataSet
            // 
            this.rulerDataSet.DataSetName = "rulerDataSet";
            this.rulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbb_produto);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_quantidade);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_id_estoque);
            this.panel3.Controls.Add(this.txt_id_produto);
            this.panel3.Location = new System.Drawing.Point(-2, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 56);
            this.panel3.TabIndex = 18;
            // 
            // cbb_produto
            // 
            this.cbb_produto.DataSource = this.tblProdutoBindingSource;
            this.cbb_produto.DisplayMember = "nome";
            this.cbb_produto.FormattingEnabled = true;
            this.cbb_produto.Location = new System.Drawing.Point(95, 32);
            this.cbb_produto.Name = "cbb_produto";
            this.cbb_produto.Size = new System.Drawing.Size(188, 21);
            this.cbb_produto.TabIndex = 92;
            this.cbb_produto.SelectedIndexChanged += new System.EventHandler(this.cbb_produto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(398, 32);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(103, 20);
            this.txt_quantidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // txt_id_estoque
            // 
            this.txt_id_estoque.Location = new System.Drawing.Point(13, 33);
            this.txt_id_estoque.Name = "txt_id_estoque";
            this.txt_id_estoque.Size = new System.Drawing.Size(76, 20);
            this.txt_id_estoque.TabIndex = 3;
            // 
            // txt_id_produto
            // 
            this.txt_id_produto.Location = new System.Drawing.Point(289, 32);
            this.txt_id_produto.Name = "txt_id_produto";
            this.txt_id_produto.Size = new System.Drawing.Size(103, 20);
            this.txt_id_produto.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(188, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 35);
            this.panel7.TabIndex = 19;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Location = new System.Drawing.Point(99, 8);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(85, 35);
            this.btn_atualizar.TabIndex = 17;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Location = new System.Drawing.Point(7, 9);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(85, 35);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_apagar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Location = new System.Drawing.Point(193, 9);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(85, 35);
            this.btn_apagar.TabIndex = 15;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 285);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idestoqueDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn,
            this.idprodutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEstoqueBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // quantidadeprodutoDataGridViewTextBoxColumn
            // 
            this.quantidadeprodutoDataGridViewTextBoxColumn.DataPropertyName = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeprodutoDataGridViewTextBoxColumn.Name = "quantidadeprodutoDataGridViewTextBoxColumn";
            this.quantidadeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeprodutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.btn_limpar);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btn_atualizar);
            this.panel4.Controls.Add(this.btn_pesquisar);
            this.panel4.Controls.Add(this.btn_apagar);
            this.panel4.Location = new System.Drawing.Point(-2, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 57);
            this.panel4.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(95, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 35);
            this.panel6.TabIndex = 18;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Location = new System.Drawing.Point(5, 5);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(85, 35);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Salvar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_voltar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Location = new System.Drawing.Point(97, 5);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(85, 35);
            this.btn_voltar.TabIndex = 12;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(93, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 35);
            this.panel5.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cadastrar);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 17;
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "Tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.rulerDataSet;
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Location = new System.Drawing.Point(282, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 35);
            this.panel8.TabIndex = 21;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Location = new System.Drawing.Point(287, 9);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(85, 35);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEstoque";
            this.Text = "Menu Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestoqueDataGridViewTextBoxColumn;
        private rulerDataSetTableAdapters.Tbl_EstoqueTableAdapter tbl_EstoqueTableAdapter;
        private System.Windows.Forms.BindingSource tblEstoqueBindingSource;
        private rulerDataSet rulerDataSet;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_produto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_id_estoque;
        public System.Windows.Forms.TextBox txt_id_produto;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_limpar;
    }
}