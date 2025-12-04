using Application.Services;
using Data;
using Domain.Model;
using DTOs;
using FastReport.Export.PdfSimple;
using FastReport;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json;
using WebApplication1;
using FastReport.Data;
using System.Data;

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
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<IClienteService, ClienteService>();


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

app.MapGet("/pedidos/cliente/{clienteId}",
    (IPedidoService service, int clienteId) =>
    {
        var result = service.GetAllByClientId(clienteId);
        return Results.Ok(result);
    });

app.MapGet("/clientes/user/{userId}",
    (IClienteService service, int userId) =>
    {
        var result = service.GetByUserId(userId);
        return Results.Ok(result);
    });


app.MapGet("/report/pedidos-mensuales", (PedidoService service) =>
{
    var datos = service.GetPedidosAgrupados();
    return Results.Ok(datos);
});


app.MapGet("/report/pedidos", (PedidoService service) =>
{
    // Obtener la lista de DTO desde el service
    var lista = service.GetPedidosAgrupados();  // List<PedidosPorDiaDTO>

    // Convertir la lista a un DataTable
    var dataTable = new DataTable("PedidosPorDia");
    dataTable.Columns.Add("Fecha", typeof(DateTime));
    dataTable.Columns.Add("CantidadPedidos", typeof(int));
    dataTable.Columns.Add("TotalDelDia", typeof(decimal));

    foreach (var item in lista)
    {
        dataTable.Rows.Add(item.Fecha, item.CantidadPedidos, item.TotalDelDia);
    }

    // Crear un DataSet y agregar el DataTable
    var dataSet = new DataSet();
    dataSet.Tables.Add(dataTable);

    using var report = new Report();


    report.Load("Reportes/ReportePedidosPorDia.frx");

    // Registrar el DataSet en el reporte
    report.RegisterData(dataSet, "Root");

    // Habilitar el datasource declarado en el FRX
    report.GetDataSource("PedidosPorDia").Enabled = true;

    // Preparar + exportar PDF
    report.Prepare();

    using var ms = new MemoryStream();
    var pdf = new PDFSimpleExport();
    report.Export(pdf, ms);
    ms.Position = 0;

    return Results.File(ms.ToArray(), "application/pdf", "PedidosPorDia.pdf");
});




using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    // Asegura que la base de datos esté creada
    context.Database.EnsureCreated();

    // Si no hay usuarios, agrega uno admin por defecto
    if (!context.Usuarios.Any())
    {
        var admin = new Usuario(
            username: "admin",
            email: "admin@rest.com",
            telefono: "123456789",
            nombre: "Admin",
            apellido: "Super",
            rol: "Admin",
            password: "1234"
        );

        

        context.Usuarios.Add(admin);
        context.SaveChanges();
        Console.WriteLine("Usuario admin creado exitosamente ✅");
    }
    else
    {
        Console.WriteLine("Usuarios ya existen, no se creó admin.");
    }
}

app.Run();
