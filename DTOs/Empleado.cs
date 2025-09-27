using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class EmpleadoDto : DTOInterface
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public int Cuit { get; set; }
        public string Turno { get; set; }
        public int HorasTrabajadas { get; set; }
        public decimal PrecioPorHora { get; set; }
        public decimal Sueldo { get; set; }
    }
}
