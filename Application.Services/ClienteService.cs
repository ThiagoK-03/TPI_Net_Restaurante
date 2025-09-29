using Domain.Model;
using DTOs;
using Data.Repositories;

namespace Application.Services
{
    public class ClienteService : CrudService<ClienteDTO>
    {
        public ClienteDTO Add(ClienteDTO dto)
        {
            var clienteRepository = new ClienteRepository();

            //Validar que el email no este duplicado
            if (clienteRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException($"Ya existe un cliente con el Email '{dto.Email}'.");
            }

            var fechaAlta = DateTime.Now;
            Cliente cliente = new Cliente(0, dto.Nombre, dto.Apellido, dto.Email, fechaAlta);

            clienteRepository.Add(cliente);

            dto.Id = cliente.Id;
            dto.FechaAlta = cliente.FechaAlta;

            return dto;
        }

        public bool Delete(int id)
        {
            var clienteRepository = new ClienteRepository();
            return clienteRepository.Delete(id);
        }

        public ClienteDTO Get(int id)
        {
            var clienteRepository = new ClienteRepository();
            Cliente? cliente = clienteRepository.Get(id);

            if (cliente == null)
                return null;

            return new ClienteDTO
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                FechaAlta = cliente.FechaAlta
            };
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var clienteRepository = new ClienteRepository();
            return clienteRepository.GetAll().Select(cliente => new ClienteDTO
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Email = cliente.Email,
                FechaAlta = cliente.FechaAlta
            }).ToList();
        }

        public bool Update(ClienteDTO dto)
        {
            var clienteRepository = new ClienteRepository();

            // Validar que el email no esté duplicado (excluyendo el cliente actual)
            if (clienteRepository.EmailExists(dto.Email, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro cliente con el Email '{dto.Email}'.");
            }

            Cliente cliente = new Cliente(dto.Id, dto.Nombre, dto.Apellido, dto.Email, dto.FechaAlta);
            return clienteRepository.Update(cliente);
        }

    }
}
