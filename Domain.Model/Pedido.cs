using System;
using System.Collections.Generic;
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
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public EstadoPedido Estado { get; private set; }
        public DateTime FechaHoraInicio { get; private set; }
        public DateTime? FechaHoraFin { get; private set; }
        public DateTime? FechaHoraFinEstimada { get; private set; }
        public List<Producto> Productos { get; private set; }
        public int ClienteId { get; private set; }
        public int EmpleadoId { get; private set; }
        public Cliente Cliente { get; private set; }
        public Empleado Empleado { get; private set; }

        public Pedido() { }
        public Pedido(int id, string descripcion, DateTime fechaHoraInicio, DateTime? fechaHoraFinEstimada, int clienteId, int empleadoId)
        {
            SetId(id);
            SetDescripcion(descripcion);
            SetEstado(EstadoPedido.Pendiente);
            SetFechaHoraInicio(fechaHoraInicio);
            SetFechaHoraFinEstimada(fechaHoraFinEstimada);
            ClienteId = clienteId;
            EmpleadoId = empleadoId;
        }

        public void SetClienteId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            ClienteId = id;
        }

        public void SetEmpleadoId(int id)
        {
            if(id<=0) 
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            ClienteId= id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(descripcion));
            Descripcion = descripcion;
        }

        public void SetEstado(EstadoPedido estado)
        {
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
            Productos = productos;
        }


    }

}
