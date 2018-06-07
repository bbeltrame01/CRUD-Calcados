namespace Loja_de_calcados.Forms
{
    partial class pesqCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesqCliente));
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.dgPesqCli = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeRazao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPesquisarCli = new System.Windows.Forms.Button();
            this.txPesqCli = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesqCli)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(626, 425);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(144, 50);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSelecionar
            // 
            this.btSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btSelecionar.Image")));
            this.btSelecionar.Location = new System.Drawing.Point(464, 425);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(156, 50);
            this.btSelecionar.TabIndex = 10;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // dgPesqCli
            // 
            this.dgPesqCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesqCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CpfCnpj,
            this.NomeRazao});
            this.dgPesqCli.Location = new System.Drawing.Point(18, 63);
            this.dgPesqCli.Name = "dgPesqCli";
            this.dgPesqCli.RowTemplate.Height = 24;
            this.dgPesqCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesqCli.Size = new System.Drawing.Size(752, 356);
            this.dgPesqCli.TabIndex = 9;
            this.dgPesqCli.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgPesqCli_CellFormatting);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Pessoa.idPessoa";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.DataPropertyName = "Pessoa.CpfCnpj";
            this.CpfCnpj.HeaderText = "CPF/CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.ReadOnly = true;
            this.CpfCnpj.Width = 150;
            // 
            // NomeRazao
            // 
            this.NomeRazao.DataPropertyName = "Pessoa.Nome";
            this.NomeRazao.HeaderText = "Nome/Razão";
            this.NomeRazao.Name = "NomeRazao";
            this.NomeRazao.ReadOnly = true;
            this.NomeRazao.Width = 459;
            // 
            // btPesquisarCli
            // 
            this.btPesquisarCli.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisarCli.Image")));
            this.btPesquisarCli.Location = new System.Drawing.Point(720, 13);
            this.btPesquisarCli.Name = "btPesquisarCli";
            this.btPesquisarCli.Size = new System.Drawing.Size(50, 30);
            this.btPesquisarCli.TabIndex = 8;
            this.btPesquisarCli.UseVisualStyleBackColor = true;
            this.btPesquisarCli.Click += new System.EventHandler(this.btPesquisarCli_Click);
            // 
            // txPesqCli
            // 
            this.txPesqCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txPesqCli.Location = new System.Drawing.Point(169, 15);
            this.txPesqCli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txPesqCli.Name = "txPesqCli";
            this.txPesqCli.Size = new System.Drawing.Size(544, 30);
            this.txPesqCli.TabIndex = 7;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(13, 18);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(148, 25);
            this.lblPesquisar.TabIndex = 6;
            this.lblPesquisar.Text = "Nome | Código:";
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.Location = new System.Drawing.Point(317, 425);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(144, 50);
            this.btAlterar.TabIndex = 20;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.Location = new System.Drawing.Point(167, 425);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(144, 50);
            this.btExcluir.TabIndex = 19;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.Location = new System.Drawing.Point(18, 425);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(143, 50);
            this.btCadastrar.TabIndex = 18;
            this.btCadastrar.Text = "Novo";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // pesqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 489);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgPesqCli);
            this.Controls.Add(this.btPesquisarCli);
            this.Controls.Add(this.txPesqCli);
            this.Controls.Add(this.lblPesquisar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pesqCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgPesqCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridView dgPesqCli;
        private System.Windows.Forms.Button btPesquisarCli;
        private System.Windows.Forms.TextBox txPesqCli;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeRazao;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCadastrar;
    }
}