using Application.Services;
using DTOs;

namespace WebApplication1.Endpoints
{
    public static class EmpleadoEndpoints
    {
        public static IEndpointRouteBuilder MapEmpleadoEndpoints(this IEndpointRouteBuilder app)
        {

            //GET BY ID
            app.MapGet("/empleados/{id}", (EmpleadoService service, int id) =>
            {

                EmpleadoDto? dto = service.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetEmpleado")
            .Produces<EmpleadoDto>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            //GET ALL
            app.MapGet("/empleados", (EmpleadoService service) =>
            {
                var dtos = service.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllEmpleados")
            .Produces<List<EmpleadoDto>>(StatusCodes.Status200OK);

            //CREATE
            app.MapPost("/empleados", (EmpleadoDto dto, EmpleadoService service) =>
            {
                try
                {
                    EmpleadoDto EmpleadoDto = service.Add(dto);

                    return Results.Created($"/empleados/{EmpleadoDto.Id}", EmpleadoDto);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddEmpleado")
            .Produces<EmpleadoDto>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);


            //UPDATE
            app.MapPut("/empleados", (EmpleadoDto dto, EmpleadoService service) =>
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
            .WithName("UpdateEmpleado")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest);


            //DELETE
            app.MapDelete("/empleados/{id}", (int id, EmpleadoService service) =>
            {
                var deleted = service.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();

            })
            .WithName("DeleteEmpleado")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound);

            return app;
        }
    }
}
