using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.Data.SqlClient;

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
            var empleado = context.Empleados.Find(id);
            if (empleado != null)
            {
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Empleado? Get(int id)
        {
            using var context = CreateContext();
            return context.Empleados.Find(id);
        }

        public IEnumerable<Empleado> GetAll()
        {
            using var context = CreateContext();
            return context.Empleados.ToList();
        }

        public bool Update(Empleado empleado)
        {
            using var context = CreateContext();
            var existingEmpleado = context.Empleados.Find(empleado.Id);
            if (existingEmpleado != null)
            {
                existingEmpleado.SetRazonSocial(empleado.RazonSocial);
                existingEmpleado.SetCuit(empleado.Cuit);
                existingEmpleado.SetTurno(empleado.Turno);
                existingEmpleado.SetHorasTrabajadas(empleado.HorasTrabajadas);
                existingEmpleado.SetPrecioPorHora(empleado.PrecioPorHora);
                //existingEmpleado.SetSueldo(empleado.Sueldo);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CuitExists(int cuit, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Empleados.Where(e => e.Cuit == cuit);
            if (excludeId.HasValue)
            {
                query = query.Where(e => e.Id != excludeId.Value);
            }
            return query.Any();
        }

    }
}
