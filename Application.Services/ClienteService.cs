using Data;
using Data.Repositories;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class ClienteService : IClienteService
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

            System.Diagnostics.Debug.WriteLine($"userid : {usuario.Id} user : {usuario} ");
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
            var usuarioRepository = new UsuarioRepository();



            if (clienteRepository.EmailExists(dto.Email, dto.Id))
                throw new ArgumentException($"Ya existe otro cliente con el Email '{dto.Email}'.");

            var existingCliente = clienteRepository.Get(dto.Id);
            if (existingCliente == null)
                return false;

            // actualizar usuario primero
            var existingUsuario = usuarioRepository.Get(existingCliente.Usuario.Id);
            if (existingUsuario == null)
                return false;

            existingUsuario.SetNombre(dto.Nombre);
            existingUsuario.SetApellido(dto.Apellido);
            existingUsuario.SetEmail(dto.Email);
            existingUsuario.SetTelefono(dto.Telefono);
            existingUsuario.SetUsername(dto.Username);
            if (!string.IsNullOrEmpty(dto.Password))
                existingUsuario.SetPassword(dto.Password);

            usuarioRepository.Update(existingUsuario);
            usuarioRepository.Save();
            
            // actualizar cliente
            existingCliente.SetFechaAlta(dto.FechaAlta);
            existingCliente.SetPenalizacion(dto.Penalizacion);

            
            clienteRepository.Update(existingCliente);
            return true;

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

        public ClienteDTO GetByUserId(int userId)
        {
            var cliente = new ClienteRepository().GetByUsuarioId(userId);
            if (cliente == null)
                throw new Exception($"Cliente con ID {userId} no existe.");

            if (cliente == null)
                return null;

            return ToDto(cliente);
        }
    }
}