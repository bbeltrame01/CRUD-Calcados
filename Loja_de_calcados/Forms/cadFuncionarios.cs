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
    public partial class cadFuncionarios : Form
    {
        public cadFuncionarios()
        {
            InitializeComponent();
        }

        Double Valor;

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

        private void txSalario_Leave(object sender, EventArgs e)
        {
            try
            {
                Valor = Double.Parse(txSalario.Text);
                txSalario.Text = Valor.ToString("C");
            }
            catch (Exception)
            {

            }
        }
    }
}
