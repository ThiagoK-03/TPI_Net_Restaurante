using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class EmpleadoRepository
    {
        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public void Add(Empleado empleado)
        {
            using var context = CreateContext();
            context.Empleados.Add(empleado);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var empleado = context.Empleados.Include(e => e.Usuario).FirstOrDefault(e => e.Id == id);
            if (empleado != null)
            {
                context.Usuarios.Remove(empleado.Usuario);
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Empleado? Get(int id)
        {
            using var context = CreateContext();
            return context.Empleados
                .Include(e => e.Usuario)
                .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Empleado> GetAll()
        {
            using var context = CreateContext();
            return context.Empleados
                .Include(e => e.Usuario)
                .ToList();
        }

        public bool Update(Empleado empleado)
        {
            using var context = CreateContext();
            context.Empleados.Update(empleado); // Usa EF Update para attach y persistir cambios
            context.SaveChanges();
            return context.Entry(empleado).State == Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public bool CuilExists(int cuil, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Empleados.Where(e => e.Cuil == cuil);
            if (excludeId.HasValue)
            {
                query = query.Where(e => e.Id != excludeId.Value);
            }
            return query.Any();
        }

        public Empleado? GetByUsuarioId(int usuarioId)
        {
            using var context = CreateContext();
            return context.Empleados
                .Include(e => e.Usuario)
                .FirstOrDefault(e => e.UsuarioId == usuarioId);
        }
    }
}