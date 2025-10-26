using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Empleado
    {
        public int Id { get; private set; }
        public string RazonSocial { get; private set; } = string.Empty;
        public int Cuil { get; private set; }
        public string Turno { get; private set; } = string.Empty;
        public int HorasTrabajadas { get; private set; }
        public decimal PrecioPorHora { get; private set; }
        public decimal Sueldo { get; private set; }
        public int UsuarioId { get; private set; } // FK
        public virtual Usuario Usuario { get; private set; } = null!;

        // Constructor principal: Toma Usuario en lugar de solo ID para consistencia
        public Empleado(Usuario usuario, string razonSocial, int cuil, string turno, int horasTrabajadas, decimal precioPorHora)
        {
            SetUsuario(usuario);
            SetRazonSocial(razonSocial);
            SetCuil(cuil);
            SetTurno(turno);
            SetHorasTrabajadas(horasTrabajadas);
            SetPrecioPorHora(precioPorHora);
            CalcularSueldo();
        }

        // Constructor con ID para actualizaciones (EF Core)
        public Empleado(int id, Usuario usuario, string razonSocial, int cuil, string turno, int horasTrabajadas, decimal precioPorHora)
        {
            SetId(id);
            SetUsuario(usuario);
            SetRazonSocial(razonSocial);
            SetCuil(cuil);
            SetTurno(turno);
            SetHorasTrabajadas(horasTrabajadas);
            SetPrecioPorHora(precioPorHora);
            CalcularSueldo();
        }

        // Constructor vacío para EF Core
        public Empleado() { }

        public void SetId(int id)
        {
            if (id <= 0) throw new ArgumentException("ID inválido");
            Id = id;
        }

        public void SetUsuario(Usuario usuario)
        {
            if (usuario == null) throw new ArgumentException("Usuario requerido");
            Usuario = usuario;
            UsuarioId = usuario.Id;
        }

        public void SetRazonSocial(string razonSocial)
        {
            if (string.IsNullOrWhiteSpace(razonSocial))
                throw new ArgumentException("La razón social no puede ser vacía.", nameof(razonSocial));
            RazonSocial = razonSocial;
        }

        public void SetCuil(int cuil)
        {
            if (cuil <= 0) throw new ArgumentException("CUIL inválido");
            Cuil = cuil;
        }

        public void SetTurno(string turno)
        {
            if (string.IsNullOrWhiteSpace(turno))
                throw new ArgumentException("El turno no puede ser vacío.", nameof(turno));
            Turno = turno;
        }

        public void SetHorasTrabajadas(int horas)
        {
            if (horas < 0)
                throw new ArgumentException("Las horas trabajadas no pueden ser negativas.", nameof(horas));
            HorasTrabajadas = horas;
            CalcularSueldo();
        }

        public void SetPrecioPorHora(decimal precio)
        {
            if (precio <= 0)
                throw new ArgumentException("El precio por hora debe ser mayor que 0.", nameof(precio));
            PrecioPorHora = precio;
            CalcularSueldo();
        }

        private void CalcularSueldo()
        {
            Sueldo = HorasTrabajadas * PrecioPorHora;
        }
    }
}