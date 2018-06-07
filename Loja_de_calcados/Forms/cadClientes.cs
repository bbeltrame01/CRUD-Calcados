using Loja_de_calcados;
using Loja_de_calcados.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ObjetoTransferencia2;

namespace AcessoBancoDados
{
    public partial class cadClientes : Form
    {
        public cadClientes(Acao acao)
        {
            InitializeComponent();

            if (acao == Acao.Inserir)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acao == Acao.Alterar)
            {
                this.Text = "Alterar Cliente";
            }
            else if (acao == Acao.Excluir)
            {
                this.Text = "Excluir Cliente";
            }
        }

        private void cep_Leave(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                    .Replace("@cep", txCEP.Text);

                ds.ReadXml(xml);

                txRua.Text = ds.Tables[0].Rows[0]["Logradouro"].ToString();
                txBairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString();
                txCidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString();
                txUF.Text = ds.Tables[0].Rows[0]["UF"].ToString();
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "CEP não encontrado...");
            }
        }

        private void rb_pf_CheckedChanged(object sender, EventArgs e)
        {
                txCPF.Mask = "000,000,000-00";
                txCPF.Size = new Size(123, 100);
                lblCPF.Visible = true;
                lbl_Nome.Visible = true;
                lblCNPJ.Visible = false;
                lbl_Razao.Visible = false;
                txCPF.Visible = true;
                txNome.Visible = true;
                lblDtNasc.Visible = true;
                dtNasc.Visible = true;
                txCPF.Focus();
        }

        private void rb_pj_CheckedChanged(object sender, EventArgs e)
        {
            txCPF.Mask = "00,000,000/0000-00";
            lblCNPJ.Visible = true;
            txCPF.Size = new Size(153, 100);
            lbl_Razao.Visible = true;
            txCPF.Visible = true;
            txNome.Visible = true;
            lblDtNasc.Visible = false;
            dtNasc.Visible = false;
            txCPF.Focus();
        }

        private void txSalvar_Click(object sender, EventArgs e)
        {
            if (txNome.Text == string.Empty)
            {
                MessageBox.Show("O campo NOME deve ser preenchido!");
                txNome.BackColor = Color.LightSeaGreen;
            }
            else if (String.IsNullOrWhiteSpace(txCPF.Text))
            {
                MessageBox.Show("O campo CPF deve ser preenchido!");
                txCPF.BackColor = Color.LightSeaGreen;
            }
            else if (String.IsNullOrWhiteSpace(txCEP.Text))
            {
                MessageBox.Show("O campo CEP deve ser preenchido!");
                txCEP.BackColor = Color.LightSeaGreen;
            }
            else if (String.IsNullOrWhiteSpace(txUF.Text))
            {
                MessageBox.Show("O campo ESTADO(UF) deve ser preenchido!");
                txUF.BackColor = Color.LightSeaGreen;
            }
            else if (txCidade.Text == string.Empty)
            {
                MessageBox.Show("O campo CIDADE deve ser preenchido!");
                txCidade.BackColor = Color.LightSeaGreen;
            }
            else if (String.IsNullOrWhiteSpace(txBairro.Text))
            {
                MessageBox.Show("O campo BAIRRO deve ser preenchido!");
                txBairro.BackColor = Color.LightSeaGreen;
            }
            else if (txRua.Text == string.Empty)
            {
                MessageBox.Show("O campo RUA deve ser preenchido!");
                txRua.BackColor = Color.LightSeaGreen;
            }
            else
            {
                
                MessageBox.Show("Cliente inserido com sucesso!");
            }
        }
    }
}
