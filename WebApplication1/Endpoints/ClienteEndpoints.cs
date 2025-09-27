using Application.Services;
using DTOs;

namespace WebApplication1.Endpoints
{
    public static class ClienteEndpoints
    {
        public static IEndpointRouteBuilder MapClienteEndpoints(this IEndpointRouteBuilder app)
        {

            //GET BY ID
            app.MapGet("/clientes/{id}", (ClienteService service, int id) =>
            {

                ClienteDTO? dto = service.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetCliente")
            .Produces<ClienteDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            //GET ALL
            app.MapGet("/clientes", (ClienteService service) =>
            {
                var dtos = service.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllClientes")
            .Produces<List<ClienteDTO>>(StatusCodes.Status200OK);

            //CREATE
            app.MapPost("/clientes", (ClienteDTO dto, ClienteService service) =>
            {
                try
                {
                    ClienteDTO ClienteDto = service.Add(dto);

                    return Results.Created($"/clientes/{ClienteDto.Id}", ClienteDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddCliente")
            .Produces<ClienteDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);


            //UPDATE
            app.MapPut("/clientes", (ClienteDTO dto, ClienteService service) =>
            {
                try
                {
                    var found = service.Update(dto);

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


            //DELETE
            app.MapDelete("/clientes/{id}", (int id, ClienteService service) =>
            {
                var deleted = service.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteCliente")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound);


            return app;
        }
    }
}
