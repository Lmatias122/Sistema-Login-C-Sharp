using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Login
{
    public partial class FormLogin : Form
    {

        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            string name = txtUsuario.Text;
            string password = txtPassword.Text;
            if (CadastroUsuarios.Login(name, password))
            {
                Close();
            }
            else
            {
                MessageBox.Show("O usuário ou a senha informados estão incorretos");
                txtPassword.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
                Close();
            }
        }

        private void checkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = default;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
