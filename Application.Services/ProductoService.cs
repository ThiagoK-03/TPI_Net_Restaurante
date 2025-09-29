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
            var repository = new ProductoRepository();
            Producto producto = new Producto(0, dto.Nombre, dto.Descripcion, dto.Imagen, dto.Calificacion, dto.Precio);

            repository.Add(producto);
            dto.Id = producto.Id;
            
            return dto;
        }

        public bool Delete(int id)
        {
            var repository = new ProductoRepository();
            return repository.Delete(id);
        }

        public ProductoDTO Get(int id)
        {
            var repository = new ProductoRepository();
            Producto? producto = repository.Get(id);
            if (producto == null)
                return null;

            return new ProductoDTO
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Imagen = producto.Imagen,
                Calificacion = producto.Calificacion,
                Precio = producto.Precio
            };
        }

        public IEnumerable<ProductoDTO> GetAll()
        {
            var repository = new ProductoRepository();

            return repository.GetAll().Select(producto => new ProductoDTO
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Imagen = producto.Imagen,
                Calificacion = producto.Calificacion,
                Precio = producto.Precio
            }).ToList();
        }

        public bool Update(ProductoDTO dto)
        {
            var repository = new ProductoRepository();

            Producto producto = new Producto(dto.Id, dto.Nombre, dto.Descripcion, dto.Imagen, dto.Calificacion, dto.Precio);
            return repository.Update(producto);
        }


    }
}
