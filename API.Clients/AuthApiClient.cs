using DTOs; // Para LoginRequest/Response
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;

namespace API.Clients
{
    public class AuthApiClient : IAuthService
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "https://localhost:5205";
        private string? accessToken;

        public event Action<bool>? AuthenticationStateChanged;

        public AuthApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var request = new LoginRequest { Username = username, Password = password };
            var response = await httpClient.PostAsJsonAsync($"{baseUrl}/auth/login", request);
            if (response.IsSuccessStatusCode)
            {
                var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
                accessToken = loginResponse?.Token;
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                AuthenticationStateChanged?.Invoke(true);
                return true;
            }
            return false;
        }

        public async Task<bool> IsAuthenticatedAsync()
        {
            if (string.IsNullOrEmpty(accessToken)) return false;
            await CheckTokenExpirationAsync(); // Llama al método void para verificar y potencialmente logout
            return !string.IsNullOrEmpty(accessToken); // Si aún tiene token después de la verificación, es auténtico
        }

        public async Task<string?> GetTokenAsync() => accessToken;

        public async Task<string?> GetUsernameAsync()
        {
            var token = await GetTokenAsync();
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(token);
                return jsonToken.Claims.FirstOrDefault(c => c.Type == "name")?.Value;
            }
            return null;
        }

        public async Task LogoutAsync()
        {
            accessToken = null;
            httpClient.DefaultRequestHeaders.Authorization = null;
            AuthenticationStateChanged?.Invoke(false);
        }

        public async Task CheckTokenExpirationAsync()
        {
            if (string.IsNullOrEmpty(accessToken)) return;
            var token = new JwtSecurityTokenHandler().ReadJwtToken(accessToken);
            if (token.ValidTo < DateTime.UtcNow)
            {
                await LogoutAsync();
            }
        }

        public async Task<bool> HasPermissionAsync(string permission)
        {
            var token = await GetTokenAsync();
            if (token == null) return false;
            var handler = new JwtSecurityTokenHandler();
            var claims = handler.ReadJwtToken(token).Claims;
            return claims.Any(c => c.Type == "permission" && c.Value == permission);
        }

        public async Task<string?> GetRoleAsync()
        {
            var token = await GetTokenAsync();
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(token);
                return jsonToken.Claims.FirstOrDefault(c => c.Type == "role")?.Value;
            }
            return null;
        }
    }
}