using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Login
{
    internal static class CadastroUsuarios
    {
        private static Usuario[] usuarios = 
        {   
        new Usuario() {Nome = "Leonardo", Senha = "123" },
        new Usuario() {Nome = "Matias", Senha = "abc" },
        new Usuario() {Nome = "Mattos",Senha = "abc123" },
        };

        private static Usuario _UserLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _UserLogado; }
            private set
            {
                _UserLogado = value;
            }
        }

        public static bool Login (string nome, string password)
        {
            foreach(Usuario usuario in usuarios) 
            {
                if(usuario.Nome == nome && usuario.Senha ==password )
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}
