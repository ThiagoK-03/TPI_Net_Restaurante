using System.Text.RegularExpressions;

namespace DTOs
{
    public class ClienteDTO : DTOInterface
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }

        public DateTime FechaAlta { get; set; }

    }
}