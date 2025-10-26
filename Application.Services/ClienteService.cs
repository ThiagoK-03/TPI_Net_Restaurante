using Data;
using Data.Repositories;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ClienteService : CrudService<ClienteDTO>
    {
        public ClienteDTO Add(ClienteDTO dto)
        {
            var usuarioRepository = new UsuarioRepository();
            var clienteRepository = new ClienteRepository();

            // Validar que el email no esté duplicado (en Usuario, filtrando por rol Cliente)
            if (clienteRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            // Crear Usuario primero (con rol "Cliente")
            var usuario = new Usuario(
                dto.Username,
                dto.Email,
                dto.Telefono,
                dto.Nombre,
                dto.Apellido,
                "Cliente",
                dto.Password // Se hasheará en el setter
            );
            usuarioRepository.Add(usuario);
            usuarioRepository.Save();

            var fechaAlta = DateTime.Now;
            var cliente = new Cliente(usuario, fechaAlta, dto.Penalizacion);

            clienteRepository.Add(cliente);

            dto.Id = cliente.Id;
            dto.FechaAlta = cliente.FechaAlta;
            dto.UsuarioId = usuario.Id; // Opcional, para referencia

            return dto;
        }

        public bool Delete(int id)
        {
            var clienteRepository = new ClienteRepository();
            return clienteRepository.Delete(id); // Maneja cascade a Usuario si configurado
        }

        public ClienteDTO Get(int id)
        {
            var clienteRepository = new ClienteRepository();
            Cliente? cliente = clienteRepository.Get(id);

            if (cliente == null)
                return null;

            return ToDto(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clienteRepository = new ClienteRepository();
            return clienteRepository.GetAll().Select(ToDto).ToList();
        }

        public bool Update(ClienteDTO dto)
        {
            var clienteRepository = new ClienteRepository();

            // Validar que el email no esté duplicado (excluyendo el actual)
            if (clienteRepository.EmailExists(dto.Email, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro cliente con el Email '{dto.Email}'.");
            }

            var existingCliente = clienteRepository.Get(dto.Id);
            if (existingCliente == null)
                return false;

            // Actualizar Usuario (campos comunes)
            existingCliente.Usuario.SetNombre(dto.Nombre);
            existingCliente.Usuario.SetApellido(dto.Apellido);
            existingCliente.Usuario.SetEmail(dto.Email);
            existingCliente.Usuario.SetTelefono(dto.Telefono);
            if (!string.IsNullOrEmpty(dto.Password))
                existingCliente.Usuario.SetPassword(dto.Password); // Solo si se proporciona nuevo

            // Actualizar campos específicos de Cliente
            existingCliente.SetFechaAlta(dto.FechaAlta);
            existingCliente.SetPenalizacion(dto.Penalizacion);

            return clienteRepository.Update(existingCliente);
        }

        private static ClienteDTO ToDto(Cliente cliente)
        {
            return new ClienteDTO
            {
                Id = cliente.Id,
                Nombre = cliente.Usuario.Nombre,
                Apellido = cliente.Usuario.Apellido,
                Email = cliente.Usuario.Email,
                Telefono = cliente.Usuario.Telefono,
                Username = cliente.Usuario.Username,
                FechaAlta = cliente.FechaAlta,
                Penalizacion = cliente.Penalizacion,
                Rol = cliente.Usuario.Rol,
                Estado = cliente.Usuario.Estado
            };
        }
    }
}