using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
    public class EmpleadoDBConfiguration : IEntityTypeConfiguration<Empleado> // Renombré a EmpleadoDBConfiguration para consistencia
    {
        public void Configure(EntityTypeBuilder<Empleado> entity)
        {
            // Clave primaria (auto-generada)
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            // Propiedades específicas de Empleado (ajusta nombres según tu modelo, ej: Cuit vs Cuil)
            entity.Property(e => e.RazonSocial)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.Cuil) // Asume es CUIT; cambia a Cuil si es del ERD
                .IsRequired()
                .HasMaxLength(15);

            entity.Property(e => e.Turno)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.HorasTrabajadas)
                .IsRequired()
                .HasColumnType("decimal(5,2)"); // Ej: 40.00

            entity.Property(e => e.PrecioPorHora)
                .IsRequired()
                .HasColumnType("decimal(8,2)");

            entity.Property(e => e.Sueldo)
                .IsRequired()
                .HasColumnType("decimal(10,2)")
                .HasComputedColumnSql("[HorasTrabajadas] * [PrecioPorHora]"); // Auto-calculado en DB si quieres

            // FK a Usuario (1:1, ya configurada en UsuarioDBConfiguration, pero se puede reforzar aquí)
            entity.Property(e => e.UsuarioId)
                .IsRequired();

            // Índice único para CUIT
            entity.HasIndex(e => e.Cuil)
                .IsUnique();

            // Relación con Usuario (reforzada, pero principal en Usuario config)
            entity.HasOne(e => e.Usuario)
                .WithOne(u => u.Empleado)
                .HasForeignKey<Empleado>(e => e.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}