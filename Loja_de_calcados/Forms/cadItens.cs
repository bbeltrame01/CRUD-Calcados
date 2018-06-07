using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoBancoDados
{
    public partial class cadItens : Form
    {
        public cadItens()
        {
            InitializeComponent();
        }

        Double Valor;

        private void txValor_Leave(object sender, EventArgs e)
        {
            try
            {
                Valor = Double.Parse(txValor.Text);
                txValor.Text = Valor.ToString("C");
            }
            catch (Exception)
            {

            }
        }

        private void cadItens_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.txGarantia.Items;
            for(int i = 1; i<=36;i++)
                collection.Add(i);            
        }

        private void txItemDescri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txValor.Focus();
        }

        private void txValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txCodFor.Focus();
        }

        private void txCodFor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbCategoria.Focus();
        }

        private void cbCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txGarantia.Focus();
        }

        private void txGarantia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dtFab.Focus();
        }

        private void dtFab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btSalvar.PerformClick();
        }
    }
}
