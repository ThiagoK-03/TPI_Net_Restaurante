using API.Clients;
//using System.Windows.Forms; // Para UI si necesitas

namespace Auth.WindowsForms
{
    public class WinFormsAuthService
    {
        private readonly IAuthService authClient;

        public WinFormsAuthService(IAuthService authClient)
        {
            this.authClient = authClient;
        }

        //public async Task<bool> LoginAsync(string username, string password)
        //{
        //    var success = await authClient.LoginAsync(username, password);
        //    if (success)
        //    {
        //        // Ej: Muestra form principal
        //        MessageBox.Show("Login exitoso!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Credenciales inválidas");
        //    }
        //    return success;
        //}

        public async Task<bool> IsAuthenticatedAsync() => await authClient.IsAuthenticatedAsync();

        // Agrega métodos para inyectar en WinForms CRUDs (ej: verificar perm antes de abrir form Empleado)
    }
}