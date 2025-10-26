using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Domain.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public DateTime FechaAlta { get; private set; }

        [ForeignKey(nameof(Usuario))]
        public int UsuarioId { get; private set; } // FK a Usuario

        [Required]
        public decimal Penalizacion { get; private set; } = 0;

        // Relaciones necesarias
        public virtual Usuario Usuario { get; private set; } = null!; // 1:1 con Usuario (navegación)
        public virtual ICollection<Pedido> HistorialPedidos { get; private set; } = new List<Pedido>(); // 1:N con Pedido

        // Constructor principal
        public Cliente(Usuario usuario, DateTime fechaAlta, decimal penalizacion = 0)
        {
            SetUsuario(usuario);
            SetFechaAlta(fechaAlta);
            SetPenalizacion(penalizacion);
        }

        // Constructor con ID para actualizaciones
        public Cliente(int id, Usuario usuario, DateTime fechaAlta, decimal penalizacion = 0)
        {
            SetId(id);
            SetUsuario(usuario);
            SetFechaAlta(fechaAlta);
            SetPenalizacion(penalizacion);
        }

        // Constructor vacío para EF Core
        public Cliente() { }

        public void SetId(int id)
        {
            if (id <= 0) throw new ArgumentException("El ID debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetUsuario(Usuario usuario)
        {
            if (usuario == null) throw new ArgumentException("El Usuario es requerido.", nameof(usuario));
            Usuario = usuario;
            UsuarioId = usuario.Id; // Sincroniza FK
        }

        public void SetFechaAlta(DateTime fechaAlta)
        {
            if (fechaAlta == default(DateTime)) throw new ArgumentException("La fecha de alta no puede ser nula.", nameof(fechaAlta));
            if (fechaAlta > DateTime.Now) throw new ArgumentException("La fecha de alta no puede ser futura.", nameof(fechaAlta));
            FechaAlta = fechaAlta;
        }

        public void SetPenalizacion(decimal penalizacion)
        {
            if (penalizacion < 0) throw new ArgumentException("La penalización no puede ser negativa.", nameof(penalizacion));
            Penalizacion = penalizacion;
        }

        // Método para agregar pedido al historial (opcional, para encapsulación)
        public void AgregarPedido(Pedido pedido)
        {
            if (pedido == null) throw new ArgumentNullException(nameof(pedido));
            if (HistorialPedidos.Any(p => p.Id == pedido.Id)) return; // Evita duplicados
            HistorialPedidos.Add(pedido);
        }
    }
}