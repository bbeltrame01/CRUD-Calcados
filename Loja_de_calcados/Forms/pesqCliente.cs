using AcessoBancoDados;
using Negocios;
using ObjetoTransferencia2;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Loja_de_calcados.Forms
{
    public partial class pesqCliente : Form
    {

        public Cliente clienteSelecionado { get; set; }

        public pesqCliente()
        {
            InitializeComponent();

            dgPesqCli.AutoGenerateColumns = false;
        }

        private void btPesquisarCli_Click(object sender, EventArgs e)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteColecao clienteColecao = new ClienteColecao();
            int cod;

            if (int.TryParse(txPesqCli.Text, out cod) == true)
                clienteColecao = clienteNegocios.Consultar(cod, null);
            else
                clienteColecao = clienteNegocios.Consultar(null, txPesqCli.Text);

            dgPesqCli.DataSource = null;
            dgPesqCli.DataSource = clienteColecao;

            dgPesqCli.Update();
            dgPesqCli.Refresh();
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

        private void dgPesqCli_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgPesqCli.Rows[e.RowIndex].DataBoundItem != null) && (dgPesqCli.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgPesqCli.Rows[e.RowIndex].DataBoundItem, dgPesqCli.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (dgPesqCli.Rows.Count < 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            clienteSelecionado = dgPesqCli.SelectedRows[0].DataBoundItem as Cliente;

            DialogResult = DialogResult.OK;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cadClientes outroForm = new cadClientes(Acao.Inserir);
            DialogResult dialogResult = outroForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Cliente inserido com sucesso!");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgPesqCli.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            Cliente clienteSelecionado = (dgPesqCli.SelectedRows[0].DataBoundItem as Cliente);
            
            cadClientes outroForm = new cadClientes(Acao.Alterar);
            outroForm.ShowDialog();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgPesqCli.SelectedRows.Count==0)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Confirma exclusão do registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            Cliente clienteSelecionado = (dgPesqCli.SelectedRows[0].DataBoundItem as Cliente);
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            
        }
    }
}
