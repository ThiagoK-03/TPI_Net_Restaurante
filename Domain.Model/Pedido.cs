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
        public DateTime FechaHoraFinEstimada { get; private set; }
        //public List<Producto> Productos { get; private set; }

        public Pedido(int id, string descripcion, EstadoPedido estado, DateTime fechaHoraInicio, DateTime fechaHoraFinEstimada)
        {
            SetId(id);
            SetDescripcion(descripcion);
            SetEstado(estado);
            SetFechaHoraInicio(fechaHoraInicio);
            SetFechaHoraFinEstimada(fechaHoraFinEstimada);
            //SetProdcutos(Productos);
        }

        public void SetId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
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

        public void SetFechaHoraFin(DateTime fechaHoraFin)
        {
            if (fechaHoraFin < FechaHoraInicio)
                throw new ArgumentException("La fecha de fin no puede ser anterior a la de inicio.", nameof(fechaHoraFin));
            FechaHoraFin = fechaHoraFin;
        }

        public void SetFechaHoraFinEstimada(DateTime fechaHoraFinEstimada)
        {
            if (fechaHoraFinEstimada < FechaHoraInicio)
                throw new ArgumentException("La fecha de fin estimada no puede ser anterior a la de inicio.", nameof(fechaHoraFinEstimada));
            FechaHoraFinEstimada = fechaHoraFinEstimada;
        }

        //public void SetProductos(List<Prodcuto> productos)
        //{
        //    if (prodcutos == null || prodcutos.Count == 0)
        //        throw new ArgumentException("El pedido debe contener al menos un producto.", nameof(productos));
        //    Productos = productos;
        //}
    }

}
