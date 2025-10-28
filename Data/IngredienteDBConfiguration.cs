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
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> entity)
        {
            entity.HasKey(i => i.Id);

            entity.Property(i => i.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(i => i.Descripcion)
                .HasMaxLength(300);

            entity.Property(i => i.Stock)
                .IsRequired()
                .HasColumnType("decimal(8,3)"); // Para cantidades precisas

            entity.Property(i => i.UnidadMedida)
                .HasMaxLength(20);

            entity.Property(i => i.Origen)
                .HasMaxLength(100);

            entity.Property(i => i.LimiteBajoStock)
                .HasColumnType("decimal(8,3)");

            entity.HasOne(i => i.Proveedor)
                .WithMany(p => p.Ingredientes) // asumí que Proveedor tiene ICollection<Ingrediente>
                .HasForeignKey(i => i.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict); // o Cascade según negocio


            entity
                .HasMany(i => i.Productos)
                .WithMany(p => p.Ingredientes) // asumí que Producto tiene ICollection<Ingrediente>
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoIngrediente", // tabla intermedia
                    j => j.HasOne<Producto>().WithMany().HasForeignKey("ProductoId"),
                    j => j.HasOne<Ingrediente>().WithMany().HasForeignKey("IngredienteId")
                );



        }
    }
}
