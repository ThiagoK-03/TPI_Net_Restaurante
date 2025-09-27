using Application.Services;
using Domain.Model;
using DTOs;
using WebApplication1;
using WebApplication1.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

// Singletons Services
builder.Services.AddSingleton<EmpleadoService>();
builder.Services.AddSingleton<ClienteService>();
builder.Services.AddSingleton<IngredienteService>();
builder.Services.AddSingleton<ProveedorService>();
builder.Services.AddSingleton<ProductoService>();

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


app.MapCrudEndpoints<EmpleadoDto, EmpleadoService>("empleados");
app.MapCrudEndpoints<ClienteDTO, ClienteService>("clientes");
app.MapCrudEndpoints<ProveedorDTO, ProveedorService>("proveedores");
app.MapCrudEndpoints<ProductoDTO, ProductoService>("productos");
app.MapCrudEndpoints<IngredienteDTO, IngredienteService>("ingredientes");
//app.MapCrudEndpoints<PedidoDto, PedidoService>("pedidos");

app.Run();
