using Application.Services;
using Data;
using Domain.Model;
using DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApplication1;
using WebApplication1.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

//Services for DB
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<UsuarioRepository>();

builder.Services.AddScoped<ProductoService>();
builder.Services.AddScoped<EmpleadoService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<IngredienteService>();
builder.Services.AddScoped<ProveedorService>();
builder.Services.AddScoped<PedidoService>();

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<UsuarioRepository>(); // O usa AddDbContext para inyección

// JWT Auth
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidateAudience = true,
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]!)),
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

// Middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapPost("/auth/login", async (AuthService authService, LoginRequest request) =>
{
    var response = await authService.LoginAsync(request);
    return response != null ? Results.Ok(response) : Results.Unauthorized();
});

//app.MapCrudEndpoints<EmpleadoDto, EmpleadoService>("empleados").RequireAuthorization("Empleado:Read");
app.MapCrudEndpoints<EmpleadoDto, EmpleadoService>("empleados");
app.MapCrudEndpoints<ClienteDTO, ClienteService>("clientes");
app.MapCrudEndpoints<ProveedorDTO, ProveedorService>("proveedores");
app.MapCrudEndpoints<ProductoDTO, ProductoService>("productos");
app.MapCrudEndpoints<IngredienteDTO, IngredienteService>("ingredientes");
app.MapCrudEndpoints<PedidoDTO, PedidoService>("pedidos");

app.Run();
