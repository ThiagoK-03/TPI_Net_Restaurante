using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class EmpleadoInMemory
    {
        public static List<Empleado> Empleados { get; }

        static EmpleadoInMemory()
        {
            Empleados = new List<Empleado>
        {
            new Empleado(1, "Juan Pérez", 123456, "Mañana", 160, 1500),
            new Empleado(2, "María Gómez", 123457, "Tarde", 120, 1600),
            new Empleado(3, "Carlos López", 123458, "Noche", 140, 1800)
        };
        }
    }
}
