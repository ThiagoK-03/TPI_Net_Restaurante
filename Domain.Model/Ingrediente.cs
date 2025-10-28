using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public class Ingrediente
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public Proveedor Proveedor { get; private set; }

        [ForeignKey(nameof(Proveedor))]
        public int ProveedorId {  get; private set; }

        // Relacion N:N Con Producto (Del otro lado tambien lleva una Collection
        public virtual ICollection<Producto> Productos { get; private set; } = new List<Producto>();

        [Required]
        public string Nombre { get; private set; }
        [Required]
        public string Descripcion { get; private set; }

        [Required]
        public int Stock { get; private set; }

        public string? UnidadMedida { get; private set; }

        public string? Origen { get; private set; }

        public int? LimiteBajoStock { get; private set; }

        protected Ingrediente() { } // requerido por EF

        public Ingrediente(int id, string nombre, Proveedor proveedor, string descripcion, int stock, string? unidadMedida, string? origen, int? limiteBajoStock) {
            SetId(id);
            SetNombre(nombre);
            SetProveedor(proveedor);
            SetDescripcion(descripcion);
            SetStock(stock);
            SetUnidadMedida(unidadMedida);
            SetOrigen(origen);
            SetLimiteBajoStock(limiteBajoStock);

        }

        public void SetProveedor(Proveedor proveedor)
        {
            if (proveedor == null) throw new ArgumentException("El Proveedor es requerido.", nameof(proveedor));
            Proveedor = proveedor;
            ProveedorId = proveedor.Id;
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

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripcion no puede ser nulo o vacío.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetStock(int stock)
        {
            if (stock < 0)
                throw new ArgumentException("El stock debe ser mayor o igual a 0.", nameof(stock));
            Stock = stock;
        }

        public void SetUnidadMedida(string? unidadMedida)
        {
            UnidadMedida = unidadMedida;
        }

        public void SetOrigen(string? origen)
        {
            if (string.IsNullOrWhiteSpace(origen))
                throw new ArgumentException("El origen no puede ser nulo o vacío.", nameof(origen));
            Origen = origen;
        }

        public void SetLimiteBajoStock(int? limiteBajoStock)
        {
            if (limiteBajoStock < 0)
                throw new ArgumentException("El limiteBajoStock debe ser mayor o igual que 0.", nameof(limiteBajoStock));
            LimiteBajoStock = limiteBajoStock;
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            if (Productos.Any(p => p.Id == producto.Id))
                return; // ya está agregado

            Productos.Add(producto);
        }

        public void QuitarProducto(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            Productos.Remove(producto);
        }
    }


}
