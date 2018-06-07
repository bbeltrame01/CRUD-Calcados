using AcessoBancoDados;
using Negocios;
using ObjetoTransferencia2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_calcados.Forms
{
    public partial class pesqFornecedores : Form
    {
        public pesqFornecedores()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cadFornecedores outroForm = new cadFornecedores();
            DialogResult dialogResult = outroForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Fornecedor inserido com sucesso!");
            }
        }

        private void btPesquisarFor_Click(object sender, EventArgs e)
        {
            FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
            FornecedorColecao fornecedorColecao = new FornecedorColecao();
            int cod;

            if (int.TryParse(txPesqFor.Text, out cod) == true)
                fornecedorColecao = fornecedorNegocios.Consultar(cod, null);
            else
                fornecedorColecao = fornecedorNegocios.Consultar(null, txPesqFor.Text);

            dgPesqFor.DataSource = null;
            dgPesqFor.DataSource = fornecedorColecao;

            dgPesqFor.Update();
            dgPesqFor.Refresh();
        }

        private object carregarPropriedade(object propriedade, string nomePropriedade)
        {
            try
            {
                object retorno = "";

                if (nomePropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomePropriedade.Substring(0, nomePropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = carregarPropriedade(propertyInfo.GetValue(propriedade, null),
                                    nomePropriedade.Substring(nomePropriedade.IndexOf(".") + 1));
                            }
                        }
                    }
                }
                else
                {
                    Type typePropertyInfo;
                    PropertyInfo propertyInfo;

                    if (propriedade != null)
                    {
                        typePropertyInfo = propriedade.GetType();
                        propertyInfo = typePropertyInfo.GetProperty(nomePropriedade);
                        retorno = propertyInfo.GetValue(propriedade, null);
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void dgPesqFor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgPesqFor.Rows[e.RowIndex].DataBoundItem != null) && (dgPesqFor.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgPesqFor.Rows[e.RowIndex].DataBoundItem, dgPesqFor.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
