using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public partial class login : Form
    {
        SqlConnection sqlConn = null;
        private string strCoon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CALCADOS_ONLINE;Integrated Security=True";
        private string _Sql = string.Empty;
        public bool logado = false;

        public login()
        {
            InitializeComponent();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strCoon);
            string usu, pwd;


            try
            {
                usu = txUser.Text;
                pwd = MD5Hash(txPassword.Text);

                    _Sql = "SELECT COUNT(id_user) FROM username WHERE usuario = @usuario AND senha = @senha";

                    SqlCommand cmd = new SqlCommand(_Sql,sqlConn);

                cmd.Parameters.Add("@usuario",SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if(v > 0)
                {
                    logado = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorreta!");
                    txUser.Text = "";
                    txPassword.Text = "";
                    txUser.Focus();
                    logado = false;
                }
            }
            catch(SqlException erro)
            {
                MessageBox.Show(erro + " no banco de dados!");
            }
        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void btEntrar_Click_1(object sender, EventArgs e)
        {
            logar();
        }

        private void txUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txPassword.Focus();
        }

        private void txPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btEntrar.PerformClick();
        }
    }
}
