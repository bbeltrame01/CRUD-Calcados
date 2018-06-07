namespace AcessoBancoDados
{
    partial class cadClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadClientes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Razao = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.rb_pj = new System.Windows.Forms.RadioButton();
            this.rb_pf = new System.Windows.Forms.RadioButton();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txCodCli = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txFone = new System.Windows.Forms.MaskedTextBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.txRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txUF = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtNasc);
            this.tabPage1.Controls.Add(this.lblDtNasc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txCodCli);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Razao);
            this.groupBox1.Controls.Add(this.lblCNPJ);
            this.groupBox1.Controls.Add(this.rb_pj);
            this.groupBox1.Controls.Add(this.rb_pf);
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Controls.Add(this.txCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.lbl_Nome);
            this.groupBox1.Location = new System.Drawing.Point(16, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 192);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Razao
            // 
            this.lbl_Razao.AutoSize = true;
            this.lbl_Razao.Location = new System.Drawing.Point(33, 120);
            this.lbl_Razao.Name = "lbl_Razao";
            this.lbl_Razao.Size = new System.Drawing.Size(74, 25);
            this.lbl_Razao.TabIndex = 6;
            this.lbl_Razao.Text = "Razão:";
            this.lbl_Razao.Visible = false;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(36, 64);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(71, 25);
            this.lblCNPJ.TabIndex = 5;
            this.lblCNPJ.Text = "CNPJ:";
            this.lblCNPJ.Visible = false;
            // 
            // rb_pj
            // 
            this.rb_pj.AutoSize = true;
            this.rb_pj.Location = new System.Drawing.Point(184, -2);
            this.rb_pj.Name = "rb_pj";
            this.rb_pj.Size = new System.Drawing.Size(172, 29);
            this.rb_pj.TabIndex = 2;
            this.rb_pj.TabStop = true;
            this.rb_pj.Text = "Pessoa Jurídica";
            this.rb_pj.UseVisualStyleBackColor = true;
            this.rb_pj.CheckedChanged += new System.EventHandler(this.rb_pj_CheckedChanged);
            // 
            // rb_pf
            // 
            this.rb_pf.AutoSize = true;
            this.rb_pf.Location = new System.Drawing.Point(18, -2);
            this.rb_pf.Name = "rb_pf";
            this.rb_pf.Size = new System.Drawing.Size(155, 29);
            this.rb_pf.TabIndex = 1;
            this.rb_pf.TabStop = true;
            this.rb_pf.Text = "Pessoa Física";
            this.rb_pf.UseVisualStyleBackColor = true;
            this.rb_pf.CheckedChanged += new System.EventHandler(this.rb_pf_CheckedChanged);
            // 
            // txNome
            // 
            this.txNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNome.Location = new System.Drawing.Point(113, 117);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(641, 30);
            this.txNome.TabIndex = 4;
            this.txNome.Visible = false;
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(113, 61);
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(156, 30);
            this.txCPF.TabIndex = 3;
            this.txCPF.Visible = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(49, 64);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(58, 25);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Visible = false;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(37, 120);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(70, 25);
            this.lbl_Nome.TabIndex = 2;
            this.lbl_Nome.Text = "Nome:";
            this.lbl_Nome.Visible = false;
            // 
            // dtNasc
            // 
            this.dtNasc.Location = new System.Drawing.Point(670, 45);
            this.dtNasc.Mask = "00/00/0000";
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(116, 30);
            this.dtNasc.TabIndex = 5;
            this.dtNasc.Visible = false;
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(454, 48);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(194, 25);
            this.lblDtNasc.TabIndex = 4;
            this.lblDtNasc.Text = "Data de Nascimento:";
            this.lblDtNasc.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txCodCli
            // 
            this.txCodCli.Enabled = false;
            this.txCodCli.Location = new System.Drawing.Point(146, 45);
            this.txCodCli.Name = "txCodCli";
            this.txCodCli.Size = new System.Drawing.Size(100, 30);
            this.txCodCli.TabIndex = 0;
            this.txCodCli.Text = "auto";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txFone);
            this.tabPage2.Controls.Add(this.txEmail);
            this.tabPage2.Controls.Add(this.txBairro);
            this.tabPage2.Controls.Add(this.txCidade);
            this.tabPage2.Controls.Add(this.txNumero);
            this.tabPage2.Controls.Add(this.txRua);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txUF);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txCEP);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereço/Contato";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Tel. Fixo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "E-mail:";
            // 
            // txFone
            // 
            this.txFone.Location = new System.Drawing.Point(633, 227);
            this.txFone.Mask = "(00)0000-0000";
            this.txFone.Name = "txFone";
            this.txFone.Size = new System.Drawing.Size(156, 30);
            this.txFone.TabIndex = 12;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(130, 291);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(490, 30);
            this.txEmail.TabIndex = 13;
            // 
            // txBairro
            // 
            this.txBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txBairro.Location = new System.Drawing.Point(130, 227);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(323, 30);
            this.txBairro.TabIndex = 11;
            // 
            // txCidade
            // 
            this.txCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCidade.Location = new System.Drawing.Point(130, 104);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(323, 30);
            this.txCidade.TabIndex = 8;
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(671, 166);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(118, 30);
            this.txNumero.TabIndex = 10;
            // 
            // txRua
            // 
            this.txRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRua.Location = new System.Drawing.Point(130, 166);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(490, 30);
            this.txRua.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nº:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Estado(UF):";
            // 
            // txUF
            // 
            this.txUF.FormattingEnabled = true;
            this.txUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "EX",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RS",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txUF.Location = new System.Drawing.Point(540, 35);
            this.txUF.Name = "txUF";
            this.txUF.Size = new System.Drawing.Size(63, 33);
            this.txUF.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "CEP:";
            // 
            // txCEP
            // 
            this.txCEP.Location = new System.Drawing.Point(130, 38);
            this.txCEP.Mask = "00000-000";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(110, 30);
            this.txCEP.TabIndex = 6;
            this.txCEP.Leave += new System.EventHandler(this.cep_Leave);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(678, 399);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(144, 50);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(528, 399);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(144, 50);
            this.btSalvar.TabIndex = 19;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.txSalvar_Click);
            // 
            // cadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 459);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodCli;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.MaskedTextBox dtNasc;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txFone;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.TextBox txRua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txUF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_pj;
        private System.Windows.Forms.RadioButton rb_pf;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.MaskedTextBox txCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lbl_Razao;
        private System.Windows.Forms.Button btSalvar;
    }
}