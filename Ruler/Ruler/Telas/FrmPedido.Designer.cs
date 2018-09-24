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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_valor_u = new System.Windows.Forms.TextBox();
            this.txt_id_produto = new System.Windows.Forms.TextBox();
            this.txt_id_pedido = new System.Windows.Forms.TextBox();
            this.lbl_u = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.txt_quant_estoque = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data_entrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.data_pedido = new System.Windows.Forms.DateTimePicker();
            this.ckb_deletar = new System.Windows.Forms.CheckBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.cbb_cliente = new System.Windows.Forms.ComboBox();
            this.tblClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet1 = new Ruler.rulerDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_produtos = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet = new Ruler.rulerDataSet();
            this.tbl_PedidoTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_PedidoTableAdapter();
            this.tbl_ProdutoTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter();
            this.tbl_ClienteTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_ClienteTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btn_voltar);
            this.groupBox1.Controls.Add(this.txt_valor_u);
            this.groupBox1.Controls.Add(this.txt_id_produto);
            this.groupBox1.Controls.Add(this.txt_id_pedido);
            this.groupBox1.Controls.Add(this.lbl_u);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(715, 19);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(54, 30);
            this.btn_voltar.TabIndex = 100;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_valor_u
            // 
            this.txt_valor_u.Enabled = false;
            this.txt_valor_u.Location = new System.Drawing.Point(716, 205);
            this.txt_valor_u.Name = "txt_valor_u";
            this.txt_valor_u.Size = new System.Drawing.Size(40, 20);
            this.txt_valor_u.TabIndex = 99;
            this.txt_valor_u.Visible = false;
            // 
            // txt_id_produto
            // 
            this.txt_id_produto.Enabled = false;
            this.txt_id_produto.Location = new System.Drawing.Point(715, 136);
            this.txt_id_produto.Name = "txt_id_produto";
            this.txt_id_produto.Size = new System.Drawing.Size(40, 20);
            this.txt_id_produto.TabIndex = 98;
            this.txt_id_produto.Visible = false;
            // 
            // txt_id_pedido
            // 
            this.txt_id_pedido.Enabled = false;
            this.txt_id_pedido.Location = new System.Drawing.Point(716, 92);
            this.txt_id_pedido.Name = "txt_id_pedido";
            this.txt_id_pedido.Size = new System.Drawing.Size(40, 20);
            this.txt_id_pedido.TabIndex = 97;
            this.txt_id_pedido.Visible = false;
            // 
            // lbl_u
            // 
            this.lbl_u.AutoSize = true;
            this.lbl_u.Location = new System.Drawing.Point(713, 189);
            this.lbl_u.Name = "lbl_u";
            this.lbl_u.Size = new System.Drawing.Size(42, 13);
            this.lbl_u.TabIndex = 94;
            this.lbl_u.Text = "valor(u)";
            this.lbl_u.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "ID produto";
            this.label5.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(713, 76);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(53, 13);
            this.lbl_id.TabIndex = 91;
            this.lbl_id.Text = "ID pedido";
            this.lbl_id.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(56, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(654, 10);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lbl_estoque);
            this.groupBox2.Controls.Add(this.txt_quant_estoque);
            this.groupBox2.Controls.Add(this.txt_quantidade);
            this.groupBox2.Controls.Add(this.lbl_valor);
            this.groupBox2.Controls.Add(this.txt_valor);
            this.groupBox2.Controls.Add(this.btn_cadastrar);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.cbb_cliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbb_produtos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_produto);
            this.groupBox2.Location = new System.Drawing.Point(56, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 146);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro de Pedidos";
            // 
            // lbl_estoque
            // 
            this.lbl_estoque.AutoSize = true;
            this.lbl_estoque.Location = new System.Drawing.Point(293, 24);
            this.lbl_estoque.Name = "lbl_estoque";
            this.lbl_estoque.Size = new System.Drawing.Size(46, 13);
            this.lbl_estoque.TabIndex = 102;
            this.lbl_estoque.Text = "Estoque";
            // 
            // txt_quant_estoque
            // 
            this.txt_quant_estoque.Enabled = false;
            this.txt_quant_estoque.Location = new System.Drawing.Point(296, 40);
            this.txt_quant_estoque.Name = "txt_quant_estoque";
            this.txt_quant_estoque.Size = new System.Drawing.Size(76, 20);
            this.txt_quant_estoque.TabIndex = 101;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(207, 40);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(71, 20);
            this.txt_quantidade.TabIndex = 100;
            this.txt_quantidade.Text = "1";
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(204, 86);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(55, 13);
            this.lbl_valor.TabIndex = 95;
            this.lbl_valor.Text = "Preço(R$)";
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(207, 103);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(71, 20);
            this.txt_valor.TabIndex = 94;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatAppearance.BorderSize = 4;
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_cadastrar.Location = new System.Drawing.Point(296, 106);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(76, 34);
            this.btn_cadastrar.TabIndex = 91;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.data_entrega);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.data_pedido);
            this.groupBox6.Controls.Add(this.ckb_deletar);
            this.groupBox6.Controls.Add(this.btn_deletar);
            this.groupBox6.Controls.Add(this.btn_atualizar);
            this.groupBox6.Controls.Add(this.btn_pesquisa);
            this.groupBox6.Location = new System.Drawing.Point(378, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 146);
            this.groupBox6.TabIndex = 90;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Outras Opções";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Data da Entrega";
            // 
            // data_entrega
            // 
            this.data_entrega.Enabled = false;
            this.data_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_entrega.Location = new System.Drawing.Point(16, 86);
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.Size = new System.Drawing.Size(97, 20);
            this.data_entrega.TabIndex = 98;
            this.data_entrega.Value = new System.DateTime(2018, 9, 18, 1, 8, 38, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Data do Pedido";
            // 
            // data_pedido
            // 
            this.data_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_pedido.Location = new System.Drawing.Point(16, 35);
            this.data_pedido.Name = "data_pedido";
            this.data_pedido.Size = new System.Drawing.Size(97, 20);
            this.data_pedido.TabIndex = 96;
            this.data_pedido.Value = new System.DateTime(2018, 9, 23, 20, 5, 40, 0);
            // 
            // ckb_deletar
            // 
            this.ckb_deletar.AutoSize = true;
            this.ckb_deletar.Enabled = false;
            this.ckb_deletar.Location = new System.Drawing.Point(16, 113);
            this.ckb_deletar.Name = "ckb_deletar";
            this.ckb_deletar.Size = new System.Drawing.Size(136, 17);
            this.ckb_deletar.TabIndex = 95;
            this.ckb_deletar.Text = "Desejo Apagar Clientes";
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
            this.btn_deletar.Text = "Deletar Pedido";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
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
            this.btn_atualizar.Text = "Atualizar Pedido";
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
            this.btn_pesquisa.Text = "Exibir Pedidos";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // cbb_cliente
            // 
            this.cbb_cliente.DataSource = this.tblClienteBindingSource;
            this.cbb_cliente.DisplayMember = "nome";
            this.cbb_cliente.FormattingEnabled = true;
            this.cbb_cliente.Location = new System.Drawing.Point(9, 102);
            this.cbb_cliente.Name = "cbb_cliente";
            this.cbb_cliente.Size = new System.Drawing.Size(173, 21);
            this.cbb_cliente.TabIndex = 88;
            // 
            // tblClienteBindingSource
            // 
            this.tblClienteBindingSource.DataMember = "Tbl_Cliente";
            this.tblClienteBindingSource.DataSource = this.rulerDataSet1;
            // 
            // rulerDataSet1
            // 
            this.rulerDataSet1.DataSetName = "rulerDataSet";
            this.rulerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Cliente";
            // 
            // cbb_produtos
            // 
            this.cbb_produtos.DataSource = this.tblProdutoBindingSource;
            this.cbb_produtos.DisplayMember = "nome";
            this.cbb_produtos.FormattingEnabled = true;
            this.cbb_produtos.Location = new System.Drawing.Point(9, 39);
            this.cbb_produtos.Name = "cbb_produtos";
            this.cbb_produtos.Size = new System.Drawing.Size(173, 21);
            this.cbb_produtos.TabIndex = 86;
            this.cbb_produtos.SelectedIndexChanged += new System.EventHandler(this.cbb_produtos_SelectedIndexChanged);
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "Tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.rulerDataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Quantidade";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(6, 23);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_produto.TabIndex = 81;
            this.lbl_produto.Text = "Produto";
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
            this.groupBox4.Text = "Pedidos Cadastrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpedidoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPedidoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(642, 193);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            this.idpedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeprodutoDataGridViewTextBoxColumn
            // 
            this.quantidadeprodutoDataGridViewTextBoxColumn.DataPropertyName = "quantidade_produto";
            this.quantidadeprodutoDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeprodutoDataGridViewTextBoxColumn.Name = "quantidadeprodutoDataGridViewTextBoxColumn";
            this.quantidadeprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPedidoBindingSource
            // 
            this.tblPedidoBindingSource.DataMember = "Tbl_Pedido";
            this.tblPedidoBindingSource.DataSource = this.rulerDataSet;
            // 
            // rulerDataSet
            // 
            this.rulerDataSet.DataSetName = "rulerDataSet";
            this.rulerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PedidoTableAdapter
            // 
            this.tbl_PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ClienteTableAdapter
            // 
            this.tbl_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPedido";
            this.Text = "Menu Pedidos";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_produtos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_entrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_pedido;
        private System.Windows.Forms.CheckBox ckb_deletar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rulerDataSet rulerDataSet;
        private System.Windows.Forms.BindingSource tblPedidoBindingSource;
        private rulerDataSetTableAdapters.Tbl_PedidoTableAdapter tbl_PedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private rulerDataSet rulerDataSet1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private rulerDataSetTableAdapters.Tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tblClienteBindingSource;
        private rulerDataSetTableAdapters.Tbl_ClienteTableAdapter tbl_ClienteTableAdapter;
        private System.Windows.Forms.TextBox txt_valor_u;
        private System.Windows.Forms.TextBox txt_id_produto;
        private System.Windows.Forms.TextBox txt_id_pedido;
        private System.Windows.Forms.Label lbl_u;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.TextBox txt_quant_estoque;
    }
}