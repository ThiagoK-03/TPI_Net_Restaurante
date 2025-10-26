using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;
using Application.Services;
using WinFormsControlLibrary1;

namespace WindowsForms
{
    public partial class LoginForm : MenuBase
    {
        private readonly IAuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            //_authService = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Credenciales hardcodeadas
            //if (_authService.Login(usuario, password))
            if (true)
                {
                this.Hide();
                Menu menu = new Menu();
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos",
                                "Error de login",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
