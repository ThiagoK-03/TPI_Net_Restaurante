using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
    public class UsuarioDBConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            // Clave primaria (auto-generada)
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Id)
                .ValueGeneratedOnAdd();

            // Propiedades obligatorias con validaciones
            entity.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(u => u.Telefono)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(u => u.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(u => u.Apellido)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(u => u.Rol)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(u => u.Estado)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(u => u.FotoPerfil)
                .HasMaxLength(500);

            entity.Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(255); // Suficiente para hashes como BCrypt

            // Índices únicos
            entity.HasIndex(u => u.Username)
                .IsUnique();
            entity.HasIndex(u => u.Email)
                .IsUnique();

            // Relaciones 1:1 con Cliente y Empleado (configuradas desde Usuario para ownership)
            // Usuario 1:1 Cliente (Usuario es principal)
            entity.HasOne(u => u.Cliente)
                .WithOne(c => c.Usuario)
                .HasForeignKey<Cliente>(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade); // Borra Cliente si se borra Usuario

            // Usuario 1:1 Empleado (similar)
            entity.HasOne(u => u.Empleado)
                .WithOne(e => e.Usuario)
                .HasForeignKey<Empleado>(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}