using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UsuarioRepository
    {
        private readonly AppDbContext context;

        public UsuarioRepository(AppDbContext context = null!)
        {
            this.context = context ?? new AppDbContext();
        }

        private AppDbContext CreateContext()
        {
            return new AppDbContext();
        }

        public Usuario? Get(int id)
        {
            return context.Usuarios
                .Include(u => u.Cliente)
                .Include(u => u.Empleado)
                .FirstOrDefault(u => u.Id == id);
        }

        public Usuario? GetByUsername(string username)
        {
            return context.Usuarios
                .Include(u => u.Cliente)
                .Include(u => u.Empleado)
                .FirstOrDefault(u => u.Username == username);
        }

        public void Add(Usuario usuario) => context.Usuarios.Add(usuario);

        public void Save() => context.SaveChanges();

        public bool Update(Usuario usuario)
        {
            using var context = CreateContext();
            context.Usuarios.Update(usuario);
            context.SaveChanges();
            return context.Entry(usuario).State == EntityState.Modified;
            
        }


        public bool Delete(int id)
        {
            var usuario = context.Usuarios.Find(id);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}