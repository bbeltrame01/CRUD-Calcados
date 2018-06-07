using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja_de_calcados.Forms;

namespace AcessoBancoDados
{
    public partial class home : Form
    {
        static void main()
        {

        }
        public home()
        {
            InitializeComponent();
        }

        private void menuCadClientes_Click(object sender, EventArgs e)
        {
            pesqCliente outroForm = new pesqCliente();
            outroForm.MdiParent = this;
            outroForm.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesqFornecedores outroForm = new pesqFornecedores();
            outroForm.MdiParent = this;
            outroForm.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesqFuncionario outroForm = new pesqFuncionario();
            outroForm.MdiParent = this;
            outroForm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesqItem outroForm = new pesqItem();
            outroForm.MdiParent = this;
            outroForm.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venda outroForm = new venda();
            outroForm.MdiParent = this;
            outroForm.Show();
        }
    }
}
