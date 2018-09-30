namespace Ruler.Telas
{
    partial class FrmRelatorio
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmovimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipomovimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMovimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet = new Ruler.rulerDataSet();
            this.tbl_MovimentoTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_MovimentoTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_voltar = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_salvar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(-2, 395);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 57);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(-2, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 56);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.Location = new System.Drawing.Point(714, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(603, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(494, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(385, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(13, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 285);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmovimentoDataGridViewTextBoxColumn,
            this.tipomovimentoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeclienteDataGridViewTextBoxColumn,
            this.idprodutoDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.parcelasDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.datavendaDataGridViewTextBoxColumn,
            this.dataentregaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMovimentoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // idmovimentoDataGridViewTextBoxColumn
            // 
            this.idmovimentoDataGridViewTextBoxColumn.DataPropertyName = "id_movimento";
            this.idmovimentoDataGridViewTextBoxColumn.HeaderText = "id_movimento";
            this.idmovimentoDataGridViewTextBoxColumn.Name = "idmovimentoDataGridViewTextBoxColumn";
            this.idmovimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipomovimentoDataGridViewTextBoxColumn
            // 
            this.tipomovimentoDataGridViewTextBoxColumn.DataPropertyName = "tipo_movimento";
            this.tipomovimentoDataGridViewTextBoxColumn.HeaderText = "tipo_movimento";
            this.tipomovimentoDataGridViewTextBoxColumn.Name = "tipomovimentoDataGridViewTextBoxColumn";
            this.tipomovimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeclienteDataGridViewTextBoxColumn
            // 
            this.nomeclienteDataGridViewTextBoxColumn.DataPropertyName = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.HeaderText = "nome_cliente";
            this.nomeclienteDataGridViewTextBoxColumn.Name = "nomeclienteDataGridViewTextBoxColumn";
            this.nomeclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeprodutoDataGridViewTextBoxColumn
            // 
            this.quantidadeprodutoDataGridViewTextBoxColumn.DataPropertyName = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.HeaderText = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.Name = "quantidadeprodutoDataGridViewTextBoxColumn";
            this.quantidadeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parcelasDataGridViewTextBoxColumn
            // 
            this.parcelasDataGridViewTextBoxColumn.DataPropertyName = "parcelas";
            this.parcelasDataGridViewTextBoxColumn.HeaderText = "parcelas";
            this.parcelasDataGridViewTextBoxColumn.Name = "parcelasDataGridViewTextBoxColumn";
            this.parcelasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datavendaDataGridViewTextBoxColumn
            // 
            this.datavendaDataGridViewTextBoxColumn.DataPropertyName = "data_venda";
            this.datavendaDataGridViewTextBoxColumn.HeaderText = "data_venda";
            this.datavendaDataGridViewTextBoxColumn.Name = "datavendaDataGridViewTextBoxColumn";
            this.datavendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentregaDataGridViewTextBoxColumn
            // 
            this.dataentregaDataGridViewTextBoxColumn.DataPropertyName = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.HeaderText = "data_entrega";
            this.dataentregaDataGridViewTextBoxColumn.Name = "dataentregaDataGridViewTextBoxColumn";
            this.dataentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblMovimentoBindingSource
            // 
            this.tblMovimentoBindingSource.DataMember = "Tbl_Movimento";
            this.tblMovimentoBindingSource.DataSource = this.rulerDataSet;
            // 
            // rulerDataSet
            // 
            this.rulerDataSet.DataSetName = "rulerDataSet";
            this.rulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MovimentoTableAdapter
            // 
            this.tbl_MovimentoTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(92, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 35);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(190, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 35);
            this.panel6.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(417, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Controls.Add(this.lbl_voltar);
            this.panel7.Location = new System.Drawing.Point(97, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(89, 37);
            this.panel7.TabIndex = 10;
            // 
            // lbl_voltar
            // 
            this.lbl_voltar.AutoSize = true;
            this.lbl_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_voltar.Location = new System.Drawing.Point(26, 12);
            this.lbl_voltar.Name = "lbl_voltar";
            this.lbl_voltar.Size = new System.Drawing.Size(34, 13);
            this.lbl_voltar.TabIndex = 8;
            this.lbl_voltar.Text = "Voltar";
            this.lbl_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_voltar.Click += new System.EventHandler(this.lbl_voltar_Click);
            // 
            // panel8
            // 
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Controls.Add(this.lbl_salvar);
            this.panel8.Location = new System.Drawing.Point(4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(85, 37);
            this.panel8.TabIndex = 11;
            // 
            // lbl_salvar
            // 
            this.lbl_salvar.AutoSize = true;
            this.lbl_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_salvar.Location = new System.Drawing.Point(26, 12);
            this.lbl_salvar.Name = "lbl_salvar";
            this.lbl_salvar.Size = new System.Drawing.Size(37, 13);
            this.lbl_salvar.TabIndex = 3;
            this.lbl_salvar.Text = "Salvar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 5;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmRelatorio";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMovimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rulerDataSet rulerDataSet;
        private System.Windows.Forms.BindingSource tblMovimentoBindingSource;
        private rulerDataSetTableAdapters.Tbl_MovimentoTableAdapter tbl_MovimentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmovimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipomovimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label lbl_voltar;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label lbl_salvar;
        public System.Windows.Forms.Panel panel2;
    }
}