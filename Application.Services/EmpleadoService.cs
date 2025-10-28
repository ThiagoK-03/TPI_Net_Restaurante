using Data;
using Data.Repositories;
using Domain.Model;
using DTOs;

namespace Application.Services
{
    public class EmpleadoService : CrudService<EmpleadoDto>
    {
        // CREATE
        public EmpleadoDto Add(EmpleadoDto dto)
        {
            var usuarioRepository = new UsuarioRepository();
            var empleadoRepository = new EmpleadoRepository();

            if (empleadoRepository.CuilExists(dto.Cuil))
            {
                throw new ArgumentException($"Ya existe un empleado con el CUIL {dto.Cuil}.");
            }

            // Crear Usuario primero (con rol "Empleado")
            var usuario = new Usuario(
                dto.Username,
                dto.Email,
                dto.Telefono,
                dto.Nombre,
                dto.Apellido,
                "Empleado",
                dto.Password // Se hasheará en el setter
            );
            usuarioRepository.Add(usuario);
            usuarioRepository.Save();

            var empleado = new Empleado(usuario, dto.RazonSocial, dto.Cuil, dto.Turno, dto.PrecioPorHora);

            empleadoRepository.Add(empleado);

            dto.Id = empleado.Id;

            return dto;
        }

        // READ ONE
        public EmpleadoDto? Get(int id)
        {
            var empleadoRepository = new EmpleadoRepository();
            Empleado? empleado = empleadoRepository.Get(id);

            return empleado is null ? null : ToDto(empleado);
        }

        // READ ALL
        public IEnumerable<EmpleadoDto> GetAll()
        {
            var empleadoRepository = new EmpleadoRepository();

            return empleadoRepository.GetAll().Select(ToDto).ToList();
        }

        // UPDATE
        public bool Update(EmpleadoDto dto)
        {
            var empleadoRepository = new EmpleadoRepository();

            if (empleadoRepository.CuilExists(dto.Cuil, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro empleado con el CUIL {dto.Cuil}.");
            }

            var existingEmpleado = empleadoRepository.Get(dto.Id);
            if (existingEmpleado == null)
                return false;

            // Actualizar Usuario
            existingEmpleado.Usuario.SetNombre(dto.Nombre);
            existingEmpleado.Usuario.SetApellido(dto.Apellido);
            existingEmpleado.Usuario.SetEmail(dto.Email);
            existingEmpleado.Usuario.SetTelefono(dto.Telefono);
            if (!string.IsNullOrEmpty(dto.Password))
                existingEmpleado.Usuario.SetPassword(dto.Password);

            // Actualizar campos específicos de Empleado
            existingEmpleado.SetRazonSocial(dto.RazonSocial);
            existingEmpleado.SetCuil(dto.Cuil);
            existingEmpleado.SetTurno(dto.Turno);
            existingEmpleado.SetHorasTrabajadas(dto.HorasTrabajadas);
            existingEmpleado.SetPrecioPorHora(dto.PrecioPorHora);
            // Sueldo se recalcula en setters

            return empleadoRepository.Update(existingEmpleado);
        }

        // DELETE
        public bool Delete(int id)
        {
            var empleadoRepository = new EmpleadoRepository();
            return empleadoRepository.Delete(id); // Maneja cascade
        }

        private static EmpleadoDto ToDto(Empleado empleado)
        {
            return new EmpleadoDto
            {
                Id = empleado.Id,
                RazonSocial = empleado.RazonSocial,
                Cuil = empleado.Cuil,
                Turno = empleado.Turno,
                HorasTrabajadas = empleado.HorasTrabajadas,
                PrecioPorHora = empleado.PrecioPorHora,
                Sueldo = empleado.Sueldo,
                Nombre = empleado.Usuario.Nombre,
                Apellido = empleado.Usuario.Apellido,
                Email = empleado.Usuario.Email,
                Telefono = empleado.Usuario.Telefono,
                Username = empleado.Usuario.Username,
                Rol = empleado.Usuario.Rol,
                Estado = empleado.Usuario.Estado
            };
        }
    }
}