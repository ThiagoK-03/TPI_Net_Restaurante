using Domain.Model;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;

namespace Application.Services
{
    public class EmpleadoService : CrudService <EmpleadoDto>
    {
        // CREATE
        public EmpleadoDto Add(EmpleadoDto dto)
        {
            var empleadoRepository = new EmpleadoRepository();

            if (empleadoRepository.CuitExists(dto.Cuit))
            {
                throw new ArgumentException($"Ya existe un empleado con el CUIT {dto.Cuit}.");
            }
            

            var empleado = new Empleado(0, dto.RazonSocial, dto.Cuit, dto.Turno, dto.HorasTrabajadas, dto.PrecioPorHora);
            empleadoRepository.Add(empleado);

            dto.Id = empleado.Id;
            dto.Sueldo = empleado.Sueldo;

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

            return empleadoRepository.GetAll().Select(e => ToDto(e)).ToList();
        }

        // UPDATE
        public bool Update(EmpleadoDto dto)
        {
            var empleadoRepository = new EmpleadoRepository();

            if (empleadoRepository.CuitExists(dto.Cuit))
            {
                throw new ArgumentException($"Ya existe un empleado con el CUIT {dto.Cuit}.");
            }

            Empleado empleado = new Empleado(dto.Id, dto.RazonSocial,dto.Cuit,dto.Turno,dto.HorasTrabajadas,dto.PrecioPorHora);
            return empleadoRepository.Update(empleado);

        }

        // DELETE
        public bool Delete(int id)
        {
            var empleadoRepository = new EmpleadoRepository();
            return empleadoRepository.Delete(id);
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
