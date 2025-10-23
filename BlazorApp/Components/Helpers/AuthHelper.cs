using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

public class AuthHelper
{
    private readonly ProtectedLocalStorage _localStorage;
    private readonly NavigationManager _navManager;

    public AuthHelper(ProtectedLocalStorage localStorage, NavigationManager navManager)
    {
        _localStorage = localStorage;
        _navManager = navManager;
    }

    public async Task<bool> IsAdminAsync()
    {
        var result = await _localStorage.GetAsync<string>("userRole");
        return result.Success && result.Value == "Admin";
    }

    public async Task RedirectIfNotAdminAsync()
    {
        if (!await IsAdminAsync())
            _navManager.NavigateTo("/login");
    }
}
