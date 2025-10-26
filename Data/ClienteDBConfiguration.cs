// Bonus: Actualización para ClienteDBConfiguration (ya que la tuya actual referencia props removidas)
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
    public class ClienteDBConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            // Clave primaria (auto-generada)
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            // Propiedades específicas de Cliente
            entity.Property(c => c.FechaAlta)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()"); // Fecha actual por defecto

            entity.Property(c => c.Penalizacion)
                .IsRequired()
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5,2)");

            // FK a Usuario (1:1, principal en Usuario config)
            entity.Property(c => c.UsuarioId)
                .IsRequired();

            // Relación con HistorialPedidos (1:N)
            entity.HasMany(c => c.HistorialPedidos)
                .WithOne(p => p.Cliente) // Asume Pedido tiene FK ClienteId
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Restrict); // No borra pedidos al borrar cliente

            // Relación con Usuario (reforzada)
            entity.HasOne(c => c.Usuario)
                .WithOne(u => u.Cliente)
                .HasForeignKey<Cliente>(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}