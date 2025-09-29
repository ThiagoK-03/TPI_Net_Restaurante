using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{

    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> entity)
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.FechaHoraInicio)
                .IsRequired();

            entity.Property(p => p.Estado)
                .IsRequired();

            // Relación con Cliente
            //entity.HasOne(p => p.Cliente)
            //    .WithMany(c => c.Pedidos)
            //    .HasForeignKey(p => p.ClienteId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //// Relación con Empleado
            //entity.HasOne(p => p.Empleado)
            //    .WithMany(e => e.Pedidos)
            //    .HasForeignKey(p => p.EmpleadoId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
