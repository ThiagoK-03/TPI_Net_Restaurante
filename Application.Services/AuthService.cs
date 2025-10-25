using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IAuthService
    {
        bool Login(string username, string password);
        Task<bool> IsAuthenticatedAsync();
        Task<string> GetUserLoggedAsync();

        string IsAuthenticated();

    }
    public class AuthService : IAuthService
    {
        public AuthService() { }

        public bool Login(string username, string password)
        {
            // 🔹 Por ahora hardcode
            if (username == "admin" && password == "1234")
                return true;

            return false;
        }

        public async Task<string> GetUserLoggedAsync()
        {
            await Task.Delay(500);
            return "empleado";
        }

        public async Task<bool> IsAuthenticatedAsync()
        {
            //implementacion
            await Task.Delay(1000);
            return  true;
        }

        public string IsAuthenticated()
        {
            return "HOLA DESDE EL SERVICE";
        }
    }
}
