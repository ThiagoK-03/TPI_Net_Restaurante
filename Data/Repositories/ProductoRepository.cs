using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;

namespace Data.Repositories
{
    public class ProductoRepository
    {
        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public void Add(Producto producto)
        {
            using var context = CreateContext();
            foreach (Ingrediente ingrediente in producto.Ingredientes) context.Attach(ingrediente);
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var producto = context.Productos.Find(id);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Producto? Get(int id)
        {
            using var context = CreateContext();
            return context.Productos.Find(id);
        }

        public IEnumerable<Producto> GetAll()
        {
            using var context = CreateContext();
            return context.Productos.ToList();
        }

        public bool Update(Producto producto)
        {
            using var context = CreateContext();
            var existingProducto = context.Productos.Find(producto.Id);
            if (existingProducto != null)
            {
                existingProducto.SetNombre(producto.Nombre);
                existingProducto.SetDescripcion(producto.Descripcion);
                existingProducto.SetImagen(producto.Imagen);
                existingProducto.SetCalificacion(producto.Calificacion);
                existingProducto.SetPrecio(producto.Precio);
                existingProducto.SetIngredientes(producto.Ingredientes.ToList());

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Producto> GetTopRated(int cantidad = 10)
        {
            using var context = CreateContext();
            return context.Productos
                .OrderByDescending(p => p.Calificacion)
                .Take(cantidad)
                .ToList();
        }
    }
}
