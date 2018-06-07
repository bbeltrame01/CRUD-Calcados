using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoBancoDados
{
    public partial class cadFornecedores : Form
    {
        public cadFornecedores()
        {
            InitializeComponent();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CEP não encontrado...");
            }
        }

        private void rb_pf_CheckedChanged_1(object sender, EventArgs e)
        {
            txCPF.Mask = "000,000,000-00";
            txCPF.Size = new Size(123, 100);
            lblCPF.Visible = true;
            lblNome.Visible = true;
            lblCNPJ.Visible = false;
            lblRazao.Visible = false;
            txCPF.Visible = true;
            txNomeFor.Visible = true;
            txCPF.Focus();
        }

        private void rb_pj_CheckedChanged_1(object sender, EventArgs e)
        {
            txCPF.Mask = "00,000,000/0000-00";
            lblCNPJ.Visible = true;
            txCPF.Size = new Size(153, 100);
            lblRazao.Visible = true;
            txCPF.Visible = true;
            txNomeFor.Visible = true;
            txCPF.Focus();
        }
    }
}
