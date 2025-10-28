using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Model;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> entity)
    {
        // Clave primaria
        entity.HasKey(p => p.Id);

        // Propiedades simples
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

        // Relación N:N con Pedidos
        entity.HasMany(p => p.Pedidos)
              .WithMany(ped => ped.Productos)
              .UsingEntity<Dictionary<string, object>>(
                  "PedidoProducto",
                  j => j.HasOne<Pedido>().WithMany().HasForeignKey("PedidoId"),
                  j => j.HasOne<Producto>().WithMany().HasForeignKey("ProductoId")
              );

        // Relación N:N con Ingredientes
        entity.HasMany(p => p.Ingredientes)
              .WithMany(i => i.Productos)
              .UsingEntity<Dictionary<string, object>>(
                  "ProductoIngrediente",
                  j => j.HasOne<Ingrediente>().WithMany().HasForeignKey("IngredienteId"),
                  j => j.HasOne<Producto>().WithMany().HasForeignKey("ProductoId")
              );
    }
}
