using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DTOs
{
    public class ProveedorDTO : DTOInterface
    {
        public int Id { get; set; }
        public string RazonSocial {  get; set; }
        public int Cuit {  get; set; }
        public string Email { get; set; }
        public int Telefono {  get; set; }
        public string TipoIngrediente {  get; set; }
        public List<int>? IngredientesIds { get; set; } = new List<int>();

    }
}
