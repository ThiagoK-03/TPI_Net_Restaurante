using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;

namespace Data.Repositories
{
    public class IngredienteRepository
    {
        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public void Add(Ingrediente ingrediente)
        {
            using var context = CreateContext();
            context.Attach(ingrediente.Proveedor);
            context.Ingredientes.Add(ingrediente);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var ingrediente = context.Ingredientes.Find(id);
            if (ingrediente != null)
            {
                context.Ingredientes.Remove(ingrediente);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Ingrediente? Get(int id)
        {
            using var context = CreateContext();
            return context.Ingredientes.Find(id);
        }

        public IEnumerable<Ingrediente> GetAll()
        {
            using var context = CreateContext();
            return context.Ingredientes.ToList();
        }

        public bool Update(Ingrediente ingrediente)
        {
            using var context = CreateContext();
            var existingIngrediente = context.Ingredientes.Find(ingrediente.Id);
            if (existingIngrediente != null)
            {


                existingIngrediente.SetNombre(ingrediente.Nombre);
                existingIngrediente.SetProveedor(ingrediente.Proveedor);
                existingIngrediente.SetDescripcion(ingrediente.Descripcion);
                existingIngrediente.SetStock(ingrediente.Stock);
                existingIngrediente.SetUnidadMedida(ingrediente.UnidadMedida ?? existingIngrediente.UnidadMedida);
                existingIngrediente.SetOrigen(ingrediente.Origen ?? existingIngrediente.Origen);
                existingIngrediente.SetLimiteBajoStock(ingrediente.LimiteBajoStock ?? existingIngrediente.LimiteBajoStock);


                existingIngrediente.Productos.Clear(); // Limpiar relaciones actuales

                foreach (var producto in ingrediente.Productos)
                {
                    if (producto != null) existingIngrediente.AgregarProducto(producto);
                }
                

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Ingrediente> GetBajoStock()
        {
            using var context = CreateContext();
            return context.Ingredientes
                .Where(i => i.Stock <= i.LimiteBajoStock)
                .ToList();
        }
    }
}
