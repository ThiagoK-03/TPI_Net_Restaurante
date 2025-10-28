using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class EmpleadoDto : DTOInterface
    {
        public int Id { get; set; }
        [Required]
        public string RazonSocial { get; set; } = string.Empty;
        [Required]
        public int Cuil { get; set; }
        [Required]
        public string Turno { get; set; } = string.Empty;
        [Required, Range(0, int.MaxValue)]
        public int? HorasTrabajadas { get; set; }
        [Required, Range(0, double.MaxValue)]
        public decimal PrecioPorHora { get; set; }
        public decimal? Sueldo { get; set; }

        // Campos de Usuario
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
        public string Password { get; set; } = string.Empty; // Temporal
        public string Rol { get; set; } = "Empleado";
        public bool Estado { get; set; } = true;
    }
}