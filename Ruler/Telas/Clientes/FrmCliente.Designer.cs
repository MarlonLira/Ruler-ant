namespace Ruler.Telas
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet = new Ruler.rulerDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbl_ClienteTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_ClienteTableAdapter();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.txt_debito);
            this.panel3.Controls.Add(this.txt_telefone);
            this.panel3.Controls.Add(this.txt_nome);
            this.panel3.Location = new System.Drawing.Point(-2, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 56);
            this.panel3.TabIndex = 18;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(13, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(76, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_debito
            // 
            this.txt_debito.Location = new System.Drawing.Point(494, 33);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(103, 20);
            this.txt_debito.TabIndex = 2;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(385, 33);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(103, 20);
            this.txt_telefone.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(95, 33);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(284, 20);
            this.txt_nome.TabIndex = 0;
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.debitoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblClienteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "Id Cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 130;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // debitoDataGridViewTextBoxColumn
            // 
            this.debitoDataGridViewTextBoxColumn.DataPropertyName = "debito";
            this.debitoDataGridViewTextBoxColumn.HeaderText = "Debito";
            this.debitoDataGridViewTextBoxColumn.Name = "debitoDataGridViewTextBoxColumn";
            this.debitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "Tbl_Cliente";
            this.tblClienteBindingSource.DataSource = this.rulerDataSet;
            // 
            // rulerDataSet
            // 
            this.rulerDataSet.DataSetName = "rulerDataSet";
            this.rulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // panel4
            // 
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
            // tbl_ClienteTableAdapter
            // 
            this.tbl_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.TextBox txt_debito;
        public System.Windows.Forms.TextBox txt_telefone;
        public System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_apagar;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private rulerDataSet rulerDataSet;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private rulerDataSetTableAdapters.Tbl_ClienteTableAdapter tbl_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitoDataGridViewTextBoxColumn;
    }
}