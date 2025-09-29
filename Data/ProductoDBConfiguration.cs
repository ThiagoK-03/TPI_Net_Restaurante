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
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(p => p.Descripcion)
                .HasMaxLength(255);

            entity.Property(p => p.Imagen)
                .HasMaxLength(255); // Ruta o URL de la imagen

            entity.Property(p => p.Calificacion)
                .HasColumnType("decimal(3,2)");

            entity.Property(p => p.Precio)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
        }
    }
}
