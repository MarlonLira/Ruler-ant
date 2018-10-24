namespace Ruler.Telas
{
    partial class FrmPedido
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
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.cbb_juros = new System.Windows.Forms.ComboBox();
            this.tblCartaoDividirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet1 = new Ruler.rulerDataSet();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_dividir = new System.Windows.Forms.ComboBox();
            this.cbb_venda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_entrega = new System.Windows.Forms.DateTimePicker();
            this.txt_valor_u = new System.Windows.Forms.TextBox();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_pedido = new System.Windows.Forms.DateTimePicker();
            this.txt_quant_estoque = new System.Windows.Forms.TextBox();
            this.lbl_u = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_id_produto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_pedido = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_cliente = new System.Windows.Forms.ComboBox();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_produtos = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_pagou = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbl_PedidoTableAdapter1 = new Ruler.rulerDataSetTableAdapters.Tbl_PedidoTableAdapter();
            this.tbl_ProdutoTableAdapter1 = new Ruler.rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter();
            this.tbl_ClienteTableAdapter1 = new Ruler.rulerDataSetTableAdapters.Tbl_ClienteTableAdapter();
            this.tbl_Cartao_DividirTableAdapter1 = new Ruler.rulerDataSetTableAdapters.Tbl_Cartao_DividirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblCartaoDividirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPedidoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Location = new System.Drawing.Point(579, 24);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(40, 20);
            this.txt_id_cliente.TabIndex = 105;
            this.txt_id_cliente.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 104;
            this.label6.Text = "ID Cliente";
            this.label6.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label9.Location = new System.Drawing.Point(631, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "Juros";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lbl_valor.Location = new System.Drawing.Point(715, 14);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(53, 13);
            this.lbl_valor.TabIndex = 114;
            this.lbl_valor.Text = "Preço(R$)";
            // 
            // cbb_juros
            // 
            this.cbb_juros.DataSource = this.tblCartaoDividirBindingSource;
            this.cbb_juros.DisplayMember = "juros";
            this.cbb_juros.Enabled = false;
            this.cbb_juros.FormattingEnabled = true;
            this.cbb_juros.Location = new System.Drawing.Point(634, 30);
            this.cbb_juros.Name = "cbb_juros";
            this.cbb_juros.Size = new System.Drawing.Size(67, 21);
            this.cbb_juros.TabIndex = 115;
            // 
            // tblCartaoDividirBindingSource
            // 
            this.tblCartaoDividirBindingSource.DataMember = "Tbl_Cartao_Dividir";
            this.tblCartaoDividirBindingSource.DataSource = this.rulerDataSet1;
            // 
            // rulerDataSet1
            // 
            this.rulerDataSet1.DataSetName = "rulerDataSet";
            this.rulerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(718, 31);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(71, 20);
            this.txt_valor.TabIndex = 113;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label8.Location = new System.Drawing.Point(567, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Dividir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label7.Location = new System.Drawing.Point(397, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Tipo de Venda";
            // 
            // cbb_dividir
            // 
            this.cbb_dividir.DataSource = this.tblCartaoDividirBindingSource;
            this.cbb_dividir.DisplayMember = "id_cartao_dividir";
            this.cbb_dividir.Enabled = false;
            this.cbb_dividir.FormattingEnabled = true;
            this.cbb_dividir.Location = new System.Drawing.Point(570, 30);
            this.cbb_dividir.Name = "cbb_dividir";
            this.cbb_dividir.Size = new System.Drawing.Size(67, 21);
            this.cbb_dividir.TabIndex = 113;
            this.cbb_dividir.SelectedIndexChanged += new System.EventHandler(this.cbb_dividir_SelectedIndexChanged);
            // 
            // cbb_venda
            // 
            this.cbb_venda.FormattingEnabled = true;
            this.cbb_venda.Items.AddRange(new object[] {
            "Dinheiro",
            "Conta",
            "Cartão"});
            this.cbb_venda.Location = new System.Drawing.Point(400, 31);
            this.cbb_venda.Name = "cbb_venda";
            this.cbb_venda.Size = new System.Drawing.Size(97, 21);
            this.cbb_venda.TabIndex = 105;
            this.cbb_venda.SelectedIndexChanged += new System.EventHandler(this.cbb_venda_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label3.Location = new System.Drawing.Point(687, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Data da Entrega";
            // 
            // data_entrega
            // 
            this.data_entrega.Enabled = false;
            this.data_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_entrega.Location = new System.Drawing.Point(690, 18);
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.Size = new System.Drawing.Size(97, 20);
            this.data_entrega.TabIndex = 105;
            this.data_entrega.Value = new System.DateTime(2018, 9, 18, 1, 8, 38, 0);
            // 
            // txt_valor_u
            // 
            this.txt_valor_u.Enabled = false;
            this.txt_valor_u.Location = new System.Drawing.Point(634, 23);
            this.txt_valor_u.Name = "txt_valor_u";
            this.txt_valor_u.Size = new System.Drawing.Size(40, 20);
            this.txt_valor_u.TabIndex = 103;
            this.txt_valor_u.Visible = false;
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lbl_estoque.Location = new System.Drawing.Point(496, 5);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(46, 13);
            this.lbl_estoque.TabIndex = 104;
            this.lbl_estoque.Text = "Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(584, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Data do Pedido";
            // 
            // data_pedido
            // 
            this.data_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_pedido.Location = new System.Drawing.Point(587, 18);
            this.data_pedido.Name = "data_pedido";
            this.data_pedido.Size = new System.Drawing.Size(97, 20);
            this.data_pedido.TabIndex = 98;
            this.data_pedido.Value = new System.DateTime(2018, 9, 23, 20, 5, 40, 0);
            // 
            // txt_quant_estoque
            // 
            this.txt_quant_estoque.Enabled = false;
            this.txt_quant_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txt_quant_estoque.Location = new System.Drawing.Point(499, 21);
            this.txt_quant_estoque.Name = "txt_quant_estoque";
            this.txt_quant_estoque.Size = new System.Drawing.Size(50, 18);
            this.txt_quant_estoque.TabIndex = 103;
            // 
            // lbl_u
            // 
            this.lbl_u.AutoSize = true;
            this.lbl_u.Location = new System.Drawing.Point(631, 7);
            this.lbl_u.Name = "lbl_u";
            this.lbl_u.Size = new System.Drawing.Size(42, 13);
            this.lbl_u.TabIndex = 102;
            this.lbl_u.Text = "valor(u)";
            this.lbl_u.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.btn_limpar);
            this.panel4.Controls.Add(this.txt_id_cliente);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_valor_u);
            this.panel4.Controls.Add(this.lbl_u);
            this.panel4.Controls.Add(this.txt_id_produto);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_id_pedido);
            this.panel4.Controls.Add(this.lbl_id);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Location = new System.Drawing.Point(282, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 35);
            this.panel8.TabIndex = 107;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Location = new System.Drawing.Point(286, 8);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(85, 35);
            this.btn_limpar.TabIndex = 106;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_id_produto
            // 
            this.txt_id_produto.Enabled = false;
            this.txt_id_produto.Location = new System.Drawing.Point(689, 23);
            this.txt_id_produto.Name = "txt_id_produto";
            this.txt_id_produto.Size = new System.Drawing.Size(40, 20);
            this.txt_id_produto.TabIndex = 101;
            this.txt_id_produto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "ID produto";
            this.label5.Visible = false;
            // 
            // txt_id_pedido
            // 
            this.txt_id_pedido.Enabled = false;
            this.txt_id_pedido.Location = new System.Drawing.Point(749, 24);
            this.txt_id_pedido.Name = "txt_id_pedido";
            this.txt_id_pedido.Size = new System.Drawing.Size(40, 20);
            this.txt_id_pedido.TabIndex = 99;
            this.txt_id_pedido.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(746, 8);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(53, 13);
            this.lbl_id.TabIndex = 98;
            this.lbl_id.Text = "ID pedido";
            this.lbl_id.Visible = false;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbl_valor);
            this.panel3.Controls.Add(this.cbb_juros);
            this.panel3.Controls.Add(this.txt_valor);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbb_dividir);
            this.panel3.Controls.Add(this.cbb_venda);
            this.panel3.Controls.Add(this.cbb_cliente);
            this.panel3.Controls.Add(this.cbb_produtos);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_quantidade);
            this.panel3.Controls.Add(this.lbl_cliente);
            this.panel3.Controls.Add(this.lbl_produtos);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.txt_quantidade);
            this.panel3.Location = new System.Drawing.Point(-2, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 56);
            this.panel3.TabIndex = 18;
            // 
            // cbb_cliente
            // 
            this.cbb_cliente.DataSource = this.tblClienteBindingSource;
            this.cbb_cliente.DisplayMember = "nome";
            this.cbb_cliente.FormattingEnabled = true;
            this.cbb_cliente.Location = new System.Drawing.Point(234, 31);
            this.cbb_cliente.Name = "cbb_cliente";
            this.cbb_cliente.Size = new System.Drawing.Size(160, 21);
            this.cbb_cliente.TabIndex = 89;
            this.cbb_cliente.SelectedIndexChanged += new System.EventHandler(this.cbb_cliente_SelectedIndexChanged);
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "Tbl_Cliente";
            this.tblClienteBindingSource.DataSource = this.rulerDataSet1;
            // 
            // cbb_produtos
            // 
            this.cbb_produtos.DataSource = this.tblProdutoBindingSource;
            this.cbb_produtos.DisplayMember = "nome";
            this.cbb_produtos.Location = new System.Drawing.Point(68, 31);
            this.cbb_produtos.Name = "cbb_produtos";
            this.cbb_produtos.Size = new System.Drawing.Size(160, 21);
            this.cbb_produtos.TabIndex = 117;
            this.cbb_produtos.SelectedIndexChanged += new System.EventHandler(this.cbb_produtos_SelectedIndexChanged_1);
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "Tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.rulerDataSet1;
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
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(500, 15);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(36, 13);
            this.lbl_quantidade.TabIndex = 6;
            this.lbl_quantidade.Text = "Quant";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(231, 14);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_cliente.TabIndex = 5;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtos.Location = new System.Drawing.Point(65, 15);
            this.lbl_produtos.Name = "lbl_produtos";
            this.lbl_produtos.Size = new System.Drawing.Size(49, 13);
            this.lbl_produtos.TabIndex = 4;
            this.lbl_produtos.Text = "Produtos";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(13, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(49, 20);
            this.txt_id.TabIndex = 3;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(503, 31);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(50, 20);
            this.txt_quantidade.TabIndex = 2;
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.tblPedidoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "produto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantidade_produto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo_venda";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo Venda";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id Produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tblPedidoBindingSource
            // 
            this.tblPedidoBindingSource.DataMember = "Tbl_Pedido";
            this.tblPedidoBindingSource.DataSource = this.rulerDataSet1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbb_pagou);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.data_entrega);
            this.panel2.Controls.Add(this.lbl_estoque);
            this.panel2.Controls.Add(this.txt_quant_estoque);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.data_pedido);
            this.panel2.Controls.Add(this.btn_cadastrar);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label2.Location = new System.Drawing.Point(418, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 108;
            this.label2.Text = "Pago?";
            // 
            // cbb_pagou
            // 
            this.cbb_pagou.FormattingEnabled = true;
            this.cbb_pagou.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbb_pagou.Location = new System.Drawing.Point(421, 17);
            this.cbb_pagou.Name = "cbb_pagou";
            this.cbb_pagou.Size = new System.Drawing.Size(49, 21);
            this.cbb_pagou.TabIndex = 109;
            this.cbb_pagou.SelectedIndexChanged += new System.EventHandler(this.cbb_pagou_SelectedIndexChanged);
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
            // tbl_PedidoTableAdapter1
            // 
            this.tbl_PedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_ProdutoTableAdapter1
            // 
            this.tbl_ProdutoTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_ClienteTableAdapter1
            // 
            this.tbl_ClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_Cartao_DividirTableAdapter1
            // 
            this.tbl_Cartao_DividirTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPedido";
            this.Text = "Menu Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCartaoDividirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPedidoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.ComboBox cbb_juros;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_dividir;
        private System.Windows.Forms.ComboBox cbb_venda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_entrega;
        private System.Windows.Forms.TextBox txt_valor_u;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker data_pedido;
        private rulerDataSet rulerDataSet;
        private rulerDataSetTableAdapters.Tbl_PedidoTableAdapter tbl_PedidoTableAdapter;
        private System.Windows.Forms.TextBox txt_quant_estoque;
        private System.Windows.Forms.Label lbl_u;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_id_produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id_pedido;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_apagar;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_cliente;
        private System.Windows.Forms.ComboBox cbb_produtos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_produtos;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private rulerDataSetTableAdapters.Tbl_ClienteTableAdapter tbl_ClienteTableAdapter;
        private rulerDataSetTableAdapters.Tbl_Cartao_DividirTableAdapter tbl_Cartao_DividirTableAdapter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_pagou;
        private rulerDataSet rulerDataSet1;
        private System.Windows.Forms.BindingSource tblPedidoBindingSource;
        private rulerDataSetTableAdapters.Tbl_PedidoTableAdapter tbl_PedidoTableAdapter1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter1;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private rulerDataSetTableAdapters.Tbl_ClienteTableAdapter tbl_ClienteTableAdapter1;
        private System.Windows.Forms.BindingSource tblCartaoDividirBindingSource;
        private rulerDataSetTableAdapters.Tbl_Cartao_DividirTableAdapter tbl_Cartao_DividirTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}