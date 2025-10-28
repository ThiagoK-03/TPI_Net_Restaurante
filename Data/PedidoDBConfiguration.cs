using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Model;

public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> entity)
    {
        // Clave primaria
        entity.HasKey(p => p.Id);

        // Propiedades simples
        entity.Property(p => p.Descripcion)
              .HasMaxLength(300);

        entity.Property(p => p.Estado)
              .IsRequired()
              .HasMaxLength(50);

        entity.Property(p => p.FechaHoraInicio)
              .IsRequired();

        entity.Property(p => p.FechaHoraFin);

        entity.Property(p => p.FechaHoraFinEstimada)
              .IsRequired();

        entity.Property(p => p.Subtotal)
              .HasColumnType("decimal(10,2)")
              .IsRequired();

        // Relación con Cliente (1:N)
        entity.HasOne(p => p.Cliente)
              .WithMany(c => c.HistorialPedidos)
              .HasForeignKey(p => p.ClienteId)
              .OnDelete(DeleteBehavior.Restrict);

        // Relación con Empleado (1:0..1)
        entity.HasOne(p => p.Empleado)
              .WithMany(e => e.PedidosAtendidos)
              .HasForeignKey(p => p.EmpleadoId)
              .IsRequired(false) // permite que sea null
              .OnDelete(DeleteBehavior.SetNull);

        // Relación N:N con Productos
        entity.HasMany(p => p.Productos)
              .WithMany(prod => prod.Pedidos)
              .UsingEntity<Dictionary<string, object>>(
                  "PedidoProducto",
                  j => j.HasOne<Producto>().WithMany().HasForeignKey("ProductoId"),
                  j => j.HasOne<Pedido>().WithMany().HasForeignKey("PedidoId")
              );
    }
}
