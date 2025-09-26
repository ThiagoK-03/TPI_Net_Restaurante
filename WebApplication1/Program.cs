using Application.Services;
using Domain.Model;
using DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

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




app.MapGet("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    ClienteDTO dto = clienteService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetCliente")
.Produces<ClienteDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound);

app.MapGet("/clientes", () =>
{
    ClienteService clienteService = new ClienteService();

    var dtos = clienteService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllClientes")
.Produces<List<ClienteDTO>>(StatusCodes.Status200OK);

app.MapPost("/clientes", (ClienteDTO dto) =>
{
    try
    {
        ClienteService clienteService = new ClienteService();

        ClienteDTO clienteDTO = clienteService.Add(dto);

        return Results.Created($"/clientes/{clienteDTO.Id}", clienteDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddCliente")
.Produces<ClienteDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest);

app.MapPut("/clientes", (ClienteDTO dto) =>
{
    try
    {
        ClienteService clienteService = new ClienteService();

        var found = clienteService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateCliente")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest);

app.MapDelete("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();

    var deleted = clienteService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteCliente")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound);


///Rest de Proveedores

app.MapGet("/proveedores/{id}", (int id) =>
{
    ProveedorService proveedorService = new ProveedorService();

    ProveedorDTO dto = proveedorService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetProveedor")
.Produces<ProveedorDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound);

app.MapGet("/proveedores", () =>
{
    ProveedorService proveedorService = new ProveedorService();

    var dtos = proveedorService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllProveedores")
.Produces<List<ProveedorDTO>>(StatusCodes.Status200OK);

app.MapPost("/proveedores", (ProveedorDTO dto) =>
{
    try
    {
        ProveedorService proveedorService = new ProveedorService();

        ProveedorDTO proveedorDTO = proveedorService.Add(dto);

        return Results.Created($"/proveedores/{proveedorDTO.Id}", proveedorDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddProveedor")
.Produces<ProveedorDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest);

app.MapPut("/proveedores", (ProveedorDTO dto) =>
{
    try
    {
        ProveedorService proveedorService = new ProveedorService();

        var found = proveedorService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateProveedor")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest);

app.MapDelete("/proveedores/{id}", (int id) =>
{
    ProveedorService proveedorService = new ProveedorService();

    var deleted = proveedorService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteProveedor")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound);

///Rest de Ingrediente

app.MapGet("/ingredientes/{id}", (int id) =>
{
    IngredienteService ingredienteService = new IngredienteService();

    IngredienteDTO dto = ingredienteService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetIngrediente")
.Produces<IngredienteDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound);

app.MapGet("/ingredientes", () =>
{
    IngredienteService ingredienteService = new IngredienteService();

    var dtos = ingredienteService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllIngredientes")
.Produces<List<IngredienteDTO>>(StatusCodes.Status200OK);

app.MapPost("/ingredientes", (IngredienteDTO dto) =>
{
    try
    {
        IngredienteService ingredienteService = new IngredienteService();

        IngredienteDTO ingredienteDTO = ingredienteService.Add(dto);

        return Results.Created($"/ingredientes/{ingredienteDTO.Id}", ingredienteDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddIngrediente")
.Produces<IngredienteDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest);

app.MapPut("/ingredientes", (IngredienteDTO dto) =>
{
    try
    {
        IngredienteService ingredienteService = new IngredienteService();

        var found = ingredienteService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateIngrediente")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest);

app.MapDelete("/ingredientes/{id}", (int id) =>
{
    IngredienteService ingredienteService = new IngredienteService();

    var deleted = ingredienteService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteIngrediente")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound);


///Rest de Producto

app.MapGet("/productos/{id}", (int id) =>
{
    ProductoService productoService = new ProductoService();

    ProductoDTO dto = productoService.Get(id);

    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
})
.WithName("GetProducto")
.Produces<ProductoDTO>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound);

app.MapGet("/productos", () =>
{
    ProductoService productoService = new ProductoService();

    var dtos = productoService.GetAll();

    return Results.Ok(dtos);
})
.WithName("GetAllProductos")
.Produces<List<ProductoDTO>>(StatusCodes.Status200OK);

app.MapPost("/productos", (ProductoDTO dto) =>
{
    try
    {
        ProductoService productoService = new ProductoService();

        ProductoDTO productoDTO = productoService.Add(dto);

        return Results.Created($"/ingredientes/{productoDTO.Id}", productoDTO);
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("AddProducto")
.Produces<ProductoDTO>(StatusCodes.Status201Created)
.Produces(StatusCodes.Status400BadRequest);

app.MapPut("/productos", (ProductoDTO dto) =>
{
    try
    {
        ProductoService productoService = new ProductoService();

        var found = productoService.Update(dto);

        if (!found)
        {
            return Results.NotFound();
        }

        return Results.NoContent();
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(new { error = ex.Message });
    }
})
.WithName("UpdateProducto")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest);

app.MapDelete("/Productos/{id}", (int id) =>
{
    ProductoService productoService = new ProductoService();

    var deleted = productoService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();

})
.WithName("DeleteProductos")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound);

app.Run();
