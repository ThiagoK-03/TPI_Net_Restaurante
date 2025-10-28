using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public enum EstadoPedido
    {
        Pendiente,
        EnProceso,
        Completado,
        Cancelado
    }

    public class Pedido
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public string Descripcion { get; private set; }

        [Required]
        public EstadoPedido Estado { get; private set; }

        [Required]
        public DateTime FechaHoraInicio { get; private set; }

        public DateTime? FechaHoraFin { get; private set; }
        public DateTime? FechaHoraFinEstimada { get; private set; }

        public decimal Subtotal { get; private set; }

        [Required]
        public List<Producto> Productos { get; private set; }

        [ForeignKey(nameof(Cliente))]
        public int ClienteId { get; private set; }
        public Cliente Cliente { get; private set; }

        [ForeignKey(nameof(Empleado))]
        public int? EmpleadoId { get; private set; }
        public virtual Empleado? Empleado { get; private set; }


        public Pedido() { }
        public Pedido(int id, string descripcion, DateTime fechaHoraInicio, DateTime? fechaHoraFinEstimada, Cliente cliente, List<Producto> productos)
        {
            SetId(id);
            SetDescripcion(descripcion);
            SetEstado(EstadoPedido.Pendiente);
            SetFechaHoraInicio(fechaHoraInicio);
            SetFechaHoraFinEstimada(fechaHoraFinEstimada);
            SetCliente(cliente);
            SetProductos(productos);
        }

        public void SetCliente(Cliente cliente)
        {
            if (cliente == null) throw new ArgumentException("El cliente es requerido");
            Cliente = cliente;
            ClienteId = cliente.Id;

        }

        public void SetEmpleado(Empleado empleado)
        {
            if(empleado == null) throw new ArgumentException("El empleado es requerido");
            Empleado = empleado;
            EmpleadoId = empleado.Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripcion no puede ser nula o vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetEstado(EstadoPedido estado)
        {
            if(!Enum.IsDefined(typeof(EstadoPedido), estado))
                throw new ArgumentException("El estado del pedido no es válido.", nameof(estado));
            Estado = estado;
        }

        public void SetFechaHoraInicio(DateTime fechaHoraInicio)
        {
            if (fechaHoraInicio == default)
                throw new ArgumentException("La fecha de inicio no es válida.", nameof(fechaHoraInicio));
            FechaHoraInicio = fechaHoraInicio;
        }

        public void SetFechaHoraFin(DateTime? fechaHoraFin)
        {
            if (fechaHoraFin < FechaHoraInicio)
                throw new ArgumentException("La fecha de fin no puede ser anterior a la de inicio.", nameof(fechaHoraFin));
            FechaHoraFin = fechaHoraFin;
        }

        public void SetFechaHoraFinEstimada(DateTime? fechaHoraFinEstimada)
        {
            if (fechaHoraFinEstimada < FechaHoraInicio)
                throw new ArgumentException("La fecha de fin estimada no puede ser anterior a la de inicio.", nameof(fechaHoraFinEstimada));
            FechaHoraFinEstimada = fechaHoraFinEstimada;
        }

        public void SetProductos(List<Producto> productos)
        {
            if (productos == null || productos.Count == 0)
                throw new ArgumentException("El pedido debe contener al menos un producto.", nameof(productos));
            AgregarProductos(productos);
        }

        private void AgregarProductos(List<Producto> productos)
        {
            if (productos != null) Productos.Clear();
            foreach (var producto in productos)
            {
                Productos.Add(producto);
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var producto in Productos)
            {
                total += (decimal)producto.Precio;
            }
            Subtotal = total;

            return total;
        }


    }

}
