using API.Clients;
using UI.Blazor.Components;
using Auth.Blazor;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7111/") });


//// Configurar autenticaci�n
////builder.Services.AddSingleton<IAuthService, BlazorWasmAuthService>();
//builder.Services.AddScoped<IAuthService, BlazorWasmAuthService>();


//var app = builder.Build();

builder.Services.AddSingleton<IAuthService, BlazorServerAuthService>();

var app = builder.Build();

// Configurar AuthServiceProvider para ApiClients
var authService = app.Services.GetRequiredService<IAuthService>();
AuthServiceProvider.Register(authService);


// Configurar AuthServiceProvider para ApiClients
//using (var scope = app.Services.CreateScope())
//{
//    var authService = scope.ServiceProvider.GetRequiredService<IAuthService>();
//    AuthServiceProvider.Register(authService);
//    // Use authService here
//}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run(); 
