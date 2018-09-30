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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet = new Ruler.rulerDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id_produto = new System.Windows.Forms.TextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.ckb_deletar = new System.Windows.Forms.CheckBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_id_estoque = new System.Windows.Forms.Label();
            this.txt_id_estoque = new System.Windows.Forms.TextBox();
            this.nud_quantidade = new System.Windows.Forms.NumericUpDown();
            this.cbb_produto = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbl_EstoqueTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_EstoqueTableAdapter();
            this.tbl_ProdutoTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter();
            this.btn_estoque_id = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idestoqueDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.idprodutoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEstoqueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 193);
            this.dataGridView1.TabIndex = 60;
            // 
            // idestoqueDataGridViewTextBoxColumn
            // 
            this.idestoqueDataGridViewTextBoxColumn.DataPropertyName = "id_estoque";
            this.idestoqueDataGridViewTextBoxColumn.HeaderText = "Id do Estoque";
            this.idestoqueDataGridViewTextBoxColumn.Name = "idestoqueDataGridViewTextBoxColumn";
            this.idestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idestoqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id do Produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprodutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeprodutoDataGridViewTextBoxColumn
            // 
            this.quantidadeprodutoDataGridViewTextBoxColumn.DataPropertyName = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.HeaderText = "Quantidade do Produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.Name = "quantidadeprodutoDataGridViewTextBoxColumn";
            this.quantidadeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeprodutoDataGridViewTextBoxColumn.Width = 150;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox4.Location = new System.Drawing.Point(56, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(654, 215);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produtos Cadastrados no Estoque";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatAppearance.BorderSize = 4;
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_cadastrar.Location = new System.Drawing.Point(296, 103);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(76, 34);
            this.btn_cadastrar.TabIndex = 90;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click_1);
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(36, 86);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_quantidade.TabIndex = 87;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(158, 80);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(73, 13);
            this.lbl_id.TabIndex = 83;
            this.lbl_id.Text = "ID do Produto";
            // 
            // txt_id_produto
            // 
            this.txt_id_produto.Enabled = false;
            this.txt_id_produto.Location = new System.Drawing.Point(161, 100);
            this.txt_id_produto.Name = "txt_id_produto";
            this.txt_id_produto.Size = new System.Drawing.Size(78, 20);
            this.txt_id_produto.TabIndex = 82;
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.Location = new System.Drawing.Point(158, 28);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_produto.TabIndex = 81;
            this.lbl_produto.Text = "Produto";
            // 
            // ckb_deletar
            // 
            this.ckb_deletar.AutoSize = true;
            this.ckb_deletar.Enabled = false;
            this.ckb_deletar.Location = new System.Drawing.Point(16, 113);
            this.ckb_deletar.Name = "ckb_deletar";
            this.ckb_deletar.Size = new System.Drawing.Size(141, 17);
            this.ckb_deletar.TabIndex = 95;
            this.ckb_deletar.Text = "Desejo Apagar Produtos";
            this.ckb_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.Enabled = false;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_deletar.FlatAppearance.BorderSize = 4;
            this.btn_deletar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_deletar.Location = new System.Drawing.Point(173, 103);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(97, 34);
            this.btn_deletar.TabIndex = 94;
            this.btn_deletar.Text = "Deletar Produto";
            this.btn_deletar.UseVisualStyleBackColor = true;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Enabled = false;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_atualizar.FlatAppearance.BorderSize = 4;
            this.btn_atualizar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_atualizar.Location = new System.Drawing.Point(173, 59);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(97, 34);
            this.btn_atualizar.TabIndex = 93;
            this.btn_atualizar.Text = "Atualizar Produto";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pesquisa.FlatAppearance.BorderSize = 4;
            this.btn_pesquisa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_pesquisa.Location = new System.Drawing.Point(173, 19);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(97, 34);
            this.btn_pesquisa.TabIndex = 92;
            this.btn_pesquisa.Text = "Exibir Produtos";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(716, 19);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(54, 30);
            this.btn_voltar.TabIndex = 91;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(56, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(654, 10);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_estoque_id);
            this.groupBox3.Controls.Add(this.ckb_deletar);
            this.groupBox3.Controls.Add(this.btn_deletar);
            this.groupBox3.Controls.Add(this.btn_atualizar);
            this.groupBox3.Controls.Add(this.btn_pesquisa);
            this.groupBox3.Location = new System.Drawing.Point(434, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 143);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outras Opções";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lbl_id_estoque);
            this.groupBox2.Controls.Add(this.txt_id_estoque);
            this.groupBox2.Controls.Add(this.nud_quantidade);
            this.groupBox2.Controls.Add(this.cbb_produto);
            this.groupBox2.Controls.Add(this.btn_cadastrar);
            this.groupBox2.Controls.Add(this.lbl_quantidade);
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.txt_id_produto);
            this.groupBox2.Controls.Add(this.lbl_produto);
            this.groupBox2.Location = new System.Drawing.Point(56, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 143);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro de Produtos no Estoque";
            // 
            // lbl_id_estoque
            // 
            this.lbl_id_estoque.AutoSize = true;
            this.lbl_id_estoque.Location = new System.Drawing.Point(34, 30);
            this.lbl_id_estoque.Name = "lbl_id_estoque";
            this.lbl_id_estoque.Size = new System.Drawing.Size(75, 13);
            this.lbl_id_estoque.TabIndex = 94;
            this.lbl_id_estoque.Text = "ID do Estoque";
            // 
            // txt_id_estoque
            // 
            this.txt_id_estoque.Location = new System.Drawing.Point(37, 50);
            this.txt_id_estoque.Name = "txt_id_estoque";
            this.txt_id_estoque.Size = new System.Drawing.Size(78, 20);
            this.txt_id_estoque.TabIndex = 93;
            // 
            // nud_quantidade
            // 
            this.nud_quantidade.Location = new System.Drawing.Point(37, 103);
            this.nud_quantidade.Name = "nud_quantidade";
            this.nud_quantidade.Size = new System.Drawing.Size(78, 20);
            this.nud_quantidade.TabIndex = 92;
            // 
            // cbb_produto
            // 
            this.cbb_produto.DataSource = this.tblProdutoBindingSource1;
            this.cbb_produto.DisplayMember = "nome";
            this.cbb_produto.FormattingEnabled = true;
            this.cbb_produto.Location = new System.Drawing.Point(161, 45);
            this.cbb_produto.Name = "cbb_produto";
            this.cbb_produto.Size = new System.Drawing.Size(188, 21);
            this.cbb_produto.TabIndex = 91;
            this.cbb_produto.SelectedIndexChanged += new System.EventHandler(this.cbb_produto_SelectedIndexChanged);
            // 
            // tblProdutoBindingSource1
            // 
            this.tblProdutoBindingSource1.DataMember = "Tbl_Produto";
            this.tblProdutoBindingSource1.DataSource = this.rulerDataSet;
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "Tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.rulerDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // tbl_EstoqueTableAdapter
            // 
            this.tbl_EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_estoque_id
            // 
            this.btn_estoque_id.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_estoque_id.FlatAppearance.BorderSize = 4;
            this.btn_estoque_id.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_estoque_id.Location = new System.Drawing.Point(6, 19);
            this.btn_estoque_id.Name = "btn_estoque_id";
            this.btn_estoque_id.Size = new System.Drawing.Size(106, 34);
            this.btn_estoque_id.TabIndex = 96;
            this.btn_estoque_id.Text = "Pesquisar Produto";
            this.btn_estoque_id.UseVisualStyleBackColor = true;
            this.btn_estoque_id.Click += new System.EventHandler(this.btn_estoque_id_Click);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEstoque";
            this.Text = "Menu Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id_produto;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.CheckBox ckb_deletar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_quantidade;
        private System.Windows.Forms.ComboBox cbb_produto;
        private rulerDataSet rulerDataSet;
        private System.Windows.Forms.BindingSource tblEstoqueBindingSource;
        private rulerDataSetTableAdapters.Tbl_EstoqueTableAdapter tbl_EstoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private System.Windows.Forms.Label lbl_id_estoque;
        private System.Windows.Forms.TextBox txt_id_estoque;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource1;
        private System.Windows.Forms.Button btn_estoque_id;
    }
}