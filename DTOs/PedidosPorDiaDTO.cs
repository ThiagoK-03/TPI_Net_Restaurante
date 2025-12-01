using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PedidosPorDiaDTO
    {
        public DateTime Fecha { get; set; }
        public int CantidadPedidos { get; set; }
        public decimal TotalDelDia { get; set; }
    }
}
