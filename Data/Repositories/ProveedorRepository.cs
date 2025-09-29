using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;

namespace Data.Repositories
{
    public class ProveedorRepository
    {
        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public void Add(Proveedor proveedor)
        {
            using var context = CreateContext();
            context.Proveedores.Add(proveedor);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var proveedor = context.Proveedores.Find(id);
            if (proveedor != null)
            {
                context.Proveedores.Remove(proveedor);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Proveedor? Get(int id)
        {
            using var context = CreateContext();
            return context.Proveedores.Find(id);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            using var context = CreateContext();
            return context.Proveedores.ToList();
        }

        public bool Update(Proveedor proveedor)
        {
            using var context = CreateContext();
            var existingProveedor = context.Proveedores.Find(proveedor.Id);
            if (existingProveedor != null)
            {
                existingProveedor.SetNombre(proveedor.RazonSocial);
                existingProveedor.SetCuit(proveedor.Cuit);
                existingProveedor.SetEmail(proveedor.Email);
                existingProveedor.SetTelefono(proveedor.Telefono);
                existingProveedor.SetTipoIngrediente(proveedor.TipoIngrediente);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CuitExists(int cuit, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Proveedores.Where(p => p.Cuit == cuit);
            if (excludeId.HasValue)
            {
                query = query.Where(p => p.Id != excludeId.Value);
            }
            return query.Any();
        }

        public bool EmailExists(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Proveedores.Where(p => p.Email == email);
            if (excludeId.HasValue)
            {
                query = query.Where(p => p.Id != excludeId.Value);
            }
            return query.Any();
        }

        public IEnumerable<Proveedor> GetByTipoIngrediente(string tipoIngrediente)
        {
            using var context = CreateContext();
            return context.Proveedores
                .Where(p => p.TipoIngrediente.ToLower() == tipoIngrediente.ToLower())
                .ToList();
        }
    }
}
