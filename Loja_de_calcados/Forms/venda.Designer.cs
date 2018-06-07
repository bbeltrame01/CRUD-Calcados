namespace AcessoBancoDados
{
    partial class venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venda));
            this.itens_venda = new System.Windows.Forms.GroupBox();
            this.addItePed = new System.Windows.Forms.Button();
            this.dgItensPedido = new System.Windows.Forms.DataGridView();
            this.btAlterarItemVda = new System.Windows.Forms.Button();
            this.btExcluirItemVda = new System.Windows.Forms.Button();
            this.txTotalVda = new System.Windows.Forms.TextBox();
            this.txQntIteVda = new System.Windows.Forms.TextBox();
            this.txTotalItem = new System.Windows.Forms.TextBox();
            this.txVlrItem = new System.Windows.Forms.TextBox();
            this.txDescriItem = new System.Windows.Forms.TextBox();
            this.txQtdItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btPesquisaItemVenda = new System.Windows.Forms.Button();
            this.txCodItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupItens = new System.Windows.Forms.GroupBox();
            this.cbDesconto = new System.Windows.Forms.ComboBox();
            this.txDesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txNomeFunc = new System.Windows.Forms.TextBox();
            this.btPesqFunc = new System.Windows.Forms.Button();
            this.txCodFun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txNomeCli = new System.Windows.Forms.TextBox();
            this.btPesqCli = new System.Windows.Forms.Button();
            this.txCodCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btNovaVenda = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itens_venda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensPedido)).BeginInit();
            this.groupItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // itens_venda
            // 
            this.itens_venda.Controls.Add(this.addItePed);
            this.itens_venda.Controls.Add(this.dgItensPedido);
            this.itens_venda.Controls.Add(this.btAlterarItemVda);
            this.itens_venda.Controls.Add(this.btExcluirItemVda);
            this.itens_venda.Controls.Add(this.txTotalVda);
            this.itens_venda.Controls.Add(this.txQntIteVda);
            this.itens_venda.Controls.Add(this.txTotalItem);
            this.itens_venda.Controls.Add(this.txVlrItem);
            this.itens_venda.Controls.Add(this.txDescriItem);
            this.itens_venda.Controls.Add(this.txQtdItem);
            this.itens_venda.Controls.Add(this.label6);
            this.itens_venda.Controls.Add(this.label5);
            this.itens_venda.Controls.Add(this.btPesquisaItemVenda);
            this.itens_venda.Controls.Add(this.txCodItem);
            this.itens_venda.Controls.Add(this.label4);
            this.itens_venda.Controls.Add(this.label3);
            this.itens_venda.Controls.Add(this.label2);
            this.itens_venda.Controls.Add(this.label1);
            this.itens_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itens_venda.Location = new System.Drawing.Point(12, 12);
            this.itens_venda.Name = "itens_venda";
            this.itens_venda.Size = new System.Drawing.Size(909, 327);
            this.itens_venda.TabIndex = 0;
            this.itens_venda.TabStop = false;
            this.itens_venda.Text = "Itens";
            // 
            // addItePed
            // 
            this.addItePed.Image = ((System.Drawing.Image)(resources.GetObject("addItePed.Image")));
            this.addItePed.Location = new System.Drawing.Point(744, 78);
            this.addItePed.Name = "addItePed";
            this.addItePed.Size = new System.Drawing.Size(47, 30);
            this.addItePed.TabIndex = 3;
            this.addItePed.UseVisualStyleBackColor = true;
            // 
            // dgItensPedido
            // 
            this.dgItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal});
            this.dgItensPedido.Location = new System.Drawing.Point(6, 116);
            this.dgItensPedido.Name = "dgItensPedido";
            this.dgItensPedido.RowTemplate.Height = 24;
            this.dgItensPedido.Size = new System.Drawing.Size(897, 160);
            this.dgItensPedido.TabIndex = 27;
            // 
            // btAlterarItemVda
            // 
            this.btAlterarItemVda.Image = ((System.Drawing.Image)(resources.GetObject("btAlterarItemVda.Image")));
            this.btAlterarItemVda.Location = new System.Drawing.Point(797, 78);
            this.btAlterarItemVda.Name = "btAlterarItemVda";
            this.btAlterarItemVda.Size = new System.Drawing.Size(50, 30);
            this.btAlterarItemVda.TabIndex = 26;
            this.btAlterarItemVda.UseVisualStyleBackColor = true;
            // 
            // btExcluirItemVda
            // 
            this.btExcluirItemVda.Image = ((System.Drawing.Image)(resources.GetObject("btExcluirItemVda.Image")));
            this.btExcluirItemVda.Location = new System.Drawing.Point(853, 78);
            this.btExcluirItemVda.Name = "btExcluirItemVda";
            this.btExcluirItemVda.Size = new System.Drawing.Size(50, 30);
            this.btExcluirItemVda.TabIndex = 25;
            this.btExcluirItemVda.UseVisualStyleBackColor = true;
            this.btExcluirItemVda.Click += new System.EventHandler(this.btExcluirItemVda_Click);
            // 
            // txTotalVda
            // 
            this.txTotalVda.Enabled = false;
            this.txTotalVda.Location = new System.Drawing.Point(744, 284);
            this.txTotalVda.Name = "txTotalVda";
            this.txTotalVda.ReadOnly = true;
            this.txTotalVda.Size = new System.Drawing.Size(159, 30);
            this.txTotalVda.TabIndex = 24;
            // 
            // txQntIteVda
            // 
            this.txQntIteVda.Enabled = false;
            this.txQntIteVda.Location = new System.Drawing.Point(385, 282);
            this.txQntIteVda.Name = "txQntIteVda";
            this.txQntIteVda.ReadOnly = true;
            this.txQntIteVda.Size = new System.Drawing.Size(117, 30);
            this.txQntIteVda.TabIndex = 23;
            // 
            // txTotalItem
            // 
            this.txTotalItem.Enabled = false;
            this.txTotalItem.Location = new System.Drawing.Point(580, 78);
            this.txTotalItem.Name = "txTotalItem";
            this.txTotalItem.ReadOnly = true;
            this.txTotalItem.Size = new System.Drawing.Size(158, 30);
            this.txTotalItem.TabIndex = 21;
            // 
            // txVlrItem
            // 
            this.txVlrItem.Location = new System.Drawing.Point(357, 80);
            this.txVlrItem.Name = "txVlrItem";
            this.txVlrItem.Size = new System.Drawing.Size(149, 30);
            this.txVlrItem.TabIndex = 2;
            // 
            // txDescriItem
            // 
            this.txDescriItem.Enabled = false;
            this.txDescriItem.Location = new System.Drawing.Point(357, 36);
            this.txDescriItem.Name = "txDescriItem";
            this.txDescriItem.ReadOnly = true;
            this.txDescriItem.Size = new System.Drawing.Size(546, 30);
            this.txDescriItem.TabIndex = 20;
            // 
            // txQtdItem
            // 
            this.txQtdItem.Location = new System.Drawing.Point(132, 80);
            this.txQtdItem.Name = "txQtdItem";
            this.txQtdItem.Size = new System.Drawing.Size(111, 30);
            this.txQtdItem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(647, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "QTD:";
            // 
            // btPesquisaItemVenda
            // 
            this.btPesquisaItemVenda.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisaItemVenda.Image")));
            this.btPesquisaItemVenda.Location = new System.Drawing.Point(301, 34);
            this.btPesquisaItemVenda.Name = "btPesquisaItemVenda";
            this.btPesquisaItemVenda.Size = new System.Drawing.Size(50, 30);
            this.btPesquisaItemVenda.TabIndex = 2;
            this.btPesquisaItemVenda.UseVisualStyleBackColor = true;
            this.btPesquisaItemVenda.Click += new System.EventHandler(this.btPesquisaItemVenda_Click);
            // 
            // txCodItem
            // 
            this.txCodItem.Location = new System.Drawing.Point(132, 36);
            this.txCodItem.Name = "txCodItem";
            this.txCodItem.Size = new System.Drawing.Size(163, 30);
            this.txCodItem.TabIndex = 0;
            this.txCodItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // groupItens
            // 
            this.groupItens.Controls.Add(this.cbDesconto);
            this.groupItens.Controls.Add(this.txDesconto);
            this.groupItens.Controls.Add(this.label9);
            this.groupItens.Controls.Add(this.txNomeFunc);
            this.groupItens.Controls.Add(this.btPesqFunc);
            this.groupItens.Controls.Add(this.txCodFun);
            this.groupItens.Controls.Add(this.label8);
            this.groupItens.Controls.Add(this.txNomeCli);
            this.groupItens.Controls.Add(this.btPesqCli);
            this.groupItens.Controls.Add(this.txCodCli);
            this.groupItens.Controls.Add(this.label7);
            this.groupItens.Location = new System.Drawing.Point(12, 345);
            this.groupItens.Name = "groupItens";
            this.groupItens.Size = new System.Drawing.Size(909, 171);
            this.groupItens.TabIndex = 1;
            this.groupItens.TabStop = false;
            this.groupItens.Text = "Dados Gerais";
            // 
            // cbDesconto
            // 
            this.cbDesconto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesconto.FormattingEnabled = true;
            this.cbDesconto.Items.AddRange(new object[] {
            "Percentual",
            "Valor"});
            this.cbDesconto.Location = new System.Drawing.Point(138, 113);
            this.cbDesconto.Name = "cbDesconto";
            this.cbDesconto.Size = new System.Drawing.Size(167, 33);
            this.cbDesconto.TabIndex = 2;
            // 
            // txDesconto
            // 
            this.txDesconto.Location = new System.Drawing.Point(311, 114);
            this.txDesconto.Name = "txDesconto";
            this.txDesconto.Size = new System.Drawing.Size(149, 30);
            this.txDesconto.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Desconto:";
            // 
            // txNomeFunc
            // 
            this.txNomeFunc.Enabled = false;
            this.txNomeFunc.Location = new System.Drawing.Point(311, 77);
            this.txNomeFunc.Name = "txNomeFunc";
            this.txNomeFunc.ReadOnly = true;
            this.txNomeFunc.Size = new System.Drawing.Size(592, 30);
            this.txNomeFunc.TabIndex = 26;
            // 
            // btPesqFunc
            // 
            this.btPesqFunc.Image = ((System.Drawing.Image)(resources.GetObject("btPesqFunc.Image")));
            this.btPesqFunc.Location = new System.Drawing.Point(255, 75);
            this.btPesqFunc.Name = "btPesqFunc";
            this.btPesqFunc.Size = new System.Drawing.Size(50, 30);
            this.btPesqFunc.TabIndex = 8;
            this.btPesqFunc.UseVisualStyleBackColor = true;
            this.btPesqFunc.Click += new System.EventHandler(this.button3_Click);
            // 
            // txCodFun
            // 
            this.txCodFun.Location = new System.Drawing.Point(138, 77);
            this.txCodFun.Name = "txCodFun";
            this.txCodFun.Size = new System.Drawing.Size(111, 30);
            this.txCodFun.TabIndex = 1;
            this.txCodFun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodFun_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Funcionário:";
            // 
            // txNomeCli
            // 
            this.txNomeCli.Enabled = false;
            this.txNomeCli.Location = new System.Drawing.Point(311, 41);
            this.txNomeCli.Name = "txNomeCli";
            this.txNomeCli.ReadOnly = true;
            this.txNomeCli.Size = new System.Drawing.Size(592, 30);
            this.txNomeCli.TabIndex = 25;
            // 
            // btPesqCli
            // 
            this.btPesqCli.Image = ((System.Drawing.Image)(resources.GetObject("btPesqCli.Image")));
            this.btPesqCli.Location = new System.Drawing.Point(255, 39);
            this.btPesqCli.Name = "btPesqCli";
            this.btPesqCli.Size = new System.Drawing.Size(50, 30);
            this.btPesqCli.TabIndex = 6;
            this.btPesqCli.UseVisualStyleBackColor = true;
            this.btPesqCli.Click += new System.EventHandler(this.button2_Click);
            // 
            // txCodCli
            // 
            this.txCodCli.Location = new System.Drawing.Point(138, 41);
            this.txCodCli.Name = "txCodCli";
            this.txCodCli.Size = new System.Drawing.Size(111, 30);
            this.txCodCli.TabIndex = 0;
            this.txCodCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodCli_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cliente:";
            // 
            // btNovaVenda
            // 
            this.btNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btNovaVenda.Image")));
            this.btNovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovaVenda.Location = new System.Drawing.Point(477, 522);
            this.btNovaVenda.Name = "btNovaVenda";
            this.btNovaVenda.Size = new System.Drawing.Size(144, 52);
            this.btNovaVenda.TabIndex = 19;
            this.btNovaVenda.Text = "Novo";
            this.btNovaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNovaVenda.UseVisualStyleBackColor = true;
            // 
            // btImprimir
            // 
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.Location = new System.Drawing.Point(627, 522);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(144, 52);
            this.btImprimir.TabIndex = 12;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btImprimir.UseVisualStyleBackColor = true;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btFinalizar.Image")));
            this.btFinalizar.Location = new System.Drawing.Point(777, 522);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(144, 52);
            this.btFinalizar.TabIndex = 0;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFinalizar.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 120;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ValorUnitario.HeaderText = "Valor Unitário";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            this.ValorUnitario.Width = 158;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 136;
            // 
            // venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 584);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btNovaVenda);
            this.Controls.Add(this.groupItens);
            this.Controls.Add(this.itens_venda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "venda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.venda_Load);
            this.itens_venda.ResumeLayout(false);
            this.itens_venda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensPedido)).EndInit();
            this.groupItens.ResumeLayout(false);
            this.groupItens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itens_venda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPesquisaItemVenda;
        private System.Windows.Forms.TextBox txCodItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txVlrItem;
        private System.Windows.Forms.TextBox txDescriItem;
        private System.Windows.Forms.TextBox txQtdItem;
        private System.Windows.Forms.TextBox txTotalVda;
        private System.Windows.Forms.TextBox txQntIteVda;
        private System.Windows.Forms.TextBox txTotalItem;
        private System.Windows.Forms.GroupBox groupItens;
        private System.Windows.Forms.Button btNovaVenda;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.TextBox txDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txNomeFunc;
        private System.Windows.Forms.Button btPesqFunc;
        private System.Windows.Forms.TextBox txCodFun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNomeCli;
        private System.Windows.Forms.Button btPesqCli;
        private System.Windows.Forms.TextBox txCodCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDesconto;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtditemvdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrtotalitemvdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAlterarItemVda;
        private System.Windows.Forms.Button btExcluirItemVda;
        private System.Windows.Forms.DataGridView dgItensPedido;
        private System.Windows.Forms.Button addItePed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}