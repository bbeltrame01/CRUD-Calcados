namespace AcessoBancoDados
{
    partial class cadFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadFuncionarios));
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txSalario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txCPFFun = new System.Windows.Forms.MaskedTextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(679, 410);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(144, 50);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.Location = new System.Drawing.Point(529, 410);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(144, 50);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 392);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txSalario);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.dtNasc);
            this.tabPage1.Controls.Add(this.txCPFFun);
            this.tabPage1.Controls.Add(this.txNome);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txCodCli);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais";
            // 
            // txSalario
            // 
            this.txSalario.Location = new System.Drawing.Point(118, 249);
            this.txSalario.Name = "txSalario";
            this.txSalario.Size = new System.Drawing.Size(159, 30);
            this.txSalario.TabIndex = 4;
            this.txSalario.Leave += new System.EventHandler(this.txSalario_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Salário:";
            // 
            // dtNasc
            // 
            this.dtNasc.Location = new System.Drawing.Point(540, 165);
            this.dtNasc.Mask = "00/00/0000";
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(116, 30);
            this.dtNasc.TabIndex = 3;
            // 
            // txCPFFun
            // 
            this.txCPFFun.Location = new System.Drawing.Point(118, 165);
            this.txCPFFun.Mask = "000,000,000-00";
            this.txCPFFun.Name = "txCPFFun";
            this.txCPFFun.Size = new System.Drawing.Size(159, 30);
            this.txCPFFun.TabIndex = 2;
            // 
            // txNome
            // 
            this.txNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNome.Location = new System.Drawing.Point(118, 100);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(538, 30);
            this.txNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txCodCli
            // 
            this.txCodCli.Enabled = false;
            this.txCodCli.Location = new System.Drawing.Point(118, 29);
            this.txCodCli.Name = "txCodCli";
            this.txCodCli.Size = new System.Drawing.Size(100, 30);
            this.txCodCli.TabIndex = 0;
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
            this.tabPage2.Size = new System.Drawing.Size(807, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereço/Contato";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tel. Fixo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "E-mail:";
            // 
            // txFone
            // 
            this.txFone.Location = new System.Drawing.Point(633, 224);
            this.txFone.Mask = "(00)0000-0000";
            this.txFone.Name = "txFone";
            this.txFone.Size = new System.Drawing.Size(156, 30);
            this.txFone.TabIndex = 11;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(130, 287);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(490, 30);
            this.txEmail.TabIndex = 12;
            // 
            // txBairro
            // 
            this.txBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txBairro.Location = new System.Drawing.Point(130, 224);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(323, 30);
            this.txBairro.TabIndex = 10;
            // 
            // txCidade
            // 
            this.txCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCidade.Location = new System.Drawing.Point(130, 101);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(323, 30);
            this.txCidade.TabIndex = 7;
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(671, 163);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(118, 30);
            this.txNumero.TabIndex = 9;
            // 
            // txRua
            // 
            this.txRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRua.Location = new System.Drawing.Point(130, 163);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(490, 30);
            this.txRua.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nº:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 6;
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
            this.txUF.Location = new System.Drawing.Point(540, 32);
            this.txUF.Name = "txUF";
            this.txUF.Size = new System.Drawing.Size(63, 33);
            this.txUF.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Logradouro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "CEP:";
            // 
            // txCEP
            // 
            this.txCEP.Location = new System.Drawing.Point(130, 35);
            this.txCEP.Mask = "00000-000";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(110, 30);
            this.txCEP.TabIndex = 5;
            this.txCEP.Leave += new System.EventHandler(this.cep_Leave);
            // 
            // cadFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 472);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadFuncionarios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox dtNasc;
        private System.Windows.Forms.MaskedTextBox txCPFFun;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodCli;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txSalario;
    }
}