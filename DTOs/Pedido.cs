using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Pedido : DTOInterface
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public DateTime? FechaHoraFinEstimada { get; set; }
        public float Subtotal { get; set; }
        //public List<Producto> Productos { get; set; } = new();
    }
}
