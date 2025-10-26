using API.Clients;
//using Microsoft.JSInterop;

namespace Auth.Blazor
{
    public class BlazorAuthService
    {
        private readonly IAuthService authClient;
        //private readonly IJSRuntime jsRuntime;

        //public BlazorAuthService(IAuthService authClient, IJSRuntime jsRuntime)
        //{
        //    this.authClient = authClient;
        //    this.jsRuntime = jsRuntime;
        //}

        //public async Task<bool> LoginAsync(string username, string password)
        //{
        //    var success = await authClient.LoginAsync(username, password);
        //    if (success)
        //    {
        //        await jsRuntime.InvokeVoidAsync("localStorage.setItem", "token", await authClient.GetTokenAsync());
        //        // Navega a dashboard
        //    }
        //    return success;
        //}

        // Similar a WinForms, integra en componentes Blazor (ej: @inject BlazorAuthService Auth)
        // En OnInitializedAsync: if (!await Auth.IsAuthenticatedAsync()) { Navigation.NavigateTo("/login"); }
    }
}