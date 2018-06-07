using Negocios;
using ObjetoTransferencia2;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace AcessoBancoDados
{
    public partial class pesqFuncionario : Form
    {

        public Funcionario funcionarioSelecionado { get; set; }

        public pesqFuncionario()
        {
            InitializeComponent();

            dgPesqFun.AutoGenerateColumns = false;
        }

        private void btPesquisarFunc_Click(object sender, EventArgs e)
        {
            FuncionarioNegocios funcionarioNegocios = new FuncionarioNegocios();
            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

            int cod;
            if (int.TryParse(txPesqFun.Text, out cod) == true)
                funcionarioColecao = funcionarioNegocios.consultarPorCodigo(cod);
            else
                funcionarioColecao = funcionarioNegocios.consultarPorNome(txPesqFun.Text);

            dgPesqFun.DataSource = null;
            dgPesqFun.DataSource = funcionarioColecao;

            dgPesqFun.Update();
            dgPesqFun.Refresh();
        }

        //BindProperty
        private object carregarPropriedade(object propriedade, string nomePropriedade)
        {
            try
            {
                object retorno = "";

                if(nomePropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomePropriedade.Substring(0, nomePropriedade.IndexOf("."));

                    if(propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if(propertyInfo.Name == propriedadeAntesDoPonto)
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

        private void dgPesqFun_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgPesqFun.Rows[e.RowIndex].DataBoundItem != null) && (dgPesqFun.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = carregarPropriedade(dgPesqFun.Rows[e.RowIndex].DataBoundItem, dgPesqFun.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if(dgPesqFun.Rows.Count < 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            funcionarioSelecionado = dgPesqFun.SelectedRows[0].DataBoundItem as Funcionario;

            DialogResult = DialogResult.OK;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            cadFuncionarios outroForm = new cadFuncionarios();
            DialogResult dialogResult = outroForm.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Funcionario inserido com sucesso!");
            }
        }
    }
}
