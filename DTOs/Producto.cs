using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DTOs
{
    public class ProductoDTO : DTOInterface
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public int Calificacion { get; set; }

        public float Precio { get; set; }
    }
}
