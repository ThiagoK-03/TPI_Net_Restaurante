using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ProductoService : CrudService<ProductoDTO>
    {
        public ProductoDTO Add(ProductoDTO dto)
        {
            var productoRepository = new ProductoRepository();
            var ingredienteRepository = new IngredienteRepository();

            if (string.IsNullOrWhiteSpace(dto.Nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");
            if (dto.Precio == null)
                throw new ArgumentException("El precio del producto es obligatorio.");

            // Cargar ingredientes si vienen
            var ingredientes = new List<Ingrediente>();
            if (dto.IngredientesIds != null)
            {
                foreach (int ingredienteId in dto.IngredientesIds)
                {
                    var ingrediente = ingredienteRepository.Get(ingredienteId);
                    if (ingrediente == null)
                        throw new ArgumentException($"Ingrediente con ID {ingredienteId} no existe.");
                    ingredientes.Add(ingrediente);
                }
            }

            var producto = new Producto(
                0,
                dto.Nombre,
                dto.Descripcion,
                dto.Imagen,
                dto.Calificacion,
                dto.Precio,
                ingredientes
            );

            productoRepository.Add(producto);
            dto.Id = producto.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var repository = new ProductoRepository();
            return repository.Delete(id);
        }

        public ProductoDTO? Get(int id)
        {
            var repository = new ProductoRepository();
            var producto = repository.Get(id);
            if (producto == null)
                return null;

            return new ProductoDTO
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Imagen = producto.Imagen,
                Calificacion = producto.Calificacion,
                Precio = producto.Precio,
                IngredientesIds = producto.Ingredientes.Select(i => i.Id).ToList()
            };
        }

        public IEnumerable<ProductoDTO> GetAll()
        {
            var repository = new ProductoRepository();
            return repository.GetAll().Select(p => new ProductoDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Imagen = p.Imagen,
                Calificacion = p.Calificacion,
                Precio = p.Precio,
                IngredientesIds = p.Ingredientes.Select(i => i.Id).ToList()
            }).ToList();
        }

        public bool Update(ProductoDTO dto)
        {
            var productoRepository = new ProductoRepository();
            var ingredienteRepository = new IngredienteRepository();

            var producto = productoRepository.Get(dto.Id)
                ?? throw new Exception($"Producto con ID {dto.Id} no existe.");

            // Actualizar solo si viene un valor (nullable-friendly)
            if (!string.IsNullOrWhiteSpace(dto.Nombre))
                producto.SetNombre(dto.Nombre);
            if (!string.IsNullOrWhiteSpace(dto.Descripcion))
                producto.SetDescripcion(dto.Descripcion);
            if (dto.Imagen != null)
                producto.SetImagen(dto.Imagen);
            if (dto.Calificacion != null)
                producto.SetCalificacion(dto.Calificacion);
            if (dto.Precio != null)
                producto.SetPrecio(dto.Precio);

            // Si vienen nuevos ingredientes, reemplazar la lista
            if (dto.IngredientesIds != null)
            {
                var nuevosIngredientes = dto.IngredientesIds
                    .Select(id => ingredienteRepository.Get(id))
                    .Where(i => i != null)
                    .ToList();

                //Este ya limpia la lista y agrega los nuevos
                producto.SetIngredientes(nuevosIngredientes!);
            }

            return productoRepository.Update(producto);
        }
    }
}
