using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ProductoService : CrudService<ProductoDTO>
    {
        public ProductoDTO Add(ProductoDTO dto)
        {            
            var id = GetNextId();

            Producto producto = new Producto(id, dto.Nombre, dto.Descripcion, dto.Imagen, dto.Calificacion, dto.Precio);

            ProductoInMemory.Productos.Add(producto);

            dto.Id = producto.Id;
            

            return dto;
        }

        public bool Delete(int id)
        {
            Producto? productoToDelete = ProductoInMemory.Productos.Find(x => x.Id == id);

            if (productoToDelete != null)
            {
                ProductoInMemory.Productos.Remove(productoToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public ProductoDTO Get(int id)
        {
            Producto? producto = ProductoInMemory.Productos.Find(x => x.Id == id);

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
            return ProductoInMemory.Productos.Select(producto => new ProductoDTO
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
            Producto? productoToUpdate = ProductoInMemory.Productos.Find(x => x.Id == dto.Id);

            if (productoToUpdate != null)
            {               
                productoToUpdate.SetNombre(dto.Nombre);
                productoToUpdate.SetDescripcion(dto.Descripcion);
                productoToUpdate.SetImagen(dto.Imagen);
                productoToUpdate.SetCalificacion(dto.Calificacion);
                productoToUpdate.SetPrecio(dto.Precio);

                return true;
            }
            else
            {
                return false;
            }
        }

        //No es ThreadSafe pero sirve para el proposito del ejemplo        
        private static int GetNextId()
        {
            int nextId;

            if (ProductoInMemory.Productos.Count > 0)
            {
                nextId = ProductoInMemory.Productos.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
