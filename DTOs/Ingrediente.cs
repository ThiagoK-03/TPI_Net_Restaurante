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

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public int Stock { get; set; }

        public string? UnidadMedida { get; set; }

        public string? Origen { get; set; }

        public int? LimiteBajoStock { get; set; }

        public int ProveedorId { get; set; }

        public string? ProveedorNombre { get; set; }

        public List<int>? ProductosIds { get; set; }

    }
}
