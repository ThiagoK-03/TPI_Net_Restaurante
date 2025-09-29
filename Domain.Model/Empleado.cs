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
        public string RazonSocial { get; private set; }
        public int Cuit { get; private set; }
        public string Turno { get; private set; }
        public int HorasTrabajadas { get; private set; }
        public decimal PrecioPorHora { get; private set; }
        public decimal Sueldo { get; private set; }

        public Empleado(int id, string razonSocial, int cuit, string turno, int horasTrabajadas, decimal precioPorHora)
        {
            SetId(id);
            SetRazonSocial(razonSocial);
            SetCuit(cuit);
            SetTurno(turno);
            SetHorasTrabajadas(horasTrabajadas);
            SetPrecioPorHora(precioPorHora);

            CalcularSueldo();
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetRazonSocial(string razonSocial)
        {
            if (string.IsNullOrWhiteSpace(razonSocial))
                throw new ArgumentException("La razón social no puede ser vacía.", nameof(razonSocial));
            RazonSocial = razonSocial;
        }

        public void SetCuit(int cuit)
        {
            if (cuit <= 0)
                throw new ArgumentException("El CUIT debe ser válido.", nameof(cuit));
            Cuit = cuit;
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
