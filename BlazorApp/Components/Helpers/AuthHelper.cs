using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Diagnostics;

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

    public async Task<string> GetSection()
    {
        var result = await _localStorage.GetAsync<string>("userRole");
        switch (result.Value)
        {
            case "Admin":
                return "/dashboard/admin";

            case "Empleado":
                return "/dashboard/empleado";

            case "Cliente":
                return "/dashboard/empleado";

            default:
                return "No logueado";
        }
    }
}
