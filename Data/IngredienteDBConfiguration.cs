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
                .IsRequired()
                .HasMaxLength(20); 

            entity.Property(i => i.Origen)
                .HasMaxLength(100); 

            entity.Property(i => i.LimiteBajoStock)
                .IsRequired()
                .HasColumnType("decimal(8,3)");
        }
    }
}
