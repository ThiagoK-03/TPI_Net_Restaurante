using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BCrypt.Net; // Asegúrate de que BCrypt.Net-Next esté instalado y el using sea correcto

namespace Domain.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(100)]
        public string Username { get; private set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; private set; } = string.Empty;

        [Required, MaxLength(20)]
        public string Telefono { get; private set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Nombre { get; private set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Apellido { get; private set; } = string.Empty;

        [Required, MaxLength(20)]
        public string Rol { get; private set; } = "Cliente";

        public bool Estado { get; private set; } = true;

        [MaxLength(500)]
        public string? FotoPerfil { get; private set; }

        [Required]
        public string PasswordHash { get; private set; } = string.Empty;

        // Navegación 1:1
        public virtual Cliente? Cliente { get; private set; }
        public virtual Empleado? Empleado { get; private set; }

        // Constructor principal
        public Usuario(string username, string email, string telefono, string nombre, string apellido, string rol, string password)
        {
            SetUsername(username);
            SetEmail(email);
            SetTelefono(telefono);
            SetNombre(nombre);
            SetApellido(apellido);
            SetRol(rol);
            SetPassword(password);
            Estado = true;
        }
        //Contructor para probar usuario precargado
        public Usuario(int id,string username, string email, string telefono, string nombre, string apellido, string rol, string password)
        {
            Id = id;
            SetUsername(username);
            SetEmail(email);
            SetTelefono(telefono);
            SetNombre(nombre);
            SetApellido(apellido);
            SetRol(rol);
            SetPassword(password);
            Estado = true;
        }

        // Constructor vacío para EF Core
        public Usuario() { }

        public void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username requerido");
            Username = username;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) throw new ArgumentException("Email inválido");
            Email = email;
        }

        public void SetTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) throw new ArgumentException("Teléfono requerido");
            Telefono = telefono;
        }

        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre requerido");
            Nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (string.IsNullOrWhiteSpace(apellido)) throw new ArgumentException("Apellido requerido");
            Apellido = apellido;
        }

        public void SetRol(string rol)
        {
            var rolesValidos = new[] { "Admin", "Empleado", "Cliente" };
            if (!rolesValidos.Contains(rol)) throw new ArgumentException("Rol inválido");
            Rol = rol;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Password requerido");
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool ValidatePassword(string password) => BCrypt.Net.BCrypt.Verify(password, PasswordHash);

        public List<string> ObtenerTodosLosPermisos()
        {
            return Rol switch
            {
                "Admin" => new() { "Admin:All" },
                "Empleado" => new() { "Empleado:Read", "Empleado:Write" },
                "Cliente" => new() { "Cliente:Read" },
                _ => new()
            };
        }

        public string ObtenerNombreGrupo() => Rol;
    }
}