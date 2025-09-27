using Domain.Model;
using DTOs;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EmpleadoService : CrudService <EmpleadoDto>
    {
        // CREATE
        public EmpleadoDto Add(EmpleadoDto dto)
        {
            if (EmpleadoInMemory.Empleados.Any(e => e.Cuit == dto.Cuit))
                throw new ArgumentException($"Ya existe un empleado con el CUIT {dto.Cuit}.");

            var id = GetNextId();

            var empleado = new Empleado(id, dto.RazonSocial, dto.Cuit, dto.Turno, dto.HorasTrabajadas, dto.PrecioPorHora);
            EmpleadoInMemory.Empleados.Add(empleado);

            dto.Id = empleado.Id;
            dto.Sueldo = empleado.Sueldo;

            return dto;
        }

        // READ ONE
        public EmpleadoDto? Get(int id)
        {
            var empleado = EmpleadoInMemory.Empleados.FirstOrDefault(e => e.Id == id);
            return empleado is null ? null : ToDto(empleado);
        }

        // READ ALL
        public IEnumerable<EmpleadoDto> GetAll()
        {
            return EmpleadoInMemory.Empleados.Select(e => ToDto(e)).ToList();
        }

        // UPDATE
        public bool Update(EmpleadoDto dto)
        {
            var empleado = EmpleadoInMemory.Empleados.FirstOrDefault(e => e.Id == dto.Id);

            if (empleado is null)
                return false;

            if (EmpleadoInMemory.Empleados.Any(e => e.Id != dto.Id && e.Cuit == dto.Cuit))
                throw new ArgumentException($"Ya existe un empleado con el CUIT {dto.Cuit}.");

            empleado.SetRazonSocial(dto.RazonSocial);
            empleado.SetCuit(dto.Cuit);
            empleado.SetTurno(dto.Turno);
            empleado.SetHorasTrabajadas(dto.HorasTrabajadas);
            empleado.SetPrecioPorHora(dto.PrecioPorHora);

            return true;
        }

        // DELETE
        public bool Delete(int id)
        {
            var empleado = EmpleadoInMemory.Empleados.FirstOrDefault(e => e.Id == id);

            if (empleado is null)
                return false;

            EmpleadoInMemory.Empleados.Remove(empleado);
            return true;
        }

        // Helpers
        private static int GetNextId()
        {
            return EmpleadoInMemory.Empleados.Count == 0
                ? 1
                : EmpleadoInMemory.Empleados.Max(e => e.Id) + 1;
        }

        private static EmpleadoDto ToDto(Empleado empleado)
        {
            return new EmpleadoDto
            {
                Id = empleado.Id,
                RazonSocial = empleado.RazonSocial,
                Cuit = empleado.Cuit,
                Turno = empleado.Turno,
                HorasTrabajadas = empleado.HorasTrabajadas,
                PrecioPorHora = empleado.PrecioPorHora,
                Sueldo = empleado.Sueldo
            };
        }
    }
}
