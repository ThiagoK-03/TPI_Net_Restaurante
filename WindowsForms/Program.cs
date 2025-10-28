using System;
using API.Clients;
using Auth.WindowsForms;

namespace WindowsForms
{
    public enum FormMode
    {
        Add,
        Update
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Task.Run(async () => await MainAsync()).GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            // Registrar AuthService en singleton
            var authService = new WindowsFormsAuthService();
            AuthServiceProvider.Register(authService);

            // Loop principal de autenticación
            while (true)
            {

                if (!await authService.IsAuthenticatedAsync())
                {
                    var loginForm = new LoginForm();
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // Usuario canceló login, cerrar aplicación
                        return;
                    }
                }

                try
                {
                    
                    if (string.Equals(await authService.GetRoleAsync(), "Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        System.Windows.Forms.Application.Run(new Menu());
                    }

                    else if (string.Equals(await authService.GetRoleAsync(), "Empleado", StringComparison.OrdinalIgnoreCase))
                    {
                        System.Windows.Forms.Application.Run(new MenuEmpleado());
                    }

                    else if (string.Equals(await authService.GetRoleAsync(), "Cliente", StringComparison.OrdinalIgnoreCase))
                    {
                        System.Windows.Forms.Application.Run(new MenuCliente());
                    }

                    break; // La aplicación se cerró normalmente
                }
                catch (UnauthorizedAccessException ex)
                {
                    // Sesión expirada, mostrar mensaje y volver al login
                    MessageBox.Show(ex.Message, "Sesión Expirada",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // El loop continuará y volverá a mostrar login
                }
            }
        }
    }
}