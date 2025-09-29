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
    public class ClienteDBConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            // Clave primaria
            entity.HasKey(c => c.Id);
            entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

            // Propiedades obligatorias
            entity.Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(c => c.Apellido)
                .IsRequired()
                .HasMaxLength(100);

            //  Email
            entity.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            //  Email único
            entity.HasIndex(c => c.Email)
                .IsUnique();

            ////  Relación con Pedidos (1 Cliente : N Pedidos)
            //entity.HasMany(c => c.Pedidos)
            //    .WithOne(p => p.Cliente)
            //    .HasForeignKey(p => p.ClienteId)
            //    .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
