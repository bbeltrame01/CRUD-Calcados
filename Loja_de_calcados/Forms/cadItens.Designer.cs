namespace AcessoBancoDados
{
    partial class cadItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadItens));
            this.label1 = new System.Windows.Forms.Label();
            this.txCodItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txItemDescri = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFab = new System.Windows.Forms.MaskedTextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txGarantia = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txCodFor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // txCodItem
            // 
            this.txCodItem.Enabled = false;
            this.txCodItem.Location = new System.Drawing.Point(130, 34);
            this.txCodItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txCodItem.Name = "txCodItem";
            this.txCodItem.Size = new System.Drawing.Size(143, 30);
            this.txCodItem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição:";
            // 
            // txItemDescri
            // 
            this.txItemDescri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txItemDescri.Location = new System.Drawing.Point(130, 105);
            this.txItemDescri.Name = "txItemDescri";
            this.txItemDescri.Size = new System.Drawing.Size(564, 30);
            this.txItemDescri.TabIndex = 1;
            this.txItemDescri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txItemDescri_KeyDown);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(592, 315);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(144, 50);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(442, 315);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(144, 50);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data de fabricação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cód. Fornecedor:";
            // 
            // dtFab
            // 
            this.dtFab.Location = new System.Drawing.Point(579, 34);
            this.dtFab.Mask = "00/00/0000";
            this.dtFab.Name = "dtFab";
            this.dtFab.Size = new System.Drawing.Size(115, 30);
            this.dtFab.TabIndex = 1;
            this.dtFab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtFab_KeyDown);
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(130, 176);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(143, 30);
            this.txValor.TabIndex = 2;
            this.txValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txValor_KeyDown);
            this.txValor.Leave += new System.EventHandler(this.txValor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Garantia:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Items.AddRange(new object[] {
            "BOTAS",
            "CHINELOS E SANDÁLIAS",
            "CHUTEIRAS",
            "SAPATÊNIS",
            "SAPATILHAS",
            "SAPATOS",
            "TÊNIS"});
            this.cbCategoria.Location = new System.Drawing.Point(130, 247);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(300, 31);
            this.cbCategoria.TabIndex = 4;
            this.cbCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCategoria_KeyDown);
            // 
            // txGarantia
            // 
            this.txGarantia.Location = new System.Drawing.Point(543, 248);
            this.txGarantia.Name = "txGarantia";
            this.txGarantia.Size = new System.Drawing.Size(74, 30);
            this.txGarantia.TabIndex = 5;
            this.txGarantia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txGarantia_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Meses";
            // 
            // txCodFor
            // 
            this.txCodFor.Location = new System.Drawing.Point(543, 176);
            this.txCodFor.Name = "txCodFor";
            this.txCodFor.Size = new System.Drawing.Size(151, 30);
            this.txCodFor.TabIndex = 3;
            this.txCodFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txCodFor_KeyDown);
            // 
            // cadItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 377);
            this.Controls.Add(this.txCodFor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txGarantia);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.dtFab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txItemDescri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCodItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadItens";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens";
            this.Load += new System.EventHandler(this.cadItens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txItemDescri;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox dtFab;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DomainUpDown txGarantia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txCodFor;
    }
}