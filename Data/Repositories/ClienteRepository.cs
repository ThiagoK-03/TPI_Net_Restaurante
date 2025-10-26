using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ClienteRepository
    {
        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public void Add(Cliente cliente)
        {
            using var context = CreateContext();
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var cliente = context.Clientes.Include(c => c.Usuario).FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                context.Usuarios.Remove(cliente.Usuario);
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Cliente? Get(int id)
        {
            using var context = CreateContext();
            return context.Clientes
                .Include(c => c.Usuario)
                .Include(c => c.HistorialPedidos)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            using var context = CreateContext();
            return context.Clientes
                .Include(c => c.Usuario)
                .Include(c => c.HistorialPedidos)
                .ToList();
        }

        public bool Update(Cliente cliente)
        {
            using var context = CreateContext();
            context.Clientes.Update(cliente); // Usa EF Update para attach y persistir cambios
            context.SaveChanges();
            return context.Entry(cliente).State == Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public bool EmailExists(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Usuarios.Where(u => u.Email.ToLower() == email.ToLower() && u.Rol == "Cliente");
            if (excludeId.HasValue)
            {
                query = query.Where(u => u.Cliente != null && u.Cliente.Id != excludeId.Value);
            }
            return query.Any();
        }

        public Cliente? GetByUsuarioId(int usuarioId)
        {
            using var context = CreateContext();
            return context.Clientes
                .Include(c => c.Usuario)
                .FirstOrDefault(c => c.UsuarioId == usuarioId);
        }
    }
}