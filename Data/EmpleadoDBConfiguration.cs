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
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.RazonSocial)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.Cuit)
                .IsRequired()
                .HasMaxLength(15);

            entity.Property(e => e.Turno)
                .IsRequired()
                .HasMaxLength(50); // Ej: "Mañana", "Tarde", "Noche"

            entity.Property(e => e.HorasTrabajadas)
                .IsRequired()
                .HasColumnType("decimal(5,2)"); // Para valores como 37.50 horas

            entity.Property(e => e.PrecioPorHora)
                .IsRequired()
                .HasColumnType("decimal(8,2)");

            entity.Property(e => e.Sueldo)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            // Índice único para CUIT
            entity.HasIndex(e => e.Cuit)
                .IsUnique();
        }
    }
}
