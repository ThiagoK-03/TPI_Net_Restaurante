using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> entity)
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.RazonSocial)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(p => p.Cuit)
                .IsRequired()
                .HasMaxLength(15);

            entity.Property(p => p.Email)
                .HasMaxLength(150);

            entity.Property(p => p.Telefono)
                .HasMaxLength(20);

            entity.Property(p => p.TipoIngrediente)
                .IsRequired()
                .HasMaxLength(100); // Ej: "Carnes", "Vegetales", "Lácteos", "Condimentos"

            // Índice único para CUIT
            entity.HasIndex(p => p.Cuit)
                .IsUnique();

            // Relación 1:N con Ingredientes
            entity.HasMany(p => p.Ingredientes)
                  .WithOne(i => i.Proveedor)
                  .HasForeignKey(i => i.ProveedorId)
                  .OnDelete(DeleteBehavior.Restrict); // Evita borrar ingredientes si se borra un proveedor
        }
    }
}
