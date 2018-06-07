using ObjetoTransferencia2;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AcessoBancoDados;
using Negocios;

namespace Loja_de_calcados.Forms
{
    public partial class pesqItem : Form
    {
        public Item itemSelecionado { get; set; }

        public pesqItem()
        {
            InitializeComponent();

            dgPesqItem.AutoGenerateColumns = false;
        }
        private void btPesqItem_Click(object sender, EventArgs e)
        {
            ItemNegocios itemNegocios = new ItemNegocios();
            ItemColecao itemColecao = new ItemColecao();
            int cod;

            if (int.TryParse(txPesqItem.Text, out cod) == true)
                itemColecao = itemNegocios.Consultar(cod, null);
            else
                itemColecao = itemNegocios.Consultar(null, txPesqItem.Text);

            dgPesqItem.DataSource = null;
            dgPesqItem.DataSource = itemColecao;

            dgPesqItem.Update();
            dgPesqItem.Refresh();
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

        private void dgPesqItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgPesqItem.Rows[e.RowIndex].DataBoundItem != null) && (dgPesqItem.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgPesqItem.Rows[e.RowIndex].DataBoundItem, dgPesqItem.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (dgPesqItem.Rows.Count < 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            itemSelecionado = dgPesqItem.SelectedRows[0].DataBoundItem as Item;

            DialogResult = DialogResult.OK;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cadItens outroForm = new cadItens();
            DialogResult dialogResult = outroForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Item inserido com sucesso!");
            }
        }
    }
}
