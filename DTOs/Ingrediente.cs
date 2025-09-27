using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DTOs
{
    public class IngredienteDTO : DTOInterface
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int Stock { get; set; }

        //listaProveedor / Nose como poner esto no me queda claro
        public string UnidadMedida { get; set; }

        public string Origen {  get; set; }

        public int LimiteBajoStock { get; set; }
    }
}
