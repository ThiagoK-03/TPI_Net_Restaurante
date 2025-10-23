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

        static public String GetUserLogged()
        {
            return "admin";
        }
    }
}
