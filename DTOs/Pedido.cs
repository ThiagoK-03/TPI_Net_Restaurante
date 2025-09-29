using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PedidoDTO : DTOInterface
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public DateTime? FechaHoraFinEstimada { get; set; }
        public float Subtotal { get; set; }
        public List<ProductoDTO> Productos { get; set; } = new();
        public int ClienteId { get; set; }

        public ClienteDTO cliente { get; set; }
        public int EmpleadoId {  get; set; }

        public EmpleadoDto empelado { get; set; }

    }
}
