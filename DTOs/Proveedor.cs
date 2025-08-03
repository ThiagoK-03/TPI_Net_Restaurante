using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DTOs
{
    public class ProveedorDTO
    {
        public int Id { get; set; }
        public string RazonSocial {  get; set; }
        public int Cuit {  get; set; }
        public string Email { get; set; }
        public int Telefono {  get; set; }
        public string TipoIngrediente {  get; set; }
        //public string Nombre { get; set; } ---- Nombre = RazonSocial..?

        public string Compañia { get; set; } //Agregue este atributo
    }
}
