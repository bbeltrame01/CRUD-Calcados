using Loja_de_calcados.Forms;
using Negocios;
using ObjetoTransferencia2;
using System;
using System.Windows.Forms;

namespace AcessoBancoDados
{
    public partial class venda : Form
    {

        Funcionario funcionario;
        Cliente cliente;
        Item item;

        public venda()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
                MessageBox.Show("Digite apenas valores numéricos!");
            }
        }

        private void venda_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //btPesqFun
        {
            pesqFuncionario pesqFuncionario = new pesqFuncionario();
            DialogResult resultado = pesqFuncionario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txNomeFunc.Text = pesqFuncionario.funcionarioSelecionado.Pessoa.Nome;
                txCodFun.Text = Convert.ToString(pesqFuncionario.funcionarioSelecionado.Pessoa.idPessoa);
                funcionario = pesqFuncionario.funcionarioSelecionado;
            }
        }

        private void button2_Click(object sender, EventArgs e) //btPesqCli
        {
            pesqCliente pesqCliente = new pesqCliente();
            DialogResult resultado = pesqCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txNomeCli.Text = pesqCliente.clienteSelecionado.Pessoa.Nome;
                txCodCli.Text = Convert.ToString(pesqCliente.clienteSelecionado.Pessoa.idPessoa);
                cliente = pesqCliente.clienteSelecionado;
            }
        }

        private void btPesquisaItemVenda_Click(object sender, EventArgs e)
        {
            pesqItem pesqItem = new pesqItem();
            DialogResult resultado = pesqItem.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txCodItem.Text = Convert.ToString(pesqItem.itemSelecionado.idItem);
                txDescriItem.Text = pesqItem.itemSelecionado.Descricao;
                txVlrItem.Text = Convert.ToString(pesqItem.itemSelecionado.Valor.Valor);
                item = pesqItem.itemSelecionado;
            }
        }

        private void txCodFun_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                txCodFun.Clear();
                txNomeFunc.Clear();
                funcionario = null;
            }
        }

        private void txCodCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txCodCli.Clear();
                txNomeCli.Clear();
                cliente = null;
            }
        }

        private void btExcluirItemVda_Click(object sender, EventArgs e)
        {
            if (dgItensPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum item selecionado.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Confirma exclusão do registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            Item itemSelecionado = (dgItensPedido.SelectedRows[0].DataBoundItem as Item);
            PedidoItemNegocios pedidoItemNegocios = new PedidoItemNegocios();

            txCodItem.Clear();
            txDescriItem.Clear();
            txVlrItem.Clear();
            txQtdItem.Clear();
            item = null;
        }
    }
}
