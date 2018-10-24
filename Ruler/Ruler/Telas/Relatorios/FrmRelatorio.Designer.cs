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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valor_u = new System.Windows.Forms.TextBox();
            this.lbl_u = new System.Windows.Forms.Label();
            this.txt_id_produto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_pedido = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.lbl_produtos = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_debito = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.data_entrega = new System.Windows.Forms.DateTimePicker();
            this.lbl_estoque = new System.Windows.Forms.Label();
            this.txt_quant_estoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_pedido = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulerDataSet = new Ruler.rulerDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.cbb_juros = new System.Windows.Forms.ComboBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_dividir = new System.Windows.Forms.ComboBox();
            this.cbb_venda = new System.Windows.Forms.ComboBox();
            this.cbb_cliente = new System.Windows.Forms.ComboBox();
            this.cbb_produtos = new System.Windows.Forms.ComboBox();
            this.tbl_PedidoTableAdapter = new Ruler.rulerDataSetTableAdapters.Tbl_PedidoTableAdapter();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // panel4
            // 
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
            this.panel4.TabIndex = 15;
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
            // txt_valor_u
            // 
            this.txt_valor_u.Enabled = false;
            this.txt_valor_u.Location = new System.Drawing.Point(634, 23);
            this.txt_valor_u.Name = "txt_valor_u";
            this.txt_valor_u.Size = new System.Drawing.Size(40, 20);
            this.txt_valor_u.TabIndex = 103;
            this.txt_valor_u.Visible = false;
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
            // lbl_produtos
            // 
            this.lbl_produtos.AutoSize = true;
            this.lbl_produtos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtos.Location = new System.Drawing.Point(65, 16);
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
            // txt_debito
            // 
            this.txt_debito.Location = new System.Drawing.Point(503, 31);
            this.txt_debito.Name = "txt_debito";
            this.txt_debito.Size = new System.Drawing.Size(50, 20);
            this.txt_debito.TabIndex = 2;
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
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label3.Location = new System.Drawing.Point(657, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Data da Entrega";
            // 
            // data_entrega
            // 
            this.data_entrega.Enabled = false;
            this.data_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_entrega.Location = new System.Drawing.Point(660, 18);
            this.data_entrega.Name = "data_entrega";
            this.data_entrega.Size = new System.Drawing.Size(97, 20);
            this.data_entrega.TabIndex = 105;
            this.data_entrega.Value = new System.DateTime(2018, 9, 18, 1, 8, 38, 0);
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
            // txt_quant_estoque
            // 
            this.txt_quant_estoque.Enabled = false;
            this.txt_quant_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txt_quant_estoque.Location = new System.Drawing.Point(499, 21);
            this.txt_quant_estoque.Name = "txt_quant_estoque";
            this.txt_quant_estoque.Size = new System.Drawing.Size(50, 18);
            this.txt_quant_estoque.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(554, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Data do Pedido";
            // 
            // data_pedido
            // 
            this.data_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_pedido.Location = new System.Drawing.Point(557, 18);
            this.data_pedido.Name = "data_pedido";
            this.data_pedido.Size = new System.Drawing.Size(97, 20);
            this.data_pedido.TabIndex = 98;
            this.data_pedido.Value = new System.DateTime(2018, 9, 23, 20, 5, 40, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpedidoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeprodutoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.tipovendaDataGridViewTextBoxColumn,
            this.idprodutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPedidoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            this.idpedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipovendaDataGridViewTextBoxColumn
            // 
            this.tipovendaDataGridViewTextBoxColumn.DataPropertyName = "tipo_venda";
            this.tipovendaDataGridViewTextBoxColumn.HeaderText = "tipo_venda";
            this.tipovendaDataGridViewTextBoxColumn.Name = "tipovendaDataGridViewTextBoxColumn";
            this.tipovendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 285);
            this.panel1.TabIndex = 12;
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
            this.panel3.Controls.Add(this.txt_debito);
            this.panel3.Location = new System.Drawing.Point(-2, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 56);
            this.panel3.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label9.Location = new System.Drawing.Point(620, 14);
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
            this.cbb_juros.DisplayMember = "juros";
            this.cbb_juros.Enabled = false;
            this.cbb_juros.FormattingEnabled = true;
            this.cbb_juros.Location = new System.Drawing.Point(623, 30);
            this.cbb_juros.Name = "cbb_juros";
            this.cbb_juros.Size = new System.Drawing.Size(67, 21);
            this.cbb_juros.TabIndex = 115;
            this.cbb_juros.ValueMember = "juros";
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
            this.label8.Location = new System.Drawing.Point(556, 14);
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
            this.cbb_dividir.DisplayMember = "id_cartao_dividir";
            this.cbb_dividir.Enabled = false;
            this.cbb_dividir.FormattingEnabled = true;
            this.cbb_dividir.Location = new System.Drawing.Point(559, 30);
            this.cbb_dividir.Name = "cbb_dividir";
            this.cbb_dividir.Size = new System.Drawing.Size(67, 21);
            this.cbb_dividir.TabIndex = 113;
            this.cbb_dividir.ValueMember = "id_cartao_dividir";
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
            // 
            // cbb_cliente
            // 
            this.cbb_cliente.DisplayMember = "nome";
            this.cbb_cliente.FormattingEnabled = true;
            this.cbb_cliente.Location = new System.Drawing.Point(234, 31);
            this.cbb_cliente.Name = "cbb_cliente";
            this.cbb_cliente.Size = new System.Drawing.Size(160, 21);
            this.cbb_cliente.TabIndex = 89;
            // 
            // cbb_produtos
            // 
            this.cbb_produtos.DisplayMember = "nome";
            this.cbb_produtos.FormattingEnabled = true;
            this.cbb_produtos.Location = new System.Drawing.Point(68, 31);
            this.cbb_produtos.Name = "cbb_produtos";
            this.cbb_produtos.Size = new System.Drawing.Size(160, 21);
            this.cbb_produtos.TabIndex = 87;
            // 
            // tbl_PedidoTableAdapter
            // 
            this.tbl_PedidoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Label lbl_produtos;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.TextBox txt_debito;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_cliente;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_produtos;
        private System.Windows.Forms.ComboBox cbb_cliente;
        private System.Windows.Forms.TextBox txt_id_pedido;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id_produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_valor_u;
        private System.Windows.Forms.Label lbl_u;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_venda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.ComboBox cbb_juros;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_dividir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker data_pedido;
        private System.Windows.Forms.Label lbl_estoque;
        private System.Windows.Forms.TextBox txt_quant_estoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_entrega;
        private rulerDataSet rulerDataSet;
        private System.Windows.Forms.BindingSource tblPedidoBindingSource;
        private rulerDataSetTableAdapters.Tbl_PedidoTableAdapter tbl_PedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
    }
}