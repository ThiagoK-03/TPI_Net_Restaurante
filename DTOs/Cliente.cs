using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class ClienteDTO : DTOInterface
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Apellido { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, Phone]
        public string Telefono { get; set; } = string.Empty;
        [Required, MinLength(3)]
        public string Username { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty; // Temporal para creación
        public DateTime FechaAlta { get; set; }
        public decimal Penalizacion { get; set; } = 0;
        public int UsuarioId { get; set; } // Opcional
        public string Rol { get; set; } = "Cliente";
        public bool Estado { get; set; } = true;
    }
}