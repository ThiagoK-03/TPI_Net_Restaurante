using Application.Services;
using Data;
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

//Services for DB
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<ProductoService>();
builder.Services.AddScoped<EmpleadoService>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<IngredienteService>();
builder.Services.AddScoped<ProveedorService>();
builder.Services.AddScoped<PedidoService>();

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
app.MapCrudEndpoints<PedidoDTO, PedidoService>("pedidos");

app.Run();
