using Application.Services;
using Domain.Model;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public static class CrudEndpoints
    {
        public static IEndpointRouteBuilder MapCrudEndpoints<TEntity, TService>(
            this IEndpointRouteBuilder app,
            string baseRoute
        )
            where TEntity : DTOInterface
            where TService : CrudService<TEntity>
        {
            app.MapGet($"/{baseRoute}", (TService service) =>
            {
                return Results.Ok(service.GetAll());
            });

            app.MapGet($"/{baseRoute}/{{id}}", (TService service, int id) =>
            {
                var entity = service.Get(id);
                return entity == null ? Results.NotFound() : Results.Ok(entity);
            });

            app.MapPost($"/{baseRoute}", (TService service, TEntity entity) =>
            {
                var created = service.Add(entity);
                return Results.Created($"/{baseRoute}/{created.Id}", created);
            });

            app.MapPut($"/{baseRoute}/{{id}}",
                (int id, TEntity entity, TService service) =>
                {
                    entity.Id = id;
                    return service.Update(entity) ? Results.Ok(entity) : Results.NotFound();
                });



            app.MapDelete($"/{baseRoute}/{{id}}", (TService service, int id) =>
            {
                return service.Delete(id) ? Results.NoContent() : Results.NotFound();
            });

            return app;
        }
    }

}
