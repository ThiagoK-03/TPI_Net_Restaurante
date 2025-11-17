using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PedidoDTO : DTOInterface
    {
        public enum EstadoPedido
        {
            Pendiente,
            EnProceso,
            Completado,
            Cancelado
        }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public EstadoPedido Estado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public DateTime? FechaHoraFinEstimada { get; set; }
        public decimal Subtotal { get; set; }
        public List<int> ProductosIds { get; set; } = new List<int>();
        public int ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public int? EmpleadoId { get; set; }
        public string? EmpleadoNombre { get; set; }

    }
}
