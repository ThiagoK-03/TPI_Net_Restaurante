using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain.Model
{
    public class Producto
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; private set; }

        [Required]
        [MaxLength(255)]
        public string? Descripcion { get; private set; }

        [MaxLength(255)]
        public string? Imagen { get; private set; }

        [Column(TypeName = "decimal(3,2)")]
        public decimal? Calificacion { get; private set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; private set; }

        // Relación N:N con Ingredientes
        [Required]
        public virtual ICollection<Ingrediente> Ingredientes { get; private set; } = new List<Ingrediente>();

        // Relación N:N con Pedidos
        public virtual ICollection<Pedido> Pedidos { get; private set; } = new List<Pedido>();

        protected Producto() { } // Requerido por EF

        public Producto(int id, string nombre, string? descripcion, string? imagen, decimal? calificacion, decimal precio, List<Ingrediente> ingredientes)
        {
            SetId(id);
            SetNombre(nombre);
            SetDescripcion(descripcion);
            SetImagen(imagen);
            SetCalificacion(calificacion);
            SetPrecio(precio);
            SetIngredientes(ingredientes);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }

        public void SetDescripcion(string? descripcion)
        {
            Descripcion = descripcion;
        }

        public void SetImagen(string? imagen)
        {
            Imagen = imagen;
        }

        public void SetCalificacion(decimal? calificacion)
        {
            if (calificacion < 0)
                throw new ArgumentException("La calificación debe ser mayor o igual que 0.", nameof(calificacion));
            Calificacion = calificacion;
        }

        public void SetPrecio(decimal precio)
        {
            if (precio < 0)
                throw new ArgumentException("El precio debe ser mayor o igual que 0.", nameof(precio));
            Precio = precio;
        }

        public void SetIngredientes(IEnumerable<Ingrediente> ingredientes)
        {
            if (ingredientes == null)
                throw new ArgumentNullException(nameof(ingredientes), "La lista de ingredientes no puede ser nula.");

            // Limpia la colección actual y agrega los nuevos
            this.Ingredientes.Clear();

            foreach (var ingrediente in ingredientes)
            {
                if (ingrediente == null)
                    throw new ArgumentException("No se pueden incluir ingredientes nulos en la lista.", nameof(ingredientes));

 
               Ingredientes.Add(ingrediente);

                Console.WriteLine(ingrediente);
                Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(Ingredientes));

            }
        }

        // Métodos para manejar Ingredientes
        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            if (ingrediente == null)
                throw new ArgumentNullException(nameof(ingrediente));

            if (Ingredientes.Any(i => i.Id == ingrediente.Id))
                return; // ya está agregado

            Ingredientes.Add(ingrediente);
        }

        public void QuitarIngrediente(Ingrediente ingrediente)
        {
            if (ingrediente == null)
                throw new ArgumentNullException(nameof(ingrediente));

            Ingredientes.Remove(ingrediente);
        }

        public void SetPedidos(IEnumerable<Pedido> pedidos)
        {
            if (pedidos == null)
                throw new ArgumentNullException(nameof(pedidos), "La lista de pedidos no puede ser nula.");

            // Limpia la colección actual y agrega los nuevos
            Pedidos.Clear();

            foreach (var pedido in pedidos)
            {
                if (pedido == null)
                    throw new ArgumentException("No se pueden incluir pedidos nulos en la lista.", nameof(pedidos));

                Pedidos.Add(pedido);
            }
        }


        // Métodos para manejar Pedidos
        public void AgregarPedido(Pedido pedido)
        {
            if (pedido == null)
                throw new ArgumentNullException(nameof(pedido));

            if (Pedidos.Any(p => p.Id == pedido.Id))
                return;

            Pedidos.Add(pedido);
        }

        public void QuitarPedido(Pedido pedido)
        {
            if (pedido == null)
                throw new ArgumentNullException(nameof(pedido));

            Pedidos.Remove(pedido);
        }
    }
}
